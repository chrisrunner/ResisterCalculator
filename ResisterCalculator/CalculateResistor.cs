using System;
using System.Collections.Generic;

namespace ResisterCalculator
{
    internal class CalculateResistor
    {
        private List<Bands> bandList;
        private List<Bands> toleranceList;

        internal CalculateResistor(List<Bands> bands, List<Bands> tolerances)
        {
            bandList = bands;
            toleranceList = tolerances;
        }

        internal string calculateOutput(int one, int two, int three)
        {
            string value = one.ToString() + two.ToString();
            float aValue = Int32.Parse(value);
            string result = "";

            switch (bandList[three].Band)
            {
                case ("Red"):
                case ("Green"):
                    aValue = aValue / 10;
                    result = aValue + bandList[three + 1].ToMulti();
                    break;
                default:
                    result = aValue + bandList[three].ToMulti();
                    break;
            }

            return "Result: " + result;
        }
    }
}
