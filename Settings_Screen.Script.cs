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
    
    
    public partial class Settings_Screen
    {
		
		void Settings_Screen_Closed(System.Object sender, System.EventArgs e)
		{
				Globals.Tags.Washing_Pump.ResetTag();
				Globals.Tags.Blower.ResetTag();
				Globals.Tags.Manual_Washing_Pump.ResetTag();
				Globals.Tags.Pressure_Valve.ResetTag();
		}
		
		void Calibration_Button_Click(System.Object sender, System.EventArgs e)
		{
			PressureCalibrationScript.Start();
			this.Rectangle2.Visible = true;
			this.Text.Visible = true;
		}
		
		void AnalogNumeric3_ValueChanged(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			string text = this.Text1.Text;
			string text2 = Globals.Tags.PressureCalibrationCounter.Value.ToString();
			text = text + ' ' + text2;
			text = text + " sec ...";
			this.Text.Text = text;
			
			if(Globals.Tags.PressureCalibrationCounter.Value == 0)
			{
				this.Rectangle2.Visible = false;
				this.Text.Visible = false;
			}
		}
		
    }
}
