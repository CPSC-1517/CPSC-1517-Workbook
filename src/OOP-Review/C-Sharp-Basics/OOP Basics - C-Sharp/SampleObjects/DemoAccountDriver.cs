namespace ProgramingFundamentals.Topics.C.Examples
{
    public class DemoAccountDriver
    {

        /**
         * @param args
         */
        public static void Start()
        {
            Account myAccount; // declares a reference variable to an Account object
            myAccount = new Account(987654, 500.00, 100.00); // creates the Account object.
            System.Console.WriteLine("My balance is " + myAccount.Balance);

            System.Console.ReadLine();
        }

    }
}