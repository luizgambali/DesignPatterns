namespace AbstractFactory.Components.Common
{
    public abstract class Button
    {
        protected string Label = "";
        public abstract void Render();

        public abstract void Click();
    }
}