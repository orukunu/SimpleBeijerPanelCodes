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
    
    
    public partial class BlinkScript
    {
		private static Timer timer1 = null;
		
		static BlinkScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.Clean_Filter.ResetTag();
			Globals.Tags.Dirty_Filter.ResetTag();
			Globals.Tags.Clogged_Filter.ResetTag();
			Globals.Tags.Printer.ResetTag();
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			Globals.Tags.BlinkTimer.Value = 0;
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			Globals.Tags.BlinkTimer.Value = Globals.Tags.BlinkTimer.Value + 1;
			
			if(Globals.Tags.BlinkTimer.Value > 10){
				Stop();			
			}
		}
    }
}
