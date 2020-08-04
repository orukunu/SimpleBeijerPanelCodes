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
    
    
    public partial class HomeScreen
    {
		void HomeScreen_Closed(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.cleaningWaterTime.Value == 1453){
				Globals.Tags.prewashWaterTime.Value = 0;
				Globals.Tags.prewashRestTime.Value = 0;
				Globals.Tags.dryingAirTime.Value = 20;
				Globals.Tags.dryingRestTime.Value = 1;
				Globals.Tags.cleaningWaterTime.Value = 6;
				Globals.Tags.cleaningPressTime.Value = 1;
				Globals.Tags.cleaningRestTime.Value = 1;
				Globals.Tags.TestTime.Value = 10;
				Globals.Tags.Man_Pre_Wash_Cycle.Value = 0;
				Globals.Tags.ManWash_Dry_Cycle.Value = 3;
				Globals.Tags.CleaningCounterLimit.Value = 15; 
			}
		}
	}
}
