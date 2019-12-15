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
        private float _TotalPrice;

        public float TotalPrice
        {
            get => _TotalPrice;
            set
            {
                _TotalPrice = value;
                NotifyOfPropertyChange(()=>TotalPrice);
            }
        }


        public MainViewModel()
        {
            ActivateItemList();
        }

        public void AddItemButton()
        {
            ActivateItem(new CreateItemViewModel());
        }

        public void FilterButton()
        {
            ActivateItem(new FilterViewModel());
        }

        public void GetSum_Event(float sum)
        {
            TotalPrice = sum;
        }

        public void ActivateItemList()
        {
            ActivateItem(new ItemsDisplayViewModel());
            (ActiveItem as ItemsDisplayViewModel).TotalSum += GetSum_Event;
        }



        public sealed override void ActivateItem(object item)
        {
            base.ActivateItem(item);
        }
    }
}
