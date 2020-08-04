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
	using Neo.ApplicationFramework.Tools.Messagebox;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class LoginScreen
    {
		
		void LoginButton_Click(System.Object sender, System.EventArgs e)
		{
			MessageBoxCF db = new MessageBoxCF(Text2.Text, Text1.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			if(Password_Num.Value.ToString() == "1998")
			{
				Password_Num.Value = 0;
				Globals.Admin_Page.Show();
			}
			else
			{
				db.Show();
			}
		}
		
		void CancelButton_Click(System.Object sender, System.EventArgs e)
		{
			Password_Num.Value = 0;
		}
    }
}
