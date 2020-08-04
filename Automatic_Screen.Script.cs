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
    
    
    public partial class Automatic_Screen
    {
			
		public bool Get_Status(){
		
			MessageBoxCF db = new MessageBoxCF(Text.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db1 = new MessageBoxCF(this.t_Door.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db2 = new MessageBoxCF(Text6.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						
			if(Globals.Tags.Testing_Proc.Value)
			{
				db.Show();
				Globals.Tags.Automatic_Washing.ResetTag();
			}
			else if(checkDoor())
			{
				db1.Show();
				Globals.Tags.Automatic_Washing.ResetTag();
			}
						
				return Globals.Tags.Automatic_Washing.Value;
		}
		
		public bool checkDoor(){
			if(Globals.Tags.MagneticDoorSwitch.Value){return false;}else{return true;}
		}
		
		public void Set_Status(){
			Globals.Tags.Automatic_Washing.SetTag();
		}
		
		public void Toggle_Status(){
			Globals.Tags.Automatic_Washing.ToggleTag();
		}
		
		public void Reset_Status(){
			Globals.Tags.Automatic_Washing.ResetTag();
		}
					
		void Auto_Wash_Button_Click(System.Object sender, System.EventArgs e)
		{
			Toggle_Status();
			bool status = Get_Status();
			
				if(status)
				{
					AutomaticWashingScript.Start();
					Manuel_Button.IsEnabled = false;
					Test_Nav.IsEnabled = false;
					Setting_Button.IsEnabled = false;
					Gun_Button.IsEnabled = false;
				
				}
				else
				{
					AutomaticWashingScript.Stop();
					Reset_Status();
					Gun_Button.IsEnabled = true;
					Globals.Tags.Washing_Pump.ResetTag();
					Globals.Tags.Pressure_Valve.ResetTag();
					Test_Nav.IsEnabled = true;
					if(!Globals.Tags.Drying_Proc.Value){
						Manuel_Button.IsEnabled = true;
						this.Setting_Button.IsEnabled = true;
					}
				}
		}
		
		void Automatic_Screen_Opened(System.Object sender, System.EventArgs e)
		{
			StatusChecker.Value = 1;
			if(Globals.Tags.Automatic_Washing.Value || Globals.Tags.Drying_Proc.Value || Globals.Tags.Manuel_Washing.Value){
				Setting_Button.IsEnabled = false;
				if(Globals.Tags.Manuel_Washing.Value){this.Manuel_Button.IsEnabled = false; this.Test_Nav.IsEnabled = false; Gun_Button.IsEnabled = false;}
			}
			else{
				Setting_Button.IsEnabled = true;
				Gun_Button.IsEnabled = true;
			}
		}
		
		void StatusChecker_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(!Globals.Tags.Automatic_Washing.Value)
			{
				Test_Nav.IsEnabled = true;
				Manuel_Button.IsEnabled = true;
				Gun_Button.IsEnabled = true;
				this.Rectangle1.Visible = false;
				this.Text3.Visible = false;
				if(!Globals.Tags.Drying_Proc.Value){
					this.Setting_Button.IsEnabled = true;
				}
			}
			else if(Globals.Tags.Automatic_Washing.Value)
			{
				Manuel_Button.IsEnabled = false;
				Test_Nav.IsEnabled = false;
				Setting_Button.IsEnabled = false;
				Gun_Button.IsEnabled = false;
				this.Rectangle1.Visible = true;
				this.Text3.Visible = true;
			}
		}
		
		void an_WaterLevel_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			MessageBoxCF db = new MessageBoxCF(t_Level.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			
			if(!Globals.Tags.WaterLevelSwitch.Value){
				db.Show();
				Globals.Tags.Water_Heater.ResetTag();
			}
		}
		
		void Heater_Button_Click(System.Object sender, System.EventArgs e)
		{
			MessageBoxCF db = new MessageBoxCF(t_Level.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			
			if(!Globals.Tags.Water_Heater.Value)
			{
				if(!Globals.Tags.WaterLevelSwitch.Value){
					db.Show();
					Globals.Tags.Water_Heater.ResetTag();
				}
				else
				{
					Globals.Tags.Water_Heater.SetTag();
				}
			}
			else
			{
				Globals.Tags.Water_Heater.ResetTag();
			}			
		}
		
		void PAUSE_Click(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.Automatic_Washing.Value){	
				if(AutomaticWashingScript.getTimer()){
					AutomaticWashingScript.Pause();
					Globals.Tags.PausedStatus.Value = 1;
					this.Rectangle1.Visible = false;
					this.Text3.Visible = false;
				}
				else
				{
					AutomaticWashingScript.Resume();
					Globals.Tags.PausedStatus.Value = 0;
					this.Rectangle1.Visible = true;
					this.Text3.Visible = true;
				}	
			}
		}
		
		
		
	}
}
