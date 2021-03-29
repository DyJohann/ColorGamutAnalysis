using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAlgorithm
{
    public class mSize
    {
        public mSize(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
    }

    public class MatrixA
    {
        public static double[][] InverseMatrix(double[][] matrix)
        {
            //matrix can't be null
            if (matrix == null || matrix.Length == 0)
            {
                return new double[][] { };
            }

            //check for square matrix
            int len = matrix.Length;
            for (int counter = 0; counter < matrix.Length; counter++)
            {
                if (matrix[counter].Length != len)
                {
                    throw new Exception("Need a square matrix");
                }
            }

            //calculate determinant
            double dDeterminant = Determinant(matrix);
            if (Math.Abs(dDeterminant) <= 1E-6)
            {
                throw new Exception("Matrix can be inversed");
            }

            //create adioint mateix
            double[][] result = AdjointMatrix(matrix);

            //divided by determinant
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    result[i][j] = result[i][j] / dDeterminant;
                }
            }

            return result;
        }

 
        public static double Determinant(double[][] matrix)
        {
            if (matrix.Length == 0) return 0;
            else if (matrix.Length == 1) return matrix[0][0];
            else if (matrix.Length == 2)
            {
                return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
            }

            double dSum = 0, dSign = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                double[][] matrixTemp = new double[matrix.Length - 1][];
                for (int count = 0; count < matrix.Length - 1; count++)
                {
                    matrixTemp[count] = new double[matrix.Length - 1];
                }

                for (int j = 0; j < matrixTemp.Length; j++)
                {
                    for (int k = 0; k < matrixTemp.Length; k++)
                    {
                        matrixTemp[j][k] = matrix[j + 1][k >= i ? k + 1 : k];
                    }
                }

                dSum += (matrix[0][i] * dSign * Determinant(matrixTemp));
                dSign = dSign * -1;
            }

            return dSum;
        }


        public static double[][] AdjointMatrix(double[][] matrix)
        {
            double[][] result = new double[matrix.Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new double[matrix[i].Length];
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    double[][] temp = new double[result.Length - 1][];
                    for (int k = 0; k < result.Length - 1; k++)
                    {
                        temp[k] = new double[result[k].Length - 1];
                    }

                    for (int x = 0; x < temp.Length; x++)
                    {
                        for (int y = 0; y < temp.Length; y++)
                        {
                            temp[x][y] = matrix[x < i ? x : x + 1][y < j ? y : y + 1];
                        }
                    }

                    result[j][i] = ((i + j) % 2 == 0 ? 1 : -1) * Determinant(temp);
                }
            }

            return result;
        }

        public static double[][] MatrixTranspose(double[][] matrix)
        {

            double[][] result = new double[matrix[0].GetLength(0)][];
            for (int i = 0; i < matrix[0].GetLength(0); i++)
            {
                result[i] = new double[matrix.GetLength(0)];
            }

            for (int i = 0; i < matrix[0].GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }

        public static double[][] MatrixMulti(double[][] matrix1, double[][] matrix2)
        {
            matrix1.GetLength(0);
            double[][] result = new double[matrix1.GetLength(0)][];
            for (int i = 0; i < matrix1.GetLength(0); i++)
                result[i] = new double[matrix2[0].GetLength(0)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2[0].GetLength(0); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        result[i][j] += matrix1[i][k] * matrix2[k][j];
                    }
                }
            }

            return result;
        }

        public static double[] MatrixMulti(double[][] matrix1, double[] matrix2)
        {
            double[] result = new double[3];

            for (int i = 0; i < 3; i++)
                result[i] = matrix1[i][0] * matrix2[0] + matrix1[i][1] * matrix2[1] + matrix1[i][2] * matrix2[2] + matrix1[i][3] * matrix2[3];

            return result;
        }

        /// <summary>
        /// ---   ---   ---      ---    ---   ---
        /// |   X   |   |           |   |   R   |
        /// |   Y   | = |  Matrix   | * |   G   |
        /// |   Z   |   |           |   |   B   |
        /// ---   ---   ---      ---    ---   ---
        public static double[][] CalculateColorMatrix(double[][] meter,double[][] sensor,bool Offset)
        {
            mSize MatrixSize = Offset ? new mSize(4, 3) : new mSize(3, 3);

            double[][] result = new double[MatrixSize.y][];
            for (int i = 0; i < MatrixSize.y; i++)
                result[i] = new double[MatrixSize.x];

            double[][] RRTI = new double[sensor.GetLength(0)][];
            for (int i = 0; i < sensor.GetLength(0); i++)
                RRTI[i] = new double[sensor.GetLength(0)];

            double[][] RRT = new double[sensor.GetLength(0)][];
            for (int i = 0; i < sensor.GetLength(0); i++)
                RRT[i] = new double[sensor.GetLength(0)];

            double[][] RT = new double[sensor[0].GetLength(0)][];
            for (int i = 0; i < sensor[0].GetLength(0); i++)
                RT[i] = new double[sensor.GetLength(0)];

            double[][] XRT = new double[meter.GetLength(0)][];
            for (int i = 0; i < meter.GetLength(0); i++)
                XRT[i] = new double[sensor.GetLength(0)];

            RT = MatrixTranspose(sensor);
            RRT = MatrixMulti(sensor, RT);
            RRTI = InverseMatrix(RRT);
            XRT = MatrixMulti(meter, RT);
            result = MatrixMulti(XRT, RRTI);

            return result;
        }

        public static double[][] MatrixPower(double[][] m,double Power)
        {
            double[][] mp = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                mp[i] = new double[m[i].Length];
                for (int j = 0; j < m[i].Length; j++)
                    mp[i][j] = Math.Pow(m[i][j], Power);
            }
            return mp;
        }

        public static double[][] MatrixPower(double[][] m, double[] PowerA)
        {
            double[][] mp = new double[m.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                mp[i] = new double[m[i].Length];
                for (int j = 0; j < m[i].Length; j++)
                    mp[i][j] = Math.Pow(m[i][j], PowerA[i]);
            }
            return mp;
        }
    }
}
