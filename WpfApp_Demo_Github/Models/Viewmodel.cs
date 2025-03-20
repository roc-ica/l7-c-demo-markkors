using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Demo_Github.Models
{
    class Viewmodel : INotifyPropertyChanged
    {
        // members
        private ObservableCollection<Person> _persons;
        private ObservableCollection<Sum> _sums = new ObservableCollection<Sum>();

        private List<string> _names;

        private string _testProp;
        private ObservableCollection<string> _member;
        private Sum _selectedsum;

        // constructor
        public Viewmodel()
        {
            _persons = new ObservableCollection<Person>();

           
        }   


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // properties

        

        public ObservableCollection<Person> Persons
        {
            get { 
                return _persons; 
            }
            set
            {
                _persons = value;
                OnPropertyChanged("Persons");
            }
        }

        public ObservableCollection<string> YourName {
            get { return _member; }
            set { _member = value; } 
        }

        public Sum SelectedSum { 
            get { return _selectedsum; } 
            set { 
                _selectedsum = value;
                OnPropertyChanged("SelectedSum");
            }
        }


        public ObservableCollection<Sum> Sums { 
            get
            {
                return _sums;
            }
            set
            {
                _sums = value;
                OnPropertyChanged("Sums");
            }
        
        }

    }
    
}
