using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            BodyAnalyser minbodyanalyse = new BodyAnalyser();
            //minbodyanalyse.CalculateBMI(1.8, 88);
            Console.WriteLine("{0}",minbodyanalyse.AnalyseBMI(1.8,88));
            // The LAST line of code should be ABOVE this line
        }
    }
}
