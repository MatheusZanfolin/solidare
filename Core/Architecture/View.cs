namespace Solidare.Core
{
    public abstract class View<V> where V : View<V>
    {
        private Controller<V> controller;

        public View()
        {
            controller = CreateController();
            controller.AttachTo(this);
        }

        public abstract Controller<V> CreateController();
    }
}
