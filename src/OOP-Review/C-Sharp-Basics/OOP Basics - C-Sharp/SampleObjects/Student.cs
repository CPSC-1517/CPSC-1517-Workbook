/**
 * Purpose: To illustrate 
 *          Highlights:
 *          - Keywords: public, class, char, int, double, this, return
 *          - Grammar: 
 *          - Other:
 *              - 
 */
namespace ProgramingFundamentals.Topics.C.Examples
{

    public class Student
    {
        #region Fields
        private string _Name;
        private char _Gender;
        private int _StudentId;
        private string _Program;
        private double _GradePointAverage;
        private bool _IsFullTime;
       #endregion

        #region Properties
        /// <summary>
        /// The full name of the student
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Gender can be 'M' or 'F'
        /// </summary>
        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        /// <summary>
        /// The school-provided student ID
        /// </summary>
        public int StudentId
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }

        /// <summary>
        /// The course program; e.g.: "CST"
        /// </summary>
        public string Program
        {
            get { return _Program; }
            set { _Program = value; }
        }

        /// <summary>
        /// GPA is from 1.0 to 9.0
        /// </summary>
        public double GradePointAverage
        {
            get { return _GradePointAverage; }
            set { _GradePointAverage = value; }
        }

        /// <summary>
        /// If the student is enrolled full-time
        /// </summary>
        public bool IsFullTime
        {
            get { return _IsFullTime; }
            set { _IsFullTime = value; }
        }
        #endregion

        #region Constructors
        public Student(string name, char gender, int studentId, string program, double gradePointAverage, bool isFullTime)
        {
            this.Name = name;
            this.Gender = gender;
            this.StudentId = studentId;
            this.Program = program;
            this.GradePointAverage = gradePointAverage;
            this.IsFullTime = isFullTime;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "(" + StudentId + ") " + Name;
        }
        #endregion
    }
}