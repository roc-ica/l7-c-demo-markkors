using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Demo_Github.Models
{
    class Sum
    {

        private string _firstPart;
        private string _secondPart;
        
        public string firstPart {
            get { 
                
                return _firstPart; }
            set { 
                
                
                _firstPart = value; }
        }

        public string secondPart
        {
            get { return _secondPart; }
            set { _secondPart = value; }
        }

        public void generate()
        {
            // generate a random sum

        }

    }
}
