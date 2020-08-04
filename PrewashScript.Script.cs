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
    
    
    public partial class PrewashScript
    {
		private static Timer timer1 = null;
							
		static PrewashScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.Cycle_Info.Value = 2;
			Globals.Tags.InCycle.Value = 1;
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			Globals.Tags.LoopCounter.Value = Globals.Tags.Man_Pre_Wash_Cycle.Value;
			Globals.Tags.InCycle.Value = 1;
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
			int isOn = Globals.Tags.prewashRestTime.Value;
			int isOn1 = Globals.Tags.prewashWaterTime.Value;
			
			if(timer <= 0){
				if(isOn == 0 && isOn1 == 0){
					loop = 0;
					Stop();
				}
				else if(loop > 0){
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
			Globals.Tags.CycleTimer.Value = (Globals.Tags.prewashWaterTime.Value + Globals.Tags.prewashRestTime.Value)*Globals.Tags.Man_Pre_Wash_Cycle.Value;	
		}
		
    }
}
