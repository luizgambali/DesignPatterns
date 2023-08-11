using AbstractFactory.Components.Common;

namespace AbstractFactory.Components.Mac
{
    public class MacTextBox : TextBox
    {
        public MacTextBox(string text)
        {
            Text = text;
        }
        
        public override void SetText(string text)
        {
            Text = text;
        }

        public override void Render()
        {
            System.Console.WriteLine($"This is a Mac textbox with value '{Text}'");
        }
    }
}