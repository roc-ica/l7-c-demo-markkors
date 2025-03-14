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
        private operators _operator;
        private string _result;
        private string _operatorSign;

        public enum operators
        {
            plus,
            minus,
            multiply/*,
            divide*/
        }
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

        public string result
        {
            get { return _result; }
            set { _result = value; }
        }   

        public operators Operator { 
            get { return _operator; }
            set {
                _operator = value; 
            }
        }

        public string OperatorSign
        {
            get {
                    switch (Operator)
                    {
                        case operators.plus:
                            _operatorSign = "+";
                            break;
                        case operators.minus:
                            _operatorSign = "-";
                            break;
                       /* case operators.divide:
                            _operatorSign = "/";
                            break;*/
                        case operators.multiply:
                            _operatorSign = "*";
                            break;

                    }
                return _operatorSign;
            }
           
        }

        public void generate()
        {
            // generate a random sum
            Random rnd = new Random();
            int first = rnd.Next(1, 10);
            firstPart = first.ToString();

            int second = rnd.Next(1, 10);
            secondPart = second.ToString();

            int op = rnd.Next(0, 4);
            Operator = (operators)op;
            
            // evaluate the sum
            int result = 0;
            switch(Operator)
            {
                case operators.plus:
                    result = first + second;
                    break;
                case operators.minus:
                    result = first - second;
                    break;
                case operators.multiply:
                    result = first * second;
                    break;
                /*case operators.divide:
                    result = first / second;
                    break;*/
            }
            this.result = result.ToString();
            // calculate the result


        }

    }
}
