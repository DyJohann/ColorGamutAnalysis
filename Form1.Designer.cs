namespace ColorGamutAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculate = new System.Windows.Forms.Button();
            this.gb_ref = new System.Windows.Forms.GroupBox();
            this.rb_rfOther = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_By = new System.Windows.Forms.TextBox();
            this.tb_Gy = new System.Windows.Forms.TextBox();
            this.tb_Bx = new System.Windows.Forms.TextBox();
            this.tb_Gx = new System.Windows.Forms.TextBox();
            this.tb_Ry = new System.Windows.Forms.TextBox();
            this.tb_Rx = new System.Windows.Forms.TextBox();
            this.lab_B = new System.Windows.Forms.Label();
            this.lab_G = new System.Windows.Forms.Label();
            this.lab_R = new System.Windows.Forms.Label();
            this.rb_Adobe = new System.Windows.Forms.RadioButton();
            this.rb_NTSC = new System.Windows.Forms.RadioButton();
            this.gb_Measure = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_mBy = new System.Windows.Forms.TextBox();
            this.tb_mGy = new System.Windows.Forms.TextBox();
            this.tb_mBx = new System.Windows.Forms.TextBox();
            this.tb_mGx = new System.Windows.Forms.TextBox();
            this.tb_mRy = new System.Windows.Forms.TextBox();
            this.tb_mRx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Gamut = new System.Windows.Forms.Label();
            this.lab_Rtilt = new System.Windows.Forms.Label();
            this.lab_Gtilt = new System.Windows.Forms.Label();
            this.lab_Btilt = new System.Windows.Forms.Label();
            this.btn_Lab = new System.Windows.Forms.Button();
            this.gb_xy2Lab = new System.Windows.Forms.GroupBox();
            this.tb_other = new System.Windows.Forms.TextBox();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.rb_srgb = new System.Windows.Forms.RadioButton();
            this.rb_aRGB = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_savefile = new System.Windows.Forms.TextBox();
            this.tb_lab_Wy = new System.Windows.Forms.TextBox();
            this.tb_lab_Wx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_lab_By = new System.Windows.Forms.TextBox();
            this.tb_lab_Gy = new System.Windows.Forms.TextBox();
            this.tb_lab_Bx = new System.Windows.Forms.TextBox();
            this.tb_lab_Gx = new System.Windows.Forms.TextBox();
            this.tb_lab_Ry = new System.Windows.Forms.TextBox();
            this.tb_lab_Rx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_ref.SuspendLayout();
            this.gb_Measure.SuspendLayout();
            this.gb_xy2Lab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(552, 39);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(254, 59);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // gb_ref
            // 
            this.gb_ref.Controls.Add(this.rb_rfOther);
            this.gb_ref.Controls.Add(this.label5);
            this.gb_ref.Controls.Add(this.label4);
            this.gb_ref.Controls.Add(this.tb_By);
            this.gb_ref.Controls.Add(this.tb_Gy);
            this.gb_ref.Controls.Add(this.tb_Bx);
            this.gb_ref.Controls.Add(this.tb_Gx);
            this.gb_ref.Controls.Add(this.tb_Ry);
            this.gb_ref.Controls.Add(this.tb_Rx);
            this.gb_ref.Controls.Add(this.lab_B);
            this.gb_ref.Controls.Add(this.lab_G);
            this.gb_ref.Controls.Add(this.lab_R);
            this.gb_ref.Controls.Add(this.rb_Adobe);
            this.gb_ref.Controls.Add(this.rb_NTSC);
            this.gb_ref.Location = new System.Drawing.Point(12, 12);
            this.gb_ref.Name = "gb_ref";
            this.gb_ref.Size = new System.Drawing.Size(470, 353);
            this.gb_ref.TabIndex = 1;
            this.gb_ref.TabStop = false;
            this.gb_ref.Text = "Ref. Point";
            // 
            // rb_rfOther
            // 
            this.rb_rfOther.AutoSize = true;
            this.rb_rfOther.Location = new System.Drawing.Point(291, 52);
            this.rb_rfOther.Name = "rb_rfOther";
            this.rb_rfOther.Size = new System.Drawing.Size(114, 34);
            this.rb_rfOther.TabIndex = 17;
            this.rb_rfOther.Text = "Other";
            this.rb_rfOther.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "sy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "sx";
            // 
            // tb_By
            // 
            this.tb_By.Location = new System.Drawing.Point(287, 285);
            this.tb_By.Name = "tb_By";
            this.tb_By.Size = new System.Drawing.Size(129, 43);
            this.tb_By.TabIndex = 9;
            this.tb_By.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Gy
            // 
            this.tb_Gy.Location = new System.Drawing.Point(287, 226);
            this.tb_Gy.Name = "tb_Gy";
            this.tb_Gy.Size = new System.Drawing.Size(129, 43);
            this.tb_Gy.TabIndex = 8;
            this.tb_Gy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Bx
            // 
            this.tb_Bx.Location = new System.Drawing.Point(121, 282);
            this.tb_Bx.Name = "tb_Bx";
            this.tb_Bx.Size = new System.Drawing.Size(129, 43);
            this.tb_Bx.TabIndex = 7;
            this.tb_Bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Gx
            // 
            this.tb_Gx.Location = new System.Drawing.Point(121, 226);
            this.tb_Gx.Name = "tb_Gx";
            this.tb_Gx.Size = new System.Drawing.Size(129, 43);
            this.tb_Gx.TabIndex = 6;
            this.tb_Gx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ry
            // 
            this.tb_Ry.Location = new System.Drawing.Point(287, 169);
            this.tb_Ry.Name = "tb_Ry";
            this.tb_Ry.Size = new System.Drawing.Size(129, 43);
            this.tb_Ry.TabIndex = 5;
            this.tb_Ry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Rx
            // 
            this.tb_Rx.Location = new System.Drawing.Point(121, 169);
            this.tb_Rx.Name = "tb_Rx";
            this.tb_Rx.Size = new System.Drawing.Size(129, 43);
            this.tb_Rx.TabIndex = 2;
            this.tb_Rx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_B
            // 
            this.lab_B.AutoSize = true;
            this.lab_B.Location = new System.Drawing.Point(6, 285);
            this.lab_B.Name = "lab_B";
            this.lab_B.Size = new System.Drawing.Size(67, 30);
            this.lab_B.TabIndex = 4;
            this.lab_B.Text = "Blue";
            // 
            // lab_G
            // 
            this.lab_G.AutoSize = true;
            this.lab_G.Location = new System.Drawing.Point(6, 229);
            this.lab_G.Name = "lab_G";
            this.lab_G.Size = new System.Drawing.Size(82, 30);
            this.lab_G.TabIndex = 3;
            this.lab_G.Text = "Green";
            // 
            // lab_R
            // 
            this.lab_R.AutoSize = true;
            this.lab_R.Location = new System.Drawing.Point(6, 172);
            this.lab_R.Name = "lab_R";
            this.lab_R.Size = new System.Drawing.Size(59, 30);
            this.lab_R.TabIndex = 2;
            this.lab_R.Text = "Red";
            // 
            // rb_Adobe
            // 
            this.rb_Adobe.AutoSize = true;
            this.rb_Adobe.Checked = true;
            this.rb_Adobe.Location = new System.Drawing.Point(150, 52);
            this.rb_Adobe.Name = "rb_Adobe";
            this.rb_Adobe.Size = new System.Drawing.Size(125, 34);
            this.rb_Adobe.TabIndex = 1;
            this.rb_Adobe.TabStop = true;
            this.rb_Adobe.Text = "Adobe";
            this.rb_Adobe.UseVisualStyleBackColor = true;
            this.rb_Adobe.CheckedChanged += new System.EventHandler(this.rb_Adobe_CheckedChanged);
            // 
            // rb_NTSC
            // 
            this.rb_NTSC.AutoSize = true;
            this.rb_NTSC.Location = new System.Drawing.Point(11, 52);
            this.rb_NTSC.Name = "rb_NTSC";
            this.rb_NTSC.Size = new System.Drawing.Size(122, 34);
            this.rb_NTSC.TabIndex = 0;
            this.rb_NTSC.Text = "NTSC";
            this.rb_NTSC.UseVisualStyleBackColor = true;
            // 
            // gb_Measure
            // 
            this.gb_Measure.Controls.Add(this.label6);
            this.gb_Measure.Controls.Add(this.label7);
            this.gb_Measure.Controls.Add(this.tb_mBy);
            this.gb_Measure.Controls.Add(this.tb_mGy);
            this.gb_Measure.Controls.Add(this.tb_mBx);
            this.gb_Measure.Controls.Add(this.tb_mGx);
            this.gb_Measure.Controls.Add(this.tb_mRy);
            this.gb_Measure.Controls.Add(this.tb_mRx);
            this.gb_Measure.Controls.Add(this.label1);
            this.gb_Measure.Controls.Add(this.label2);
            this.gb_Measure.Controls.Add(this.label3);
            this.gb_Measure.Location = new System.Drawing.Point(12, 392);
            this.gb_Measure.Name = "gb_Measure";
            this.gb_Measure.Size = new System.Drawing.Size(470, 353);
            this.gb_Measure.TabIndex = 10;
            this.gb_Measure.TabStop = false;
            this.gb_Measure.Text = "Measure Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "sy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "sx";
            // 
            // tb_mBy
            // 
            this.tb_mBy.Location = new System.Drawing.Point(287, 285);
            this.tb_mBy.Name = "tb_mBy";
            this.tb_mBy.Size = new System.Drawing.Size(129, 43);
            this.tb_mBy.TabIndex = 9;
            this.tb_mBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mGy
            // 
            this.tb_mGy.Location = new System.Drawing.Point(287, 226);
            this.tb_mGy.Name = "tb_mGy";
            this.tb_mGy.Size = new System.Drawing.Size(129, 43);
            this.tb_mGy.TabIndex = 8;
            this.tb_mGy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mBx
            // 
            this.tb_mBx.Location = new System.Drawing.Point(121, 282);
            this.tb_mBx.Name = "tb_mBx";
            this.tb_mBx.Size = new System.Drawing.Size(129, 43);
            this.tb_mBx.TabIndex = 7;
            this.tb_mBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mGx
            // 
            this.tb_mGx.Location = new System.Drawing.Point(121, 226);
            this.tb_mGx.Name = "tb_mGx";
            this.tb_mGx.Size = new System.Drawing.Size(129, 43);
            this.tb_mGx.TabIndex = 6;
            this.tb_mGx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mRy
            // 
            this.tb_mRy.Location = new System.Drawing.Point(287, 169);
            this.tb_mRy.Name = "tb_mRy";
            this.tb_mRy.Size = new System.Drawing.Size(129, 43);
            this.tb_mRy.TabIndex = 5;
            this.tb_mRy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_mRx
            // 
            this.tb_mRx.Location = new System.Drawing.Point(121, 169);
            this.tb_mRx.Name = "tb_mRx";
            this.tb_mRx.Size = new System.Drawing.Size(129, 43);
            this.tb_mRx.TabIndex = 2;
            this.tb_mRx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red";
            // 
            // lab_Gamut
            // 
            this.lab_Gamut.AutoSize = true;
            this.lab_Gamut.Location = new System.Drawing.Point(547, 150);
            this.lab_Gamut.Name = "lab_Gamut";
            this.lab_Gamut.Size = new System.Drawing.Size(150, 30);
            this.lab_Gamut.TabIndex = 11;
            this.lab_Gamut.Text = "NTSC (%) :";
            // 
            // lab_Rtilt
            // 
            this.lab_Rtilt.AutoSize = true;
            this.lab_Rtilt.Location = new System.Drawing.Point(547, 213);
            this.lab_Rtilt.Name = "lab_Rtilt";
            this.lab_Rtilt.Size = new System.Drawing.Size(154, 30);
            this.lab_Rtilt.TabIndex = 12;
            this.lab_Rtilt.Text = "R (r,theta) : ";
            // 
            // lab_Gtilt
            // 
            this.lab_Gtilt.AutoSize = true;
            this.lab_Gtilt.Location = new System.Drawing.Point(547, 262);
            this.lab_Gtilt.Name = "lab_Gtilt";
            this.lab_Gtilt.Size = new System.Drawing.Size(155, 30);
            this.lab_Gtilt.TabIndex = 13;
            this.lab_Gtilt.Text = "G (r,theta) : ";
            // 
            // lab_Btilt
            // 
            this.lab_Btilt.AutoSize = true;
            this.lab_Btilt.Location = new System.Drawing.Point(547, 310);
            this.lab_Btilt.Name = "lab_Btilt";
            this.lab_Btilt.Size = new System.Drawing.Size(154, 30);
            this.lab_Btilt.TabIndex = 14;
            this.lab_Btilt.Text = "B (r,theta) : ";
            // 
            // btn_Lab
            // 
            this.btn_Lab.Location = new System.Drawing.Point(530, 332);
            this.btn_Lab.Name = "btn_Lab";
            this.btn_Lab.Size = new System.Drawing.Size(210, 48);
            this.btn_Lab.TabIndex = 15;
            this.btn_Lab.Text = "xy2Lab";
            this.btn_Lab.UseVisualStyleBackColor = true;
            this.btn_Lab.Click += new System.EventHandler(this.btn_Lab_Click);
            // 
            // gb_xy2Lab
            // 
            this.gb_xy2Lab.Controls.Add(this.tb_other);
            this.gb_xy2Lab.Controls.Add(this.rb_other);
            this.gb_xy2Lab.Controls.Add(this.rb_srgb);
            this.gb_xy2Lab.Controls.Add(this.rb_aRGB);
            this.gb_xy2Lab.Controls.Add(this.label15);
            this.gb_xy2Lab.Controls.Add(this.label14);
            this.gb_xy2Lab.Controls.Add(this.tb_savefile);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Wy);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Wx);
            this.gb_xy2Lab.Controls.Add(this.label13);
            this.gb_xy2Lab.Controls.Add(this.label8);
            this.gb_xy2Lab.Controls.Add(this.label9);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_By);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Gy);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Bx);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Gx);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Ry);
            this.gb_xy2Lab.Controls.Add(this.tb_lab_Rx);
            this.gb_xy2Lab.Controls.Add(this.label10);
            this.gb_xy2Lab.Controls.Add(this.label11);
            this.gb_xy2Lab.Controls.Add(this.label12);
            this.gb_xy2Lab.Controls.Add(this.btn_Lab);
            this.gb_xy2Lab.Location = new System.Drawing.Point(552, 392);
            this.gb_xy2Lab.Name = "gb_xy2Lab";
            this.gb_xy2Lab.Size = new System.Drawing.Size(793, 395);
            this.gb_xy2Lab.TabIndex = 16;
            this.gb_xy2Lab.TabStop = false;
            this.gb_xy2Lab.Text = "xy2Lab";
            // 
            // tb_other
            // 
            this.tb_other.Location = new System.Drawing.Point(672, 170);
            this.tb_other.Name = "tb_other";
            this.tb_other.Size = new System.Drawing.Size(96, 43);
            this.tb_other.TabIndex = 39;
            this.tb_other.Text = "2.2";
            this.tb_other.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_other.Visible = false;
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Location = new System.Drawing.Point(530, 172);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(114, 34);
            this.rb_other.TabIndex = 38;
            this.rb_other.Text = "Other";
            this.rb_other.UseVisualStyleBackColor = true;
            this.rb_other.CheckedChanged += new System.EventHandler(this.rb_other_CheckedChanged);
            // 
            // rb_srgb
            // 
            this.rb_srgb.AutoSize = true;
            this.rb_srgb.Location = new System.Drawing.Point(530, 131);
            this.rb_srgb.Name = "rb_srgb";
            this.rb_srgb.Size = new System.Drawing.Size(119, 34);
            this.rb_srgb.TabIndex = 37;
            this.rb_srgb.Text = "sRGB";
            this.rb_srgb.UseVisualStyleBackColor = true;
            // 
            // rb_aRGB
            // 
            this.rb_aRGB.AutoSize = true;
            this.rb_aRGB.Checked = true;
            this.rb_aRGB.Location = new System.Drawing.Point(530, 91);
            this.rb_aRGB.Name = "rb_aRGB";
            this.rb_aRGB.Size = new System.Drawing.Size(191, 34);
            this.rb_aRGB.TabIndex = 36;
            this.rb_aRGB.TabStop = true;
            this.rb_aRGB.Text = "Adobe RGB";
            this.rb_aRGB.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(525, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 30);
            this.label15.TabIndex = 35;
            this.label15.Text = "Gamma : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(525, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "Save File";
            // 
            // tb_savefile
            // 
            this.tb_savefile.Location = new System.Drawing.Point(530, 282);
            this.tb_savefile.Name = "tb_savefile";
            this.tb_savefile.Size = new System.Drawing.Size(210, 43);
            this.tb_savefile.TabIndex = 33;
            this.tb_savefile.Text = "xy2Lab";
            this.tb_savefile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Wy
            // 
            this.tb_lab_Wy.Location = new System.Drawing.Point(302, 341);
            this.tb_lab_Wy.Name = "tb_lab_Wy";
            this.tb_lab_Wy.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Wy.TabIndex = 32;
            this.tb_lab_Wy.Text = "0.329";
            this.tb_lab_Wy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Wx
            // 
            this.tb_lab_Wx.Location = new System.Drawing.Point(136, 338);
            this.tb_lab_Wx.Name = "tb_lab_Wx";
            this.tb_lab_Wx.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Wx.TabIndex = 31;
            this.tb_lab_Wx.Text = "0.313";
            this.tb_lab_Wx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 30);
            this.label13.TabIndex = 30;
            this.label13.Text = "White";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "sy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 30);
            this.label9.TabIndex = 28;
            this.label9.Text = "sx";
            // 
            // tb_lab_By
            // 
            this.tb_lab_By.Location = new System.Drawing.Point(302, 285);
            this.tb_lab_By.Name = "tb_lab_By";
            this.tb_lab_By.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_By.TabIndex = 27;
            this.tb_lab_By.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Gy
            // 
            this.tb_lab_Gy.Location = new System.Drawing.Point(302, 226);
            this.tb_lab_Gy.Name = "tb_lab_Gy";
            this.tb_lab_Gy.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Gy.TabIndex = 26;
            this.tb_lab_Gy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Bx
            // 
            this.tb_lab_Bx.Location = new System.Drawing.Point(136, 282);
            this.tb_lab_Bx.Name = "tb_lab_Bx";
            this.tb_lab_Bx.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Bx.TabIndex = 25;
            this.tb_lab_Bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Gx
            // 
            this.tb_lab_Gx.Location = new System.Drawing.Point(136, 226);
            this.tb_lab_Gx.Name = "tb_lab_Gx";
            this.tb_lab_Gx.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Gx.TabIndex = 24;
            this.tb_lab_Gx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Ry
            // 
            this.tb_lab_Ry.Location = new System.Drawing.Point(302, 169);
            this.tb_lab_Ry.Name = "tb_lab_Ry";
            this.tb_lab_Ry.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Ry.TabIndex = 23;
            this.tb_lab_Ry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lab_Rx
            // 
            this.tb_lab_Rx.Location = new System.Drawing.Point(136, 169);
            this.tb_lab_Rx.Name = "tb_lab_Rx";
            this.tb_lab_Rx.Size = new System.Drawing.Size(129, 43);
            this.tb_lab_Rx.TabIndex = 19;
            this.tb_lab_Rx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 30);
            this.label10.TabIndex = 22;
            this.label10.Text = "Blue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Green";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "Red";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 799);
            this.Controls.Add(this.gb_xy2Lab);
            this.Controls.Add(this.lab_Btilt);
            this.Controls.Add(this.lab_Gtilt);
            this.Controls.Add(this.lab_Rtilt);
            this.Controls.Add(this.lab_Gamut);
            this.Controls.Add(this.gb_Measure);
            this.Controls.Add(this.gb_ref);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_ref.ResumeLayout(false);
            this.gb_ref.PerformLayout();
            this.gb_Measure.ResumeLayout(false);
            this.gb_Measure.PerformLayout();
            this.gb_xy2Lab.ResumeLayout(false);
            this.gb_xy2Lab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox gb_ref;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_By;
        private System.Windows.Forms.TextBox tb_Gy;
        private System.Windows.Forms.TextBox tb_Bx;
        private System.Windows.Forms.TextBox tb_Gx;
        private System.Windows.Forms.TextBox tb_Ry;
        private System.Windows.Forms.TextBox tb_Rx;
        private System.Windows.Forms.Label lab_B;
        private System.Windows.Forms.Label lab_G;
        private System.Windows.Forms.Label lab_R;
        private System.Windows.Forms.RadioButton rb_Adobe;
        private System.Windows.Forms.RadioButton rb_NTSC;
        private System.Windows.Forms.GroupBox gb_Measure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_mBy;
        private System.Windows.Forms.TextBox tb_mGy;
        private System.Windows.Forms.TextBox tb_mBx;
        private System.Windows.Forms.TextBox tb_mGx;
        private System.Windows.Forms.TextBox tb_mRy;
        private System.Windows.Forms.TextBox tb_mRx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_Gamut;
        private System.Windows.Forms.Label lab_Rtilt;
        private System.Windows.Forms.Label lab_Gtilt;
        private System.Windows.Forms.Label lab_Btilt;
        private System.Windows.Forms.Button btn_Lab;
        private System.Windows.Forms.GroupBox gb_xy2Lab;
        private System.Windows.Forms.TextBox tb_other;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.RadioButton rb_srgb;
        private System.Windows.Forms.RadioButton rb_aRGB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_savefile;
        private System.Windows.Forms.TextBox tb_lab_Wy;
        private System.Windows.Forms.TextBox tb_lab_Wx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_lab_By;
        private System.Windows.Forms.TextBox tb_lab_Gy;
        private System.Windows.Forms.TextBox tb_lab_Bx;
        private System.Windows.Forms.TextBox tb_lab_Gx;
        private System.Windows.Forms.TextBox tb_lab_Ry;
        private System.Windows.Forms.TextBox tb_lab_Rx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_rfOther;
    }
}

