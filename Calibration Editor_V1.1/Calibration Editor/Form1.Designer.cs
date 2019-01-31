namespace Calibration_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Startbut = new System.Windows.Forms.Button();
            this.ResetBut = new System.Windows.Forms.Button();
            this.SearchBut = new System.Windows.Forms.Button();
            this.Radbutgrp = new System.Windows.Forms.GroupBox();
            this.UnitTypeBut = new System.Windows.Forms.RadioButton();
            this.SerialNumbut = new System.Windows.Forms.RadioButton();
            this.CurSertxt = new System.Windows.Forms.TextBox();
            this.NewSertxt = new System.Windows.Forms.TextBox();
            this.CurSerlbl = new System.Windows.Forms.Label();
            this.NewSerlbl = new System.Windows.Forms.Label();
            this.FileLoctxt = new System.Windows.Forms.TextBox();
            this.StatusTx = new System.Windows.Forms.RichTextBox();
            this.RadTypeCombox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Radbutgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Startbut
            // 
            this.Startbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Startbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbut.Location = new System.Drawing.Point(12, 124);
            this.Startbut.Name = "Startbut";
            this.Startbut.Size = new System.Drawing.Size(83, 33);
            this.Startbut.TabIndex = 0;
            this.Startbut.Text = "Start";
            this.Startbut.UseVisualStyleBackColor = false;
            this.Startbut.Click += new System.EventHandler(this.Startbut_Click);
            // 
            // ResetBut
            // 
            this.ResetBut.BackColor = System.Drawing.Color.Red;
            this.ResetBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBut.Location = new System.Drawing.Point(12, 164);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(83, 33);
            this.ResetBut.TabIndex = 1;
            this.ResetBut.Text = "Reset";
            this.ResetBut.UseVisualStyleBackColor = false;
            this.ResetBut.Click += new System.EventHandler(this.ResetBut_Click);
            // 
            // SearchBut
            // 
            this.SearchBut.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBut.Location = new System.Drawing.Point(12, 203);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(83, 33);
            this.SearchBut.TabIndex = 2;
            this.SearchBut.Text = "Search";
            this.SearchBut.UseVisualStyleBackColor = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // Radbutgrp
            // 
            this.Radbutgrp.Controls.Add(this.UnitTypeBut);
            this.Radbutgrp.Controls.Add(this.SerialNumbut);
            this.Radbutgrp.Location = new System.Drawing.Point(101, 124);
            this.Radbutgrp.Name = "Radbutgrp";
            this.Radbutgrp.Size = new System.Drawing.Size(161, 72);
            this.Radbutgrp.TabIndex = 3;
            this.Radbutgrp.TabStop = false;
            this.Radbutgrp.Text = "Select One";
            // 
            // UnitTypeBut
            // 
            this.UnitTypeBut.AutoSize = true;
            this.UnitTypeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTypeBut.Location = new System.Drawing.Point(3, 39);
            this.UnitTypeBut.Name = "UnitTypeBut";
            this.UnitTypeBut.Size = new System.Drawing.Size(84, 20);
            this.UnitTypeBut.TabIndex = 1;
            this.UnitTypeBut.Text = "Unit Type";
            this.UnitTypeBut.UseVisualStyleBackColor = true;
            this.UnitTypeBut.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SerialNumbut
            // 
            this.SerialNumbut.AutoSize = true;
            this.SerialNumbut.Checked = true;
            this.SerialNumbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumbut.Location = new System.Drawing.Point(3, 16);
            this.SerialNumbut.Name = "SerialNumbut";
            this.SerialNumbut.Size = new System.Drawing.Size(112, 20);
            this.SerialNumbut.TabIndex = 0;
            this.SerialNumbut.TabStop = true;
            this.SerialNumbut.Text = "Serial Number";
            this.SerialNumbut.UseVisualStyleBackColor = true;
            this.SerialNumbut.CheckedChanged += new System.EventHandler(this.SerialNumbut_CheckedChanged);
            // 
            // CurSertxt
            // 
            this.CurSertxt.Location = new System.Drawing.Point(378, 131);
            this.CurSertxt.Name = "CurSertxt";
            this.CurSertxt.Size = new System.Drawing.Size(161, 20);
            this.CurSertxt.TabIndex = 4;
            this.CurSertxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewSertxt
            // 
            this.NewSertxt.Location = new System.Drawing.Point(378, 167);
            this.NewSertxt.Name = "NewSertxt";
            this.NewSertxt.Size = new System.Drawing.Size(161, 20);
            this.NewSertxt.TabIndex = 5;
            // 
            // CurSerlbl
            // 
            this.CurSerlbl.AutoSize = true;
            this.CurSerlbl.Location = new System.Drawing.Point(268, 134);
            this.CurSerlbl.Name = "CurSerlbl";
            this.CurSerlbl.Size = new System.Drawing.Size(110, 13);
            this.CurSerlbl.TabIndex = 6;
            this.CurSerlbl.Text = "Current Serial Number";
            this.CurSerlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewSerlbl
            // 
            this.NewSerlbl.AutoSize = true;
            this.NewSerlbl.Location = new System.Drawing.Point(268, 167);
            this.NewSerlbl.Name = "NewSerlbl";
            this.NewSerlbl.Size = new System.Drawing.Size(98, 13);
            this.NewSerlbl.TabIndex = 7;
            this.NewSerlbl.Text = "New Serial Number";
            this.NewSerlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // FileLoctxt
            // 
            this.FileLoctxt.Location = new System.Drawing.Point(104, 216);
            this.FileLoctxt.Name = "FileLoctxt";
            this.FileLoctxt.ReadOnly = true;
            this.FileLoctxt.Size = new System.Drawing.Size(435, 20);
            this.FileLoctxt.TabIndex = 8;
            this.FileLoctxt.Text = "Press Search to find the HEX file you need";
            // 
            // StatusTx
            // 
            this.StatusTx.Location = new System.Drawing.Point(12, 242);
            this.StatusTx.Name = "StatusTx";
            this.StatusTx.ReadOnly = true;
            this.StatusTx.Size = new System.Drawing.Size(250, 148);
            this.StatusTx.TabIndex = 9;
            this.StatusTx.Text = "Status of current Event...";
            // 
            // RadTypeCombox
            // 
            this.RadTypeCombox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RadTypeCombox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RadTypeCombox.FormattingEnabled = true;
            this.RadTypeCombox.Items.AddRange(new object[] {
            "--Radio Types--",
            "AWS",
            "ASSET",
            "--Block Format--",
            "ASSET(Block Format)",
            "--Other--",
            "Other"});
            this.RadTypeCombox.Location = new System.Drawing.Point(268, 242);
            this.RadTypeCombox.Name = "RadTypeCombox";
            this.RadTypeCombox.Size = new System.Drawing.Size(262, 21);
            this.RadTypeCombox.TabIndex = 10;
            this.RadTypeCombox.Text = "Select One....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Calibration_Editor.Properties.Resources.ctdi_11;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RadTypeCombox);
            this.Controls.Add(this.StatusTx);
            this.Controls.Add(this.FileLoctxt);
            this.Controls.Add(this.NewSerlbl);
            this.Controls.Add(this.CurSerlbl);
            this.Controls.Add(this.NewSertxt);
            this.Controls.Add(this.CurSertxt);
            this.Controls.Add(this.Radbutgrp);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.ResetBut);
            this.Controls.Add(this.Startbut);
            this.Name = "Form1";
            this.Text = "Calibration Editor";
            this.Radbutgrp.ResumeLayout(false);
            this.Radbutgrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbut;
        private System.Windows.Forms.Button ResetBut;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.GroupBox Radbutgrp;
        private System.Windows.Forms.RadioButton UnitTypeBut;
        private System.Windows.Forms.RadioButton SerialNumbut;
        private System.Windows.Forms.TextBox CurSertxt;
        private System.Windows.Forms.TextBox NewSertxt;
        private System.Windows.Forms.Label CurSerlbl;
        private System.Windows.Forms.Label NewSerlbl;
        private System.Windows.Forms.TextBox FileLoctxt;
        private System.Windows.Forms.RichTextBox StatusTx;
        private System.Windows.Forms.ComboBox RadTypeCombox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

