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
    
    
    public partial class AutomaticWashingScript
    {
		private static Timer timer1 = null;
	
		
		static AutomaticWashingScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static bool getTimer()
		{
			return timer1.Enabled;
		}

		public static void Stop() 
		{
			Globals.Tags.WashTimer.Value = 0;
			Globals.Tags.CycleTimer.Value = 0;
			Globals.Tags.InCycleTimer.Value = 0;
			Globals.Tags.LoopCounter.Value = 0;
			PrewashScript.Stop();
			WashingScript.Stop();
			WashDryingScript.Stop();
			CycleTimerScript.Stop();
			Globals.Tags.Automatic_Washing.ResetTag();
			Globals.Tags.Washing_Pump.ResetTag();
			Globals.Tags.Pressure_Valve.ResetTag();
			Globals.Tags.Yellow_Light.SetTag();
			Globals.Tags.Buzzer.SetTag();
			Globals.Tags.Green_Light.ResetTag();
			BuzzerScript.Start();
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			TimeCalculator();
			Globals.Tags.LoopCounter.Value = CycleDicider();
			Globals.Tags.Green_Light.SetTag();
			Globals.Tags.CycleTimer.Value = 1;
			Globals.Tags.Cycle_Info.Value = 1;
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
		
		public static void Pause()
		{
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}
		
		public static void Resume()
		{
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
		
		
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			Globals.Tags.WashTimer.Value = Globals.Tags.WashTimer.Value - 1;
			Globals.Tags.Washing_Time.Value = Globals.Tags.WashTimer.Value /60;
			Globals.Tags.CycleTimer.Value = Globals.Tags.CycleTimer.Value - 1;
			Globals.Tags.InCycleTimer.Value = Globals.Tags.InCycleTimer.Value - 1;
			int cycleInfo = Globals.Tags.Cycle_Info.Value;
			
			if(Globals.Tags.WashTimer.Value > 0)
			{
				if(Globals.Tags.CycleTimer.Value <= 0){
					if(cycleInfo == 1)
					{
						PrewashScript.Start();
					}
					else if(cycleInfo == 2)
					{
						PrewashScript.Stop();
						WashingScript.Start();
					}
					else if(cycleInfo == 3)
					{
						WashingScript.Stop();
						WashDryingScript.Start();
					}
					else
					{ 
						Stop();
						WashDryingScript.Stop();
					}
				}
			}
			else
			{
				Stop();
			}
		}
		
		public static void TimeCalculator(){
			
			int time = ((Globals.Tags.prewashWaterTime.Value + Globals.Tags.prewashRestTime.Value)*Globals.Tags.Man_Pre_Wash_Cycle.Value)+((Globals.Tags.cleaningWaterTime.Value+Globals.Tags.cleaningPressTime.Value+Globals.Tags.cleaningRestTime.Value)*CycleDicider())+((Globals.Tags.dryingAirTime.Value+Globals.Tags.dryingRestTime.Value)*1);
			Globals.Tags.WashTimer.Value = time;
		}

		public static int CycleDicider(){
			
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
			
			return washCycle;
		}	
    }
}
