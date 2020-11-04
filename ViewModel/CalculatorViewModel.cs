using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.ViewModel
{
    class CalculatorViewModel
    {
    
        public CalculatorViewModel()
        {
            this._calc = new CalculatorModel();
        }
        private CalculatorModel _calc;
        public CalculatorModel Calc
        {
            get
            {
                return _calc;
            }
                
        }

    }
}
