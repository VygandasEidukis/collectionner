﻿using Caliburn.Micro;
using DataHandlerLibrary.Collectionner.Filters;
using DataHandlerLibrary.Collectionner.Filters.Date;
using DataHandlerLibrary.Collectionner.Filters.Money;
using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;
using Kolekcionuojami_Daiktai.Models;
using System.Collections.Generic;

namespace Kolekcionuojami_Daiktai.ViewModels
{
    public class FilterViewModel : Screen
    {
        public delegate void SaveDelegate(FilterViewModel filterViewModel);
        public SaveDelegate Save;

        public delegate void SaveFiltersDelegate(List<ItemModel> items);
        public SaveFiltersDelegate SaveFilters;

        private BindableCollection<TreeViewQualityModel> _Qualities;

        public BindableCollection<TreeViewQualityModel> Qualities
        {
            get { return _Qualities; }
            set
            {
                _Qualities = value;
                NotifyOfPropertyChange(() => Qualities);
            }
        }

        #region price filter handlers
        private bool _MoreThanMedianRadio;

        public bool MoreThanMedianRadio
        {
            get { return _MoreThanMedianRadio; }
            set
            {
                _MoreThanMedianRadio = value;
                NotifyOfPropertyChange(() => MoreThanMedianRadio);
            }
        }

        private bool _LessThanMedianRadio;

        public bool LessThanMedianRadio
        {
            get { return _LessThanMedianRadio; }
            set
            {
                _LessThanMedianRadio = value;
                NotifyOfPropertyChange(() => LessThanMedianRadio);
            }
        }




        private PriceBetweenFilter _PriceBetweenFilterHandler;
        public PriceBetweenFilter PriceBetweenFilterHandler
        {
            get { return _PriceBetweenFilterHandler; }
            set
            {
                _PriceBetweenFilterHandler = value;
                NotifyOfPropertyChange(() => PriceBetweenFilterHandler);
            }
        }
        private PriceMoreThanFilter _PriceMoreThanFilterHandler;
        public PriceMoreThanFilter PriceMoreThanFilterHandler
        {
            get { return _PriceMoreThanFilterHandler; }
            set
            {
                _PriceMoreThanFilterHandler = value;
                NotifyOfPropertyChange(() => PriceMoreThanFilterHandler);

            }
        }
        private PriceLessThanFilter _PriceLessThanFilterHandler;
        public PriceLessThanFilter PriceLessThanFilterHandler
        {
            get { return _PriceLessThanFilterHandler; }
            set
            {
                _PriceLessThanFilterHandler = value;
                NotifyOfPropertyChange(() => PriceLessThanFilterHandler);
            }
        }

        #endregion

        #region date filter handlers

        private DateBetweenFilter _DateBetweenFilterHandler;
        public DateBetweenFilter DateBetweenFilterHandler
        {
            get { return _DateBetweenFilterHandler; }
            set
            {
                _DateBetweenFilterHandler = value;
                NotifyOfPropertyChange(() => DateBetweenFilterHandler);
            }
        }
        private DateNewerThanFilter _DateNewerThanFilterHandler;
        public DateNewerThanFilter DateNewerThanFilterHandler
        {
            get { return _DateNewerThanFilterHandler; }
            set
            {
                _DateNewerThanFilterHandler = value;
                NotifyOfPropertyChange(() => DateNewerThanFilterHandler);
            }
        }
        private DateOlderThanFilter _DateOlderThanFilterHandler;
        public DateOlderThanFilter DateOlderThanFilterHandler
        {
            get { return _DateOlderThanFilterHandler; }
            set
            {
                _DateOlderThanFilterHandler = value;
                NotifyOfPropertyChange(() => DateNewerThanFilterHandler);
            }
        }
        #endregion

        #region CheckBoxes
        private bool _PriceMedianCheckbox;

        public bool PriceMedianCheckbox
        {
            get { return _PriceMedianCheckbox; }
            set
            {
                _PriceMedianCheckbox = value;
                NotifyOfPropertyChange(() => PriceMedianCheckbox);
            }
        }


        private bool _PriceBetweenCheckbox;

        public bool PriceBetweenCheckbox
        {
            get { return _PriceBetweenCheckbox; }
            set
            {
                _PriceBetweenCheckbox = value;
                NotifyOfPropertyChange(() => PriceBetweenCheckbox);
            }
        }
        private bool _PriceMoreThanCheckBox;
        public bool PriceMoreThanCheckBox
        {
            get { return _PriceMoreThanCheckBox; }
            set
            {
                _PriceMoreThanCheckBox = value;
                NotifyOfPropertyChange(() => PriceMoreThanCheckBox);
            }
        }
        private bool _PriceLessThanCheckBox;

