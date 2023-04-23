using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJG_DataUpDate
{
    public abstract class Point
    {
        public Point(string name)
        {
            Name = name;
        }
        private string _name;
        [JsonProperty("Tag", Order = 1)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty("value", Order = 2)]
        public abstract object presentValue { get; set; }

    }
}
