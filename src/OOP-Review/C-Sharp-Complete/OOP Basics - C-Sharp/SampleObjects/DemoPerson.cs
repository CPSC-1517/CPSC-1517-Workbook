namespace ProgramingFundamentals.Topics.C.Examples
{
    public class DemoPerson
    {
        public static void Start()
        {
            Person someGuy;
            someGuy = new Person();
            someGuy.FirstName = "Mitch";
            someGuy.LastName ="Robbins";
            someGuy.Age = 25;

            Person someGirl;
            someGirl = new Person();
            someGirl.FirstName = "Barbara";
            someGirl.LastName = "Smithston";
            someGirl.Age = 25;

            string fullName;

            fullName = someGuy.FirstName + " " + someGuy.LastName;
            System.Console.WriteLine("Hi. My name is " + fullName);

            fullName = someGirl.FirstName + " " + someGirl.LastName;
            System.Console.WriteLine("Hi " + someGuy.FirstName +
                               ". My name is " + fullName);
        }
    }
}