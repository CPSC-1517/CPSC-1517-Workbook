using System;
namespace ProgramingFundamentals.Topics.C.Examples
{
    public class Account
    {
        #region Fields (always private)
        private int _AccountNumber;
        private double _Balance;         // can be positive or negative
        private double _OverdraftLimit;  //$1000
        #endregion

        #region Properties
        public int AccountNumber
        {
            get //are found on the right side of an assignment
            { 
                return _AccountNumber; 
            }
            set //are found on the left side of an assignment
            { _AccountNumber = value; }
        }

        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        public double OverdraftLimit
        {
            get { return _OverdraftLimit; }
            set { _OverdraftLimit = value; }
        }
        #endregion

        #region Constructors
        public Account(int accountNumber, double balance,
                            double overdraftLimit)
        {
            AccountNumber = accountNumber; //using the property (set)
            _Balance = balance; //setting the private member data directly
            OverdraftLimit = overdraftLimit;
        }
        public Account() //system equlavient default
        {
            _AccountNumber = 0;
            _Balance = 0.0d;
            _OverdraftLimit = 0.0d;
        }
        #endregion
        #region Class Member Methods
        public bool CreditCheck(double amount, char action)
        {
            bool bResult = false;
            if (amount <= 0)
            {
                bResult = false;
            }
            else
            {
                switch (Char.ToUpper(action))
                {
                    case 'W': //char uses single quotes, string uses double quotes
                    
                        {
                            if ((Balance - amount + OverdraftLimit) >= 0)
                            {
                                Balance -= amount;
                                bResult = true;
                            }
                            else
                            {
                                bResult = false;
                            }
                            break;
                        }
                    case 'D':
                        {
                           
                                Balance += amount;
                                bResult = true;
                            
                            break;
                        }
                    case 'P':
                        {
                            if ((Balance - amount + OverdraftLimit) >= 0)
                            {
                                Balance -= amount;
                                bResult = true;
                            }
                            else
                            {
                                bResult = false;
                            }

                            break;
                        }
                    default:
                        {
                            bResult = false;
                            break;
                        }
                }
            }
            return bResult;
        }
        #endregion
    }
}