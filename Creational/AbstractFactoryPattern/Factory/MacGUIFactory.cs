using AbstractFactory.Components.Mac;
using AbstractFactory.Components.Common;

namespace AbstractFactory.Factory
{
    public class MacGUIFactory : BaseGUIFactory
    {
        public override Button CreateButton(string label)
        {
            return new MacButton(label);
        }

        public override TextBox CreateTextBox(string text)
        {            
            return new MacTextBox(text);
        }
    }
}