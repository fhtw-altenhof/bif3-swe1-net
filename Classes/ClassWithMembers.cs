using System;

namespace Bif3.Swe1.Oop.Classes {
    /// <summary>
    /// PLS NOTE THAT THESE ARE ONLY GUIDELINES.
    /// THEY MAY VARY FROM COMPANY TO COMPANY!
    /// 
    /// - Use pascal casing for members (fields and methods)
    /// - Keep your variables in order: 
    ///     declare all member variables at the top of a class, with static variables at the very top
    ///     first public, then private
    /// - group by type
    ///     const/static/readonly
    ///     properties
    ///     class variables
    ///     
    /// </summary>
    class ClassWithMembers {
        // constant values are not changeable
        public const float ConstantValue = 3.14f;
        // static values are the same value over all instanzes
        // can only be changed in static methods
        public static string StaticString = "Value";
        // readonly can only be changed in constructor
        public readonly int ReadOnlyInt = 0;

        // full auto property
        public int IntProperty { get; set; }
        // property with private setter and default value
        public int ReadProperty { get; private set; } = 0;

        // only accessable in derived classes
        protected string _protectedString = "default";

        // only accessable in this class
        private int _privateVariable = 7;

        // default constructor
        public ClassWithMembers() { }

        // overloaded constructor
        public ClassWithMembers(int x, int y) {
            ReadOnlyInt = _privateVariable;
            ChangeValue(x, y);
        }

        // public member methods
        public void ChangeSomeValues(int newValue) {
            _privateVariable = newValue;
            ReadProperty = newValue;
        }

        public void WriteSomething() {
            Console.WriteLine("Write Something");
        }

        private void ChangeValue(int x, int y) {
            _privateVariable = x + y;
        }
    }
}
