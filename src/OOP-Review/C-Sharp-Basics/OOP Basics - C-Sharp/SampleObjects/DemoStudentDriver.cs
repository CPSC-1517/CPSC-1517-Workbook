/**
 * Purpose: To illustrate 
 *          Highlights:
 *          - Keywords: public, class, static, void, new
 *          - Grammar: 
 *          - Other:
 *              - 
 */
namespace ProgramingFundamentals.Topics.C.Examples
{

    public class DemoStudentDriver
    {

        /**
         * @param args
         */
        public static void Start()
        {
            Student bob, mary, joe, susan, frank;
            bob = new Student("Bob McNalley", 'M', 200765789, "CST", 6.76, true);
            mary = new Student("Mary McTavishski", 'F', 200765790, "CST", 5.76, true);
            joe = new Student("Joe Jetson", 'M', 200765792, "CST", 4.66, true);
            susan = new Student("Susan Orlando", 'F', 200765795, "CST", 8.54, true);
            frank = new Student("Frank Smith", 'M', 200765797, "CST", 8.52, true);

            System.Console.WriteLine(bob.Name);
            System.Console.WriteLine(bob.Gender);
            System.Console.WriteLine(bob.Program);
            System.Console.WriteLine(bob.StudentId);
            System.Console.WriteLine(bob.GradePointAverage);
            System.Console.WriteLine();

            System.Console.WriteLine(mary.Name);
            System.Console.WriteLine(mary.Gender);
            System.Console.WriteLine(mary.Program);
            System.Console.WriteLine(mary.StudentId);
            System.Console.WriteLine(mary.GradePointAverage);
            System.Console.WriteLine();

            System.Console.WriteLine(joe.Name);
            System.Console.WriteLine(joe.Gender);
            System.Console.WriteLine(joe.Program);
            System.Console.WriteLine(joe.StudentId);
            System.Console.WriteLine(joe.GradePointAverage);
            System.Console.WriteLine();

            System.Console.WriteLine(susan.Name);
            System.Console.WriteLine(susan.Gender);
            System.Console.WriteLine(susan.Program);
            System.Console.WriteLine(susan.StudentId);
            System.Console.WriteLine(susan.GradePointAverage);
            System.Console.WriteLine();

            System.Console.WriteLine(frank.Name);
            System.Console.WriteLine(frank.Gender);
            System.Console.WriteLine(frank.Program);
            System.Console.WriteLine(frank.StudentId);
            System.Console.WriteLine(frank.GradePointAverage);
            System.Console.WriteLine();
        }
    }
}