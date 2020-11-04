using System;

namespace Unit2_VariablesTransportation
{
    class Program
    {
        private int variable = 100;

        static private void globalVar_And_localVar()
        {
            int variable = 99;
            Console.WriteLine("\n" + variable);
            Console.WriteLine("global variable = 100 and local variable = 99");
            Console.WriteLine("But value here is only 99 = value of local variable");
        }

        static private void Call_By_Value(int newInt)
        {
            newInt++;
        }

        static private void Call_By_Reference(ref int newInt)
        {
            newInt++;
        }

        static void Main(string[] args)
        {
            int varInt = 1999;
            Console.WriteLine("varInt = " + varInt);
            Call_By_Value(varInt);
            Console.WriteLine("varInt CallByValue = " + varInt);
            Call_By_Reference(ref varInt);
            Console.WriteLine("varInt CallByReference = " + varInt);

            globalVar_And_localVar();
            Console.ReadKey();
        }
    }
}
