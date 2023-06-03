using Infrastructure.Services.Input;
using VContainer;
using VContainer.Unity;

namespace Infrastructure
{
    public class GameLifetimeScope: LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IWindowsInputService, WindowsInputService>(Lifetime.Singleton);
            builder.Register<IInputService, InputService>(Lifetime.Singleton);
        }
    }
}