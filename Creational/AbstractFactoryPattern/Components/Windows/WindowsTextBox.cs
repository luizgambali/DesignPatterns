using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Windows
{
    public class WindowsTextBox : TextBox
    {
        public WindowsTextBox(string text){
            Text = text;
        }
        public override void SetText(string text)
        {
            Text = text;
        }

        public override void Render()
        {
            System.Console.WriteLine($"This is a Windows textbox with value '{Text}'");
        }
    }
}