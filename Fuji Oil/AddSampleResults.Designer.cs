namespace Fuji_Oil
{
    partial class AddSampleResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btViewSampleResult = new Guna.UI.WinForms.GunaButton();
            this.txtSelectedProduct = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmoist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.btAddSampleResult = new Guna.UI.WinForms.GunaButton();
            this.txtact = new System.Windows.Forms.TextBox();
            this.txtiv = new System.Windows.Forms.TextBox();
            this.txtsos = new System.Windows.Forms.TextBox();
            this.txtffa = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD SAMPLE RESULTS";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btViewSampleResult);
            this.groupBox2.Controls.Add(this.txtSelectedProduct);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(144, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 76);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Product";
            // 
            // btViewSampleResult
            // 
            this.btViewSampleResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btViewSampleResult.AnimationHoverSpeed = 0.07F;
            this.btViewSampleResult.AnimationSpeed = 0.03F;
            this.btViewSampleResult.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btViewSampleResult.BorderColor = System.Drawing.Color.Black;
            this.btViewSampleResult.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btViewSampleResult.FocusedColor = System.Drawing.Color.Empty;
            this.btViewSampleResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewSampleResult.ForeColor = System.Drawing.Color.White;
            this.btViewSampleResult.Image = null;
            this.btViewSampleResult.ImageSize = new System.Drawing.Size(20, 20);
            this.btViewSampleResult.Location = new System.Drawing.Point(455, 22);
            this.btViewSampleResult.Name = "btViewSampleResult";
            this.btViewSampleResult.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btViewSampleResult.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btViewSampleResult.OnHoverForeColor = System.Drawing.Color.White;
            this.btViewSampleResult.OnHoverImage = null;
            this.btViewSampleResult.OnPressedColor = System.Drawing.Color.Black;
            this.btViewSampleResult.Size = new System.Drawing.Size(99, 36);
            this.btViewSampleResult.TabIndex = 20;
            this.btViewSampleResult.Text = "Get Samples";
            this.btViewSampleResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btViewSampleResult.Click += new System.EventHandler(this.btViewSampleResult_Click);
            // 
            // txtSelectedProduct
            // 
            this.txtSelectedProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSelectedProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectedProduct.BorderRadius = 3;
            this.txtSelectedProduct.DisabledColor = System.Drawing.Color.Gray;
            this.txtSelectedProduct.ForeColor = System.Drawing.Color.White;
            this.txtSelectedProduct.Items = new string[] {
        "REFLUX",
        "MISCELLA",
        "C BUTTER",
        "OLEIN(1)",
        "STEARIN"};
            this.txtSelectedProduct.Location = new System.Drawing.Point(135, 26);
            this.txtSelectedProduct.Name = "txtSelectedProduct";
            this.txtSelectedProduct.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSelectedProduct.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtSelectedProduct.selectedIndex = -1;
            this.txtSelectedProduct.Size = new System.Drawing.Size(293, 26);
            this.txtSelectedProduct.TabIndex = 18;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.AutoSize = true;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(408, 189);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(0, 17);
            this.txtProductName.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(144, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 207);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Samples";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Production Engineer 1";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Production Engineer 2";
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.txtffa);
            this.groupBox3.Controls.Add(this.txtsos);
            this.groupBox3.Controls.Add(this.txtiv);
            this.groupBox3.Controls.Add(this.txtact);
            this.groupBox3.Controls.Add(this.txtmoist);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtsid);
            this.groupBox3.Controls.Add(this.btAddSampleResult);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(144, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 93);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Sample Result";
            // 
            // txtmoist
            // 
            this.txtmoist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtmoist.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoist.ForeColor = System.Drawing.Color.White;
            this.txtmoist.Location = new System.Drawing.Point(83, 40);
            this.txtmoist.Name = "txtmoist";
            this.txtmoist.Size = new System.Drawing.Size(56, 30);
            this.txtmoist.TabIndex = 26;
            this.txtmoist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "SID";
            // 
            // txtsid
            // 
            this.txtsid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtsid.Enabled = false;
            this.txtsid.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsid.ForeColor = System.Drawing.Color.White;
            this.txtsid.Location = new System.Drawing.Point(9, 41);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(53, 30);
            this.txtsid.TabIndex = 23;
            this.txtsid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAddSampleResult
            // 
            this.btAddSampleResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddSampleResult.AnimationHoverSpeed = 0.07F;
            this.btAddSampleResult.AnimationSpeed = 0.03F;
            this.btAddSampleResult.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btAddSampleResult.BorderColor = System.Drawing.Color.Black;
            this.btAddSampleResult.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAddSampleResult.FocusedColor = System.Drawing.Color.Empty;
            this.btAddSampleResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSampleResult.ForeColor = System.Drawing.Color.White;
            this.btAddSampleResult.Image = null;
            this.btAddSampleResult.ImageSize = new System.Drawing.Size(20, 20);
            this.btAddSampleResult.Location = new System.Drawing.Point(592, 37);
            this.btAddSampleResult.Name = "btAddSampleResult";
            this.btAddSampleResult.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btAddSampleResult.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAddSampleResult.OnHoverForeColor = System.Drawing.Color.White;
            this.btAddSampleResult.OnHoverImage = null;
            this.btAddSampleResult.OnPressedColor = System.Drawing.Color.Black;
            this.btAddSampleResult.Size = new System.Drawing.Size(99, 36);
            this.btAddSampleResult.TabIndex = 20;
            this.btAddSampleResult.Text = "Add Result";
            this.btAddSampleResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtact
            // 
            this.txtact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtact.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtact.ForeColor = System.Drawing.Color.White;
            this.txtact.Location = new System.Drawing.Point(269, 41);
            this.txtact.Name = "txtact";
            this.txtact.Size = new System.Drawing.Size(56, 30);
            this.txtact.TabIndex = 27;
            this.txtact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtiv
            // 
            this.txtiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtiv.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiv.ForeColor = System.Drawing.Color.White;
            this.txtiv.Location = new System.Drawing.Point(331, 40);
            this.txtiv.Name = "txtiv";
            this.txtiv.Size = new System.Drawing.Size(56, 30);
            this.txtiv.TabIndex = 28;
            this.txtiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsos
            // 
            this.txtsos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtsos.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsos.ForeColor = System.Drawing.Color.White;
            this.txtsos.Location = new System.Drawing.Point(207, 40);
            this.txtsos.Name = "txtsos";
            this.txtsos.Size = new System.Drawing.Size(56, 30);
            this.txtsos.TabIndex = 29;
            this.txtsos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtffa
            // 
            this.txtffa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtffa.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtffa.ForeColor = System.Drawing.Color.White;
            this.txtffa.Location = new System.Drawing.Point(145, 41);
            this.txtffa.Name = "txtffa";
            this.txtffa.Size = new System.Drawing.Size(56, 30);
            this.txtffa.TabIndex = 30;
            this.txtffa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.Color.White;
            this.txtRemark.Location = new System.Drawing.Point(393, 40);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(193, 30);
            this.txtRemark.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "%Moist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "%FFA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "%SOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "%ACT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "%IV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Remark";
            // 
            // AddSampleResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "AddSampleResults";
            this.Text = "AddSampleResults";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaButton btViewSampleResult;
        private Bunifu.Framework.UI.BunifuDropdown txtSelectedProduct;
        private System.Windows.Forms.Label txtProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtffa;
        private System.Windows.Forms.TextBox txtsos;
        private System.Windows.Forms.TextBox txtiv;
        private System.Windows.Forms.TextBox txtact;
        private System.Windows.Forms.TextBox txtmoist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsid;
        private Guna.UI.WinForms.GunaButton btAddSampleResult;
    }
}