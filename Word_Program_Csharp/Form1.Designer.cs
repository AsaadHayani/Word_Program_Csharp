namespace Word_Program_Csharp
{
  partial class frmword
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmword));
      this.text2 = new System.Windows.Forms.RichTextBox();
      this.panel8 = new System.Windows.Forms.Panel();
      this.rduback = new System.Windows.Forms.RadioButton();
      this.rdutext = new System.Windows.Forms.RadioButton();
      this.btnmorecolor = new System.Windows.Forms.Button();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.panel9 = new System.Windows.Forms.Panel();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cbxitalic = new System.Windows.Forms.CheckBox();
      this.cbxunderline = new System.Windows.Forms.CheckBox();
      this.cbxbold = new System.Windows.Forms.CheckBox();
      this.nudsize = new System.Windows.Forms.NumericUpDown();
      this.cbxfont = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nudsize)).BeginInit();
      this.SuspendLayout();
      // 
      // text2
      // 
      this.text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.text2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.text2.Location = new System.Drawing.Point(0, 243);
      this.text2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.text2.Name = "text2";
      this.text2.Size = new System.Drawing.Size(1307, 204);
      this.text2.TabIndex = 35;
      this.text2.Text = resources.GetString("text2.Text");
      // 
      // panel8
      // 
      this.panel8.BackColor = System.Drawing.Color.Lime;
      this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel8.Location = new System.Drawing.Point(104, 131);
      this.panel8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(33, 33);
      this.panel8.TabIndex = 31;
      this.panel8.Click += new System.EventHandler(this.panel2_Click);
      // 
      // rduback
      // 
      this.rduback.AutoSize = true;
      this.rduback.ForeColor = System.Drawing.Color.White;
      this.rduback.Location = new System.Drawing.Point(295, 91);
      this.rduback.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.rduback.Name = "rduback";
      this.rduback.Size = new System.Drawing.Size(163, 36);
      this.rduback.TabIndex = 34;
      this.rduback.Text = "Background";
      this.rduback.UseVisualStyleBackColor = true;
      // 
      // rdutext
      // 
      this.rdutext.AutoSize = true;
      this.rdutext.Checked = true;
      this.rdutext.ForeColor = System.Drawing.Color.White;
      this.rdutext.Location = new System.Drawing.Point(295, 27);
      this.rdutext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.rdutext.Name = "rdutext";
      this.rdutext.Size = new System.Drawing.Size(79, 36);
      this.rdutext.TabIndex = 33;
      this.rdutext.TabStop = true;
      this.rdutext.Text = "Text";
      this.rdutext.UseVisualStyleBackColor = true;
      // 
      // btnmorecolor
      // 
      this.btnmorecolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.btnmorecolor.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnmorecolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnmorecolor.ForeColor = System.Drawing.Color.Black;
      this.btnmorecolor.Location = new System.Drawing.Point(37, 23);
      this.btnmorecolor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.btnmorecolor.Name = "btnmorecolor";
      this.btnmorecolor.Size = new System.Drawing.Size(225, 50);
      this.btnmorecolor.TabIndex = 32;
      this.btnmorecolor.Text = "More Colors";
      this.btnmorecolor.UseVisualStyleBackColor = false;
      this.btnmorecolor.Click += new System.EventHandler(this.btnmorecolor_Click);
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.Aqua;
      this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel6.Location = new System.Drawing.Point(37, 131);
      this.panel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(33, 33);
      this.panel6.TabIndex = 29;
      this.panel6.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel7
      // 
      this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel7.Location = new System.Drawing.Point(37, 85);
      this.panel7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(33, 33);
      this.panel7.TabIndex = 27;
      this.panel7.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.Yellow;
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel4.Location = new System.Drawing.Point(169, 131);
      this.panel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(33, 33);
      this.panel4.TabIndex = 28;
      this.panel4.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel9
      // 
      this.panel9.BackColor = System.Drawing.Color.Blue;
      this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel9.Location = new System.Drawing.Point(104, 85);
      this.panel9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(33, 33);
      this.panel9.TabIndex = 30;
      this.panel9.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.Red;
      this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel5.Location = new System.Drawing.Point(169, 85);
      this.panel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(33, 33);
      this.panel5.TabIndex = 26;
      this.panel5.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.White;
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel3.Location = new System.Drawing.Point(229, 131);
      this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(33, 33);
      this.panel3.TabIndex = 25;
      this.panel3.Click += new System.EventHandler(this.panel2_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Black;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.panel2.Location = new System.Drawing.Point(229, 85);
      this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(33, 33);
      this.panel2.TabIndex = 18;
      this.panel2.Click += new System.EventHandler(this.panel2_Click);
      // 
      // cbxitalic
      // 
      this.cbxitalic.AutoSize = true;
      this.cbxitalic.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Italic);
      this.cbxitalic.ForeColor = System.Drawing.Color.White;
      this.cbxitalic.Location = new System.Drawing.Point(1169, 79);
      this.cbxitalic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.cbxitalic.Name = "cbxitalic";
      this.cbxitalic.Size = new System.Drawing.Size(86, 33);
      this.cbxitalic.TabIndex = 24;
      this.cbxitalic.Text = "Italic";
      this.cbxitalic.UseVisualStyleBackColor = true;
      this.cbxitalic.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
      // 
      // cbxunderline
      // 
      this.cbxunderline.AutoSize = true;
      this.cbxunderline.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Underline);
      this.cbxunderline.ForeColor = System.Drawing.Color.White;
      this.cbxunderline.Location = new System.Drawing.Point(1169, 131);
      this.cbxunderline.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.cbxunderline.Name = "cbxunderline";
      this.cbxunderline.Size = new System.Drawing.Size(135, 33);
      this.cbxunderline.TabIndex = 23;
      this.cbxunderline.Text = "Underline";
      this.cbxunderline.UseVisualStyleBackColor = true;
      this.cbxunderline.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
      // 
      // cbxbold
      // 
      this.cbxbold.AutoSize = true;
      this.cbxbold.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
      this.cbxbold.ForeColor = System.Drawing.Color.White;
      this.cbxbold.Location = new System.Drawing.Point(1169, 23);
      this.cbxbold.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.cbxbold.Name = "cbxbold";
      this.cbxbold.Size = new System.Drawing.Size(88, 33);
      this.cbxbold.TabIndex = 22;
      this.cbxbold.Text = "Bold";
      this.cbxbold.UseVisualStyleBackColor = true;
      this.cbxbold.CheckedChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
      // 
      // nudsize
      // 
      this.nudsize.Location = new System.Drawing.Point(947, 80);
      this.nudsize.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
      this.nudsize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
      this.nudsize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.nudsize.Name = "nudsize";
      this.nudsize.Size = new System.Drawing.Size(117, 38);
      this.nudsize.TabIndex = 21;
      this.nudsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.nudsize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
      this.nudsize.ValueChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
      // 
      // cbxfont
      // 
      this.cbxfont.FormattingEnabled = true;
      this.cbxfont.Location = new System.Drawing.Point(578, 79);
      this.cbxfont.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
      this.cbxfont.Name = "cbxfont";
      this.cbxfont.Size = new System.Drawing.Size(290, 39);
      this.cbxfont.TabIndex = 20;
      this.cbxfont.SelectedIndexChanged += new System.EventHandler(this.cbxfont_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(973, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 32);
      this.label2.TabIndex = 19;
      this.label2.Text = "Size";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(647, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 32);
      this.label1.TabIndex = 17;
      this.label1.Text = "Font Name";
      // 
      // frmword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.ClientSize = new System.Drawing.Size(1307, 447);
      this.Controls.Add(this.text2);
      this.Controls.Add(this.panel8);
      this.Controls.Add(this.rduback);
      this.Controls.Add(this.rdutext);
      this.Controls.Add(this.btnmorecolor);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel7);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel9);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.cbxitalic);
      this.Controls.Add(this.cbxunderline);
      this.Controls.Add(this.cbxbold);
      this.Controls.Add(this.nudsize);
      this.Controls.Add(this.cbxfont);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
      this.Name = "frmword";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmword_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudsize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox text2;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.RadioButton rduback;
    private System.Windows.Forms.RadioButton rdutext;
    private System.Windows.Forms.Button btnmorecolor;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.CheckBox cbxitalic;
    private System.Windows.Forms.CheckBox cbxunderline;
    private System.Windows.Forms.CheckBox cbxbold;
    private System.Windows.Forms.NumericUpDown nudsize;
    private System.Windows.Forms.ComboBox cbxfont;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}

