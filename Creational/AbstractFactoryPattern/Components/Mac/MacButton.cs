using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Mac
{
    public class MacButton : Button
    {
        public MacButton(string label)
        {
            Label = label;
        }

        public override void Render()
        {
            System.Console.WriteLine($"This is a Mac Button with label '{Label}'");
        }

        public override void Click()
        {
            System.Console.WriteLine($"Mac Button Clicked!");
        }
    }
}