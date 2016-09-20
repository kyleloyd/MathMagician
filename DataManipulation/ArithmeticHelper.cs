using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class ArithmeticHelper
    {
        public decimal? CurrentValue;

        private string _nextOperator;

        public ArithmeticHelper()
        {
            CurrentValue = null;
        }

        public decimal? OperatorAction(decimal number, string nextOperator)
        {
            var actionDictionary = new Dictionary<string, Action>()
            {
                { "Add",        () => CurrentValue += number },
                { "Subtract",   () => CurrentValue -= number },
                { "Multiply",   () => CurrentValue *= number },
                { "Divide",     () => CurrentValue /= number },
            };

            if (_nextOperator == "Solve")
            {
                ClearValues();
            }

            if (CurrentValue == null)
            {
                CurrentValue = number;
                _nextOperator = nextOperator;
                return 0;
            }

            if (nextOperator == "Solve")
            {
                actionDictionary[_nextOperator].Invoke();
                _nextOperator = nextOperator;
                return CurrentValue;
            }

            actionDictionary[_nextOperator].Invoke();
            _nextOperator = nextOperator;

            return 0;
        }

        public void ClearValues()
        {
            CurrentValue = null;
            _nextOperator = null;
        }
    }
}
