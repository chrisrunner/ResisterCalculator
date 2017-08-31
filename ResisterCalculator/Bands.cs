using System.Windows.Media;

namespace ResisterCalculator
{
    internal class Bands
    {
        internal string Band { get; set; }
        internal Color BandColour { get; set; }
        internal int BandInt { get; set; }
        internal string BandMulti { get; set; }
        internal float BandTolerance { get; set; }

        public override string ToString()
        {
            return Band;
        }

        public int ToInt()
        {
            return BandInt;
        }

        public string ToMulti()
        {
            return BandMulti;
        }

        public string ToTolerance()
        {
            return BandTolerance + "%";
        }

        public Color ToColour()
        {
            return BandColour;
        }
    }
}