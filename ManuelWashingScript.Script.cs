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
    
    
    public partial class ManuelWashingScript
	{
		private static Timer timer1 = null;
	
		
		static ManuelWashingScript()
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
			Globals.Tags.Manuel_Washing.ResetTag();
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
			Globals.Tags.ManWashTimer.Value = Globals.Tags.ManWashTime.Value * 60;
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
			Globals.Tags.ManWashTimer.Value = Globals.Tags.ManWashTimer.Value - 1;
			Globals.Tags.CycleTimer.Value = Globals.Tags.CycleTimer.Value - 1;
			Globals.Tags.InCycleTimer.Value = Globals.Tags.InCycleTimer.Value - 1;
			Globals.Tags.ManWashTime.Value = (Globals.Tags.ManWashTimer.Value / 60)+1;
			int cycleInfo = Globals.Tags.Cycle_Info.Value;
			
			if(Globals.Tags.ManWashTimer.Value >= 0)
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
	}
}
