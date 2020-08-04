//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class WashingScript
    {
		private static Timer timer1 = null;
		public static int washCycle;
		public static int washTime;

		static WashingScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.Cycle_Info.Value = 3;
			Globals.Tags.InCycle.Value = 1;
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			CycleTimerCalculator();
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			int cycleNo = Globals.Tags.InCycle.Value;
			int timer = Globals.Tags.InCycleTimer.Value;
			int loop = Globals.Tags.LoopCounter.Value;
			
			if(timer <= 0){
				if(loop > 0){
					CycleTimerScript.Start();
				}
				else
				{
					Stop();
				}
			}
		}
		
		public static void CycleTimerCalculator()
		{
			int pre_time;
			int dry_time;
			int man_time = Globals.Tags.ManWashTime.Value * 60;
			int cycleTimeTotal;
			if(Globals.Tags.Manuel_Washing.Value)
			{
				pre_time = (Globals.Tags.prewashWaterTime.Value + Globals.Tags.prewashRestTime.Value)*Globals.Tags.Man_Pre_Wash_Cycle.Value;
				dry_time = (Globals.Tags.dryingAirTime.Value + Globals.Tags.dryingRestTime.Value)*Globals.Tags.ManWash_Dry_Cycle.Value;
				washTime = man_time - (pre_time + dry_time);
				Globals.Tags.CycleTimer.Value = washTime;
				cycleTimeTotal = (Globals.Tags.cleaningWaterTime.Value+Globals.Tags.cleaningPressTime.Value+Globals.Tags.cleaningRestTime.Value);
				Globals.Tags.LoopCounter.Value = (washTime / cycleTimeTotal) + 1;
			}else if(Globals.Tags.Automatic_Washing.Value){
				AutoDicider();
			}
		}
		
	
		public static void AutoDicider()
		{
			int max_press = Globals.Tags.Max_Pressure.Value;
			int washCycle = 40;
			
			if(max_press > 200){ washCycle = 60; }
			else if(175 < max_press && max_press < 201){ washCycle = 52; }
			else if(150 < max_press && max_press < 176){ washCycle = 50; }
			else if(125 < max_press && max_press < 151){ washCycle = 48; }
			else if(100 < max_press && max_press < 126){ washCycle = 46; }
			else if(75 < max_press && max_press < 101){ washCycle = 44; }
			else if(50 < max_press && max_press < 76){ washCycle = 42; }
			else if(max_press < 51){ washCycle = 40; }
			
			Globals.Tags.CycleTimer.Value = (Globals.Tags.cleaningWaterTime.Value+Globals.Tags.cleaningPressTime.Value+Globals.Tags.cleaningRestTime.Value)*washCycle;

			Globals.Tags.LoopCounter.Value = washCycle;
		}
    }
}
