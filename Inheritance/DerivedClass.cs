using System;

namespace Bif3.Swe1.Oop.Inheritance {
    class DerivedClass : BaseClass {
        // override baseclass method
        public override void Method1() {
            Console.WriteLine("Method1 DerivedClass");
        }

        // hiding baseclass method
        public new void Method2() {
            Console.WriteLine("Method2 DerivedClass");
        }

        // different types of string interpolation
        public void Method2(string parameterString) {
            Console.WriteLine("Method2 Param DerivedClass" + parameterString);
            Console.WriteLine(string.Format("Method2 Param DerivedClass {0}", parameterString));
            Console.WriteLine($"Method2 Param DerivedClass {parameterString}");
        }
    }
}
