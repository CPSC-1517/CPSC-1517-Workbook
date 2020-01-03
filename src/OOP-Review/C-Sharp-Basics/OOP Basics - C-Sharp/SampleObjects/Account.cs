namespace ProgramingFundamentals.Topics.C.Examples
{
    public class Account
    {
        #region Fields (always private)
        private int _AccountNumber;
        private double _Balance;
        private double _OverdraftLimit;
        #endregion

        #region Properties
        public int AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
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
        public Account(int accountNumber, double balance, double overdraftLimit)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
        }
        #endregion
    }
}