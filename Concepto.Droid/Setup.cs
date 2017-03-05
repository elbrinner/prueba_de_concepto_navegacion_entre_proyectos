using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using System.Reflection;
using Concepto.Module.Home.BusinessLogic.ViewModels;
using System.Collections.Generic;
using Concepto.BaseCore.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform;
using System.Linq;
using Concepto.Droid.Views;
using Concepto.Module.Home.Droid.Views;
using System;
using Concepto.Module.Product.BusinessLogin.ViewModels;
using Concepto.Module.Product.Droid.Views;

namespace Concepto.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new BaseCore.App();
        }

        protected override System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetViewModelAssemblies()
        {
            Concepto.BaseCore.Helpers.RegisterScreen.AddViewModel("Home", typeof(HomeViewModel));
            Concepto.BaseCore.Helpers.RegisterScreen.AddViewModel("First", typeof(FirstViewModel));
            Concepto.BaseCore.Helpers.RegisterScreen.AddViewModel("Data", typeof(DataViewModel));

            var toReturn = base.GetViewModelAssemblies().ToList();
            toReturn.Add(typeof(FirstViewModel).Assembly);
            toReturn.Add(typeof(HomeViewModel).Assembly);
            toReturn.Add(typeof(DataViewModel).Assembly);
            return toReturn.ToArray();
        }

        protected override void InitializeViewLookup()
        {
            var viewModelLookup = new Dictionary<Type, Type>
                {
                    {typeof(FirstViewModel), typeof(FirstView)},
                     {typeof(HomeViewModel), typeof(HomeView)},
                      {typeof(DataViewModel), typeof(DataView)},
                };

            var container = Mvx.Resolve<IMvxViewsContainer>();
            container.AddAll(viewModelLookup);
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
