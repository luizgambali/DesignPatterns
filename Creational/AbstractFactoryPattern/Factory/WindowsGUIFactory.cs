using AbstractFactory.Components.Windows;
using AbstractFactory.Components.Common;

namespace AbstractFactory.Factory
{
    public class WindowsGUIFactory : BaseGUIFactory
    {
        public override Button CreateButton(string label)
        {
            return new WindowsButton(label);
        }

        public override TextBox CreateTextBox(string text)
        {
            return new WindowsTextBox(text);
        }
    }
}