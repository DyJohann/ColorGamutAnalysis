using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorGamutAnalysis;
using CalColor;
using MatrixAlgorithm;

namespace ColorGamutAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (rb_NTSC.Checked)
            {
                tb_Rx.Text = StanderGamut.NTSC.RxyY.sx.ToString();
                tb_Ry.Text = StanderGamut.NTSC.RxyY.sy.ToString();

                tb_Gx.Text = StanderGamut.NTSC.GxyY.sx.ToString();
                tb_Gy.Text = StanderGamut.NTSC.GxyY.sy.ToString();

                tb_Bx.Text = StanderGamut.NTSC.BxyY.sx.ToString();
                tb_By.Text = StanderGamut.NTSC.BxyY.sy.ToString();
            }
            else
            {
                tb_Rx.Text = StanderGamut.ADOBE.RxyY.sx.ToString();
                tb_Ry.Text = StanderGamut.ADOBE.RxyY.sy.ToString();

                tb_Gx.Text = StanderGamut.ADOBE.GxyY.sx.ToString();
                tb_Gy.Text = StanderGamut.ADOBE.GxyY.sy.ToString();

                tb_Bx.Text = StanderGamut.ADOBE.BxyY.sx.ToString();
                tb_By.Text = StanderGamut.ADOBE.BxyY.sy.ToString();
            }

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (tb_mRx.Text=="" || tb_mRy.Text == "" || tb_mGx.Text == "" || tb_mGy.Text == "" || tb_mBx.Text == "" || tb_mBy.Text == "")
            {
                MessageBox.Show("Please fill measure point text");
                return;
            }

            CalGamut Measure = new CalGamut(
                new xyY(float.Parse(tb_mRx.Text), float.Parse(tb_mRy.Text)), 
                new xyY(float.Parse(tb_mGx.Text), float.Parse(tb_mGy.Text)),
                new xyY(float.Parse(tb_mBx.Text), float.Parse(tb_mBy.Text)),
                new xyY(0.3126715f, 0.328505f));

            CalGamut Target = new CalGamut(
                new xyY(float.Parse(tb_Rx.Text), float.Parse(tb_Ry.Text)),
                new xyY(float.Parse(tb_Gx.Text), float.Parse(tb_Gy.Text)),
                new xyY(float.Parse(tb_Bx.Text), float.Parse(tb_By.Text)),
                new xyY(0.3126715f, 0.328505f));

            float GamutValue = 0.0f;
            RadiusAngle[] RA = new RadiusAngle[3];
            if (rb_NTSC.Checked)
            {
                GamutValue = CalCGA.ColorGamut(Measure, StanderGamut.NTSC);
                RA = CalCGA.GamutAngle(Measure, StanderGamut.NTSC);
                lab_Gamut.Text = "NTSC(%) : " + (GamutValue * 100).ToString("###.00");
            }
            else if (rb_Adobe.Checked)
            {
                GamutValue = CalCGA.ColorGamut(Measure, StanderGamut.ADOBE);
                RA = CalCGA.GamutAngle(Measure, StanderGamut.ADOBE);
                lab_Gamut.Text = "Adobe(%) : " + (GamutValue * 100).ToString("###.00");
            }
            else
            {
                GamutValue = CalCGA.ColorGamut(Measure, Target);
                RA = CalCGA.GamutAngle(Measure, Target);
                lab_Gamut.Text = "Gamut(%) : " + (GamutValue * 100).ToString("###.00");
            }
            lab_Rtilt.Text = "R (r,theta) : " + RA[0].Radius.ToString("0.0000") + ", " + RA[0].Angle.ToString("###.00");
            lab_Gtilt.Text = "G (r,theta) : " + RA[1].Radius.ToString("0.0000") + ", " + RA[1].Angle.ToString("###.00");
            lab_Btilt.Text = "B (r,theta) : " + RA[2].Radius.ToString("0.0000") + ", " + RA[2].Angle.ToString("###.00");
        }

        private void rb_Adobe_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_NTSC.Checked)
            {
                tb_Rx.Text = StanderGamut.NTSC.RxyY.sx.ToString();
                tb_Ry.Text = StanderGamut.NTSC.RxyY.sy.ToString();

                tb_Gx.Text = StanderGamut.NTSC.GxyY.sx.ToString();
                tb_Gy.Text = StanderGamut.NTSC.GxyY.sy.ToString();

                tb_Bx.Text = StanderGamut.NTSC.BxyY.sx.ToString();
                tb_By.Text = StanderGamut.NTSC.BxyY.sy.ToString();
            }
            else
            {
                tb_Rx.Text = StanderGamut.ADOBE.RxyY.sx.ToString();
                tb_Ry.Text = StanderGamut.ADOBE.RxyY.sy.ToString();

                tb_Gx.Text = StanderGamut.ADOBE.GxyY.sx.ToString();
                tb_Gy.Text = StanderGamut.ADOBE.GxyY.sy.ToString();

                tb_Bx.Text = StanderGamut.ADOBE.BxyY.sx.ToString();
                tb_By.Text = StanderGamut.ADOBE.BxyY.sy.ToString();
            }
        }

        double [][]De32Pattern()
        {
            double[][] Pattern = new double[32][];

            ///W
            Pattern[0] = new double[3] { 32, 32, 32 };
            Pattern[1] = new double[3] { 64, 64, 64 };
            Pattern[2] = new double[3] { 96, 96, 96 };
            Pattern[3] = new double[3] { 128, 128, 128 };
            Pattern[4] = new double[3] { 160, 160, 160 };
            Pattern[5] = new double[3] { 192, 192, 192 };
            Pattern[6] = new double[3] { 224, 224, 224 };
            Pattern[7] = new double[3] { 255, 255, 255 };
            ///Color
            Pattern[8] = new double[3] { 128, 0, 0 };
            Pattern[9] = new double[3] { 192, 64, 64 };
            Pattern[10] = new double[3] { 255, 0, 0 };
            Pattern[11] = new double[3] { 255, 128, 128 };

            Pattern[12] = new double[3] { 0, 128, 0 };
            Pattern[13] = new double[3] { 64, 192, 64 };
            Pattern[14] = new double[3] { 0, 255, 0 };
            Pattern[15] = new double[3] { 128, 255, 128 };

            Pattern[16] = new double[3] { 0, 0, 128 };
            Pattern[17] = new double[3] { 64, 64, 192 };
            Pattern[18] = new double[3] { 0, 0, 255 };
            Pattern[19] = new double[3] { 128, 128, 255 };

            Pattern[20] = new double[3] { 128, 128, 0 };
            Pattern[21] = new double[3] { 192, 192, 64 };
            Pattern[22] = new double[3] { 255, 255, 0 };
            Pattern[23] = new double[3] { 255, 255, 128 };

            Pattern[24] = new double[3] { 128, 0, 128 };
            Pattern[25] = new double[3] { 192, 64, 192 };
            Pattern[26] = new double[3] { 255, 0, 255 };
            Pattern[27] = new double[3] { 255, 128, 255 };

            Pattern[28] = new double[3] { 0, 128, 128 };
            Pattern[29] = new double[3] { 64, 192, 192 };
            Pattern[30] = new double[3] { 0, 255, 255 };
            Pattern[31] = new double[3] { 128, 255, 255 };

            return Pattern;
        }

        private void btn_Lab_Click(object sender, EventArgs e)
        {
            ///Adobe RGB
            //acerGamut Target =
            //    new acerGamut(new xyY(0.64f, 0.33f), new xyY(0.21f, 0.71f),
            //    new xyY(0.15f, 0.06f), new xyY(0.313f, 0.329f));

            /// sRGB
            //acerGamut Target =
            //    new acerGamut(new xyY(0.64f, 0.33f), new xyY(0.3f, 0.6f),
            //    new xyY(0.15f, 0.06f), new xyY(0.313f, 0.329f));

            ///DCI-P3
            //acerGamut Target =
            //    new acerGamut(new xyY(0.68f, 0.32f), new xyY(0.265f, 0.69f),
            //    new xyY(0.15f, 0.06f), new xyY(0.313f, 0.329f));

            CalGamut Target =
                new CalGamut(
                    new xyY(float.Parse(tb_lab_Rx.Text), float.Parse(tb_lab_Ry.Text)),
                    new xyY(float.Parse(tb_lab_Gx.Text), float.Parse(tb_lab_Gy.Text)),
                    new xyY(float.Parse(tb_lab_Bx.Text), float.Parse(tb_lab_By.Text)),
                    new xyY(float.Parse(tb_lab_Wx.Text), float.Parse(tb_lab_Wy.Text)));

            double GammaV = 2.2;

            if (rb_aRGB.Checked)
                GammaV = 2.19921875;
            else if (rb_other.Checked)
            {
                tb_other.Text = tb_other.Text == "" ? "2.2" : tb_other.Text;
                GammaV = double.Parse(tb_other.Text);
            }
                

            double[][] Pattern = De32Pattern();

            double[][] Tmatrix = CalCGA.DeltaE_Matrix(Target);

            for (int i = 0; i < Tmatrix.Length; i++)
            {
                for (int j = 0; j < Tmatrix[0].Length; j++)
                    Console.Write(Tmatrix[i][j].ToString("0.0000") + ", ");
                Console.WriteLine();
            }

            double[][] LabValue;
            if (rb_srgb.Checked)
                LabValue = CalCGA.DeltaE_Target(Target, 0x02, Pattern);
            else
                LabValue = CalCGA.DeltaE_Target(Target, GammaV, Pattern);

            string sFile = tb_savefile.Text == "" ? "LabFile" : tb_savefile.Text;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(sFile + ".csv");
            sw.WriteLine("NO,L,a,b");
            for (int i = 0; i < LabValue.Length; i++)
                sw.WriteLine(i.ToString() + "," + LabValue[i][0].ToString("##.00") + ","
                    + LabValue[i][1].ToString("##.00") + "," + LabValue[i][2].ToString("##.00"));
            sw.Close();
            MessageBox.Show("Done!");
        }

        private void rb_other_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_other.Checked)
                tb_other.Visible = true;
            else
                tb_other.Visible = false;
        }

    }
}
