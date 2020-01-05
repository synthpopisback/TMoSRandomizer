using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMoS_R
{
    class ObjectSet
    {
        public ObjectSet(byte datapointer, byte objectSetId)
        {
            DataPointer = datapointer;
            ObjectSetId = objectSetId;
        }
        public byte DataPointer;
        public byte ObjectSetId;
    }
}
