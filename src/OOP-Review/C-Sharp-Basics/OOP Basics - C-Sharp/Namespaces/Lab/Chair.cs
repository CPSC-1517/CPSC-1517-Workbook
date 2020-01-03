using System;
using LanguageReview.CSharp.Namespaces;

namespace LanguageReview.CSharp.Namespaces.Furniture.Lab
{
    public class Chair
    {
        // Some fields here
        private double _seatHeight;
        public double SeatHeight
        {
            get { return _seatHeight; }
            set { _seatHeight = value; }
        }

        private double _maxWeight;
        public double MaxWeight
        {
            get { return _maxWeight; }
        }

        private int _YearsLeftOnWarranty;
        public int YearsLeftOnWarranty
        {
            get { return _YearsLeftOnWarranty; }
        }

        // Some Methods
        public double Glide(double Speed)
        {
            // Returns a distance, based on speed
            return 0; // dummy value for now...
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
