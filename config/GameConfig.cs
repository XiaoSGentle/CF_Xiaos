using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Xiaos.config
{
    public static class GameConfig
    {
        static xiaos dm = new xiaos();

        public static void Go()
        {
            setFormPosition();
            dm.Delays(2000, 3000);
        }
        private static void setFormPosition()
        {
            int hwnd = dm.FindWindowEx(0, "CrossFire", "穿越火线");
            dm.MoveWindow(hwnd, 0, 0);
            dm.SetSimMode(3);
        }
    }
}
