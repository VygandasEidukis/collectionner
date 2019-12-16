using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;
using Xamarin.Forms.Internals;

namespace Kolekcionuojami_Daiktai.ViewModels
{
    public class ItemsDisplayViewModel : Screen
    {
        public delegate void GetTotal(float sum);

        public GetTotal TotalSum;

        private BindableCollection<ItemModel> _Items;

        public BindableCollection<ItemModel> Items
        {
            get => _Items;
            set
            {
                _Items = value; 
                NotifyOfPropertyChange(()=>Items);
            }
        }

        private float Total
        {
            get
            {
                float total = 0;
                Items?.ForEach(x => total += x.EstimatedPrice);
                return total;
            } 
        }

        public ItemsDisplayViewModel()
        {
            LoadData();
        }

        public ItemsDisplayViewModel(List<ItemModel> items)
        {
            Items = new BindableCollection<ItemModel>();
            Items.AddRange(items);
        }

        public void Loaded()
        {
            TotalSum?.Invoke(Total);
        }

        private void LoadData()
        {
            var read = new ItemReadLogic();
            Items = new BindableCollection<ItemModel>();
            Items.AddRange(read.ReadItems());
        }

    }
}
