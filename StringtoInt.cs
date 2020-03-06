using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class StringtoInt
    {
        public int convert(string input)
        {
            try
            {
                int convertedNumber;
                bool isConvertedSuccesfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSuccesfully)
                {
                    throw new Exception("Conversion was not succesful");
                }
                return convertedNumber;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
