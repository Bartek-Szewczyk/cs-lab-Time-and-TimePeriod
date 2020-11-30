using System;
using System.Collections.Generic;
using System.Text;



namespace Time
{
    class Program
    {
        static void Main()
        {
            Time t1 = new Time(12, 22, 09);
            Time t2 = new Time(1,2,3);
            Time t3 = new Time("12:32:11");
            TimePeriod tp1 =new TimePeriod(6352);
            Console.WriteLine(tp1);
        }


    }
}



