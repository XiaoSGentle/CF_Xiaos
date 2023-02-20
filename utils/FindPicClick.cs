using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaos.utils
{
    public class FindPicClick
    {

        xiaos dm = new xiaos();
        /// <summary>
        /// 找图返回结果
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public List<FindPicResult> FindAndClick(string result)
        {
            if (result.Equals("") || result == null)
            {
                return null;
            }
            String[] splitResults = result.Split('|');
            List<FindPicResult> picResults = new List<FindPicResult>();
            for (int i = 0; i < splitResults.Length; i++)
            {
                String[] splitResult = splitResults[i].Split(',');
                FindPicResult r = new FindPicResult(splitResult[0], int.Parse(splitResult[1]), int.Parse(splitResult[2]));
                picResults.Add(r);
            }
            return picResults;
        }
        /// <summary>
        /// 找图点击指定坐标
        /// </summary>
        /// <param name="result"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Boolean FindAndClick(string result, int x, int y, int delays)
        {
            if (result.Equals("") || result == null)
            {
                return false;
            }
            String[] splitResult = result.Split(',');
            FindPicResult r = new FindPicResult(splitResult[0], int.Parse(splitResult[1]), int.Parse(splitResult[2]));
            dm.MoveToEx(x, y, 15, 15);
            dm.Delays(delays, delays + 100);
            dm.LeftClick();
            return true;
        }
        /// <summary>
        /// 找图并点击        
        /// <param name="result"></param>
        /// <param name="click"></param>
        /// <returns></returns>
        public Boolean FindAndClick(string result, Boolean click, int delays)
        {
            if (result.Equals("") || result == null)
            {
                return false;
            }
            String[] splitResult = result.Split(',');
            FindPicResult r = new FindPicResult(splitResult[0], int.Parse(splitResult[1]), int.Parse(splitResult[2]));
            dm.MoveToEx(r.X, r.Y, 10, 10);
            if (click == true)
            {
                dm.Delays(delays, delays + 200);
                dm.LeftClick();
            }
            return true;
        }
    }
    /// <summary>
    /// 找图结果类的封装
    /// </summary>
    public class FindPicResult
    {
        private string pic_num;
        private int x;
        private int y;

        public string Pic_num
        {
            get { return pic_num; }
            set { pic_num = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public FindPicResult()
        {

        }
        public FindPicResult(string pic_num, int x, int y)
        {
            this.pic_num = pic_num;
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "FindPicResult: pic_num:" + pic_num + " X:" + x + " Y:" + y;
        }
    }
}
