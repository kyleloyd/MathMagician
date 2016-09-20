namespace DataManipulation
{
    public class NumberHelper
    {
        public bool CurrentIncludesDecimal { get; private set; }
        public bool AddDecimalWithNext { get; private set; }

        public NumberHelper()
        {
            ResetDecimalFlags(true, true);
        }

        public bool DecimalAction()
        {
            if (!CurrentIncludesDecimal)
            {
                AddDecimalWithNext = true;
                CurrentIncludesDecimal = true;
                return true;
            }

            return false;
        }

        public void ResetDecimalFlags(bool resetCurrentIncludes, bool resetAddDecimal)
        {
            CurrentIncludesDecimal = resetCurrentIncludes ? false : CurrentIncludesDecimal;
            AddDecimalWithNext = resetAddDecimal ? false : AddDecimalWithNext;
        }

        public bool IsANumber(string test)
        {
            decimal output;
            return decimal.TryParse(test, out output);
        }
    }
}
