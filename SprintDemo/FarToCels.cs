using System;
using System.Collections.Generic;
using System.Text;

namespace SprintDemo
{
    public class FarenheitToCelcius
    {

        public static int farToCels(int startTemp)
        {
            var convertedTemp = (startTemp - 32) * (5 / 9);

            return convertedTemp;
        }
    }
}
