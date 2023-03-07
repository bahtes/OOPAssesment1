using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)  //Main method
        {
            Test test = new Test();  //Creates a new instance of the Test class

            test.shuffle(1);

            test.dealOne();

            test.shuffle(2);

            test.dealOne();

            test.shuffle(3);

            test.dealOne();

            test.dealMultiple(52);

            test.dealMultiple(48);

            test.dealOne();

            test.dealOne();

            test.dealMultiple(2);
            
        }
    }
}