using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalColor
{

    class ScalarC
    {
        public ScalarC()
        {
            R = 0;
            G = 0;
            B = 0;
        }

        public ScalarC(byte R,byte G,byte B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public byte R;
        public byte G;
        public byte B;
    }

    public class CTclass
    {
        public CTclass()
        {
            X = 0;
            Y = 0;
            Z = 0;
            sx = 0;
            sy = 0;
            CT = 0;
            No = 0;
            this.ud = 0;
            this.vd = 0;
            this.duv = 0;
        }

        public CTclass(float X, float Y, float Z, float sx, float sy)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.sx = sx;
            this.sy = sy;
            this.ud = 0;
            this.vd = 0;
            this.duv = 0;
        }

        public float X;
        public float Y;
        public float Z;
        public float sx;
        public float sy;
        public float CT;
        public float ud;
        public float vd;
        public float duv;
        public float No;
    }

    public static class CTconvert
    {
        public static double xy2CT(double sx,double sy)
        {
            double CT = 0;
            double[,] table = new double[31, 4];
            double U = 0, V = 0, den = 0, d = 0, D1 = 0, D2 = 0;
            int i = 0;

            {
                table[0, 0] = 10000000000;
                table[0, 1] = 0.18006;
                table[0, 2] = 0.26352;
                table[0, 3] = -0.24341;
                table[1, 0] = 100000;
                table[1, 1] = 0.18066;
                table[1, 2] = 0.26589;
                table[1, 3] = -0.25479;
                table[2, 0] = 50000;
                table[2, 1] = 0.18133;
                table[2, 2] = 0.26848; table[2, 3] = -0.26876;
                table[3, 0] = 33333;
                table[3, 1] = 0.18208;
                table[3, 2] = 0.27119;
                table[3, 3] = -0.28539;
                table[4, 0] = 25000;
                table[4, 1] = 0.18293;
                table[4, 2] = 0.27404;
                table[4, 3] = -0.3047;
                table[5, 0] = 20000;
                table[5, 1] = 0.18388;
                table[5, 2] = 0.27709;
                table[5, 3] = -0.32675;
                table[6, 0] = 16667;
                table[6, 1] = 0.18494;
                table[6, 2] = 0.28021;
                table[6, 3] = -0.35156;
                table[7, 0] = 14286;
                table[7, 1] = 0.18611;
                table[7, 2] = 0.28342;
                table[7, 3] = -0.37915;
                table[8, 0] = 12500;
                table[8, 1] = 0.1874;
                table[8, 2] = 0.28668;
                table[8, 3] = -0.40955;
                table[9, 0] = 11111;
                table[9, 1] = 0.1888;
                table[9, 2] = 0.28997;
                table[9, 3] = -0.44278;
                table[10, 0] = 10000;
                table[10, 1] = 0.19032;
                table[10, 2] = 0.29326;
                table[10, 3] = -0.47888;
                table[11, 0] = 8000;
                table[11, 1] = 0.19462;
                table[11, 2] = 0.30141;
                table[11, 3] = -0.58204;
                table[12, 0] = 6667;
                table[12, 1] = 0.19962;
                table[12, 2] = 0.30921;
                table[12, 3] = -0.70471;
                table[13, 0] = 5714;
                table[13, 1] = 0.20525;
                table[13, 2] = 0.31647;
                table[13, 3] = -0.84901;
                table[14, 0] = 5000;
                table[14, 1] = 0.21142;
                table[14, 2] = 0.32312;
                table[14, 3] = -1.0182;
                table[15, 0] = 4444;
                table[15, 1] = 0.21807;
                table[15, 2] = 0.32909;
                table[15, 3] = -1.2168;
                table[16, 0] = 4000;
                table[16, 1] = 0.22511;
                table[16, 2] = 0.33439;
                table[16, 3] = -1.4512;
                table[17, 0] = 3636;
                table[17, 1] = 0.23247;
                table[17, 2] = 0.33904;
                table[17, 3] = -1.7298;
                table[18, 0] = 3333;
                table[18, 1] = 0.2401;
                table[18, 2] = 0.34308;
                table[18, 3] = -2.0637;
                table[19, 0] = 3077;
                table[19, 1] = 0.24702;
                table[19, 2] = 0.34655;
                table[19, 3] = -2.4681;
                table[20, 0] = 2857;
                table[20, 1] = 0.25591;
                table[20, 2] = 0.34951;
                table[20, 3] = -2.9641;
                table[21, 0] = 2677;
                table[21, 1] = 0.264;
                table[21, 2] = 0.352;
                table[21, 3] = -3.5814;
                table[22, 0] = 2500;
                table[22, 1] = 0.27218;
                table[22, 2] = 0.35407;
                table[22, 3] = -4.3633;
                table[23, 0] = 2353;
                table[23, 1] = 0.28039;
                table[23, 2] = 0.35577;
                table[23, 3] = -5.3762;
                table[24, 0] = 2222;
                table[24, 1] = 0.28863;
                table[24, 2] = 0.35714;
                table[24, 3] = -6.7262;
                table[25, 0] = 2105;
                table[25, 1] = 0.29658;
                table[25, 2] = 0.35823;
                table[25, 3] = -8.5955;
                table[26, 0] = 2000;
                table[26, 1] = 0.30505;
                table[26, 2] = 0.35907;
                table[26, 3] = -11.324;
                table[27, 0] = 1905;
                table[27, 1] = 0.3132;
                table[27, 2] = 0.35968;
                table[27, 3] = -15.628;
                table[28, 0] = 1818;
                table[28, 1] = 0.32129;
                table[28, 2] = 0.36011;
                table[28, 3] = -23.325;
                table[29, 0] = 1739;
                table[29, 1] = 0.32931;
                table[29, 2] = 0.36038;
                table[29, 3] = -40.77;
                table[30, 0] = 1667;
                table[30, 1] = 0.33724;
                table[30, 2] = 0.36051;
                table[30, 3] = -116.45;
            }
            den = 12 * sy - 2 * sx + 3;
            U = Math.Floor(10000 * (4 * sx / den) + 0.5) / 10000;
            V = Math.Floor(10000 * (9 * sy / den) + 0.5) / 10000;

            V = V / 1.5;
            d = 1;
            D2 = ((V - table[0,2]) - table[0,3] * (U - table[0,1])) / Math.Sqrt(1 + Math.Pow(table[0,3], 2));
            i = -1;

            while ((i < 29) && (d >= 0))
            {
                i++;
                D1 = D2;
                D2 = ((V - table[i + 1,2]) - (table[i + 1,3] * (U - table[i + 1,1]))) / Math.Sqrt(1 + Math.Pow(table[i + 1,3], 2));
                d = D2 / D1;
            }
            if ((i == 29) && (d >= 0))
            {
                return -1;
            }
            else
            {
                CT = Math.Floor(1 / (1 / table[i,0] + D1 / (D1 - D2) * (1 / table[i + 1,0] - 1 / table[i,0])) + 0.5);

                return CT;
            }

        }
    }

}
