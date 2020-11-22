namespace Solidare.Core
{
    public abstract class Controller<V> where V : View<V>
    {
        private View<V> view;

        public void AttachTo(View<V> view)
        {
            this.view = view;
        }
    }
}
