using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJG_DataUpDate
{
    class digitalPoint : Point
    {
        public digitalPoint(string name) :base(name)
        {

        }
        private bool[] _value = new bool[1];//这里使用数组是为了满足油田公司的json格式要求，并无其他用处
        public override object presentValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value[0] = Convert.ToBoolean(value);
            }
        }
    }
}
