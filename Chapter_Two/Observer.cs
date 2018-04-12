using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_Two
{
    // 观察者接口
    public interface Observer
    {
        // 观察者更新主题变化数据
        void update(float temp, float humidity, float pressure);
    }
}
