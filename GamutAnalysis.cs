using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MatrixAlgorithm;

namespace ColorGamutAnalysis
{
    class xyY
    {
        public  xyY()
        {
            Lv = 0;
            sx = 0;
            sy = 0;
        }
        public xyY(float sx,float sy,float Lv = 0)
        {
            this.sx = sx;
            this.sy = sy;
            this.Lv = Lv;
        }
        public float Lv;
        public float sx;
        public float sy;
    }

    class CalGamut
    {
        public CalGamut()
        {
            RxyY = new xyY();
            GxyY = new xyY();
            BxyY = new xyY();
            WxyY = new xyY();
        }
        public CalGamut(xyY R,xyY G,xyY B,xyY W)
        {
            RxyY = R;
            GxyY = G;
            BxyY = B;
            WxyY = W;
        }
        public xyY RxyY;
        public xyY GxyY;
        public xyY BxyY;
        public xyY WxyY;
    }

    class StanderGamut
    {
        static public CalGamut NTSC = new CalGamut(new xyY(0.6700f, 0.3300f), new xyY(0.2100f, 0.7100f)
                        , new xyY(0.1400f, 0.0800f), new xyY(0.313f, 0.329f));
        static public CalGamut ADOBE = new CalGamut(new xyY(0.6400f, 0.3300f), new xyY(0.2100f, 0.7100f)
                        , new xyY(0.1500f, 0.0600f), new xyY(0.313f, 0.329f));
    }

    class RadiusAngle
    {
        public RadiusAngle()
        {
            this.Radius = 0.0f;
            this.Angle = 0.0f;
        }
        public float Radius = 0.0f;
        public float Angle = 0.0f;
    }

    class CalCGA
    {
        public enum Gamma
        {
            Adobe=1,sRGB=2,DCIP3=4
        }

        static public float ColorGamut(CalGamut Measure,CalGamut Target)
        {
            float mGamut = Measure.RxyY.sx * Measure.GxyY.sy + Measure.RxyY.sy * Measure.BxyY.sx + Measure.GxyY.sx * Measure.BxyY.sy
                - (Measure.RxyY.sx * Measure.BxyY.sy + Measure.GxyY.sx * Measure.RxyY.sy + Measure.BxyY.sx * Measure.GxyY.sy);
            float tGamut = Target.RxyY.sx * Target.GxyY.sy + Target.RxyY.sy * Target.BxyY.sx + Target.GxyY.sx * Target.BxyY.sy
                - (Target.RxyY.sx * Target.BxyY.sy + Target.GxyY.sx * Target.RxyY.sy + Target.BxyY.sx * Target.GxyY.sy);
            return mGamut / tGamut;
        }

        static private float PointDistance(xyY P1,xyY P2)
        {
            return (float)Math.Sqrt(Math.Pow((double)(P1.sx - P2.sx), 2) + Math.Pow((double)(P1.sy - P2.sy), 2));
        }

        static private float TiltAngle(xyY Measure,xyY Target, xyY RefP)
        {
            PointF Vrt = new PointF(Target.sx - RefP.sx, Target.sy - RefP.sy);
            PointF Vtm = new PointF(Measure.sx - Target.sx, Measure.sy - Target.sy);
            float Lrt = (float)Math.Sqrt(Math.Pow(Vrt.X, 2) + Math.Pow(Vrt.Y, 2));
            float Ltm = (float)Math.Sqrt(Math.Pow(Vtm.X, 2) + Math.Pow(Vtm.Y, 2));
            float CosTheta = (Vrt.X * Vtm.X + Vrt.Y * Vtm.Y) / (Lrt * Ltm);
            return (float)(Math.Acos(CosTheta) * 180.0f / Math.PI);
        }

        static public RadiusAngle[] GamutAngle(CalGamut Measure, CalGamut Target)
        {
            RadiusAngle[] RA = new RadiusAngle[3];
            for (int i = 0; i < 3; i++)
                RA[i] = new RadiusAngle();
            RA[0].Radius = PointDistance(Measure.RxyY, Target.RxyY);
            RA[0].Angle = TiltAngle(Measure.RxyY, Target.RxyY, 
                new xyY((Target.GxyY.sx + Target.BxyY.sx) / 2, (Target.GxyY.sy + Target.BxyY.sy) / 2));

            RA[1].Radius = PointDistance(Measure.GxyY, Target.GxyY);
            RA[1].Angle = TiltAngle(Measure.GxyY, Target.GxyY,
                new xyY((Target.RxyY.sx + Target.BxyY.sx) / 2, (Target.RxyY.sy + Target.BxyY.sy) / 2));

            RA[2].Radius = PointDistance(Measure.BxyY, Target.BxyY);
            RA[2].Angle = TiltAngle(Measure.BxyY, Target.BxyY,
                new xyY((Target.GxyY.sx + Target.RxyY.sx) / 2, (Target.GxyY.sy + Target.RxyY.sy) / 2));

            return RA;
        }

