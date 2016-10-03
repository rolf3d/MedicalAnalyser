using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BodyAnalyser ba = new BodyAnalyser();

            Console.WriteLine(ba.AnalyseBMI(1.60, 35));
            Console.WriteLine(ba.AnalyseBMI(1.60, 45));
            Console.WriteLine(ba.AnalyseBMI(1.60, 55));
            Console.WriteLine(ba.AnalyseBMI(1.60, 65));
            Console.WriteLine(ba.AnalyseBMI(1.60, 75));
            Console.WriteLine(ba.AnalyseBMI(1.60, 85));
            Console.WriteLine(ba.AnalyseBMI(1.60, 95));
            Console.WriteLine(ba.AnalyseBMI(1.60, 105));

            // The LAST line of code should be ABOVE this line
        }
    }
}
