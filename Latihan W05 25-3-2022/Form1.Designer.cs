
namespace Latihan_W05_25_3_2022
{
    partial class FormTugas
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.checkBoxBlock = new System.Windows.Forms.CheckBox();
            this.lBoxKiri = new System.Windows.Forms.ListBox();
            this.lBoxKanan = new System.Windows.Forms.ListBox();
            this.btnFullKanan = new System.Windows.Forms.Button();
            this.btnKanan = new System.Windows.Forms.Button();
            this.btnKiri = new System.Windows.Forms.Button();
            this.btnFullKiri = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(32, 38);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 17);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(32, 80);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(47, 17);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "Mode:";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(94, 35);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(362, 22);
            this.txtBoxData.TabIndex = 2;
            // 
            // cBoxMode
            // 
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Items.AddRange(new object[] {
            "Add",
            "Replace"});
            this.cBoxMode.Location = new System.Drawing.Point(94, 77);
            this.cBoxMode.Name = "cBoxMode";
            this.cBoxMode.Size = new System.Drawing.Size(177, 24);
            this.cBoxMode.TabIndex = 3;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(35, 122);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(91, 33);
            this.btnProses.TabIndex = 4;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // checkBoxBlock
            // 
            this.checkBoxBlock.AutoSize = true;
            this.checkBoxBlock.Location = new System.Drawing.Point(336, 129);
            this.checkBoxBlock.Name = "checkBoxBlock";
            this.checkBoxBlock.Size = new System.Drawing.Size(64, 21);
            this.checkBoxBlock.TabIndex = 5;
            this.checkBoxBlock.Text = "Block";
            this.checkBoxBlock.UseVisualStyleBackColor = true;
            this.checkBoxBlock.CheckedChanged += new System.EventHandler(this.checkBoxBlock_CheckedChanged);
            // 
            // lBoxKiri
            // 
            this.lBoxKiri.FormattingEnabled = true;
            this.lBoxKiri.ItemHeight = 16;
            this.lBoxKiri.Location = new System.Drawing.Point(35, 167);
            this.lBoxKiri.Name = "lBoxKiri";
            this.lBoxKiri.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxKiri.Size = new System.Drawing.Size(194, 260);
            this.lBoxKiri.TabIndex = 6;
            // 
            // lBoxKanan
            // 
            this.lBoxKanan.FormattingEnabled = true;
            this.lBoxKanan.ItemHeight = 16;
            this.lBoxKanan.Location = new System.Drawing.Point(336, 167);
            this.lBoxKanan.Name = "lBoxKanan";
            this.lBoxKanan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxKanan.Size = new System.Drawing.Size(194, 260);
            this.lBoxKanan.TabIndex = 7;
            // 
            // btnFullKanan
            // 
            this.btnFullKanan.Location = new System.Drawing.Point(262, 183);
            this.btnFullKanan.Name = "btnFullKanan";
            this.btnFullKanan.Size = new System.Drawing.Size(40, 30);
            this.btnFullKanan.TabIndex = 8;
            this.btnFullKanan.Text = ">>";
            this.btnFullKanan.UseVisualStyleBackColor = true;
            this.btnFullKanan.Click += new System.EventHandler(this.btnFullKanan_Click);
            // 
            // btnKanan
            // 
            this.btnKanan.Location = new System.Drawing.Point(262, 233);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(40, 30);
            this.btnKanan.TabIndex = 9;
            this.btnKanan.Text = ">";
            this.btnKanan.UseVisualStyleBackColor = true;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // btnKiri
            // 
            this.btnKiri.Location = new System.Drawing.Point(262, 281);
            this.btnKiri.Name = "btnKiri";
            this.btnKiri.Size = new System.Drawing.Size(40, 30);
            this.btnKiri.TabIndex = 10;
            this.btnKiri.Text = "<";
            this.btnKiri.UseVisualStyleBackColor = true;
            this.btnKiri.Click += new System.EventHandler(this.btnKiri_Click);
            // 
            // btnFullKiri
            // 
            this.btnFullKiri.Location = new System.Drawing.Point(262, 334);
            this.btnFullKiri.Name = "btnFullKiri";
            this.btnFullKiri.Size = new System.Drawing.Size(40, 30);
            this.btnFullKiri.TabIndex = 11;
            this.btnFullKiri.Text = "<<";
            this.btnFullKiri.UseVisualStyleBackColor = true;
            this.btnFullKiri.Click += new System.EventHandler(this.btnFullKiri_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(262, 389);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(40, 30);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "X";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnFullKiri);
            this.Controls.Add(this.btnKiri);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnFullKanan);
            this.Controls.Add(this.lBoxKanan);
            this.Controls.Add(this.lBoxKiri);
            this.Controls.Add(this.checkBoxBlock);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.cBoxMode);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblData);
            this.Name = "FormTugas";
            this.Text = "Form Tugas";
            this.Load += new System.EventHandler(this.FormTugas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.ComboBox cBoxMode;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.CheckBox checkBoxBlock;
        private System.Windows.Forms.ListBox lBoxKiri;
        private System.Windows.Forms.ListBox lBoxKanan;
        private System.Windows.Forms.Button btnFullKanan;
        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.Button btnKiri;
        private System.Windows.Forms.Button btnFullKiri;
        private System.Windows.Forms.Button btnHapus;
    }
}

