namespace Solidare.Core.Architecture
{
    public abstract class Controller<View>
    {
        protected View view;

        public Controller(View toAttach)
        {
            view = toAttach;
        }
    }
}
