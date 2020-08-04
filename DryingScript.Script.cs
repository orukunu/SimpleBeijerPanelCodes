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
    
    
    public partial class DryingScript
	{
		private static Timer timer1 = null;
		
		static DryingScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.DryingTimer.Value = 0;
			Globals.Tags.Drying_Proc.ResetTag();
			StopBlower();
			StopDryer();
			Globals.Tags.Green_Light.ResetTag();
			Globals.Tags.Yellow_Light.SetTag();
			Globals.Tags.Buzzer.SetTag();
			BuzzerScript.Start();
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			StartBlower();
			Globals.Tags.Green_Light.SetTag();
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			Globals.Tags.DryingTimer.Value = Globals.Tags.DryingTimer.Value - 1;
			Globals.Tags.Drying_Time.Value = Globals.Tags.DryingTimer.Value / 60;
			
			if(Globals.Tags.DryingTimer.Value < 40)
			{
				StopDryer();
			}
			if(Globals.Tags.LeisterStarter.Value == Globals.Tags.DryingTimer.Value)
			{
				StartDryer();
			}
			if(Globals.Tags.DryingTimer.Value == 0)
			{
				Stop();
			}
		}
		
		public static void StartBlower()
		{
			Globals.Tags.Blower.SetTag();
			Globals.Tags.LeisterStarter.Value = (Globals.Tags.Drying_Time.Value * 60) - 20;
		}
		public static void StopBlower()
		{
			Globals.Tags.Blower.ResetTag();
		}
		public static void StartDryer()
		{
			Globals.Tags.Air_Heater.SetTag();
		}
		public static void StopDryer()
		{
			Globals.Tags.Air_Heater.ResetTag();
		}
		
		
	}
}
