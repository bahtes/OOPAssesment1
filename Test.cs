using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Test  
    {

        Format format = new Format();

        public void run()
        {

            format.shuffle(1);

            format.shuffle(10);

            format.dealOne();

            format.shuffle(2);

            format.dealOne();

            format.shuffle(3);

            format.dealOne();

            format.dealMultiple(52);

            format.dealMultiple(48);

            format.dealOne();

            format.dealOne();

            format.dealMultiple(2);

        }

    }
}