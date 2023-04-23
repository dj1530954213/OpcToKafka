using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJG_DataUpDate
{
    public class AnalogPoint : Point
    {
        public AnalogPoint(string name) :base(name)
        {

        }

        private float[] _value = new float[1];

        public override object presentValue
        {
            get 
            { 
                return _value; 
            }
            set
            {
                _value[0] = Convert.ToSingle(value);
            }
        }

    }
}
