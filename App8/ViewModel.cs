using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    public class ViewModel
    {
        public List<Item> DataList { get; set; }
        public ViewModel()
        {
            DataList = new List<Item>()
            {
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
                new Item{ Data1 = "Zhu",Data2="Ming",Data3=""},
            };
        }
    }

    public class Item : INotifyPropertyChanged
    {
        private string _data1;

        public string Data1
        {
            get
            {
                return _data1;
            }
            set
            {
                _data1 = value;

                Data3 = Data1 + Data2;
                OnPropertyChanged();
            }
        }


        private string _data2;

        public string Data2
        {
            get
            {
                return _data2;
            }
            set
            {
                _data2 = value;
                OnPropertyChanged();
            }
        }

        private string _data3;

        public string Data3
        {
            get
            {
                return _data3;
            }
            set
            {
                _data3 = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
