using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;

namespace Kolekcionuojami_Daiktai.ViewModels
{
    public class FilterViewModel : Screen
    {
        private BindableCollection<QualityModel> _Qualities;

        public BindableCollection<QualityModel> Qualities
        {
            get { return _Qualities; }
            set 
            { 
                _Qualities = value;
                NotifyOfPropertyChange(() => Qualities);
            }
        }

        public FilterViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            Qualities = new BindableCollection<QualityModel>();
            Qualities.AddRange(QualityReadLogic.ReadQualities());
        }

    }
}
