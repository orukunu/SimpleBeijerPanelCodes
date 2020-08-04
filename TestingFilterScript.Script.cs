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
    
    
	public partial class TestingFilterScript
	{
		private static Timer timer1 = null;
		
		static TestingFilterScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.TestTimer.Value = 0;
			Globals.Tags.Testing_Proc.ResetTag();
			Globals.Tags.Pressure_Valve.ResetTag();
			Globals.Tags.Printer.SetTag();
			BlinkScript.Start();
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			Globals.Tags.TestTimer.Value = 0;
			Globals.Tags.Max_Pressure.Value = 0;
			Globals.Tags.Pressure_Valve.SetTag();
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			Globals.Tags.TestTimer.Value = Globals.Tags.TestTimer.Value + 1;
			int test_time = Globals.Tags.TestTime.Value+1; 
			
			if(Globals.Tags.TestTimer.Value < test_time)
			{
				if(Globals.Tags.Max_Pressure.Value < Globals.Tags.Pressure_Info.Value){
					Globals.Tags.Max_Pressure.Value = Globals.Tags.Pressure_Info.Value;
				}

				if(Globals.Tags.Pressure_Info.Value > 500){
					Globals.Tags.TestTimer.Value = 20;
				}
			}
			else
			{
				Stop();
				if(Globals.Tags.Max_Pressure.Value < 25)
				{
					Globals.Tags.Clean_Filter.SetTag();
				}
				else if(Globals.Tags.Max_Pressure.Value > 75){
					Globals.Tags.Clogged_Filter.SetTag();
				}
				else
				{
					Globals.Tags.Dirty_Filter.SetTag();
				}
			}
		}			
	}
}
