using System.Collections.Generic;

namespace ResisterCalculator
{
    internal class ToleranceList : List<Bands>
    {
        internal List<Bands> initToleranceList()
        {
            List<Bands> toleranceList = new List<Bands>();

            toleranceList.Add(new Bands() { Band = "None" });
            toleranceList.Add(new Bands() { Band = "Gold", BandMulti = "0.1", BandTolerance = 5.0F });
            toleranceList.Add(new Bands() { Band = "Silver", BandMulti = "0.01", BandTolerance = 10.0F });

            return toleranceList;
        }
    }
}
