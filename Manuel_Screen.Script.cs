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
    
    
    public partial class Manuel_Screen
    {
		
		public void Set_Status(){
			Globals.Tags.Manuel_Washing.SetTag();
		}
		
		public void Toggle_Status(){
			Globals.Tags.Manuel_Washing.ToggleTag();
		}
		
		public void Reset_Status(){
			Globals.Tags.Manuel_Washing.ResetTag();
		}
		public bool Get_Status(){
		
			string text = Globals.Tags.MagneticDoorSwitch.Value.ToString();
			MessageBoxCF db = new MessageBoxCF(Text.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db1 = new MessageBoxCF(Text2.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db2 = new MessageBoxCF(t_Door.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MessageBoxCF db3 = new MessageBoxCF(Text6.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						
			if(Globals.Tags.Testing_Proc.Value || Globals.Tags.Automatic_Washing.Value)
			{
				db.Show();
				Globals.Tags.Manuel_Washing.ResetTag();
			}
			else if(Globals.Tags.ManWashTime.Value < 1){
				db1.Show();
				Globals.Tags.Manuel_Washing.ResetTag();
			}
			else if(checkDoor()){
				db2.Show();
				Globals.Tags.Manuel_Washing.ResetTag();
			}
			
			return Globals.Tags.Manuel_Washing.Value;
		}
		
		public bool checkDoor(){
			if(Globals.Tags.MagneticDoorSwitch.Value){return false;}else{return true;}
		}
		
		void Manuel_Screen_Opened(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.Manuel_Washing.Value){
				Auto_Button.IsEnabled = false;
				Test_Nav.IsEnabled = false;
				Gun_Button.IsEnabled = false;
				this.Home_Button.IsEnabled = false;
				if(Globals.Tags.Automatic_Washing.Value || Globals.Tags.Drying_Proc.Value){
					Setting_Button.IsEnabled = false;
				}
			}
			else{
				Auto_Button.IsEnabled = true;
				Gun_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = true;
			}
			if(Globals.Tags.Automatic_Washing.Value || Globals.Tags.Drying_Proc.Value || Globals.Tags.Manuel_Washing.Value){
				Setting_Button.IsEnabled = false;
			}else{Setting_Button.IsEnabled = true;}
			if(Globals.Tags.Cycle_Info.Value == 2 && Globals.Tags.InCycle.Value == 1){
				this.Press_Button.IsEnabled = true;
			}else{this.Press_Button.IsEnabled = false;}
		}
		
		
		void MWashing_Button_Click(System.Object sender, System.EventArgs e)
		{
			Toggle_Status();
			bool status = Get_Status();
						
			if(status)
			{
				ManuelWashingScript.Start();
				Auto_Button.IsEnabled = false;
				Test_Nav.IsEnabled = false;
				Setting_Button.IsEnabled = false;
				Gun_Button.IsEnabled = false;
				this.Home_Button.IsEnabled = false;
				this.Rectangle1.Visible = true;
				this.Text3.Visible = true;
			}
			else
			{
				ManuelWashingScript.Stop();
				Reset_Status();
				Globals.Tags.Washing_Pump.ResetTag();
				Globals.Tags.Pressure_Valve.ResetTag();
				Test_Nav.IsEnabled = true;
				Gun_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = true;
				Auto_Button.IsEnabled = true;
				if(!Globals.Tags.Drying_Proc.Value){
					this.Setting_Button.IsEnabled = true;
				}
				this.Rectangle1.Visible = false;
				this.Text3.Visible = false;
			}		
		}
		
		void StatusChecker_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(!Globals.Tags.Manuel_Washing.Value)
			{
				Test_Nav.IsEnabled = true;
				Gun_Button.IsEnabled = true;
				this.Home_Button.IsEnabled = true;
				Auto_Button.IsEnabled = true;
				if(!Globals.Tags.Drying_Proc.Value){
					this.Setting_Button.IsEnabled = true;
				}
			}
			else if(Globals.Tags.Manuel_Washing.Value)
			{
				Auto_Button.IsEnabled = false;
				Test_Nav.IsEnabled = false;
				Setting_Button.IsEnabled = false;
				Gun_Button.IsEnabled = false;
				this.Home_Button.IsEnabled = false;
			}			
		}
		
		void PressChecker_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.Cycle_Info.Value == 2 && Globals.Tags.InCycle.Value == 1){
				this.Press_Button.IsEnabled = true;
			}else{this.Press_Button.IsEnabled = false;}
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
			
			if(!Globals.Tags.Water_Heater.Value){
				if(!Globals.Tags.WaterLevelSwitch.Value){
					db.Show();
					Globals.Tags.Water_Heater.ResetTag();
				}else{
					Globals.Tags.Water_Heater.SetTag();
				}
			}else{
				Globals.Tags.Water_Heater.ResetTag();
			}
			
		}
		
		void PAUSE_Click(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.Manuel_Washing.Value){	
				if(ManuelWashingScript.getTimer()){
					ManuelWashingScript.Pause();
					Globals.Tags.PausedStatus.Value = 1;
					this.Rectangle1.Visible = false;
					this.Text3.Visible = false;
				}
				else
				{
					ManuelWashingScript.Resume();
					Globals.Tags.PausedStatus.Value = 0;
					this.Rectangle1.Visible = true;
					this.Text3.Visible = true;
				}	
			}			
		}
		
		
		
		
		
    }
}
