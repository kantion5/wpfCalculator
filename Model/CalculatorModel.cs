using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator.Model
{
    public class CalculatorModel : INotifyPropertyChanged
    {
        private string _calculatorText;
        public CalculatorModel()
        {
            _calculatorText = "temp";
        }

        public string CalculatorText
        {
            get { return _calculatorText; }
            set
            {
                if (value != this._calculatorText)
                {
                    this._calculatorText = value;
                    NotifyPropertyChanged();
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
