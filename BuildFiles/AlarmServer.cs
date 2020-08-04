//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	using Neo.ApplicationFramework.Tools.Alarm;
	
	
	public partial class AlarmServer : Neo.ApplicationFramework.Tools.Alarm.AlarmServer, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmGroup m_Default;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_Emergency_Stop;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_Phase_Sequence;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_Washing_Pump_Error;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_Manuel_Washing_Pump_Error;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_Blower_Error;
		
		public AlarmServer()
		{
			this.InitializeComponent();
			this.Default_Emergency_Stop.AlarmActive += new System.EventHandler(this.Default_Emergency_Stop_Action_AlarmActive);
			this.Default_Emergency_Stop.AlarmAcknowledge += new System.EventHandler(this.Default_Emergency_Stop_Action_AlarmAcknowledge);
			this.Default_Emergency_Stop.AlarmInactive += new System.EventHandler(this.Default_Emergency_Stop_Action_AlarmInactive);
			this.Default_Phase_Sequence.AlarmActive += new System.EventHandler(this.Default_Phase_Sequence_Action_AlarmActive);
			this.Default_Phase_Sequence.AlarmAcknowledge += new System.EventHandler(this.Default_Phase_Sequence_Action_AlarmAcknowledge);
			this.Default_Phase_Sequence.AlarmInactive += new System.EventHandler(this.Default_Phase_Sequence_Action_AlarmInactive);
			this.Default_Washing_Pump_Error.AlarmActive += new System.EventHandler(this.Default_Washing_Pump_Error_Action_AlarmActive);
			this.Default_Washing_Pump_Error.AlarmAcknowledge += new System.EventHandler(this.Default_Washing_Pump_Error_Action_AlarmAcknowledge);
			this.Default_Washing_Pump_Error.AlarmInactive += new System.EventHandler(this.Default_Washing_Pump_Error_Action_AlarmInactive);
			this.Default_Manuel_Washing_Pump_Error.AlarmActive += new System.EventHandler(this.Default_Manuel_Washing_Pump_Error_Action_AlarmActive);
			this.Default_Manuel_Washing_Pump_Error.AlarmAcknowledge += new System.EventHandler(this.Default_Manuel_Washing_Pump_Error_Action_AlarmAcknowledge);
			this.Default_Manuel_Washing_Pump_Error.AlarmInactive += new System.EventHandler(this.Default_Manuel_Washing_Pump_Error_Action_AlarmInactive);
			this.Default_Blower_Error.AlarmActive += new System.EventHandler(this.Default_Blower_Error_Action_AlarmActive);
			this.Default_Blower_Error.AlarmAcknowledge += new System.EventHandler(this.Default_Blower_Error_Action_AlarmAcknowledge);
			this.Default_Blower_Error.AlarmInactive += new System.EventHandler(this.Default_Blower_Error_Action_AlarmInactive);
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmGroup Default
		{
			get
			{
				return this.m_Default;
			}
			set
			{
				this.m_Default = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_Emergency_Stop
		{
			get
			{
				return this.m_Default_Emergency_Stop;
			}
			set
			{
				this.m_Default_Emergency_Stop = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_Phase_Sequence
		{
			get
			{
				return this.m_Default_Phase_Sequence;
			}
			set
			{
				this.m_Default_Phase_Sequence = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_Washing_Pump_Error
		{
			get
			{
				return this.m_Default_Washing_Pump_Error;
			}
			set
			{
				this.m_Default_Washing_Pump_Error = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_Manuel_Washing_Pump_Error
		{
			get
			{
				return this.m_Default_Manuel_Washing_Pump_Error;
			}
			set
			{
				this.m_Default_Manuel_Washing_Pump_Error = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_Blower_Error
		{
			get
			{
				return this.m_Default_Blower_Error;
			}
			set
			{
				this.m_Default_Blower_Error = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public virtual void ConnectDataBindings()
		{
			this.Default_Emergency_Stop.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.Emergency_Stop"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_Phase_Sequence.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.Phase_Error"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_Washing_Pump_Error.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.Washing_Thermic"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_Manuel_Washing_Pump_Error.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.Manuel_Washing_Thermic"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_Blower_Error.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.Blower_Error"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
		}
		
		private void InitializeObjectCreations()
		{
			this.Default = new Neo.ApplicationFramework.Tools.Alarm.AlarmGroup();
			this.Default_Emergency_Stop = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_Phase_Sequence = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_Washing_Pump_Error = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_Manuel_Washing_Pump_Error = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_Blower_Error = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_Emergency_Stop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Phase_Sequence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Washing_Pump_Error)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Manuel_Washing_Pump_Error)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Blower_Error)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_Emergency_Stop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Phase_Sequence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Washing_Pump_Error)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Manuel_Washing_Pump_Error)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_Blower_Error)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.Default.AcknowledgeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
			this.Default.AcknowledgeForeColor = System.Drawing.Color.Black;
			this.Default.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
			this.Default.ActiveForeColor = System.Drawing.Color.Black;
			this.Default_Emergency_Stop.AcknowledgeRequired = true;
			this.Default_Emergency_Stop.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_Emergency_Stop.Contacts = null;
			this.Default_Emergency_Stop.DefaultText = "Emergency Stop is Pressed";
			this.Default_Emergency_Stop.DisplayName = "Emergency_Stop";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString1 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString1.Text = "Emergency Stop is Pressed";
			this.Default_Emergency_Stop.DynamicString = DynamicString1;
			this.Default_Emergency_Stop.EnableDistribution = false;
			this.Default_Emergency_Stop.GroupId = new System.Guid("236b8315-f921-45c3-b11d-80681e2b2f60");
			this.Default_Emergency_Stop.GroupName = "Default";
			this.Default_Emergency_Stop.History = true;
			this.Default_Emergency_Stop.IsDigitalValue = false;
			this.Default_Emergency_Stop.Name = "Default_Emergency_Stop";
			this.Default_Emergency_Stop.OutputDevices = null;
			this.Default_Emergency_Stop.RepeatCount = false;
			this.Default_Emergency_Stop.TriggerValue = 0;
			this.Default_Phase_Sequence.AcknowledgeRequired = true;
			this.Default_Phase_Sequence.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_Phase_Sequence.Contacts = null;
			this.Default_Phase_Sequence.DefaultText = "Phase Sequence is Wrong";
			this.Default_Phase_Sequence.DisplayName = "Phase_Sequence";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString2 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString2.Text = "Phase Sequence is Wrong";
			this.Default_Phase_Sequence.DynamicString = DynamicString2;
			this.Default_Phase_Sequence.EnableDistribution = false;
			this.Default_Phase_Sequence.GroupId = new System.Guid("236b8315-f921-45c3-b11d-80681e2b2f60");
			this.Default_Phase_Sequence.GroupName = "Default";
			this.Default_Phase_Sequence.History = true;
			this.Default_Phase_Sequence.IsDigitalValue = false;
			this.Default_Phase_Sequence.Name = "Default_Phase_Sequence";
			this.Default_Phase_Sequence.OutputDevices = null;
			this.Default_Phase_Sequence.RepeatCount = false;
			this.Default_Phase_Sequence.TriggerValue = 0;
			this.Default_Washing_Pump_Error.AcknowledgeRequired = true;
			this.Default_Washing_Pump_Error.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_Washing_Pump_Error.Contacts = null;
			this.Default_Washing_Pump_Error.DefaultText = "Washing Pump Error";
			this.Default_Washing_Pump_Error.DisplayName = "Washing_Pump_Error";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString3 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString3.Text = "Washing Pump Error";
			this.Default_Washing_Pump_Error.DynamicString = DynamicString3;
			this.Default_Washing_Pump_Error.EnableDistribution = false;
			this.Default_Washing_Pump_Error.GroupId = new System.Guid("236b8315-f921-45c3-b11d-80681e2b2f60");
			this.Default_Washing_Pump_Error.GroupName = "Default";
			this.Default_Washing_Pump_Error.History = true;
			this.Default_Washing_Pump_Error.IsDigitalValue = false;
			this.Default_Washing_Pump_Error.Name = "Default_Washing_Pump_Error";
			this.Default_Washing_Pump_Error.OutputDevices = null;
			this.Default_Washing_Pump_Error.RepeatCount = false;
			this.Default_Washing_Pump_Error.TriggerValue = 0;
			this.Default_Manuel_Washing_Pump_Error.AcknowledgeRequired = true;
			this.Default_Manuel_Washing_Pump_Error.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_Manuel_Washing_Pump_Error.Contacts = null;
			this.Default_Manuel_Washing_Pump_Error.DefaultText = "High Pressure (Manuel) Washing Pump Error";
			this.Default_Manuel_Washing_Pump_Error.DisplayName = "Manuel_Washing_Pump_Error";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString4 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString4.Text = "High Pressure (Manuel) Washing Pump Error";
			this.Default_Manuel_Washing_Pump_Error.DynamicString = DynamicString4;
			this.Default_Manuel_Washing_Pump_Error.EnableDistribution = false;
			this.Default_Manuel_Washing_Pump_Error.GroupId = new System.Guid("236b8315-f921-45c3-b11d-80681e2b2f60");
			this.Default_Manuel_Washing_Pump_Error.GroupName = "Default";
			this.Default_Manuel_Washing_Pump_Error.History = true;
			this.Default_Manuel_Washing_Pump_Error.IsDigitalValue = false;
			this.Default_Manuel_Washing_Pump_Error.Name = "Default_Manuel_Washing_Pump_Error";
			this.Default_Manuel_Washing_Pump_Error.OutputDevices = null;
			this.Default_Manuel_Washing_Pump_Error.RepeatCount = false;
			this.Default_Manuel_Washing_Pump_Error.TriggerValue = 0;
			this.Default_Blower_Error.AcknowledgeRequired = true;
			this.Default_Blower_Error.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_Blower_Error.Contacts = null;
			this.Default_Blower_Error.DefaultText = "Dryer Blower Error";
			this.Default_Blower_Error.DisplayName = "Blower_Error";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString5 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString5.Text = "Dryer Blower Error";
			this.Default_Blower_Error.DynamicString = DynamicString5;
			this.Default_Blower_Error.EnableDistribution = false;
			this.Default_Blower_Error.GroupId = new System.Guid("236b8315-f921-45c3-b11d-80681e2b2f60");
			this.Default_Blower_Error.GroupName = "Default";
			this.Default_Blower_Error.History = true;
			this.Default_Blower_Error.IsDigitalValue = false;
			this.Default_Blower_Error.Name = "Default_Blower_Error";
			this.Default_Blower_Error.OutputDevices = null;
			this.Default_Blower_Error.RepeatCount = false;
			this.Default_Blower_Error.TriggerValue = 0;
			this.Default.AlarmItems.Add(this.Default_Emergency_Stop);
			this.Default.AlarmItems.Add(this.Default_Phase_Sequence);
			this.Default.AlarmItems.Add(this.Default_Washing_Pump_Error);
			this.Default.AlarmItems.Add(this.Default_Manuel_Washing_Pump_Error);
			this.Default.AlarmItems.Add(this.Default_Blower_Error);
			this.Default.EnableDistribution = false;
			this.Default.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(204)))), ((int)(((byte)(71)))));
			this.Default.InactiveForeColor = System.Drawing.Color.Black;
			this.Default.Name = "Default";
			this.Default.NormalBackColor = System.Drawing.SystemColors.Window;
			this.Default.NormalForeColor = System.Drawing.Color.Black;
			this.AlarmGroups.Add(this.Default);
			this.StorageEvent.AcknowledgeTime = null;
			this.StorageEvent.ActiveTime = null;
			this.StorageEvent.AlarmGroupName = "";
			this.StorageEvent.AlarmGroupText = "";
			this.StorageEvent.AlarmItemId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.StorageEvent.Count = 0;
			this.StorageEvent.DisplayText = "";
			this.StorageEvent.EnableDistribution = false;
			this.StorageEvent.ForceToList = false;
			this.StorageEvent.History = false;
			this.StorageEvent.InActiveTime = null;
			this.StorageEvent.NormalTime = null;
			this.StorageEvent.RepeatCount = false;
			this.StorageEvent.State = Neo.ApplicationFramework.Interfaces.AlarmState.Normal;
			this.StorageEvent.TableName = "AlarmServer";
			this.StorageEvent.Text = "";
			this.SummaryAlarmComponentMode = Neo.ApplicationFramework.Interfaces.AlarmServerAlarmEventsState.Never;
		}
		
		private void Default_Emergency_Stop_Action_AlarmActive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmActive", "Set Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmActive", "Show Screen", "Alarm_Screen", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Alarm_Screen.Show();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmActive", "Set Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.SetTag();
		}
		
		private void Default_Emergency_Stop_Action_AlarmAcknowledge(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmAcknowledge", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmAcknowledge", "Set Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmAcknowledge", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Emergency_Stop_Action_AlarmInactive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmInactive", "Reset Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmInactive", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmInactive", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Emergency_Stop", "AlarmInactive", "Set Tag", "Tags.Green_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Green_Light.SetTag();
		}
		
		private void Default_Phase_Sequence_Action_AlarmActive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmActive", "Set Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmActive", "Show Screen", "Alarm_Screen", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Alarm_Screen.Show();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmActive", "Set Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.SetTag();
		}
		
		private void Default_Phase_Sequence_Action_AlarmAcknowledge(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmAcknowledge", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmAcknowledge", "Set Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmAcknowledge", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Phase_Sequence_Action_AlarmInactive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmInactive", "Reset Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmInactive", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmInactive", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Phase_Sequence", "AlarmInactive", "Set Tag", "Tags.Green_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Green_Light.SetTag();
		}
		
		private void Default_Washing_Pump_Error_Action_AlarmActive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmActive", "Set Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmActive", "Show Screen", "Alarm_Screen", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Alarm_Screen.Show();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmActive", "Set Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.SetTag();
		}
		
		private void Default_Washing_Pump_Error_Action_AlarmAcknowledge(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmAcknowledge", "Set Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Washing_Pump_Error_Action_AlarmInactive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Manuel_Washing_Pump_Error_Action_AlarmActive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmActive", "Show Screen", "Alarm_Screen", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Alarm_Screen.Show();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmActive", "Set Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmActive", "Set Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.SetTag();
		}
		
		private void Default_Manuel_Washing_Pump_Error_Action_AlarmAcknowledge(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmAcknowledge", "Set Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Manuel_Washing_Pump_Error_Action_AlarmInactive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Manuel_Washing_Pump_Error", "AlarmInactive", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Blower_Error_Action_AlarmActive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmActive", "Set Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmActive", "Show Screen", "Alarm_Screen", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Alarm_Screen.Show();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmActive", "Set Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.SetTag();
		}
		
		private void Default_Blower_Error_Action_AlarmAcknowledge(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmAcknowledge", "Set Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.SetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmAcknowledge", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		private void Default_Blower_Error_Action_AlarmInactive(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmInactive", "Reset Tag", "Tags.Yellow_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Yellow_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmInactive", "Reset Tag", "Tags.Red_Light", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Red_Light.ResetTag();
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("Default_Blower_Error", "AlarmInactive", "Reset Tag", "Tags.Buzzer", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.Buzzer.ResetTag();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(AlarmServer));
			this.m_Default.Text = resources.GetText("AlarmServer.Default.Text", "Default");
			this.m_Default_Emergency_Stop.StaticText = resources.GetText("AlarmServer.Default_Emergency_Stop.StaticText", "Emergency Stop is Pressed");
			this.m_Default_Phase_Sequence.StaticText = resources.GetText("AlarmServer.Default_Phase_Sequence.StaticText", "Phase Sequence is Wrong");
			this.m_Default_Washing_Pump_Error.StaticText = resources.GetText("AlarmServer.Default_Washing_Pump_Error.StaticText", "Washing Pump Error");
			this.m_Default_Manuel_Washing_Pump_Error.StaticText = resources.GetText("AlarmServer.Default_Manuel_Washing_Pump_Error.StaticText", "High Pressure (Manuel) Washing Pump Error");
			this.m_Default_Blower_Error.StaticText = resources.GetText("AlarmServer.Default_Blower_Error.StaticText", "Dryer Blower Error");
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
