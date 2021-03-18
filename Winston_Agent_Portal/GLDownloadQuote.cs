﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Winston_Agent_Portal
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GLDownloadQuote recording.
    /// </summary>
    [TestModule("ada74755-0316-43e5-a1f2-b204b6638cdd", ModuleType.Recording, 1)]
    public partial class GLDownloadQuote : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Winston_Agent_PortalRepository repository.
        /// </summary>
        public static Winston_Agent_PortalRepository repo = Winston_Agent_PortalRepository.Instance;

        static GLDownloadQuote instance = new GLDownloadQuote();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GLDownloadQuote()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GLDownloadQuote Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadQuote' at Center.", repo.ApplicationUnderTest.BtnDownloadQuoteInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BtnDownloadQuote.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(1));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.TabClick' at Center.", repo.Chrome.TabClickInfo, new RecordItemIndex(2));
            repo.Chrome.TabClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'Chrome.PageElement' at Center.", repo.Chrome.PageElementInfo, new RecordItemIndex(3));
            repo.Chrome.PageElement.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome1.SaveAsCtrlPlusS' at Center.", repo.Chrome1.SaveAsCtrlPlusSInfo, new RecordItemIndex(4));
            repo.Chrome1.SaveAsCtrlPlusS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.Text1001' at Center.", repo.SaveAs.Text1001Info, new RecordItemIndex(5));
            repo.SaveAs.Text1001.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveAs.ButtonSave' at Center.", repo.SaveAs.ButtonSaveInfo, new RecordItemIndex(6));
            repo.SaveAs.ButtonSave.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Close' at Center.", repo.Chrome.CloseInfo, new RecordItemIndex(7));
            repo.Chrome.Close.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.FCGAGL' at Center.", repo.Chrome.FCGAGLInfo, new RecordItemIndex(8));
            repo.Chrome.FCGAGL.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}