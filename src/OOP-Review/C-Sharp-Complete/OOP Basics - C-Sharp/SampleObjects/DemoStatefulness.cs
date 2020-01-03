namespace ProgramingFundamentals.Topics.C.Examples
{

    public class DemoStatefulness
    {

        public static void Start()
        {
            Person nobody = new Person();
            System.Console.WriteLine("First name: " + nobody.FirstName);
            System.Console.WriteLine("Age: " + nobody.Age);
            System.Console.WriteLine();

            Account myAccount = new Account(3, 1500.00, 500.00);
            System.Console.WriteLine("Balance: " + myAccount.Balance);
        }
    }
}