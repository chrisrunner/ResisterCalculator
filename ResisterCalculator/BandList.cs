using System.Collections.Generic;
using System.Windows.Media;

namespace ResisterCalculator
{
    internal class BandList : List<Bands>
    {
        internal List<Bands> initBandList()
        {
            List<Bands> bandList = new List<Bands>();

            bandList.Add(new Bands() { Band = "Black", BandColour = Color.FromRgb(0, 0, 0), BandInt = 0, BandMulti = "", BandTolerance = 1.0F });
            bandList.Add(new Bands() { Band = "Brown", BandColour = Color.FromRgb(128, 0, 0), BandInt = 1, BandMulti = "0", BandTolerance = 2.0F });
            bandList.Add(new Bands() { Band = "Red", BandColour = Color.FromRgb(255, 0, 0), BandInt = 2, BandMulti = "00" });
            bandList.Add(new Bands() { Band = "Orange", BandColour = Color.FromRgb(255, 128, 0), BandInt = 3, BandMulti = "K" });
            bandList.Add(new Bands() { Band = "Yellow", BandColour = Color.FromRgb(255, 255, 0), BandInt = 4, BandMulti = "0K", BandTolerance = 0.5F });
            bandList.Add(new Bands() { Band = "Green", BandColour = Color.FromRgb(0, 255, 0), BandInt = 5, BandMulti = "00K", BandTolerance = 0.25F });
            bandList.Add(new Bands() { Band = "Blue", BandColour = Color.FromRgb(0, 0, 255), BandInt = 6, BandMulti = "M", BandTolerance = 0.1F });
            bandList.Add(new Bands() { Band = "Violet", BandColour = Color.FromRgb(200, 0, 200), BandInt = 7, BandMulti = "0M", BandTolerance = 0.05F });
            bandList.Add(new Bands() { Band = "Gray", BandColour = Color.FromRgb(128, 128, 128), BandInt = 8, BandTolerance = 1.0F });
            bandList.Add(new Bands() { Band = "White", BandColour = Color.FromRgb(255, 255, 255), BandInt = 9 });

            return bandList;
        }
    }
}
