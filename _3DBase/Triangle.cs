using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DBase
{
    public class Triangle
    {
        public Vector3 v0, v1, v2;

        public Triangle()
        {
            this.v0 = new Vector3();
            this.v1 = new Vector3();
            this.v2 = new Vector3();
        }
        public Triangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            this.v0 = v0;
            this.v1 = v1;
            this.v2 = v2;
        }
        public Triangle(Triangle t)
            : this(t.v0, t.v1, t.v2)
        {

        }

        public Vector3 NormalAtV0
        {
            get { return (v1 - v0) ^ (v2 - v0); }
        }

        //public Vector3 NormalAtV1
        //{
        //    get { return  }
        //}

        //public Vector3 NormalAtV2
        //{
        //    get { return  }
        //}

        public bool IsVisible(Vector3 viewVector)
        {
            return viewVector * NormalAtV0 > 0;
        }

        public float GetColorIntensity(Vector3 viewVector)
        {
            Vector3 normal = this.NormalAtV0;
            float lengthNormal = normal.Length;
            float lengthViewVector = viewVector.Length;
            return (viewVector * normal) / lengthViewVector / lengthNormal;
        }

        public float GetWeightZ
        {
            get { return (v0.z + v1.z + v2.z) / 3f; }
        }
    }
}
