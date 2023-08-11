using AbstractFactory.Components.Linux;
using AbstractFactory.Components.Common;

namespace AbstractFactory.Factory
{
    public class LinuxGUIFactory : BaseGUIFactory
    {
        public override Button CreateButton(string label)
        {
            return new LinuxButton(label);
        }

        public override TextBox CreateTextBox(string text)
        {
            return new LinuxTextBox(text);
        }
    }
}