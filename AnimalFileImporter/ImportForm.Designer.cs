namespace AnimalFileImporter
{
    partial class AnimalFileImporterForm
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
            this.lbDog = new System.Windows.Forms.ListBox();
            this.lbCat = new System.Windows.Forms.ListBox();
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbDog
            // 
            this.lbDog.FormattingEnabled = true;
            this.lbDog.Location = new System.Drawing.Point(26, 12);
            this.lbDog.Name = "lbDog";
            this.lbDog.Size = new System.Drawing.Size(214, 173);
            this.lbDog.TabIndex = 0;
            // 
            // lbCat
            // 
            this.lbCat.FormattingEnabled = true;
            this.lbCat.Location = new System.Drawing.Point(26, 203);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(214, 173);
            this.lbCat.TabIndex = 1;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(246, 12);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(199, 364);
            this.btImport.TabIndex = 2;
            this.btImport.Text = "import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AnimalFileImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 406);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.lbDog);
            this.Name = "AnimalFileImporterForm";
            this.Text = "AnimalFileImporter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDog;
        private System.Windows.Forms.ListBox lbCat;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

