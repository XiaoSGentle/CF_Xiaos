using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xiaos.config;
using Xiaos.utils;

namespace Xiaos
{
    public partial class Form1 : Form
    {
        public static Form1 show;
        public Form1()
        {
            InitializeComponent();
            show = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterDmSoft.RegisterDmSoftDll();
        }
        /// <summary>
        /// 日志输出
        /// </summary>
        /// <param name="log"></param>
        public void Log(object log)
        {
            lbxLog.Items.Insert(0, DateTime.Now.ToString() + "-" + log);
        }
        public void test()
        {
            new sld_paoshang().Go(new sld_userConfig(int.Parse(tbxFps.Text), tbxRoomPwd.Text,int.Parse(tbxMouseParam.Text) ));

        }
        /// <summary>
        /// 以下三个是关于快捷键的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {

            //注册热键f3，Id号为100。
            HotKey.RegisterHotKey(Handle, 100, HotKey.KeyModifiers.None, Keys.F3);
            //注册热键f4，Id号为101。
            HotKey.RegisterHotKey(Handle, 101, HotKey.KeyModifiers.None, Keys.F4);
        }
        private void Form1_Leave(object sender, EventArgs e)
        {

            //注销Id号为100的热键设定
            HotKey.UnregisterHotKey(Handle, 100);
            //注销Id号为101的热键设定
            HotKey.UnregisterHotKey(Handle, 101);

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            GameConfig.Go();
                          
                            Log("开始跑商！");
                            

                            break;
                        case 101:
                            Log("KEPRESS F4");
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test();
        }
    }
}