        static public double TargetGamma(int Index,byte Gamut)
        {
            double value = 0.0;
            double di = (double)Index;
            di /= 255.0;
            switch (Gamut)
            {
                case 0x01:
                    value = Math.Pow(di , 2.19921875);
                    break;
                case 0x02:
                    if (di <= 0.03928)
                        value = di / 12.92f;
                    else
                        value = Math.Pow((di + 0.055) / 1.055f, 2.4f);
                    break;
                case 0x04:
                    value = Math.Pow(di, 2.19921875);
                    break;
                default:
                    break;
            }
            return value;
        }

        static public double[][] DeltaE_Target(CalGamut Target,double Gamma,double [][]Pattern)
        {
            double[][] Lab;
            double[][] RGB = new double[3][];
            double[][] invRGB = new double[3][];
            double[][] W = new double[3][];
            double[][] XYZmatrix = new double[3][];
            double[][] XYZ = new double[1][];
            double[][] Tmatrix = new double[3][];
            XYZ[0] = new double[3];
            for (int i = 0; i < RGB.Length; i++)
            {
                RGB[i] = new double[3];
                invRGB[i] = new double[3];
                XYZmatrix[i] = new double[3];
                Tmatrix[i] = new double[3];
                W[i] = new double[1];
            }

            RGB[0][0] = Target.RxyY.sx; RGB[1][0] = Target.RxyY.sy; RGB[2][0] = 1 - (Target.RxyY.sx + Target.RxyY.sy);
            RGB[0][1] = Target.GxyY.sx; RGB[1][1] = Target.GxyY.sy; RGB[2][1] = 1 - (Target.GxyY.sx + Target.GxyY.sy);
            RGB[0][2] = Target.BxyY.sx; RGB[1][2] = Target.BxyY.sy; RGB[2][2] = 1 - (Target.BxyY.sx + Target.BxyY.sy);

            invRGB = MatrixA.InverseMatrix(RGB);

            W[0][0] = Target.WxyY.sx / Target.WxyY.sy;
            W[1][0] = Target.WxyY.sy / Target.WxyY.sy;
            W[2][0] = (1 - Target.WxyY.sx - Target.WxyY.sy) / Target.WxyY.sy;

            XYZ = MatrixAlgorithm.MatrixA.MatrixMulti(invRGB, W);

            for (int i = 0; i < 3; i++)
                XYZmatrix[i][i] = XYZ[i][0];

            Tmatrix = MatrixAlgorithm.MatrixA.MatrixMulti(RGB, XYZmatrix);
            double[][] tPattern = new double[Pattern.Length][];
            Lab = new double[Pattern.Length][];
            double[][] Ttemp = new double[Pattern.Length][];
            for (int i = 0; i < Pattern.Length; i++)
            {
                Lab[i] = new double[3];
                double[][] temp = new double[3][];
                for (int j = 0; j < temp.Length; j++)
                    temp[j] = new double[1];
                tPattern[i] = new double[3];
                for (int j = 0; j < Pattern[0].Length; j++)
                {
                    Pattern[i][j] = Math.Pow(Pattern[i][j] / 255.0, Gamma);
                    temp[j][0] = Pattern[i][j];
                }

                double[][] tt = MatrixA.MatrixTranspose(MatrixA.MatrixMulti(Tmatrix, temp));
                Ttemp[i] = tt[0];

                double[][] fXYZ = new double[1][];
                fXYZ[0] = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    tPattern[i][j] = Ttemp[i][j] / W[j][0];
                    fXYZ[0][j] = tPattern[i][j] <= 0.008856 ?
                        (7.787 * tPattern[i][j]) + (16.0 / 116.0) :
                        Math.Pow(tPattern[i][j], (1.0 / 3.0));
                }
                Lab[i][0] = tPattern[i][1] <= 0.008856 ?
                    9.033 * tPattern[i][1] :
                    1.16 * Math.Pow(tPattern[i][1], (1.0 / 3.0)) - 0.16;
                Lab[i][0] *= 100;
                Lab[i][1] = 500 * (fXYZ[0][0] - fXYZ[0][1]);
                Lab[i][2] = 200 * (fXYZ[0][1] - fXYZ[0][2]);
            }

            return Lab;
        }

