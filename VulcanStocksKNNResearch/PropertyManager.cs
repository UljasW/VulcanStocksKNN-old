using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace VulcanStocksKNNResearch
{
    public class PropertyManager : INotifyPropertyChanged
    {
        //membervariables
        private string notchDisplay = "Homepage";

        //properties

        public string NotchDisplay 
        { 
            get
            {
                return notchDisplay;
            }
            set
            {
                notchDisplay = value;
                OnPropertyChanged("NotchDisplay");
            } 
        }
        

        //Interfaces

        public void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
