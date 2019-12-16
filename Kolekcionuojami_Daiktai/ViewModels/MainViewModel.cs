using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using DataHandlerLibrary.Collectionner.Models;

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

        public FilterViewModel SavedFilterModel { get; set; }
        public FilterViewModel TemporaryFilterModel { get; set; }

        public MainViewModel()
        {
            ActivateItemList();
        }

        public void AddItemButton()
        {
            ActivateItem(new CreateItemViewModel());
        }

        public void HomeButton()
        {
            ActivateItemList();
        }

        public void FilterButton()
        {
            ActivateFilter();
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

        public void ActivateFilter()
        {
            if (SavedFilterModel == null)
                SavedFilterModel = new FilterViewModel();

            TemporaryFilterModel = SavedFilterModel;
            ActivateItem(TemporaryFilterModel);
            (ActiveItem as FilterViewModel).Save += SaveFilterModel_Event;
            (ActiveItem as FilterViewModel).SaveFilters += LoadFilteredList_Event;
        }
        public void LoadFilteredList_Event(List<ItemModel> items)
        {
            ActivateItem(new ItemsDisplayViewModel(items));
            (ActiveItem as ItemsDisplayViewModel).TotalSum += GetSum_Event;
        }
        public void SaveFilterModel_Event(FilterViewModel filter)
        {
            SavedFilterModel = filter;
            ActivateItemList();
        }

        public sealed override void ActivateItem(object item)
        {
            base.ActivateItem(item);
        }
    }
}
