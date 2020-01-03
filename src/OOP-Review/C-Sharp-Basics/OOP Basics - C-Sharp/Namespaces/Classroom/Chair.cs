using System;
using LanguageReview.CSharp.Namespaces;

namespace LanguageReview.CSharp.Namespaces.Furniture.Classroom
{
    public class Chair
    {
        // Some fields here
        private double _seatHeight;
        public double SeatHeight
        {
            get { return _seatHeight; }
        }

        private int _YearsLeftOnWarranty;
        public int YearsLeftOnWarranty
        {
            get { return _YearsLeftOnWarranty; }
        }

        public Chair(double seatHeight, int YearsLeftOnWarranty)
        {
            _YearsLeftOnWarranty = YearsLeftOnWarranty;
            _seatHeight = seatHeight;
        }

        // Some Methods
        public void AgeOneYear()
        {
            _YearsLeftOnWarranty -= 1;
        }

        public ComfortScale CalcComfort()
        {
            return ComfortScale.Good;
        }
    }
}
