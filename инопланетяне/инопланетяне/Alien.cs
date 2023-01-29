using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace инопланетяне
{
    public class Alien
    {
        string name; //имя инопланетянина 
        string planet; //планета 
        double minheight; //минимальный возможный рост 
        double maxheight; //максимально возможный рост 
        double height; //его рост 
        double heightChangeVal;//сумма значений изменения роста
        int heightChangeCnt;//кол-во изменения роста
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Planet
        {
            get { return planet; }
            set { planet = value; }
        }
        public double Minheight
        {
            get { return minheight; }
            set { minheight = value; }
        }
        public double Maxheight
        {
            get { return maxheight; }
            set { maxheight = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double HeightChangeVal
        {
            get { return heightChangeVal; }
            set { heightChangeVal = value; }
        }
        public int HeightChangeCnt
        {
            get { return heightChangeCnt; }
            set { heightChangeCnt = value; }
        }
        /// <summary>
        /// метод вычисляет отклонение от среднего роста
        /// </summary>
        /// <returns>возвращвет значение отклонения от среднего роста</returns>
        public double Otclonenie()
        {
            return height - ((maxheight + minheight) / 2);
        }
        public double Change(double Otclonenie1)
        {
            height += Otclonenie1;
            return height;
        }
        
    }
}
