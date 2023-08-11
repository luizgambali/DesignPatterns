using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Windows
{
    public class WindowsButton : Button
    {
        public WindowsButton(string label){
            Label = label;
        }
        public override void Render()
        {
            System.Console.WriteLine($"This is a Windows Button with label '{Label}'");
        }

        public override void Click()
        {
            System.Console.WriteLine($"Windows Button Clicked!");
        }
    }
}