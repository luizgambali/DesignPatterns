namespace AbstractFactory.Components.Common
{
    public abstract class TextBox
    {
        protected string Text = "";
        public abstract void SetText(string text);
        public abstract void Render();
    }
}