using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Linux
{
    public class LinuxTextBox : TextBox
    {
        public LinuxTextBox(string text){
            Text = text;
        }
        
        public override void SetText(string text)
        {
            Text = text;
        }

        public override void Render()
        {
            System.Console.WriteLine($"This is a Linux textbox with value '{Text}'");
        }
    }
}