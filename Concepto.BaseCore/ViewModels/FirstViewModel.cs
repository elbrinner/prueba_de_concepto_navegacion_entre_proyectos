using Concepto.BaseCore.Model;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform;
using System;

namespace Concepto.BaseCore.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel 
    {
        private string _hello = "Vista base";
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
            var type = Concepto.BaseCore.Helpers.RegisterScreen.GetArquitectureKey("Home");
            GenericData config = new GenericData() {
              
            };
            this.ShowViewModel(type, new object[] { config });
        }
    }
}
