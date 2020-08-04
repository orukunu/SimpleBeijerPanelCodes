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
    
    
    public partial class Drying_Screen
    {
		
		public bool Get_Status(){
		
			return Globals.Tags.Drying_Proc.Value;
		}
		
		public void Set_Status(){
			Globals.Tags.Drying_Proc.SetTag();
		}
		
		public void Toggle_Status(){
			Globals.Tags.Drying_Proc.ToggleTag();
		}
		
		public void Reset_Status(){
			Globals.Tags.Drying_Proc.ResetTag();
		}
		
		void Drying_Start_Click(System.Object sender, System.EventArgs e)
		{
			Toggle_Status();
			bool status = Get_Status();
			Globals.Tags.DryingTimer.Value = Globals.Tags.Drying_Time.Value * 60;
			MessageBoxCF db = new MessageBoxCF(Text2.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db1 = new MessageBoxCF(Text.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			if(status)
			{
				if(Globals.Tags.DryingTimer.Value > 0)
				{
					if(Globals.Tags.Air_Heater_Set.Value > 49){
						if(Globals.Tags.Air_Heater_Set.Value <126){
							Set_Status();
							DryingScript.Start();
						}else
						{
							db1.Show();
							Reset_Status();
						}						
					}else
					{
						db1.Show();
						Reset_Status();
					}
				}
				else
				{
					db.Show();
					Reset_Status();
				}
			
			}
			else
			{
				Reset_Status();
				DryingScript.Stop();
			}
		}
		
		void Drying_Screen_Opened(System.Object sender, System.EventArgs e)
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
