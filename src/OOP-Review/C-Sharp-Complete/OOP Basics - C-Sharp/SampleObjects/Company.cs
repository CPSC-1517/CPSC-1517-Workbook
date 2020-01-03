using System;
namespace ProgramingFundamentals.Topics.C.Examples
{
    public class Company
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        private bool _IsIncorporated;
        public bool IsIncorporated
        {
            get { return _IsIncorporated; }
            set { _IsIncorporated = value; }
        }
        private DateTime _BusinessStartDate;
        public DateTime BusinessStartDate
        {
            get { return _BusinessStartDate; }
        }

        private double _GrossIncomeToDate;
        public double GrossIncomeToDate
        {
            get { return _GrossIncomeToDate; }
            set { _GrossIncomeToDate = value; }
        }

        public Company(string name, string city, bool isIncorporated, DateTime businessStartDate, double grossIncomeToDate)
        {
            Name = name;
            City = city;
            IsIncorporated = isIncorporated;
            _BusinessStartDate = businessStartDate;
            GrossIncomeToDate = grossIncomeToDate;
        }
    }
}