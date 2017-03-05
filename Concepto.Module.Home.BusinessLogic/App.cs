using MvvmCross.Platform.IoC;

namespace Concepto.Module.Home.BusinessLogic
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

           // RegisterAppStart<ViewModels.HomeViewModel>();
        }
    }
}
