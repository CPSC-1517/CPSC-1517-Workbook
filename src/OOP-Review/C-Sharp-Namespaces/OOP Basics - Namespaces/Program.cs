using System;
using LabChair = LanguageReview.CSharp.Namespaces.Furniture.Lab.Chair;
using ClassroomChair = LanguageReview.CSharp.Namespaces.Furniture.Classroom.Chair;

namespace LanguageReview.CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DemoChairs();

            Console.ReadLine();
        }

        private static void DemoChairs()
        {
            LabChair instructorChair;
            instructorChair = new LabChair(25, 350, 2);
            instructorChair.SeatHeight = 25;


            ClassroomChair guestChair;
            guestChair = new ClassroomChair(23, 1);
            // guestChair.SeatHeight = 25;
            instructorChair.SeatHeight = guestChair.SeatHeight;
        }
    }
}
