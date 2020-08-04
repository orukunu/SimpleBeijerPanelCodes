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
    
    
    public partial class Alarm_Screen
    {
		
		void Alarm_Screen_Opened(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.Automatic_Washing.Value)
			{
				this.Manuel_Button.IsEnabled = false;
				this.Test_Nav.IsEnabled = false;
				this.Auto_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = true;
			}
			else if(Globals.Tags.Manuel_Washing.Value)
			{
				this.Auto_Button.IsEnabled = false;
				this.Test_Nav.IsEnabled = false;
				this.Manuel_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = false;
			}
			else if(Globals.Tags.Testing_Proc.Value)
			{
				this.Auto_Button.IsEnabled = false;
				this.Manuel_Button.IsEnabled = false;
				this.Test_Nav.IsEnabled = true;
				this.Home_Button.IsEnabled = false;
			}	
			else
			{
				this.Test_Nav.IsEnabled = true;
				this.Manuel_Button.IsEnabled = true;
				this.Auto_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = true;
			}
		}
    }
}
