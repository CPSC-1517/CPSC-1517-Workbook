namespace ProgramingFundamentals.Topics.C.Examples
{

    public class DemoToStringMethods
    {

        public static void Start()
        {
            Person nobody = new Person();

            // Because the println() method requires a string parameter, the
            // toString() method of the object is automatically called.
            System.Console.WriteLine(nobody);
            System.Console.WriteLine();
            // Every object has a toString() method, even if it is not
            // explicitly coded by the programmer.
            System.Console.WriteLine(nobody.ToString());
            System.Console.WriteLine();

            Account myAccount = new Account(3, 1500.00, 500.00);
            System.Console.WriteLine(myAccount);
            System.Console.WriteLine();

            Student newGuy = new Student("New Guy", 'M', 20084444, "CST", 3.8, true);
            System.Console.WriteLine(newGuy);
            System.Console.WriteLine();
        }
    }
}