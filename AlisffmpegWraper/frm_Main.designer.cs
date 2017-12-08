namespace AlisffmpegWraper
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_FileAdress = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.rbtn_mp4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_ac_Copy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_vc_copy = new System.Windows.Forms.RadioButton();
            this.rbtn_vc_libx264 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_vs_copy = new System.Windows.Forms.RadioButton();
            this.rbtn_vs_960720 = new System.Windows.Forms.RadioButton();
            this.rbtn_vs_800600 = new System.Windows.Forms.RadioButton();
            this.rbtn_vs_640480 = new System.Windows.Forms.RadioButton();
            this.chk_Override = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(12, 38);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(100, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Select Source";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_FileAdress
            // 
            this.txt_FileAdress.Location = new System.Drawing.Point(118, 38);
            this.txt_FileAdress.Name = "txt_FileAdress";
            this.txt_FileAdress.Size = new System.Drawing.Size(293, 20);
            this.txt_FileAdress.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(78, 354);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(108, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start Convert";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(206, 354);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(108, 23);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Puase";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Location = new System.Drawing.Point(333, 354);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(108, 23);
            this.btn_Resume.TabIndex = 4;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // rbtn_mp4
            // 
            this.rbtn_mp4.AutoSize = true;
            this.rbtn_mp4.Checked = true;
            this.rbtn_mp4.Location = new System.Drawing.Point(78, 81);
            this.rbtn_mp4.Name = "rbtn_mp4";
            this.rbtn_mp4.Size = new System.Drawing.Size(45, 17);
            this.rbtn_mp4.TabIndex = 5;
            this.rbtn_mp4.TabStop = true;
            this.rbtn_mp4.Text = "mp4";
            this.rbtn_mp4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Convert To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_ac_Copy);
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Codec";
            // 
            // rbtn_ac_Copy
            // 
            this.rbtn_ac_Copy.AutoSize = true;
            this.rbtn_ac_Copy.Checked = true;
            this.rbtn_ac_Copy.Location = new System.Drawing.Point(63, 29);
            this.rbtn_ac_Copy.Name = "rbtn_ac_Copy";
            this.rbtn_ac_Copy.Size = new System.Drawing.Size(49, 17);
            this.rbtn_ac_Copy.TabIndex = 0;
            this.rbtn_ac_Copy.TabStop = true;
            this.rbtn_ac_Copy.Text = "Copy";
            this.rbtn_ac_Copy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_vc_copy);
            this.groupBox2.Controls.Add(this.rbtn_vc_libx264);
            this.groupBox2.Location = new System.Drawing.Point(15, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 61);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Codec";
            // 
            // rbtn_vc_copy
            // 
            this.rbtn_vc_copy.AutoSize = true;
            this.rbtn_vc_copy.Location = new System.Drawing.Point(63, 29);
            this.rbtn_vc_copy.Name = "rbtn_vc_copy";
            this.rbtn_vc_copy.Size = new System.Drawing.Size(49, 17);
            this.rbtn_vc_copy.TabIndex = 1;
            this.rbtn_vc_copy.Text = "Copy";
            this.rbtn_vc_copy.UseVisualStyleBackColor = true;
            // 
            // rbtn_vc_libx264
            // 
            this.rbtn_vc_libx264.AutoSize = true;
            this.rbtn_vc_libx264.Checked = true;
            this.rbtn_vc_libx264.Location = new System.Drawing.Point(138, 29);
            this.rbtn_vc_libx264.Name = "rbtn_vc_libx264";
            this.rbtn_vc_libx264.Size = new System.Drawing.Size(61, 17);
            this.rbtn_vc_libx264.TabIndex = 0;
            this.rbtn_vc_libx264.TabStop = true;
            this.rbtn_vc_libx264.Text = "libx264 ";
            this.rbtn_vc_libx264.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_vs_copy);
            this.groupBox3.Controls.Add(this.rbtn_vs_960720);
            this.groupBox3.Controls.Add(this.rbtn_vs_800600);
            this.groupBox3.Controls.Add(this.rbtn_vs_640480);
            this.groupBox3.Location = new System.Drawing.Point(15, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video Size";
            // 
            // rbtn_vs_copy
            // 
            this.rbtn_vs_copy.AutoSize = true;
            this.rbtn_vs_copy.Location = new System.Drawing.Point(63, 28);
            this.rbtn_vs_copy.Name = "rbtn_vs_copy";
            this.rbtn_vs_copy.Size = new System.Drawing.Size(49, 17);
            this.rbtn_vs_copy.TabIndex = 3;
            this.rbtn_vs_copy.Text = "Copy";
            this.rbtn_vs_copy.UseVisualStyleBackColor = true;
            // 
            // rbtn_vs_960720
            // 
            this.rbtn_vs_960720.AutoSize = true;
            this.rbtn_vs_960720.Location = new System.Drawing.Point(309, 28);
            this.rbtn_vs_960720.Name = "rbtn_vs_960720";
            this.rbtn_vs_960720.Size = new System.Drawing.Size(67, 17);
            this.rbtn_vs_960720.TabIndex = 2;
            this.rbtn_vs_960720.Text = "960×720";
            this.rbtn_vs_960720.UseVisualStyleBackColor = true;
            // 
            // rbtn_vs_800600
            // 
            this.rbtn_vs_800600.AutoSize = true;
            this.rbtn_vs_800600.Checked = true;
            this.rbtn_vs_800600.Location = new System.Drawing.Point(227, 28);
            this.rbtn_vs_800600.Name = "rbtn_vs_800600";
            this.rbtn_vs_800600.Size = new System.Drawing.Size(65, 17);
            this.rbtn_vs_800600.TabIndex = 1;
            this.rbtn_vs_800600.TabStop = true;
            this.rbtn_vs_800600.Text = "800*600";
            this.rbtn_vs_800600.UseVisualStyleBackColor = true;
            // 
            // rbtn_vs_640480
            // 
            this.rbtn_vs_640480.AutoSize = true;
            this.rbtn_vs_640480.Location = new System.Drawing.Point(138, 28);
            this.rbtn_vs_640480.Name = "rbtn_vs_640480";
            this.rbtn_vs_640480.Size = new System.Drawing.Size(66, 17);
            this.rbtn_vs_640480.TabIndex = 0;
            this.rbtn_vs_640480.Text = "640x480";
            this.rbtn_vs_640480.UseVisualStyleBackColor = true;
            // 
            // chk_Override
            // 
            this.chk_Override.AutoSize = true;
            this.chk_Override.Location = new System.Drawing.Point(428, 40);
            this.chk_Override.Name = "chk_Override";
            this.chk_Override.Size = new System.Drawing.Size(118, 17);
            this.chk_Override.TabIndex = 10;
            this.chk_Override.Text = "Overide Existing file";
            this.chk_Override.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 389);
            this.Controls.Add(this.chk_Override);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_mp4);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_FileAdress);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_FileAdress;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.RadioButton rbtn_mp4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_ac_Copy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_vc_libx264;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_vs_800600;
        private System.Windows.Forms.RadioButton rbtn_vs_640480;
        private System.Windows.Forms.RadioButton rbtn_vc_copy;
        private System.Windows.Forms.CheckBox chk_Override;
        private System.Windows.Forms.RadioButton rbtn_vs_960720;
        private System.Windows.Forms.RadioButton rbtn_vs_copy;
    }
}

