using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJG_DataUpDate
{
    public class JsonResult
    {
        [JsonProperty("time",Order = 1)]//设置键名称和输出顺序
        [JsonConverter(typeof(ChinaDateTimeConverter))]//设置输出时间显示格式
        public DateTime MyProperty
        {
            get { return DateTime.Now; }
        }
        [JsonProperty("data", Order = 2)]
        public List<Point> pointListResult;
    }
}
