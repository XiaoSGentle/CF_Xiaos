﻿using System;
using System.Collections.Generic;
using Xiaos.utils;

namespace Xiaos
{
    class sld_paoshang
    {
        //创建大漠对象
        xiaos dm = new xiaos();
        FindPicClick fppc = new FindPicClick();
        List<FindPicResult> fprList = new List<FindPicResult>();
        FindPicResult fpr = new FindPicResult();
        sld_userConfig config = new sld_userConfig();//创建一个跑商参数对象
        //获取当前文件的目录
        //String basePath = System.IO.Directory.GetCurrentDirectory();
        String basePath = @"C:\Users\39334\Desktop\7.2302\cf图片文件\";


        /// <summary>
        /// 对日志输出再次进行封装
        /// </summary>
        /// <param name="log"></param>
        private void Log(object log)
        {
            Form1.show.Log(log);
        }

        private void moveAndClick(int x, int y, int delay)
        {
            dm.Delays(delay, delay + 100);
            dm.MoveToEx(x, y, 10, 10);
            dm.Delays(delay, delay + 100);
            dm.LeftClick();
            dm.Delays(30, 200);
            dm.LeftClick();
            dm.Delays(delay, delay + 100);
        }
        /// <summary>
        /// 跑商总启动项
        /// </summary>
        /// <param name="userConfig"></param>
        public void Go(sld_userConfig userConfig)
        {
            this.config = userConfig;
            joinGame();
        }
        /// <summary>
        /// 危险区域检测
        /// </summary>
        public void dangerArea()
        {

        }
        /// <summary>
        /// 开始游戏前进行判断位置
        /// </summary>
        public void currentPosition()
        {

        }

        /// <summary>
        /// 各种弹窗检测，及其关闭
        /// </summary>
        public void popupDetection()
        {
            //关闭第二天更新的火线币弹窗
            fppc.FindAndClick(dm.FindPicEx(563, 124, 609, 142, basePath + "火线币.bmp", "000000", 1, 0), 742, 693, 300);
            //大厅内
            fprList = fppc.FindAndClick(dm.FindPicEx(1048, 125, 1081, 143, basePath + "战队.bmp", "000000", 1, 0));
            //房间内
            fprList = fppc.FindAndClick(dm.FindPicEx(268, 370, 308, 394, basePath + "房间内.bmp", "000000", 1, 0));
            //关闭长时间未操作弹窗
            fppc.FindAndClick(dm.FindPicEx(585, 350, 619, 366, basePath + "长时间未操作.bmp", "000000", 1, 0), 622, 460, 300);
            //关闭成为房主弹窗
            fppc.FindAndClick(dm.FindPicEx(613, 343, 643, 369, basePath + "成为房主.bmp", "000000", 1, 0), 630, 460, 300);
            //关闭无法创建加密房间弹窗
            fppc.FindAndClick(dm.FindPicEx(615, 349, 660, 364, basePath + "加密房间.bmp", "000000", 1, 0), 630, 460, 300);
        }
        /// <summary>
        /// 大厅内创建房间
        /// </summary>
        /// <param name="pwd"></param>
        public void createRoom()
        {
            //点击创建房间
            moveAndClick(447, 548, 500);
            //模式选择：挑战模式
            moveAndClick(291, 229, 500);
            //点击密码框
            moveAndClick(720, 530, 500);
            dm.Delays(200, 300);
            //for循环输入密码
            for (int i = 0; i < config.Room_Pwd.Length; i++)
            {
                dm.KeyPressChar(config.Room_Pwd[i].ToString());
                dm.Delays(200, 300);
            }
            dm.Delays(200, 300);
            //点击确定
            moveAndClick(963, 649, 500);
            dm.delay(1000);
            //关闭无法创建加密房间弹窗
            fppc.FindAndClick(dm.FindPicEx(615, 349, 660, 364, basePath + "加密房间.bmp", "000000", 1, 0), 630, 460, 300);
            //查询是否在房间
            fprList = fppc.FindAndClick(dm.FindPicEx(268, 370, 308, 394, basePath + "房间内.bmp", "000000", 1, 0));
            if (fprList == null)
            {
                createRoom();
            }
            joinGame();
        }

        /// <summary>
        /// 加入游戏
        /// </summary>
        public void joinGame()
        {
            moveAndClick(1136, 547, 300);
            fprList = fppc.FindAndClick(dm.FindPicEx(268, 370, 308, 394, basePath + "房间内.bmp", "000000", 1, 0));
            if (fprList != null)
            {
                joinGame();
            }
            Log("房间>>>游戏内");
            dm.delay(20000);
            getTask();
        }
        /// <summary>
        /// 获取任务
        /// </summary>
        public void getTask()
        {
            fprList = fppc.FindAndClick(dm.FindPicEx(130, 692, 166, 709, basePath + "游戏内.bmp", "000000", 1, 0));
            if (fprList == null)
            {
                getTask();
            }
            else
            {
                Log("移动领取任务");
                dm.Delays(500, 600);
                dm.KeyDownChar("a");
                for (int i = 0; i < 55 + config.Delay_Time; i++)
                {
                    dm.KeyDownChar("w");
                    dm.Delays(30, 50);
                }
                dm.KeyUpChar("a");
                dm.KeyUpChar("w");
            }
        }
    }

    /// <summary>
    ///跑商脚本参数封装
    /// </summary>
    class sld_userConfig
    {
        private int delay_Time;
        private string room_Pwd;

        public int Delay_Time
        {
            get { return delay_Time; }
            set { delay_Time = value; }
        }
        public string Room_Pwd
        {
            get { return room_Pwd; }
            set { room_Pwd = value; }
        }

        public sld_userConfig()
        {

        }

        public sld_userConfig(int delay_Time, string room_Pwd)
        {
            this.delay_Time = delay_Time;
            this.room_Pwd = room_Pwd;
        }
    }

}