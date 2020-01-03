using System;
using LanguageReview.CSharp.Syntax;
namespace LanguageReview.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        private static void DemonstrateThisKeyword()
        {
            ClassName firstObject;
            ClassName secondObject;
            firstObject = new ClassName(4, "Bob", "the Banker");
            secondObject = new ClassName("Dave");

            Console.WriteLine(firstObject.MemberVariable);
            Console.WriteLine(secondObject.MemberVariable);

            Console.ReadLine();
        }
    }
}
