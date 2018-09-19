using Microsoft.Practices.Unity;
using Unity;
using Unity.Lifetime;

namespace Util.IoC
{
    internal class RegisterModules : IRegisterModules
    {
        private readonly IUnityContainer _container;

        public RegisterModules(IUnityContainer container)
        {
            _container = container;
        }

        public void RegisterTyper<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
        {
            if (!withInterception)
            {
                _container.RegisterType<TFrom, TTo>();
            }
        }

        public void RegisterTypeWithLifeTime<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }
    }
}
