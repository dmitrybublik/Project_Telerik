using System.Windows.Automation.Peers;
using Telerik.Windows.Automation.Peers;
using Telerik.Windows.Controls;

namespace Project_Telerik
{
    public class CustomDiagramShape : RadDiagramShape
    {
        public CustomDiagramShape()
        {

        }

        public CustomDiagramShape(CustomElementViewModel viewModel)
        {
            DataContext = viewModel;
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            if (AutomationManager.AutomationMode == AutomationMode.Disabled)
            {
                return null;
            }

            return new FrameworkElementAutomationPeer(this);
        }
    }
}
