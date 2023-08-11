using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Linux
{
    public class LinuxButton : Button
    {
        public LinuxButton(string label)
        {
            this.Label = label;
        }
        
        public override void Render()
        {
            Console.WriteLine($"This is a Linux Button with label '{Label}'");
        }

        public override void Click()
        {
            Console.WriteLine($"Linux Button Clicked!");
        }
    }
}