using System;

namespace Open_Close_Principle
{
    // O : Open Close Principle (OCP)
    // Classes, Modules, Functions are open for extension but close for modification.
    // New functionality should add with adding new classes, methods instead of changing in existing classes and modules.

   ////Before Applying OSP Code
   // public class BusinessOperations
   // {
   //     public decimal CalculateBonus(decimal salary)
   //     {
   //         return salary * 26;
   //     }
   // }

    // After Applying OSP Code
    public abstract class BusinessOperations
    {
        public abstract decimal CalculateBonus(decimal salary)
    }

    public class PermnentEmp : BusinessOperations
    {
        public override decimal CalculateBonus( decimal salary)
        {
            return salary * 85;
        }
    }

    public class TemporaryEmp : BusinessOperations
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 54;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
