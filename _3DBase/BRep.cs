using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DBase
{
    public class BRep
    {
        public List<Vector3> vertices = new List<Vector3>();
        public List<Line> lines = new List<Line>();
        public List<Triangle> triangles = new List<Triangle>();
    }
}
