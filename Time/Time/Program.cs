using System;
using System.Collections.Generic;
using System.Text;
using Time;



namespace Time
{
    public class Program
    {
       public  static void Main()
        {
            Time t01 = new Time(12, 22, 09);
            Time t02 = new Time(1, 2, 3);
            Time t3 = new Time("12:32:11");
            TimePeriod tp01 = new TimePeriod(6352);
            TimePeriod tp02 = new TimePeriod("6:42:19");


            Time t1 = new Time(17, 31, 59);
            Time t2 = new Time(17, 31, 59);
            Console.WriteLine(t1);

            TimePeriod tp03 = new TimePeriod("4:10:46");

            t1.Plus(tp01);
            TimePeriod tp05= TimePeriod.Plus(tp03, tp01);

            Time tt1 = t2 + tp01;
            TimePeriod tp1 = new TimePeriod(35, 41, 28);
            TimePeriod tp2 = new TimePeriod("36:41:28");
            TimePeriod tp3 = new TimePeriod(73582);

            TimePeriod ttp0 = tp1 - tp3;

            Console.WriteLine(ttp0);
            Console.WriteLine(tp3);
            
        }

    }
}



