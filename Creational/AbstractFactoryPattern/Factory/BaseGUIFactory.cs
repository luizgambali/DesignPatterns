using System;
using AbstractFactory.Components.Common;
namespace AbstractFactory.Factory
{
    public enum OS
    {
        Windows,
        Linux,
        Mac
    }

    public abstract class BaseGUIFactory
    {
        public static BaseGUIFactory GetFactory(OS operationalSystem)
        {
            switch (operationalSystem)
            {
                case OS.Windows:
                    return new WindowsGUIFactory();
                case OS.Linux:
                    return new LinuxGUIFactory();
                case OS.Mac:
                    return new MacGUIFactory();
                default:
                    throw new ArgumentException("Operational System not supported");
            }
        }
        
        public abstract Button CreateButton(string label);
        public abstract TextBox CreateTextBox(string text);
    }
}