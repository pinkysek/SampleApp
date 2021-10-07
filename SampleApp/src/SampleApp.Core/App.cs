using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SampleApp.Core.ViewModels.Main;

namespace SampleApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
