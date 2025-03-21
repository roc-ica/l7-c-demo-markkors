﻿using System;
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
        private ObservableCollection<Sum> _sums;
        private List<string> _names;
        
        private string _testProp;

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

        public string TestProp{
            get { return _testProp; } 
            set { 
                _testProp = value;
                OnPropertyChanged("TestProp");
            } 
        }


        public ObservableCollection<Sum> MySums { 
            get { return _sums; }
            set {
                _sums = value;
                OnPropertyChanged("MySums");
            }
        }

    }
    
}
