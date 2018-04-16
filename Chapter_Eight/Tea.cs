using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Eight
{
    public class Tea
    {

        void prepareRecipe()
        {
            boilWater();
            steepTeaBag();
            pourInCup();
            addLemon();
        }

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void steepTeaBag()
        {
            Console.WriteLine("Steeping the tea bag");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void addLemon()
        {
            Console.WriteLine("Adding lemon");
        }

    }

    /* 这个泡茶的类和冲咖啡的类中有很多相同和相似的
     * 方法。那么可以先单独将相同的方法抽出来作为基类
     * 再处理相似的方法。
     */
}
