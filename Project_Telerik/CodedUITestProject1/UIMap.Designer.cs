﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIClickHereButton = this.UIWpfWindow.UIClickHereButton;
            WpfCustom uICustomElement_1Custom = this.UIWpfWindow.UIDiagramCustom.UICustomElement_1Custom;
            #endregion

            // Click 'Click Here!' button
            Mouse.Click(uIClickHereButton, new Point(39, 17));

            // Click 'CustomElement_1' custom control
            Mouse.Click(uICustomElement_1Custom, new Point(165, 135));

            // Click 'CustomElement_1' custom control
            Mouse.Click(uICustomElement_1Custom, new Point(225, 17));
        }
        
        #region Properties
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow();
                }
                return this.mUIWpfWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIWpfWindow mUIWpfWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public WpfButton UIClickHereButton
        {
            get
            {
                if ((this.mUIClickHereButton == null))
                {
                    this.mUIClickHereButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIClickHereButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_Add";
                    #endregion
                }
                return this.mUIClickHereButton;
            }
        }
        
        public UIDiagramCustom UIDiagramCustom
        {
            get
            {
                if ((this.mUIDiagramCustom == null))
                {
                    this.mUIDiagramCustom = new UIDiagramCustom(this);
                }
                return this.mUIDiagramCustom;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIClickHereButton;
        
        private UIDiagramCustom mUIDiagramCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDiagramCustom : WpfCustom
    {
        
        public UIDiagramCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.RadDiagram";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "diagram";
            #endregion
        }
        
        #region Properties
        public WpfCustom UICustomElement_1Custom
        {
            get
            {
                if ((this.mUICustomElement_1Custom == null))
                {
                    this.mUICustomElement_1Custom = new WpfCustom(this);
                    #region Search Criteria
                    this.mUICustomElement_1Custom.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.RadDiagramShape";
                    this.mUICustomElement_1Custom.SearchProperties[WpfControl.PropertyNames.AutomationId] = "CustomElement_1";
                    #endregion
                }
                return this.mUICustomElement_1Custom;
            }
        }
        #endregion
        
        #region Fields
        private WpfCustom mUICustomElement_1Custom;
        #endregion
    }
}
