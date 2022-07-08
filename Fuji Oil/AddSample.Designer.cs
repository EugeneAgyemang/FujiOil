namespace Fuji_Oil
{
    partial class AddSample
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
            this.btGetOperatorData = new Guna.UI.WinForms.GunaButton();
            this.btUpdateOperator = new Guna.UI.WinForms.GunaButton();
            this.btDeleteOperator = new Guna.UI.WinForms.GunaButton();
            this.btAddOperator = new Guna.UI.WinForms.GunaButton();
            this.btNewOperator = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chStearin = new Guna.UI.WinForms.GunaCheckBox();
            this.chOlein = new Guna.UI.WinForms.GunaCheckBox();
            this.chCButter = new Guna.UI.WinForms.GunaCheckBox();
            this.chMiscella = new Guna.UI.WinForms.GunaCheckBox();
            this.chReflux = new Guna.UI.WinForms.GunaCheckBox();
            this.btUpdateSample = new Guna.UI.WinForms.GunaButton();
            this.btDeleteSample = new Guna.UI.WinForms.GunaButton();
            this.btAddSample = new Guna.UI.WinForms.GunaButton();
            this.btNewSample = new Guna.UI.WinForms.GunaButton();
            this.txtOperator2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtOperator1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD SAMPLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btGetOperatorData);
            this.groupBox1.Controls.Add(this.btUpdateOperator);
            this.groupBox1.Controls.Add(this.btDeleteOperator);
            this.groupBox1.Controls.Add(this.btAddOperator);
            this.groupBox1.Controls.Add(this.btNewOperator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOperatorName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(206, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Production Engineer";
            // 
            // btGetOperatorData
            // 
            this.btGetOperatorData.AnimationHoverSpeed = 0.07F;
            this.btGetOperatorData.AnimationSpeed = 0.03F;
            this.btGetOperatorData.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btGetOperatorData.BorderColor = System.Drawing.Color.Black;
            this.btGetOperatorData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetOperatorData.FocusedColor = System.Drawing.Color.Empty;
            this.btGetOperatorData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGetOperatorData.ForeColor = System.Drawing.Color.White;
            this.btGetOperatorData.Image = null;
            this.btGetOperatorData.ImageSize = new System.Drawing.Size(20, 20);
            this.btGetOperatorData.Location = new System.Drawing.Point(408, 106);
            this.btGetOperatorData.Name = "btGetOperatorData";
            this.btGetOperatorData.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btGetOperatorData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btGetOperatorData.OnHoverForeColor = System.Drawing.Color.White;
            this.btGetOperatorData.OnHoverImage = null;
            this.btGetOperatorData.OnPressedColor = System.Drawing.Color.Black;
            this.btGetOperatorData.Size = new System.Drawing.Size(76, 36);
            this.btGetOperatorData.TabIndex = 8;
            this.btGetOperatorData.Text = "Get Data";
            this.btGetOperatorData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btGetOperatorData.Click += new System.EventHandler(this.btGetOperatorData_Click);
            // 
            // btUpdateOperator
            // 
            this.btUpdateOperator.AnimationHoverSpeed = 0.07F;
            this.btUpdateOperator.AnimationSpeed = 0.03F;
            this.btUpdateOperator.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btUpdateOperator.BorderColor = System.Drawing.Color.Black;
            this.btUpdateOperator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btUpdateOperator.Enabled = false;
            this.btUpdateOperator.FocusedColor = System.Drawing.Color.Empty;
            this.btUpdateOperator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateOperator.ForeColor = System.Drawing.Color.White;
            this.btUpdateOperator.Image = null;
            this.btUpdateOperator.ImageSize = new System.Drawing.Size(20, 20);
            this.btUpdateOperator.Location = new System.Drawing.Point(326, 106);
            this.btUpdateOperator.Name = "btUpdateOperator";
            this.btUpdateOperator.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btUpdateOperator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btUpdateOperator.OnHoverForeColor = System.Drawing.Color.White;
            this.btUpdateOperator.OnHoverImage = null;
            this.btUpdateOperator.OnPressedColor = System.Drawing.Color.Black;
            this.btUpdateOperator.Size = new System.Drawing.Size(76, 36);
            this.btUpdateOperator.TabIndex = 7;
            this.btUpdateOperator.Text = "Update";
            this.btUpdateOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDeleteOperator
            // 
            this.btDeleteOperator.AnimationHoverSpeed = 0.07F;
            this.btDeleteOperator.AnimationSpeed = 0.03F;
            this.btDeleteOperator.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDeleteOperator.BorderColor = System.Drawing.Color.Black;
            this.btDeleteOperator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDeleteOperator.Enabled = false;
            this.btDeleteOperator.FocusedColor = System.Drawing.Color.Empty;
            this.btDeleteOperator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteOperator.ForeColor = System.Drawing.Color.White;
            this.btDeleteOperator.Image = null;
            this.btDeleteOperator.ImageSize = new System.Drawing.Size(20, 20);
            this.btDeleteOperator.Location = new System.Drawing.Point(244, 106);
            this.btDeleteOperator.Name = "btDeleteOperator";
            this.btDeleteOperator.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btDeleteOperator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDeleteOperator.OnHoverForeColor = System.Drawing.Color.White;
            this.btDeleteOperator.OnHoverImage = null;
            this.btDeleteOperator.OnPressedColor = System.Drawing.Color.Black;
            this.btDeleteOperator.Size = new System.Drawing.Size(76, 36);
            this.btDeleteOperator.TabIndex = 6;
            this.btDeleteOperator.Text = "Delete";
            this.btDeleteOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAddOperator
            // 
            this.btAddOperator.AnimationHoverSpeed = 0.07F;
            this.btAddOperator.AnimationSpeed = 0.03F;
            this.btAddOperator.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btAddOperator.BorderColor = System.Drawing.Color.Black;
            this.btAddOperator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAddOperator.FocusedColor = System.Drawing.Color.Empty;
            this.btAddOperator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddOperator.ForeColor = System.Drawing.Color.White;
            this.btAddOperator.Image = null;
            this.btAddOperator.ImageSize = new System.Drawing.Size(20, 20);
            this.btAddOperator.Location = new System.Drawing.Point(162, 106);
            this.btAddOperator.Name = "btAddOperator";
            this.btAddOperator.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btAddOperator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAddOperator.OnHoverForeColor = System.Drawing.Color.White;
            this.btAddOperator.OnHoverImage = null;
            this.btAddOperator.OnPressedColor = System.Drawing.Color.Black;
            this.btAddOperator.Size = new System.Drawing.Size(76, 36);
            this.btAddOperator.TabIndex = 5;
            this.btAddOperator.Text = "Save";
            this.btAddOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btNewOperator
            // 
            this.btNewOperator.AnimationHoverSpeed = 0.07F;
            this.btNewOperator.AnimationSpeed = 0.03F;
            this.btNewOperator.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btNewOperator.BorderColor = System.Drawing.Color.Black;
            this.btNewOperator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btNewOperator.FocusedColor = System.Drawing.Color.Empty;
            this.btNewOperator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewOperator.ForeColor = System.Drawing.Color.White;
            this.btNewOperator.Image = null;
            this.btNewOperator.ImageSize = new System.Drawing.Size(20, 20);
            this.btNewOperator.Location = new System.Drawing.Point(81, 106);
            this.btNewOperator.Name = "btNewOperator";
            this.btNewOperator.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btNewOperator.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btNewOperator.OnHoverForeColor = System.Drawing.Color.White;
            this.btNewOperator.OnHoverImage = null;
            this.btNewOperator.OnPressedColor = System.Drawing.Color.Black;
            this.btNewOperator.Size = new System.Drawing.Size(76, 36);
            this.btNewOperator.TabIndex = 4;
            this.btNewOperator.Text = "New";
            this.btNewOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btNewOperator.Click += new System.EventHandler(this.btNewOperator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Engineer\'s Full Name";
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtOperatorName.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatorName.ForeColor = System.Drawing.Color.White;
            this.txtOperatorName.Location = new System.Drawing.Point(81, 54);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(403, 30);
            this.txtOperatorName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.chStearin);
            this.groupBox2.Controls.Add(this.chOlein);
            this.groupBox2.Controls.Add(this.chCButter);
            this.groupBox2.Controls.Add(this.chMiscella);
            this.groupBox2.Controls.Add(this.chReflux);
            this.groupBox2.Controls.Add(this.btUpdateSample);
            this.groupBox2.Controls.Add(this.btDeleteSample);
            this.groupBox2.Controls.Add(this.btAddSample);
            this.groupBox2.Controls.Add(this.btNewSample);
            this.groupBox2.Controls.Add(this.txtOperator2);
            this.groupBox2.Controls.Add(this.txtOperator1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(206, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 246);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Sample";
            // 
            // chStearin
            // 
            this.chStearin.BaseColor = System.Drawing.Color.White;
            this.chStearin.CheckedOffColor = System.Drawing.Color.Gray;
            this.chStearin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.chStearin.FillColor = System.Drawing.Color.White;
            this.chStearin.Location = new System.Drawing.Point(449, 37);
            this.chStearin.Name = "chStearin";
            this.chStearin.Size = new System.Drawing.Size(79, 20);
            this.chStearin.TabIndex = 37;
            this.chStearin.Text = "STEARIN";
            // 
            // chOlein
            // 
            this.chOlein.BaseColor = System.Drawing.Color.White;
            this.chOlein.CheckedOffColor = System.Drawing.Color.Gray;
            this.chOlein.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.chOlein.FillColor = System.Drawing.Color.White;
            this.chOlein.Location = new System.Drawing.Point(370, 37);
            this.chOlein.Name = "chOlein";
            this.chOlein.Size = new System.Drawing.Size(78, 20);
            this.chOlein.TabIndex = 36;
            this.chOlein.Text = "OLEIN(1)";
            // 
            // chCButter
            // 
            this.chCButter.BaseColor = System.Drawing.Color.White;
            this.chCButter.CheckedOffColor = System.Drawing.Color.Gray;
            this.chCButter.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.chCButter.FillColor = System.Drawing.Color.White;
            this.chCButter.Location = new System.Drawing.Point(282, 37);
            this.chCButter.Name = "chCButter";
            this.chCButter.Size = new System.Drawing.Size(86, 20);
            this.chCButter.TabIndex = 35;
            this.chCButter.Text = "C BUTTER";
            // 
            // chMiscella
            // 
            this.chMiscella.BaseColor = System.Drawing.Color.White;
            this.chMiscella.CheckedOffColor = System.Drawing.Color.Gray;
            this.chMiscella.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.chMiscella.FillColor = System.Drawing.Color.White;
            this.chMiscella.Location = new System.Drawing.Point(198, 37);
            this.chMiscella.Name = "chMiscella";
            this.chMiscella.Size = new System.Drawing.Size(86, 20);
            this.chMiscella.TabIndex = 34;
            this.chMiscella.Text = "MISCELLA";
            // 
            // chReflux
            // 
            this.chReflux.BaseColor = System.Drawing.Color.White;
            this.chReflux.CheckedOffColor = System.Drawing.Color.Gray;
            this.chReflux.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.chReflux.FillColor = System.Drawing.Color.White;
            this.chReflux.Location = new System.Drawing.Point(118, 37);
            this.chReflux.Name = "chReflux";
            this.chReflux.Size = new System.Drawing.Size(74, 20);
            this.chReflux.TabIndex = 10;
            this.chReflux.Text = "REFLUX";
            // 
            // btUpdateSample
            // 
            this.btUpdateSample.AnimationHoverSpeed = 0.07F;
            this.btUpdateSample.AnimationSpeed = 0.03F;
            this.btUpdateSample.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btUpdateSample.BorderColor = System.Drawing.Color.Black;
            this.btUpdateSample.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btUpdateSample.Enabled = false;
            this.btUpdateSample.FocusedColor = System.Drawing.Color.Empty;
            this.btUpdateSample.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateSample.ForeColor = System.Drawing.Color.White;
            this.btUpdateSample.Image = null;
            this.btUpdateSample.ImageSize = new System.Drawing.Size(20, 20);
            this.btUpdateSample.Location = new System.Drawing.Point(364, 177);
            this.btUpdateSample.Name = "btUpdateSample";
            this.btUpdateSample.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btUpdateSample.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btUpdateSample.OnHoverForeColor = System.Drawing.Color.White;
            this.btUpdateSample.OnHoverImage = null;
            this.btUpdateSample.OnPressedColor = System.Drawing.Color.Black;
            this.btUpdateSample.Size = new System.Drawing.Size(76, 36);
            this.btUpdateSample.TabIndex = 22;
            this.btUpdateSample.Text = "Update";
            this.btUpdateSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDeleteSample
            // 
            this.btDeleteSample.AnimationHoverSpeed = 0.07F;
            this.btDeleteSample.AnimationSpeed = 0.03F;
            this.btDeleteSample.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDeleteSample.BorderColor = System.Drawing.Color.Black;
            this.btDeleteSample.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDeleteSample.Enabled = false;
            this.btDeleteSample.FocusedColor = System.Drawing.Color.Empty;
            this.btDeleteSample.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteSample.ForeColor = System.Drawing.Color.White;
            this.btDeleteSample.Image = null;
            this.btDeleteSample.ImageSize = new System.Drawing.Size(20, 20);
            this.btDeleteSample.Location = new System.Drawing.Point(282, 177);
            this.btDeleteSample.Name = "btDeleteSample";
            this.btDeleteSample.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btDeleteSample.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btDeleteSample.OnHoverForeColor = System.Drawing.Color.White;
            this.btDeleteSample.OnHoverImage = null;
            this.btDeleteSample.OnPressedColor = System.Drawing.Color.Black;
            this.btDeleteSample.Size = new System.Drawing.Size(76, 36);
            this.btDeleteSample.TabIndex = 21;
            this.btDeleteSample.Text = "Delete";
            this.btDeleteSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAddSample
            // 
            this.btAddSample.AnimationHoverSpeed = 0.07F;
            this.btAddSample.AnimationSpeed = 0.03F;
            this.btAddSample.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btAddSample.BorderColor = System.Drawing.Color.Black;
            this.btAddSample.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAddSample.FocusedColor = System.Drawing.Color.Empty;
            this.btAddSample.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSample.ForeColor = System.Drawing.Color.White;
            this.btAddSample.Image = null;
            this.btAddSample.ImageSize = new System.Drawing.Size(20, 20);
            this.btAddSample.Location = new System.Drawing.Point(200, 177);
            this.btAddSample.Name = "btAddSample";
            this.btAddSample.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btAddSample.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btAddSample.OnHoverForeColor = System.Drawing.Color.White;
            this.btAddSample.OnHoverImage = null;
            this.btAddSample.OnPressedColor = System.Drawing.Color.Black;
            this.btAddSample.Size = new System.Drawing.Size(76, 36);
            this.btAddSample.TabIndex = 20;
            this.btAddSample.Text = "Save";
            this.btAddSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btNewSample
            // 
            this.btNewSample.AnimationHoverSpeed = 0.07F;
            this.btNewSample.AnimationSpeed = 0.03F;
            this.btNewSample.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btNewSample.BorderColor = System.Drawing.Color.Black;
            this.btNewSample.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btNewSample.FocusedColor = System.Drawing.Color.Empty;
            this.btNewSample.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewSample.ForeColor = System.Drawing.Color.White;
            this.btNewSample.Image = null;
            this.btNewSample.ImageSize = new System.Drawing.Size(20, 20);
            this.btNewSample.Location = new System.Drawing.Point(119, 177);
            this.btNewSample.Name = "btNewSample";
            this.btNewSample.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btNewSample.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btNewSample.OnHoverForeColor = System.Drawing.Color.White;
            this.btNewSample.OnHoverImage = null;
            this.btNewSample.OnPressedColor = System.Drawing.Color.Black;
            this.btNewSample.Size = new System.Drawing.Size(76, 36);
            this.btNewSample.TabIndex = 19;
            this.btNewSample.Text = "New";
            this.btNewSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btNewSample.Click += new System.EventHandler(this.btNewSample_Click);
            // 
            // txtOperator2
            // 
            this.txtOperator2.BackColor = System.Drawing.Color.Transparent;
            this.txtOperator2.BorderRadius = 3;
            this.txtOperator2.DisabledColor = System.Drawing.Color.Gray;
            this.txtOperator2.ForeColor = System.Drawing.Color.White;
            this.txtOperator2.Items = new string[0];
            this.txtOperator2.Location = new System.Drawing.Point(282, 102);
            this.txtOperator2.Name = "txtOperator2";
            this.txtOperator2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtOperator2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtOperator2.selectedIndex = -1;
            this.txtOperator2.Size = new System.Drawing.Size(236, 26);
            this.txtOperator2.TabIndex = 18;
            // 
            // txtOperator1
            // 
            this.txtOperator1.BackColor = System.Drawing.Color.Transparent;
            this.txtOperator1.BorderRadius = 3;
            this.txtOperator1.DisabledColor = System.Drawing.Color.Gray;
            this.txtOperator1.ForeColor = System.Drawing.Color.White;
            this.txtOperator1.Items = new string[0];
            this.txtOperator1.Location = new System.Drawing.Point(45, 102);
            this.txtOperator1.Name = "txtOperator1";
            this.txtOperator1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtOperator1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.txtOperator1.selectedIndex = -1;
            this.txtOperator1.Size = new System.Drawing.Size(231, 26);
            this.txtOperator1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Production Engineer 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Production Engineer 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product :";
            // 
            // AddSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddSample";
            this.Text = "AddSample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btGetOperatorData;
        private Guna.UI.WinForms.GunaButton btUpdateOperator;
        private Guna.UI.WinForms.GunaButton btDeleteOperator;
        private Guna.UI.WinForms.GunaButton btAddOperator;
        private Guna.UI.WinForms.GunaButton btNewOperator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown txtOperator2;
        private Bunifu.Framework.UI.BunifuDropdown txtOperator1;
        private Guna.UI.WinForms.GunaButton btUpdateSample;
        private Guna.UI.WinForms.GunaButton btDeleteSample;
        private Guna.UI.WinForms.GunaButton btAddSample;
        private Guna.UI.WinForms.GunaButton btNewSample;
        private Guna.UI.WinForms.GunaCheckBox chStearin;
        private Guna.UI.WinForms.GunaCheckBox chOlein;
        private Guna.UI.WinForms.GunaCheckBox chCButter;
        private Guna.UI.WinForms.GunaCheckBox chMiscella;
        private Guna.UI.WinForms.GunaCheckBox chReflux;
    }
}