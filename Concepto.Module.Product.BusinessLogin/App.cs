using MvvmCross.Platform.IoC;

namespace Concepto.Module.Product.BusinessLogin
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

           // RegisterAppStart<ViewModels.DataViewModel>();
        }
    }
}
