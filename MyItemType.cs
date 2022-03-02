using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApp2
{
    [Serializable]
    internal class MyItemType:ISerializable
    {
        public MyItemType() { }
        public string myvalue;
        public string MyValue { get { return myvalue; } set { myvalue = value; } }
        void ISerializable.GetObjectData(SerializationInfo info,StreamingContext context)
        {
            info.AddValue("props",myvalue,typeof(string));
        }
        public MyItemType(SerializationInfo info, StreamingContext context)
        {
            myvalue = (string)info.GetValue("props", typeof(string));
        }
    }
}
