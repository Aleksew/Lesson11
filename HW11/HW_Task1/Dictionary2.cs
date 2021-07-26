using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    public class Dictionary2<TKey, TValue1, TValue2> 
    {
        public TKey Key { get; set; }
        public TValue1 Value1 { get; set; }
        public TValue2 Value2 { get; set; }

        public Dictionary2(TKey key, TValue1 value1, TValue2 value2)
        {
            Key = key;
            Value1 = value1;
            Value2 = value2;
        }

        public Dictionary2()
        {

        }



    }
}
