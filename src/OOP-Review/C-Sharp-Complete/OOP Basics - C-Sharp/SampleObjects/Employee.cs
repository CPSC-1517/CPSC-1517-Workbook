using System;

namespace ProgramingFundamentals.Topics.C.Examples
{


    public class Employee
    {
        #region Auto-Implemented Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialInsuranceNumber { get; private set; }
        public double YearlySalary { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public char Gender { get; set; }
        #endregion

        #region Constructors
        public Employee(string firstName, string lastName, int socialInsuranceNumber, double yearlySalary, DateTime employmentStartDate, char gender)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialInsuranceNumber = socialInsuranceNumber;
            YearlySalary = yearlySalary;
            EmploymentStartDate = employmentStartDate;
            Gender = gender;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        #endregion
    }
}