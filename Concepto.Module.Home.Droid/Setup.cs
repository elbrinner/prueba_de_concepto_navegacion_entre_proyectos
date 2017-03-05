using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using System.Reflection;
using System.Collections.Generic;
using Concepto.Module.Home.BusinessLogic.ViewModels;

namespace Concepto.Module.Home.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Module.Home.BusinessLogic.App();
        }

        protected override System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetViewModelAssemblies()
        {
            var list = new List<Assembly>();

            list.AddRange(base.GetViewModelAssemblies());
            list.Add(typeof(HomeViewModel).Assembly);


            //  foreach (var item in list)
            //{
            Concepto.BaseCore.Helpers.RegisterScreen.AddViewModel("Home", typeof(Concepto.Module.Home.BusinessLogic.ViewModels.HomeViewModel));
            //   }

            return list.ToArray();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
