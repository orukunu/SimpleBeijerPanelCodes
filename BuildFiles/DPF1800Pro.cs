using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Utilities.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.42.138.0")]
[assembly: NeoDesignerVersion("2.42.138.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals() 
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "KSP - DPF1800";
            m_ProjectSettings.Topmost = true;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.UseWideScrollbars = false;
            m_ProjectSettings.MainScreenSize = new Size(800,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                new ProjectStorageProviderSetting("BackupAtStartup", false), new ProjectStorageProviderSetting("MaxSize", 0), 
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs485); comPortModes.Add(ComPort.COM3, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM4, PortMode.rs485);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.TimeZoneId = -1;
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerFriendlyNamesEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.VncActiveConnectionNotification = false;
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.IsHeadless = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("db68fff3-d845-416d-a550-0224b965380a");
        }
        
        
        private static IToolManager CreateToolManager()
        {
            string executablePath = typeof(Globals).Module.FullyQualifiedName;            
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true, executablePath) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter LoginScreen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LoginScreen>("Screens.LoginScreen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Components
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Components>("Screens.Components.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Manuel_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Manuel_Screen>("Screens.Manuel_Screen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Admin_Page
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Admin_Page>("Screens.Admin_Page.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Test_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Test_Screen>("Screens.Test_Screen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Drying_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Drying_Screen>("Screens.Drying_Screen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Alarm_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Alarm_Screen>("Screens.Alarm_Screen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Settings_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Settings_Screen>("Screens.Settings_Screen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Automatic_Screen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Automatic_Screen>("Screens.Automatic_Screen.Default").Adapter;
                        }
                    }           
                    public static PressureCalibrationScript PressureCalibrationScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<PressureCalibrationScript>("PressureCalibrationScript");
                        }
                    }           
                    public static ManuelWashingScript ManuelWashingScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ManuelWashingScript>("ManuelWashingScript");
                        }
                    }           
                    public static BuzzerScript BuzzerScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<BuzzerScript>("BuzzerScript");
                        }
                    }           
                    public static WashDryingScript WashDryingScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<WashDryingScript>("WashDryingScript");
                        }
                    }           
                    public static WashingScript WashingScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<WashingScript>("WashingScript");
                        }
                    }           
                    public static PrewashScript PrewashScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<PrewashScript>("PrewashScript");
                        }
                    }           
                    public static CycleTimerScript CycleTimerScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CycleTimerScript>("CycleTimerScript");
                        }
                    }           
                    public static BlinkScript BlinkScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<BlinkScript>("BlinkScript");
                        }
                    }           
                    public static DryingScript DryingScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DryingScript>("DryingScript");
                        }
                    }           
                    public static AutomaticWashingScript AutomaticWashingScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AutomaticWashingScript>("AutomaticWashingScript");
                        }
                    }           
                    public static TestingFilterScript TestingFilterScript
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<TestingFilterScript>("TestingFilterScript");
                        }
                    }           
                    public static SntpClientRootComponent SntpClientRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SntpClientRootComponent>("SntpClientRootComponent");
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Security>("Security");
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ProjectConfiguration>("ProjectConfiguration");
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Tags>("Tags");
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LicenseRootComponent>("LicenseRootComponent");
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Expressions>("Expressions");
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<MultipleLanguages>("MultipleLanguages");
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmServer>("AlarmServer");
                        }
                    }           
                    public static IScreenAdapter HomeScreen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<HomeScreen>("Screens.HomeScreen.Default").Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            
            
            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;
            IsCompiledForDesktopWindowsPanel = false;

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;
            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"Tags","AlarmServer","MultipleLanguages","Expressions","LicenseRootComponent","ProjectConfiguration","Security","SntpClientRootComponent","Controller2","TestingFilterScript","AutomaticWashingScript","DryingScript","BlinkScript","CycleTimerScript","PrewashScript","WashingScript","WashDryingScript","BuzzerScript","ManuelWashingScript","PressureCalibrationScript","ProjectImages"}, new string[]{}, () => HomeScreen);
        }

    }
}