        public bool PriceLessThanCheckBox
        {
            get { return _PriceLessThanCheckBox; }
            set
            {
                _PriceLessThanCheckBox = value;
                NotifyOfPropertyChange(() => PriceLessThanCheckBox);
            }
        }
        private bool _DateBetweenCheckbox;
        public bool DateBetweenCheckbox
        {
            get { return _DateBetweenCheckbox; }
            set
            {
                _DateBetweenCheckbox = value;
                NotifyOfPropertyChange(() => DateBetweenCheckbox);
            }
        }
        private bool _DateOlderThanCheckbox;

        public bool DateOlderThanCheckbox
        {
            get { return _DateOlderThanCheckbox; }
            set
            {
                _DateOlderThanCheckbox = value;
                NotifyOfPropertyChange(() => DateOlderThanCheckbox);
            }
        }
        private bool _DateNewerThanCheckbox;
        public bool DateNewerThanCheckbox
        {
            get { return _DateNewerThanCheckbox; }
            set
            {
                _DateNewerThanCheckbox = value;
                NotifyOfPropertyChange(() => DateNewerThanCheckbox);
            }
        }



        #endregion

        private bool _QualityTreeItemCheckbox;

        public bool QualityTreeItemCheckbox
        {
            get { return _QualityTreeItemCheckbox; }
            set
            {
                _QualityTreeItemCheckbox = value;
                NotifyOfPropertyChange(() => QualityTreeItemCheckbox);
            }
        }



        public FilterViewModel()
        {
            LoadData();
            PriceBetweenFilterHandler = new PriceBetweenFilter();
            PriceLessThanFilterHandler = new PriceLessThanFilter();
            PriceMoreThanFilterHandler = new PriceMoreThanFilter();

            DateBetweenFilterHandler = new DateBetweenFilter();
            DateOlderThanFilterHandler = new DateOlderThanFilter();
            DateNewerThanFilterHandler = new DateNewerThanFilter();
        }

        private void LoadData()
        {
            LessThanMedianRadio = true;
            Qualities = new BindableCollection<TreeViewQualityModel>();

            var qualities = QualityReadLogic.ReadQualities();

            qualities.ForEach(item =>
            {
                Qualities.Add(new TreeViewQualityModel { Checked = true, Quality = item });
            });
        }

        public void SaveButton()
        {
            Save.Invoke(this);
            SaveFilters.Invoke(FilterItems());
        }

        public List<ItemModel> FilterItems()
        {
            List<IBaseFilter> filters = new List<IBaseFilter>();

            if (PriceBetweenCheckbox)
                filters.Add(PriceBetweenFilterHandler);
            if (PriceLessThanCheckBox)
                filters.Add(PriceLessThanFilterHandler);
            if (PriceMoreThanCheckBox)
                filters.Add(PriceMoreThanFilterHandler);
            if (DateBetweenCheckbox)
                filters.Add(DateBetweenFilterHandler);
            if (DateNewerThanCheckbox)
                filters.Add(DateNewerThanFilterHandler);
            if (DateOlderThanCheckbox)
                filters.Add(DateOlderThanFilterHandler);

            var selectedQualities = new List<QualityModel>();
            foreach (var quality in Qualities)
            {
                if (quality.Checked)
                    selectedQualities.Add(quality.Quality);
            }
            var items = FilterHelper.ApplyFilter(filters, selectedQualities);
            return FilterMedian(items);
        }

        private List<ItemModel> FilterMedian(List<ItemModel> items)
        {
            var median = GetMedian(new ItemReadLogic().ReadItems());
            if (PriceMedianCheckbox)
            {
                var itemsToRemove = new List<ItemModel>();
                foreach (var item in items)
                {
                    if (LessThanMedianRadio)
                    {
                        if (item.EstimatedPrice > median)
                        {
                            itemsToRemove.Add(item);
                        }
                    }
                    else if (MoreThanMedianRadio)
                    {
                        if (item.EstimatedPrice < median)
                        {
                            itemsToRemove.Add(item);
                        }
                    }
                }
                foreach (var item in itemsToRemove)
                {
                    items.Remove(item);
                }
            }


            return items;
        }

        private float GetMedian(List<ItemModel> items)
        {
            float max = 0;
            foreach (var item in items)
            {
                max += item.EstimatedPrice;
            }
            return max / items.Count;
        }
    }
}
