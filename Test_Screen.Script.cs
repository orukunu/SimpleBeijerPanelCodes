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
    
    
	
	
	public partial class Test_Screen
	{
				
		public bool Get_Status(){
		
			MessageBoxCF db = new MessageBoxCF(Text.Text, Text4.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						
			if(Globals.Tags.Automatic_Washing.Value)
			{
				db.Show();
				Globals.Tags.Testing_Proc.ResetTag();
			}
			
			return Globals.Tags.Testing_Proc.Value;
		}
		
		public void Set_Status(){
			Globals.Tags.Green_Light.SetTag();
			Globals.Tags.Testing_Proc.SetTag();
		}
		
		public void Toggle_Status(){
			Globals.Tags.Testing_Proc.ToggleTag();
		}
		
		public void Reset_Status(){
			Globals.Tags.Testing_Proc.ResetTag();
			Globals.Tags.Green_Light.ResetTag();
			Globals.Tags.Buzzer.SetTag();
			BuzzerScript.Start();
		}
		
		void Filter_Test_Click(System.Object sender, System.EventArgs e)
		{
			Toggle_Status();
			bool status = Get_Status();
						
			if(status)
			{
				Set_Status();
				TestingFilterScript.Start();
				this.Disable_Buttons();
				
			}
			else
			{
				Reset_Status();
				TestingFilterScript.Stop();
				this.Enable_Buttons();
			}			
		}
		
		void Test_Screen_Opened(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.Max_Pressure.Value = 0;
			Globals.Tags.TestTimer.Value = 0;
			TrendViewer.ShowHistory("On");
			TrendViewer1.ShowHistory("On");
		}			
		void AnalogNumeric_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(!Globals.Tags.Testing_Proc.Value)
			{
				TrendViewer.ShowHistory("On");
				TrendViewer1.ShowHistory("On");
				this.Enable_Buttons();
			}
			else if(Globals.Tags.Testing_Proc.Value)
			{
				TrendViewer.ShowHistory("Off");
				TrendViewer1.ShowHistory("Off");
			}
		}
		
		void Enable_Buttons(){
			this.Alarm_button.IsEnabled = true;
			this.Test_Nav.IsEnabled = true;
			this.Home_Button.IsEnabled = true;
			this.Drying_Button.IsEnabled = true;
			this.Auto_Button.IsEnabled = true;
			this.Manuel_Button.IsEnabled = true;
		}
		void Disable_Buttons(){
			this.Alarm_button.IsEnabled = false;
			this.Test_Nav.IsEnabled = false;
			this.Home_Button.IsEnabled = false;
			this.Drying_Button.IsEnabled = false;
			this.Auto_Button.IsEnabled = false;
			this.Manuel_Button.IsEnabled = false;
		}
	}
}
