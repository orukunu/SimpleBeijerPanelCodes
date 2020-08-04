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
    
    
	public partial class CycleTimerScript
	{
		private static Timer timer1 = null;
		private static int prewashWaterTime = Globals.Tags.prewashWaterTime.Value;
		private static int prewashRestTime = Globals.Tags.prewashRestTime.Value;
		private static int dryingAirTime = Globals.Tags.dryingAirTime.Value;
		private static int dryingRestTime = Globals.Tags.dryingRestTime.Value;
		private static int cleaningWaterTime = Globals.Tags.cleaningWaterTime.Value;
		private static int cleaningPressTime = Globals.Tags.cleaningPressTime.Value;
		private static int cleaningRestTime = Globals.Tags.cleaningRestTime.Value;
		
		
		static CycleTimerScript()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(TimeOut1);
			timer1.Interval = 1000;
			timer1.Enabled = false;	
		}

		public static void Stop() 
		{
			try {
				timer1.Enabled = false;
			}
			catch(Exception) {}
		}		
		
		public static void Start()
		{
			if(Globals.Tags.Cycle_Info.Value == 1)
			{
				//PREWASH
				if(Globals.Tags.Man_Pre_Wash_Cycle.Value < 1)
				{
					Globals.Tags.Cycle_Info.Value = 2;	
				}
				else if(Globals.Tags.InCycle.Value == 1)
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.prewashWaterTime.Value;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value + 1;
					PrewashWater_Proc();
				}
				else
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.prewashRestTime.Value;
					Globals.Tags.LoopCounter.Value = Globals.Tags.LoopCounter.Value - 1;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value - 1;
					if(Globals.Tags.LoopCounter.Value == 0){ Globals.Tags.Cycle_Info.Value = 2;}
					Rest_Proc();
				}
			}
			else if(Globals.Tags.Cycle_Info.Value == 2)
			{
				//Cleaning
				if(Globals.Tags.InCycle.Value == 1)
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.cleaningWaterTime.Value;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value + 1;
					CleaningWater_Proc();					
				}
				else if(Globals.Tags.InCycle.Value == 2)
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.cleaningPressTime.Value;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value + 1;
					if(Globals.Tags.DPF_CAT.Value == 1){
						CleaningPress_Proc();
					}
				}
				else if(Globals.Tags.InCycle.Value == 3)
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.cleaningRestTime.Value;
					Globals.Tags.LoopCounter.Value = Globals.Tags.LoopCounter.Value - 1;
					Globals.Tags.InCycle.Value = 1;
					if(Globals.Tags.LoopCounter.Value == 0){ Globals.Tags.Cycle_Info.Value = 3;}
					Rest_Proc();
				}
			}
			else if(Globals.Tags.Cycle_Info.Value == 3)
			{
				//Drying
				if(Globals.Tags.InCycle.Value == 1)
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.dryingAirTime.Value;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value + 1;
					DryingAir_Proc();
				}
				else
				{
					Globals.Tags.InCycleTimer.Value = Globals.Tags.dryingRestTime.Value;
					Globals.Tags.LoopCounter.Value = Globals.Tags.LoopCounter.Value - 1;
					Globals.Tags.InCycle.Value = Globals.Tags.InCycle.Value - 1;
					Rest_Proc();
				}
			}
			try {
				timer1.Enabled = true;
			}
			catch(Exception) {}
		}
	
		public static void TimeOut1(Object myObject, EventArgs myEventArgs) 
		{	
			if(Globals.Tags.InCycleTimer.Value <= 0){
				Stop();
			}
		}

		public static void PrewashWater_Proc()
		{
			Globals.Tags.Washing_Pump.SetTag();
			Globals.Tags.Pressure_Valve.ResetTag();
		}
		public static void CleaningWater_Proc()
		{
			Globals.Tags.Washing_Pump.SetTag();
			Globals.Tags.Pressure_Valve.ResetTag();
		}
		public static void CleaningPress_Proc()
		{
			Globals.Tags.Washing_Pump.SetTag();
			Globals.Tags.Pressure_Valve.SetTag();
		}
		public static void DryingAir_Proc()
		{
			Globals.Tags.Washing_Pump.ResetTag();
			Globals.Tags.Pressure_Valve.SetTag();
		}
		public static void Rest_Proc()
		{
			Globals.Tags.Washing_Pump.ResetTag();
			Globals.Tags.Pressure_Valve.ResetTag();
		}
	}
}
