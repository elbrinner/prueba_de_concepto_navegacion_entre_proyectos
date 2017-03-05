using Concepto.BaseCore.ViewModels;
using MvvmCross.Core.ViewModels;

namespace Concepto.Module.Product.BusinessLogin.ViewModels
{
    public class DataViewModel 
        : MvxViewModel
    {
        private string _hello = "Modulo producto";
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
            this.ShowViewModel<FirstViewModel>();
          



        }
    }
}
