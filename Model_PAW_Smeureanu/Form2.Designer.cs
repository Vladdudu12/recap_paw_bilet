namespace Model_PAW_Smeureanu
{
    partial class Form2
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
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_StatiePlecare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DataCursei = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Destinatie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Pret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(169, 63);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(261, 22);
            this.tb_Id.TabIndex = 0;
            // 
            // tb_StatiePlecare
            // 
            this.tb_StatiePlecare.Location = new System.Drawing.Point(169, 126);
            this.tb_StatiePlecare.Name = "tb_StatiePlecare";
            this.tb_StatiePlecare.Size = new System.Drawing.Size(261, 22);
            this.tb_StatiePlecare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Statie Plecare";
            // 
            // dtp_DataCursei
            // 
            this.dtp_DataCursei.Location = new System.Drawing.Point(169, 192);
            this.dtp_DataCursei.Name = "dtp_DataCursei";
            this.dtp_DataCursei.Size = new System.Drawing.Size(261, 22);
            this.dtp_DataCursei.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Cursei";
            // 
            // cb_Destinatie
            // 
            this.cb_Destinatie.FormattingEnabled = true;
            this.cb_Destinatie.Items.AddRange(new object[] {
            "Bucuresti",
            "Ploiesti",
            "Pitesti",
            "Buhusi",
            "Prahova"});
            this.cb_Destinatie.Location = new System.Drawing.Point(169, 261);
            this.cb_Destinatie.Name = "cb_Destinatie";
            this.cb_Destinatie.Size = new System.Drawing.Size(261, 24);
            this.cb_Destinatie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destinatie";
            // 
            // tb_Pret
            // 
            this.tb_Pret.Location = new System.Drawing.Point(169, 326);
            this.tb_Pret.Name = "tb_Pret";
            this.tb_Pret.Size = new System.Drawing.Size(261, 22);
            this.tb_Pret.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pret";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(42, 393);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 40);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(258, 393);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(172, 40);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 478);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Pret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Destinatie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_DataCursei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_StatiePlecare);
            this.Controls.Add(this.tb_Id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_StatiePlecare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DataCursei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Destinatie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Pret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}