using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Kolekcionuojami_Daiktai.ViewModels
{
    class MainViewModel : Conductor<object>
    {

        public MainViewModel()
        {
            ActivateItem(new ItemsDisplayViewModel());
        }

        public void AddItemButton()
        {
            ActivateItem(new CreateItemViewModel());
        }

        public sealed override void ActivateItem(object item)
        {
            base.ActivateItem(item);
        }
    }
}
