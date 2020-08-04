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
    
    
    public partial class WashDryingScript
    {
		private static Timer timer1 = null;

		static WashDryingScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			Globals.Tags.Cycle_Info.Value = 0;
			Globals.Tags.InCycle.Value = 1;
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			CycleTimerCalculator();
			if(Globals.Tags.Automatic_Washing.Value)
			{
				Globals.Tags.LoopCounter.Value = 5;
			}
			else if(Globals.Tags.Manuel_Washing.Value)
			{
				Globals.Tags.LoopCounter.Value = Globals.Tags.ManWash_Dry_Cycle.Value;
			}
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
				if(loop >= 0){
					CycleTimerScript.Start();
				}
			}
		}
		
		public static void CycleTimerCalculator()
		{
			if(Globals.Tags.Automatic_Washing.Value)
			{
				Globals.Tags.CycleTimer.Value = (Globals.Tags.dryingAirTime.Value + Globals.Tags.dryingRestTime.Value)*5;
			}
			else if(Globals.Tags.Manuel_Washing.Value)
			{
				Globals.Tags.CycleTimer.Value = (Globals.Tags.dryingAirTime.Value + Globals.Tags.dryingRestTime.Value)* Globals.Tags.ManWash_Dry_Cycle.Value;
			}
		}
    }
}