        static public double[][] DeltaE_Matrix(CalGamut Target)
        {
            double[][] RGB = new double[3][];
            double[][] invRGB = new double[3][];
            double[][] W = new double[3][];
            double[][] XYZmatrix = new double[3][];
            double[][] XYZ = new double[1][];
            double[][] Tmatrix = new double[3][];
            XYZ[0] = new double[3];
            for (int i = 0; i < RGB.Length; i++)
            {
                RGB[i] = new double[3];
                invRGB[i] = new double[3];
                XYZmatrix[i] = new double[3];
                Tmatrix[i] = new double[3];
                W[i] = new double[1];
            }

            RGB[0][0] = Target.RxyY.sx; RGB[1][0] = Target.RxyY.sy; RGB[2][0] = 1 - (Target.RxyY.sx + Target.RxyY.sy);
            RGB[0][1] = Target.GxyY.sx; RGB[1][1] = Target.GxyY.sy; RGB[2][1] = 1 - (Target.GxyY.sx + Target.GxyY.sy);
            RGB[0][2] = Target.BxyY.sx; RGB[1][2] = Target.BxyY.sy; RGB[2][2] = 1 - (Target.BxyY.sx + Target.BxyY.sy);

            invRGB = MatrixA.InverseMatrix(RGB);

            W[0][0] = Target.WxyY.sx / Target.WxyY.sy;
            W[1][0] = Target.WxyY.sy / Target.WxyY.sy;
            W[2][0] = (1 - Target.WxyY.sx - Target.WxyY.sy) / Target.WxyY.sy;

            XYZ = MatrixAlgorithm.MatrixA.MatrixMulti(invRGB, W);

            for (int i = 0; i < 3; i++)
                XYZmatrix[i][i] = XYZ[i][0];

            Tmatrix = MatrixAlgorithm.MatrixA.MatrixMulti(RGB, XYZmatrix);

            return Tmatrix;
        }

        static public double[][] DeltaE_Target(CalGamut Target, byte gGamma, double[][] Pattern)
        {
            double[][] Lab;
            double[][] RGB = new double[3][];
            double[][] invRGB = new double[3][];
            double[][] W = new double[3][];
            double[][] XYZmatrix = new double[3][];
            double[][] XYZ = new double[1][];
            double[][] Tmatrix = new double[3][];
            XYZ[0] = new double[3];
            for (int i = 0; i < RGB.Length; i++)
            {
                RGB[i] = new double[3];
                invRGB[i] = new double[3];
                XYZmatrix[i] = new double[3];
                Tmatrix[i] = new double[3];
                W[i] = new double[1];
            }

            RGB[0][0] = Target.RxyY.sx; RGB[1][0] = Target.RxyY.sy; RGB[2][0] = 1 - (Target.RxyY.sx + Target.RxyY.sy);
            RGB[0][1] = Target.GxyY.sx; RGB[1][1] = Target.GxyY.sy; RGB[2][1] = 1 - (Target.GxyY.sx + Target.GxyY.sy);
            RGB[0][2] = Target.BxyY.sx; RGB[1][2] = Target.BxyY.sy; RGB[2][2] = 1 - (Target.BxyY.sx + Target.BxyY.sy);

            invRGB = MatrixA.InverseMatrix(RGB);

            W[0][0] = Target.WxyY.sx / Target.WxyY.sy;
            W[1][0] = Target.WxyY.sy / Target.WxyY.sy;
            W[2][0] = (1 - Target.WxyY.sx - Target.WxyY.sy) / Target.WxyY.sy;

            XYZ = MatrixAlgorithm.MatrixA.MatrixMulti(invRGB, W);

            for (int i = 0; i < 3; i++)
                XYZmatrix[i][i] = XYZ[i][0];

            Tmatrix = MatrixAlgorithm.MatrixA.MatrixMulti(RGB, XYZmatrix);
            double[][] tPattern = new double[Pattern.Length][];
            Lab = new double[Pattern.Length][];
            double[][] Ttemp = new double[Pattern.Length][];
            for (int i = 0; i < Pattern.Length; i++)
            {
                Lab[i] = new double[3];
                double[][] temp = new double[3][];
                for (int j = 0; j < temp.Length; j++)
                    temp[j] = new double[1];
                tPattern[i] = new double[3];
                for (int j = 0; j < Pattern[0].Length; j++)
                {
                    Pattern[i][j] = TargetGamma((int)Pattern[i][j], gGamma);
                    temp[j][0] = Pattern[i][j];
                }

                double[][] tt = MatrixA.MatrixTranspose(MatrixA.MatrixMulti(Tmatrix, temp));
                Ttemp[i] = tt[0];

                double[][] fXYZ = new double[1][];
                fXYZ[0] = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    tPattern[i][j] = Ttemp[i][j] / W[j][0];
                    fXYZ[0][j] = tPattern[i][j] <= 0.008856 ?
                        (7.787 * tPattern[i][j]) + (16.0 / 116.0) :
                        Math.Pow(tPattern[i][j], (1.0 / 3.0));
                }
                Lab[i][0] = tPattern[i][1] <= 0.008856 ?
                    9.033 * tPattern[i][1] :
                    1.16 * Math.Pow(tPattern[i][1], (1.0 / 3.0)) - 0.16;
                Lab[i][0] *= 100;
                Lab[i][1] = 500 * (fXYZ[0][0] - fXYZ[0][1]);
                Lab[i][2] = 200 * (fXYZ[0][1] - fXYZ[0][2]);
            }

            return Lab;
        }

    }
}
