using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.IO;

namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        ApplicationUnderTest App = null;
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            System.Threading.Thread.Sleep(1000);
            var mainWindow = new WpfWindow();
            mainWindow.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "Main_Window"));
            mainWindow.Find();
            var btn = new WpfButton();
            btn.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "btn_AddShape"));
            btn.Find();
            btn.WaitForControlReady();
            btn.GetClickablePoint();
            
            Mouse.Click(mainWindow, new Point(btn.Top + 20, btn.Left + 20));
            //Mouse.Click(new Point(btn.BoundingRectangle.X + btn.BoundingRectangle.Width / 2, btn.BoundingRectangle.Y + btn.BoundingRectangle.Height / 2));
            //Mouse.Click(new Point(btn.GetClickablePoint().X, btn.GetClickablePoint().Y));
            var diagram = new WpfWindow();
            diagram.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "diagram"));
            diagram.Find();
            diagram.WaitForControlReady();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }


        [TestMethod]
        public void CodedUITestMethod2()
        {

            this.UIMap.RecordedMethod1();

        }
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            App = ApplicationUnderTest.Launch(@"D:\Projects\Sample\Project_Telerik\Project_Telerik\bin\Debug\Project_Telerik.exe");
            var window = new WpfWindow();
            window.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.Name, "Telerik UI for WPF Trial"));
            window.Find();
            window.SetFocus();
            Keyboard.SendKeys(window, "{F4}", ModifierKeys.Alt);
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            App.Close();
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
