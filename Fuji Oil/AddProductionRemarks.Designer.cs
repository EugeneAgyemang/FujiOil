namespace Fuji_Oil
{
    partial class AddProductionRemarks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSelectedProduct = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtProductName = new System.Windows.Forms.Label();
            this.btViewSampleResult = new Guna.UI.WinForms.GunaButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAddProductionRemarks = new Guna.UI.WinForms.GunaButton();
            this.txtProductionRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADD PRODUCTION REMARKS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(141, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample Results";
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
            this.txtProductName.Location = new System.Drawing.Point(405, 188);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(0, 17);
            this.txtProductName.TabIndex = 9;
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
            this.btViewSampleResult.Text = "Check Result";
            this.btViewSampleResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btViewSampleResult.Click += new System.EventHandler(this.btViewSampleResult_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btViewSampleResult);
            this.groupBox2.Controls.Add(this.txtSelectedProduct);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(141, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 76);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            this.Column2.HeaderText = "%Moist";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "%FFA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "%SOS";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "%ACT";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "%IV";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Remarks";
            this.Column7.Name = "Column7";
            this.Column7.Width = 400;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtsid);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtProductionRemarks);
            this.groupBox3.Controls.Add(this.btAddProductionRemarks);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(144, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 93);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Production Remarks";
            // 
            // btAddProductionRemarks
            // 
            this.btAddProductionRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAddProductionRemarks.AnimationHoverSpeed = 0.07F;
            this.btAddProductionRemarks.AnimationSpeed = 0.03F;
            this.btAddProductionRemarks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btAddProductionRemarks.BorderColor = System.Drawing.Color.Black;
            this.btAddProductionRemarks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAddProductionRemarks.FocusedColor = System.Drawing.Color.Empty;
            this.btAddProductionRemarks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProductionRemarks.ForeColor = System.Drawing.Color.White;
            this.btAddProductionRemarks.Image = null;
            this.btAddProductionRemarks.ImageSize = new System.Drawing.Size(20, 20);
            this.btAddProductionRemarks.Location = new System.Drawing.Point(579, 40);
            this.btAddProductionRemarks.Name = "btAddProductionRemarks";
            this.btAddProductionRemarks.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btAddProductionRemarks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAddProductionRemarks.OnHoverForeColor = System.Drawing.Color.White;
            this.btAddProductionRemarks.OnHoverImage = null;
            this.btAddProductionRemarks.OnPressedColor = System.Drawing.Color.Black;
            this.btAddProductionRemarks.Size = new System.Drawing.Size(99, 36);
            this.btAddProductionRemarks.TabIndex = 20;
            this.btAddProductionRemarks.Text = "Add Remarks";
            this.btAddProductionRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductionRemarks
            // 
            this.txtProductionRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtProductionRemarks.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionRemarks.ForeColor = System.Drawing.Color.White;
            this.txtProductionRemarks.Location = new System.Drawing.Point(132, 41);
            this.txtProductionRemarks.Name = "txtProductionRemarks";
            this.txtProductionRemarks.Size = new System.Drawing.Size(419, 30);
            this.txtProductionRemarks.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Production Remarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 25);
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
            this.txtsid.Location = new System.Drawing.Point(22, 41);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(63, 30);
            this.txtsid.TabIndex = 26;
            this.txtsid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddProductionRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddProductionRemarks";
            this.Text = "AddProductionRemarks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuDropdown txtSelectedProduct;
        private System.Windows.Forms.Label txtProductName;
        private Guna.UI.WinForms.GunaButton btViewSampleResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaButton btAddProductionRemarks;
        private System.Windows.Forms.TextBox txtProductionRemarks;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}