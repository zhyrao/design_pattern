using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Two
{
    // 主题接口
    public interface Subject
    {
        // 注册成为观察者
        void registerObserver(Observer o);

        // 从观察者队列中移除
        void removeObserver(Observer o);

        // 当主题状态改变的时候，通知所有的观察者
        void notifyObserver();
    }


    public class WeatherData: Subject
    {
        // 注册的观察者列表
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        // 构造
        public WeatherData()
        {
            observers = new List<Observer>();
        }

        // 观察者注册
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        // 移除观察者
        public void removeObserver(Observer o)
        {
            int index = observers.IndexOf(o);
            if (index >= 0)
                observers.Remove(o);
        }

        // 通知观察者
        public void notifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].update(temperature, humidity, pressure);
            }
        }

        // 确认状态变化，通知观察者
        public void measurementsChanged()
        {
            notifyObserver();
        }


        // 当状态变化是被调用
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}
