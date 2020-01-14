using Caliburn.Micro;
using DataHandlerLibrary.Collectionner.Logic;
using DataHandlerLibrary.Collectionner.Models;
using System.Windows;

namespace Kolekcionuojami_Daiktai.ViewModels
{
    public class CreateItemViewModel : Screen
    {
        private ItemModel _Item;

        public ItemModel Item
        {
            get => _Item;
            set
            {
                _Item = value;
                NotifyOfPropertyChange(() => Item);
            }
        }

        private BindableCollection<QualityModel> _Qualities;

        public BindableCollection<QualityModel> Qualities
        {
            get => _Qualities;
            set
            {
                _Qualities = value;
                NotifyOfPropertyChange(() => Qualities);
            }
        }

        private QualityModel _SelectedQuality;

        public QualityModel SelectedQuality
        {
            get => _SelectedQuality;
            set
            {
                _SelectedQuality = value;
                NotifyOfPropertyChange(() => SelectedQuality);
            }
        }

        public CreateItemViewModel()
        {
            Item = new ItemModel();
            Qualities = new BindableCollection<QualityModel>();
            SelectedQuality = new QualityModel();
            PrepareData();
        }

        public void SubmitButton()
        {
            if (Item.IsValid())
            {
                var write = new ItemWriteLogic();
                write.CreateNewItem(Item, SelectedQuality);
                ReturnPage();
            }
            else
            {
                MessageBox.Show("Failed to create", "Failed");
            }
        }

        public void CancelButton()
        {
            ReturnPage();
        }

        private void ReturnPage()
        {
            ((MainViewModel)Parent)?.ActivateItemList();
        }

        private void PrepareData()
        {
            Qualities.AddRange(QualityReadLogic.ReadQualities());
            if (Qualities.Count > 0)
            {
                SelectedQuality = Qualities[0];
            }
        }


    }
}
