using System;
using LanguageReview.CSharp.Namespaces;

namespace LanguageReview.CSharp.Namespaces.Furniture.Home
{
    public class Chair
    {
        // Some fields here
        private ChairStyle _style;
        public ChairStyle Style
        {
            get { return _style; }
        }

        private double _seatHeight;
        public double SeatHeight
        {
            get { return _seatHeight; }
        }

        private double _backHeight;
        public double BackHeight
        {
            get { return _backHeight; }
        }


        private int _YearsLeftOnWarranty;
        public int YearsLeftOnWarranty
        {
            get { return _YearsLeftOnWarranty; }
        }

        public Chair(ChairStyle Style, double SeatHeight, double BackHeight, int YearsLeftOnWarranty)
        {
            _style = Style;
            _seatHeight = SeatHeight;
            _backHeight = BackHeight;
            _YearsLeftOnWarranty = YearsLeftOnWarranty;
        }

        // Some Methods
        public double Glide(double Force)
        {
            // Returns the maximum arc in a backwards direction for the given force
            double theGlide = 0; // dummy value for now...
            return theGlide;
        }

        public void AgeOneYear()
        {
            _YearsLeftOnWarranty -= 1;
        }

        public ComfortScale CalcComfort()
        {
            return ComfortScale.VeryGood;
        }
    }
}
