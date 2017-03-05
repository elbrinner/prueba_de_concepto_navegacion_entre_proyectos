using Concepto.BaseCore.Model;
using Concepto.BaseCore.ViewModels;
using MvvmCross.Core.ViewModels;

namespace Concepto.Module.Home.BusinessLogic.ViewModels
{
    public class HomeViewModel 
        : MvxViewModel
    {
        private string _hello = "Modulo Home";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        private MvxCommand testNavigation;

        public MvxCommand TestNavigation
        {
            get
            {
                return testNavigation = testNavigation ?? new MvxCommand(NavigationModule);
            }
        }



        private void NavigationModule()
        {
            var type = Concepto.BaseCore.Helpers.RegisterScreen.GetArquitectureKey("Data");
            this.ShowViewModel(type);
        }

        public void Init(GenericData valor)
        {
            var a = valor;
        }
    }

    
}
