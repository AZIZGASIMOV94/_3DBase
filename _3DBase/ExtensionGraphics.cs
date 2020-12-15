using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DBase
{
    public static class ExtensionGraphics
    {
        public static void DrawLine(this Graphics g, Pen pen, Vector3 v0, Vector3 v1)
        {
            g.DrawLine(pen, v0.x, v0.y, v1.x, v1.y);
        }

        public static void FillPolygon(this Graphics g, Brush brush, params Vector3[] V)
        {
            PointF[] P = new PointF[V.Length];
            for (int i = 0; i < P.Length; i++)
                P[i] = new PointF(V[i].x, V[i].y);
            g.FillPolygon(brush, P);
        }
    }
}
