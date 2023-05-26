namespace winFormNDP
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.boySend = new System.Windows.Forms.NumericUpDown();
            this.enSend = new System.Windows.Forms.NumericUpDown();
            this.enLabel = new System.Windows.Forms.Label();
            this.boyLabel = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.rSend = new System.Windows.Forms.NumericUpDown();
            this.zSend = new System.Windows.Forms.NumericUpDown();
            this.ySend = new System.Windows.Forms.NumericUpDown();
            this.xSend = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boySend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(405, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 434);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(15, 228);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(374, 23);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.Text = "Ekle";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nokta",
            "Küre",
            "Dikdörtgen",
            "Silindir",
            "Çember",
            "Yüzey"});
            this.listBox1.Location = new System.Drawing.Point(3, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 108);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Cisim:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(175, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 25);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alttaki listeden cisim seçiniz";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(228, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(228, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(228, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Z:";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(32, 192);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 12;
            this.ekle.Text = "Seç";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.boySend);
            this.panel3.Controls.Add(this.enSend);
            this.panel3.Controls.Add(this.enLabel);
            this.panel3.Controls.Add(this.boyLabel);
            this.panel3.Controls.Add(this.r);
            this.panel3.Controls.Add(this.rSend);
            this.panel3.Controls.Add(this.zSend);
            this.panel3.Controls.Add(this.ySend);
            this.panel3.Controls.Add(this.xSend);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(12, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 224);
            this.panel3.TabIndex = 13;
            // 
            // boySend
            // 
            this.boySend.Location = new System.Drawing.Point(317, 160);
            this.boySend.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.boySend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boySend.Name = "boySend";
            this.boySend.Size = new System.Drawing.Size(42, 20);
            this.boySend.TabIndex = 22;
            this.boySend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boySend.Visible = false;
            // 
            // enSend
            // 
            this.enSend.Location = new System.Drawing.Point(239, 160);
            this.enSend.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.enSend.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enSend.Name = "enSend";
            this.enSend.Size = new System.Drawing.Size(42, 20);
            this.enSend.TabIndex = 21;
            this.enSend.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enSend.Visible = false;
            // 
            // enLabel
            // 
            this.enLabel.AutoSize = true;
            this.enLabel.Location = new System.Drawing.Point(216, 162);
            this.enLabel.Name = "enLabel";
            this.enLabel.Size = new System.Drawing.Size(23, 13);
            this.enLabel.TabIndex = 19;
            this.enLabel.Text = "En:";
            this.enLabel.Visible = false;
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(287, 164);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(31, 13);
            this.boyLabel.TabIndex = 20;
            this.boyLabel.Text = "Boy: ";
            this.boyLabel.Visible = false;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(215, 162);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(18, 13);
            this.r.TabIndex = 18;
            this.r.Text = "R:";
            this.r.Visible = false;
            this.r.Click += new System.EventHandler(this.label8_Click);
            // 
            // rSend
            // 
            this.rSend.Location = new System.Drawing.Point(239, 160);
            this.rSend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rSend.Name = "rSend";
            this.rSend.Size = new System.Drawing.Size(120, 20);
            this.rSend.TabIndex = 17;
            this.rSend.Visible = false;
            // 
            // zSend
            // 
            this.zSend.Enabled = false;
            this.zSend.Location = new System.Drawing.Point(239, 129);
            this.zSend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zSend.Name = "zSend";
            this.zSend.Size = new System.Drawing.Size(120, 20);
            this.zSend.TabIndex = 16;
            // 
            // ySend
            // 
            this.ySend.Enabled = false;
            this.ySend.Location = new System.Drawing.Point(239, 96);
            this.ySend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ySend.Name = "ySend";
            this.ySend.Size = new System.Drawing.Size(120, 20);
            this.ySend.TabIndex = 15;
            // 
            // xSend
            // 
            this.xSend.Enabled = false;
            this.xSend.Location = new System.Drawing.Point(239, 63);
            this.xSend.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xSend.Name = "xSend";
            this.xSend.Size = new System.Drawing.Size(120, 20);
            this.xSend.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(44, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 440);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 36);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(890, 489);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1042, 524);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boySend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown zSend;
        private System.Windows.Forms.NumericUpDown ySend;
        private System.Windows.Forms.NumericUpDown xSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.NumericUpDown rSend;
        private System.Windows.Forms.NumericUpDown boySend;
        private System.Windows.Forms.NumericUpDown enSend;
        private System.Windows.Forms.Label enLabel;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonReset;
    }
}

