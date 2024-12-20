using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using System.Windows.Forms;


namespace Dypl
{

    static internal class Calc
    {
        public static double[] p = new double[23];
        public static double[] solve;
        public static double[] intens1;
        public static double[] intens2;

        public static double[] vir1;
        public static double[] vir2;


        public static double[] SolveMatrixEquation(int i, int n)
        {
            p[n] *= i;

            var vector = Vector<double>.Build.Dense(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });

            var matrix = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { -1 * (p[0] + p[1] + p[2] + p[13] + p[14] + p[15]), p[19], p[20], p[12], p[11], p[10], 0, 0, 0, p[22], 0 },
                { p[13], -1 * (p[19] + p[16]), 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { p[15], 0, -1 * (p[20] + p[18]), 0, 0, 0, 0, 0, 0, 0, 0 },
                { p[2], 0, 0, -1 * (p[12] + p[1] + p[8]), 0, 0, 0, p[11], 0, 0, 0 },
                { p[1], 0, 0, 0, -1 * (p[11] + p[0] + p[2] + p[6] + p[7]), 0, 0, p[12], p[10], 0, 0},
                { p[0], 0, 0, 0, 0, -1 * (p[10] + p[1] + p[3] + p[4]), 0, 0, p[11], 0, 0 },
                { p[14], 0, 0, 0, 0, 0, -p[17], 0, 0, 0, 0 },
                { 0, 0, 0, p[1], p[2], 0, 0, -1 * (p[11] + p[12] + p[9]), 0, 0, 0 },
                { 0, 0, 0, 0, p[0], p[1], 0, 0, -1 * (p[11] + p[10] + p[5]), 0, 0 },
                { 0, p[16], 0, p[8], p[7], p[4], 0, p[9], 0, -p[21], p[22] },
                { 0, 0, p[18], 0, p[6], p[3], p[17], 0, p[5], 0, -p[22] },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            });

            return matrix.Solve(vector).ToArray();
        }
    }
}
