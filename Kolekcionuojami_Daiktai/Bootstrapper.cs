using Caliburn.Micro;
using Kolekcionuojami_Daiktai.ViewModels;
using System.Windows;

namespace Kolekcionuojami_Daiktai
{
    public class Bootstrapper : BootstrapperBase
    {
        #region Constructor
        public Bootstrapper()
        {
            Initialize();

        }
        #endregion

        #region Overrides
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
        #endregion
    }
}
