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
        private string importTicker = "Enter ticker here";
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
        
        public string ImportTicker 
        { 
            get
            {
                return importTicker;
            }
            set
            {
                importTicker = value;
                OnPropertyChanged("ImportTicker");
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
