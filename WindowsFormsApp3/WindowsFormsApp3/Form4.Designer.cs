
namespace WindowsFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtaracdurum = new System.Windows.Forms.ComboBox();
            this.txtrenk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyil = new ns1.BunifuMetroTextbox();
            this.txtaractipi = new ns1.BunifuMetroTextbox();
            this.txtmodel = new ns1.BunifuMetroTextbox();
            this.txtmarka = new ns1.BunifuMetroTextbox();
            this.txtplaka = new ns1.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new ns1.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(459, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 29);
            this.label9.TabIndex = 84;
            this.label9.Text = "ARAÇ LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 325);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Tan;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.NavajoWhite;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tüm Araçlar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(452, 30);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(125, 32);
            this.bunifuThinButton21.TabIndex = 80;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Tan;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.NavajoWhite;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Çıkış";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DarkGray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(612, 30);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(88, 32);
            this.bunifuThinButton22.TabIndex = 79;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // txtaracdurum
            // 
            this.txtaracdurum.FormattingEnabled = true;
            this.txtaracdurum.Location = new System.Drawing.Point(118, 382);
            this.txtaracdurum.Margin = new System.Windows.Forms.Padding(2);
            this.txtaracdurum.Name = "txtaracdurum";
            this.txtaracdurum.Size = new System.Drawing.Size(164, 21);
            this.txtaracdurum.TabIndex = 76;
            // 
            // txtrenk
            // 
            this.txtrenk.FormattingEnabled = true;
            this.txtrenk.Location = new System.Drawing.Point(118, 315);
            this.txtrenk.Margin = new System.Windows.Forms.Padding(2);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(164, 21);
            this.txtrenk.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-3, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Araç Durumu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(72, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Yıl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Renk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Araç Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Plaka:";
            // 
            // txtyil
            // 
            this.txtyil.BackColor = System.Drawing.Color.SeaShell;
            this.txtyil.BorderColorFocused = System.Drawing.Color.White;
            this.txtyil.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtyil.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtyil.BorderThickness = 3;
            this.txtyil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtyil.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtyil.ForeColor = System.Drawing.Color.Black;
            this.txtyil.isPassword = false;
            this.txtyil.Location = new System.Drawing.Point(118, 341);
            this.txtyil.Margin = new System.Windows.Forms.Padding(4);
            this.txtyil.Name = "txtyil";
            this.txtyil.Size = new System.Drawing.Size(164, 30);
            this.txtyil.TabIndex = 66;
            this.txtyil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtaractipi
            // 
            this.txtaractipi.BackColor = System.Drawing.Color.SeaShell;
            this.txtaractipi.BorderColorFocused = System.Drawing.Color.White;
            this.txtaractipi.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtaractipi.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtaractipi.BorderThickness = 3;
            this.txtaractipi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaractipi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtaractipi.ForeColor = System.Drawing.Color.Black;
            this.txtaractipi.isPassword = false;
            this.txtaractipi.Location = new System.Drawing.Point(118, 277);
            this.txtaractipi.Margin = new System.Windows.Forms.Padding(4);
            this.txtaractipi.Name = "txtaractipi";
            this.txtaractipi.Size = new System.Drawing.Size(164, 28);
            this.txtaractipi.TabIndex = 65;
            this.txtaractipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtmodel
            // 
            this.txtmodel.BackColor = System.Drawing.Color.SeaShell;
            this.txtmodel.BorderColorFocused = System.Drawing.Color.White;
            this.txtmodel.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtmodel.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtmodel.BorderThickness = 3;
            this.txtmodel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmodel.ForeColor = System.Drawing.Color.Black;
            this.txtmodel.isPassword = false;
            this.txtmodel.Location = new System.Drawing.Point(118, 242);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(4);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(164, 28);
            this.txtmodel.TabIndex = 64;
            this.txtmodel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtmarka
            // 
            this.txtmarka.BackColor = System.Drawing.Color.SeaShell;
            this.txtmarka.BorderColorFocused = System.Drawing.Color.White;
            this.txtmarka.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtmarka.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtmarka.BorderThickness = 3;
            this.txtmarka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmarka.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmarka.ForeColor = System.Drawing.Color.Black;
            this.txtmarka.isPassword = false;
            this.txtmarka.Location = new System.Drawing.Point(118, 209);
            this.txtmarka.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(164, 27);
            this.txtmarka.TabIndex = 63;
            this.txtmarka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtplaka
            // 
            this.txtplaka.BackColor = System.Drawing.Color.SeaShell;
            this.txtplaka.BorderColorFocused = System.Drawing.Color.White;
            this.txtplaka.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtplaka.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtplaka.BorderThickness = 3;
            this.txtplaka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtplaka.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtplaka.ForeColor = System.Drawing.Color.Black;
            this.txtplaka.isPassword = false;
            this.txtplaka.Location = new System.Drawing.Point(118, 175);
            this.txtplaka.Margin = new System.Windows.Forms.Padding(4);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(164, 28);
            this.txtplaka.TabIndex = 62;
            this.txtplaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(72, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.SeaShell;
            this.txtid.BorderColorFocused = System.Drawing.Color.White;
            this.txtid.BorderColorIdle = System.Drawing.Color.Violet;
            this.txtid.BorderColorMouseHover = System.Drawing.Color.Thistle;
            this.txtid.BorderThickness = 3;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.isPassword = false;
            this.txtid.Location = new System.Drawing.Point(117, 139);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(164, 28);
            this.txtid.TabIndex = 86;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 484);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtaracdurum);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyil);
            this.Controls.Add(this.txtaractipi);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtplaka);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtaracdurum;
        private System.Windows.Forms.ComboBox txtrenk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMetroTextbox txtyil;
        private ns1.BunifuMetroTextbox txtaractipi;
        private ns1.BunifuMetroTextbox txtmodel;
        private ns1.BunifuMetroTextbox txtmarka;
        private ns1.BunifuMetroTextbox txtplaka;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuMetroTextbox txtid;
    }
}