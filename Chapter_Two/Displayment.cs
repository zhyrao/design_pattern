using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Two
{
    public interface Displayment
    {
        // 显示布告板内容
        void display();
    }

    // 
    public class CurrentConditionDisplay:Observer, Displayment
    {
        private float temperature;
        private float humidity;

        // 自身的主题
        private Subject weatherData;

        // 构造的时候需要subject对象作为注册使用
        public CurrentConditionDisplay(Subject s)
        {
            this.weatherData = s;
            s.registerObserver(this);
        }

        // 更新数据，更新显示
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        // 显示
        public void display()
        {
            Console.WriteLine(string.Format("Current Conditions: " + temperature + " F degrees and " + humidity + " % humidity"));
        }
    }

    // 统计面板
    public class StaticsDisplay : Observer, Displayment
    {
        private float tempetrue;

        private Subject s;
        public StaticsDisplay(Subject s)
        {
            this.s = s;
            s.registerObserver(this);
        }

        // 状态接受更新
        public void update(float temp, float humidity, float pressure)
        {
            this.tempetrue = temp;
            display();
        }

        // 显示
        public void display()
        {
            Console.WriteLine("最高温度：" + (tempetrue + 5.0f) + "\n平均温度：" + tempetrue + "\n最低温度：" + (tempetrue - 6.0f));
        }
    }
}
