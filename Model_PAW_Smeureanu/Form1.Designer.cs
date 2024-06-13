namespace Model_PAW_Smeureanu
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
            this.components = new System.ComponentModel.Container();
            this.btn_AdaugaBilet = new System.Windows.Forms.Button();
            this.lv_Bilete = new System.Windows.Forms.ListView();
            this.cl_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_StatiePlecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataCursei = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Destinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdaugaBilet
            // 
            this.btn_AdaugaBilet.Location = new System.Drawing.Point(50, 54);
            this.btn_AdaugaBilet.Name = "btn_AdaugaBilet";
            this.btn_AdaugaBilet.Size = new System.Drawing.Size(176, 57);
            this.btn_AdaugaBilet.TabIndex = 0;
            this.btn_AdaugaBilet.Text = "Adauga Bilet";
            this.btn_AdaugaBilet.UseVisualStyleBackColor = true;
            this.btn_AdaugaBilet.Click += new System.EventHandler(this.btn_AdaugaBilet_Click);
            // 
            // lv_Bilete
            // 
            this.lv_Bilete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Id,
            this.cl_StatiePlecare,
            this.cl_DataCursei,
            this.cl_Destinatie,
            this.cl_Pret});
            this.lv_Bilete.GridLines = true;
            this.lv_Bilete.HideSelection = false;
            this.lv_Bilete.Location = new System.Drawing.Point(272, 54);
            this.lv_Bilete.Name = "lv_Bilete";
            this.lv_Bilete.Size = new System.Drawing.Size(475, 287);
            this.lv_Bilete.TabIndex = 1;
            this.lv_Bilete.UseCompatibleStateImageBehavior = false;
            this.lv_Bilete.View = System.Windows.Forms.View.Details;
            // 
            // cl_Id
            // 
            this.cl_Id.Text = "Id";
            this.cl_Id.Width = 39;
            // 
            // cl_StatiePlecare
            // 
            this.cl_StatiePlecare.Text = "StatiePlecare";
            this.cl_StatiePlecare.Width = 100;
            // 
            // cl_DataCursei
            // 
            this.cl_DataCursei.Text = "Data Cursei";
            this.cl_DataCursei.Width = 88;
            // 
            // cl_Destinatie
            // 
            this.cl_Destinatie.Text = "Destinatie";
            this.cl_Destinatie.Width = 76;
            // 
            // cl_Pret
            // 
            this.cl_Pret.Text = "Pret";
            this.cl_Pret.Width = 46;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 52);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lv_Bilete);
            this.Controls.Add(this.btn_AdaugaBilet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AdaugaBilet;
        private System.Windows.Forms.ListView lv_Bilete;
        private System.Windows.Forms.ColumnHeader cl_Id;
        private System.Windows.Forms.ColumnHeader cl_StatiePlecare;
        private System.Windows.Forms.ColumnHeader cl_DataCursei;
        private System.Windows.Forms.ColumnHeader cl_Destinatie;
        private System.Windows.Forms.ColumnHeader cl_Pret;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

