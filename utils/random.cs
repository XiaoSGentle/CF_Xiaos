using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaos.utils
{
    class random
    {
        xiaos dm = new xiaos();
        /*
         * 延时函数
         */
        public void delay(int mis)
        {
            mis = mis + new Random().Next(1, 50);
            //Form1.show.Log(mis);
            dm.delay(mis);
        }

        /*
         * 位置偏移函数
         */
        public void moveTo(int x, int y)
        {
            dm.MoveTo(x + new Random().Next(1, 10), x + new Random().Next(1, 10));
        }
    }
}
