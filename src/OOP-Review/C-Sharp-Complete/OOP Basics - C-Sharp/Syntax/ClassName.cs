using System;

namespace LanguageReview.CSharp.Syntax
{
    public class ClassName
    {
        #region What the object will look like...
        #region Fields
        private int _memberVariable;
        private string _someData;
        #endregion

        #region Properties
        public int MemberVariable
        {
            get
            {
                return _memberVariable;
            }
            set
            {
                _memberVariable = value;
            }
        }
        public string SomeData
        {
            get
            {
                return _someData;
            }
        }

        public double CalculatedData
        {
            get
            {
                // Note: This doesn't reference any field, it just does a calculation
                double area = 12 * 5.6;
                area = area * MemberVariable;
                return area;
            }
        }

        public string AutoImplementedProperty { get; set; }
        #endregion
        #endregion

        #region How the object will behave
        #region Constructors
        public ClassName(int memberVariable, string someData, string autoImplementedProperty)
        {
            _memberVariable = memberVariable;
            _someData = someData;
            AutoImplementedProperty = autoImplementedProperty;
        }

        public ClassName(string someData)
        {
            _someData = someData;
        }
        #endregion

        #region Methods
        private void ReturnsNoData(string parameterName)
        {
            // Do something...
        }

        private double ReturnsOneValue(int firstParameter, int secondParameter)
        {
            double result = Math.PI * firstParameter * 2 + secondParameter;
            return result;
        }
        #endregion
        #endregion
    }
}
