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
    ///The QuickStartQuestions recording.
    /// </summary>
    [TestModule("c75cb8d3-62f7-473f-8daa-8ff4a44bccc2", ModuleType.Recording, 1)]
    public partial class QuickStartQuestions : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Winston_Agent_PortalRepository repository.
        /// </summary>
        public static Winston_Agent_PortalRepository repo = Winston_Agent_PortalRepository.Instance;

        static QuickStartQuestions instance = new QuickStartQuestions();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public QuickStartQuestions()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static QuickStartQuestions Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNoInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MyTable.LabelTagNo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo1' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MyTable.LabelTagNo1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo2' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo2Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MyTable.LabelTagNo2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo3' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo3Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MyTable.LabelTagNo3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo4' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo4Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.MyTable.LabelTagNo4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagYes' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagYesInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MyTable.LabelTagYes.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo6' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo6Info, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.MyTable.LabelTagNo6.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo5' at Center.", repo.ApplicationUnderTest.MyTable.LabelTagNo5Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.MyTable.LabelTagNo5.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnSave1' at Center.", repo.ApplicationUnderTest.BtnSave1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.BtnSave1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
