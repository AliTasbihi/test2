
namespace Hydro_Berger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_calculate_meta = new System.Windows.Forms.Label();
            this.lable_meta_center = new System.Windows.Forms.Label();
            this.label_calculate_moman = new System.Windows.Forms.Label();
            this.lable_moman = new System.Windows.Forms.Label();
            this.label_calculate_S = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_i = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_lenght = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_simson = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(613, 356);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_calculate_meta);
            this.tabPage1.Controls.Add(this.lable_meta_center);
            this.tabPage1.Controls.Add(this.label_calculate_moman);
            this.tabPage1.Controls.Add(this.lable_moman);
            this.tabPage1.Controls.Add(this.label_calculate_S);
            this.tabPage1.Controls.Add(this.label_S);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button_calculate);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مرکز سطح حول محور افقی";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_calculate_meta
            // 
            this.label_calculate_meta.AutoSize = true;
            this.label_calculate_meta.Location = new System.Drawing.Point(67, 305);
            this.label_calculate_meta.Name = "label_calculate_meta";
            this.label_calculate_meta.Size = new System.Drawing.Size(0, 15);
            this.label_calculate_meta.TabIndex = 4;
            // 
            // lable_meta_center
            // 
            this.lable_meta_center.AutoSize = true;
            this.lable_meta_center.Location = new System.Drawing.Point(57, 268);
            this.lable_meta_center.Name = "lable_meta_center";
            this.lable_meta_center.Size = new System.Drawing.Size(59, 15);
            this.lable_meta_center.TabIndex = 4;
            this.lable_meta_center.Text = "مرکز سطح";
            // 
            // label_calculate_moman
            // 
            this.label_calculate_moman.AutoSize = true;
            this.label_calculate_moman.Location = new System.Drawing.Point(306, 305);
            this.label_calculate_moman.Name = "label_calculate_moman";
            this.label_calculate_moman.Size = new System.Drawing.Size(0, 15);
            this.label_calculate_moman.TabIndex = 3;
            // 
            // lable_moman
            // 
            this.lable_moman.AutoSize = true;
            this.lable_moman.Location = new System.Drawing.Point(278, 268);
            this.lable_moman.Name = "lable_moman";
            this.lable_moman.Size = new System.Drawing.Size(54, 15);
            this.lable_moman.TabIndex = 3;
            this.lable_moman.Text = "ممان_اول";
            // 
            // label_calculate_S
            // 
            this.label_calculate_S.AutoSize = true;
            this.label_calculate_S.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_calculate_S.Location = new System.Drawing.Point(508, 305);
            this.label_calculate_S.Name = "label_calculate_S";
            this.label_calculate_S.Size = new System.Drawing.Size(0, 15);
            this.label_calculate_S.TabIndex = 2;
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Location = new System.Drawing.Point(498, 268);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(48, 15);
            this.label_S.TabIndex = 1;
            this.label_S.Text = "مساحت ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_i);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_lenght);
            this.groupBox1.Controls.Add(this.textBox_y);
            this.groupBox1.Controls.Add(this.textBox_simson);
            this.groupBox1.Controls.Add(this.textBox_length);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(605, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عددی_سیمپسون اول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ایستگاه ها";
            // 
            // textBox_i
            // 
            this.textBox_i.Location = new System.Drawing.Point(66, 116);
            this.textBox_i.Name = "textBox_i";
            this.textBox_i.Size = new System.Drawing.Size(442, 23);
            this.textBox_i.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "مقادیر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ضریب سیمپسون";
            // 
            // label_lenght
            // 
            this.label_lenght.AutoSize = true;
            this.label_lenght.Location = new System.Drawing.Point(536, 43);
            this.label_lenght.Name = "label_lenght";
            this.label_lenght.Size = new System.Drawing.Size(34, 15);
            this.label_lenght.TabIndex = 4;
            this.label_lenght.Text = "طول ";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(66, 150);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(442, 23);
            this.textBox_y.TabIndex = 3;
            // 
            // textBox_simson
            // 
            this.textBox_simson.Location = new System.Drawing.Point(66, 81);
            this.textBox_simson.Name = "textBox_simson";
            this.textBox_simson.Size = new System.Drawing.Size(442, 23);
            this.textBox_simson.TabIndex = 2;
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(67, 43);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(442, 23);
            this.textBox_length.TabIndex = 1;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(257, 239);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 0;
            this.button_calculate.Text = "محاسبه";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 353);
            this.Controls.Add(this.tabControl);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hydro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_lenght;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_simson;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_calculate_S;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_calculate_moman;
        private System.Windows.Forms.Label lable_moman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.Label label_calculate_meta;
        private System.Windows.Forms.Label lable_meta_center;
    }
}

