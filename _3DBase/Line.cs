using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DBase
{
    public class Line
    {
        public Vector3 v0, v1;

        public Line(Vector3 v0, Vector3 v1)
        {
            this.v0 = new Vector3(v0.x, v0.y, v0.z);
            this.v1 = new Vector3(v1.x, v1.y, v1.z);
        }

        public Line(Line l)
            : this(l.v0, l.v1)
        {

        }
    }
}
