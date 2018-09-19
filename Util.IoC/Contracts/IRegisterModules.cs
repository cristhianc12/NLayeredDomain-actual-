namespace Util.IoC
{
    public interface IRegisterModules
    {
        void RegisterTyper<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;

        void RegisterTypeWithLifeTime<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;
    }
}
