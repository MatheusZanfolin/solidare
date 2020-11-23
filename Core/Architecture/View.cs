namespace Solidare.Core
{
    public interface View<C>
    {
        C CreateController();
    }
}
