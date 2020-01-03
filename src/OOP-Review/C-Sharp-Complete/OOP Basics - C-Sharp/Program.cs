using System;
using LanguageReview.CSharp.Syntax;

#region Additional Namespace Requirements
using ProgramingFundamentals.Topics.C.Examples;
#endregion

namespace LanguageReview.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account myAccount = new Account(123,45.0d,1000.0d);
            Account defaultAccount = new Account();

            defaultAccount.AccountNumber = 222; //set
            defaultAccount.OverdraftLimit = 500.0d;

            Console.WriteLine("Account #" + myAccount.AccountNumber); //get
            Console.WriteLine("Balance $" + myAccount.Balance.ToString());
            Console.WriteLine("OverDraft $" + myAccount.OverdraftLimit.ToString()+"\n\n");

            Console.WriteLine("Account #" + defaultAccount.AccountNumber); //get
            Console.WriteLine("Balance $" + defaultAccount.Balance.ToString());
            Console.WriteLine("OverDraft $" + defaultAccount.OverdraftLimit.ToString() + "\n\n");

            double amount = 600.0d;
            bool actionResult;
            actionResult = myAccount.CreditCheck(amount, 'p');
            Console.WriteLine("New Balance $" + myAccount.Balance.ToString());
            Console.WriteLine("Result of CreditCheck was " + actionResult);

            //actionResult = defaultAccount.CreditCheck(amount, 'p');
            //Console.WriteLine("New Balance $" + defaultAccount.Balance.ToString());
            //Console.WriteLine("Result of CreditCheck was " + actionResult);

            
            if (defaultAccount.CreditCheck(amount, 'p'))
            {
                Console.WriteLine("New Balance $" + defaultAccount.Balance.ToString());
            }
            else
            {
                
                Console.WriteLine("Action was unacceptable.");
            }

            Console.ReadLine();

        }

        private static void DemonstrateThisKeyword()
        {
            ClassName firstObject;
            ClassName secondObject;
            firstObject = new ClassName(4, "Bob", "the Banker");
            secondObject = new ClassName("Dave");

            Console.WriteLine(firstObject.MemberVariable);
            Console.WriteLine(secondObject.MemberVariable);
        }
    }
}
