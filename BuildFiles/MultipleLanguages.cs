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
	
	
	public partial class MultipleLanguages : Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageServer, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		public MultipleLanguages()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
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
		}
		
		private void InitializeObjectCreations()
		{
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo LanguageInfo1 = new Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo();
			LanguageInfo1.Index = 6;
			LanguageInfo1.IsPublic = true;
			LanguageInfo1.KeyboardLayoutName = "Spanish";
			LanguageInfo1.Name = "Spanish (Spain, International Sort)";
			LanguageInfo1.UseInRuntime = true;
			LanguageInfo1.WordWrapAdjust = false;
			this.Languages.Add(LanguageInfo1);
			Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo LanguageInfo2 = new Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo();
			LanguageInfo2.Index = 7;
			LanguageInfo2.IsPublic = true;
			LanguageInfo2.KeyboardLayoutName = "Spanish";
			LanguageInfo2.Name = "Portuguese (Portugal)";
			LanguageInfo2.UseInRuntime = true;
			LanguageInfo2.WordWrapAdjust = false;
			this.Languages.Add(LanguageInfo2);
			Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo LanguageInfo3 = new Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo();
			LanguageInfo3.Index = 9;
			LanguageInfo3.IsPublic = true;
			LanguageInfo3.KeyboardLayoutName = "Italian";
			LanguageInfo3.Name = "Italian (Italy)";
			LanguageInfo3.UseInRuntime = true;
			LanguageInfo3.WordWrapAdjust = false;
			this.Languages.Add(LanguageInfo3);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(MultipleLanguages));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected virtual void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
		}
	}
}