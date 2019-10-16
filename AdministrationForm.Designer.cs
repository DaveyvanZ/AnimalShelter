namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.btCreateAnimal = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbChip = new System.Windows.Forms.TextBox();
            this.lbSelect = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbChip = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateofBirth = new System.Windows.Forms.Label();
            this.gbCreateAnimal = new System.Windows.Forms.GroupBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhoto = new System.Windows.Forms.TextBox();
            this.btBrowsePicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateWalked = new System.Windows.Forms.DateTimePicker();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBad = new System.Windows.Forms.Label();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.listUnReserved = new System.Windows.Forms.ListBox();
            this.btUnreserveAnimal = new System.Windows.Forms.Button();
            this.btReserve = new System.Windows.Forms.Button();
            this.lbUnreserved = new System.Windows.Forms.Label();
            this.listReserved = new System.Windows.Forms.ListBox();
            this.lbReserved = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbSelectAnimal = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.btShowInfo = new System.Windows.Forms.Button();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCreateAnimal.SuspendLayout();
            this.gpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.cbAnimalType.Location = new System.Drawing.Point(177, 31);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cbAnimalType.TabIndex = 0;
            this.cbAnimalType.SelectedIndexChanged += new System.EventHandler(this.cbAnimalType_SelectedIndexChanged);
            // 
            // btCreateAnimal
            // 
            this.btCreateAnimal.Location = new System.Drawing.Point(177, 255);
            this.btCreateAnimal.Name = "btCreateAnimal";
            this.btCreateAnimal.Size = new System.Drawing.Size(121, 26);
            this.btCreateAnimal.TabIndex = 1;
            this.btCreateAnimal.Text = "Create";
            this.btCreateAnimal.UseVisualStyleBackColor = true;
            this.btCreateAnimal.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(177, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbChip
            // 
            this.tbChip.Location = new System.Drawing.Point(177, 84);
            this.tbChip.Name = "tbChip";
            this.tbChip.Size = new System.Drawing.Size(121, 20);
            this.tbChip.TabIndex = 4;
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSelect.Location = new System.Drawing.Point(20, 35);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(119, 17);
            this.lbSelect.TabIndex = 5;
            this.lbSelect.Text = "Select Cat or Dog";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(20, 61);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // lbChip
            // 
            this.lbChip.AutoSize = true;
            this.lbChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbChip.Location = new System.Drawing.Point(20, 85);
            this.lbChip.Name = "lbChip";
            this.lbChip.Size = new System.Drawing.Size(155, 17);
            this.lbChip.TabIndex = 7;
            this.lbChip.Text = "Chipregistrationnumber";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(177, 110);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(121, 20);
            this.dtBirth.TabIndex = 8;
            // 
            // lbDateofBirth
            // 
            this.lbDateofBirth.AutoSize = true;
            this.lbDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateofBirth.Location = new System.Drawing.Point(20, 110);
            this.lbDateofBirth.Name = "lbDateofBirth";
            this.lbDateofBirth.Size = new System.Drawing.Size(87, 17);
            this.lbDateofBirth.TabIndex = 9;
            this.lbDateofBirth.Text = "Date of Birth";
            // 
            // gbCreateAnimal
            // 
            this.gbCreateAnimal.Controls.Add(this.lblDateOfBirth);
            this.gbCreateAnimal.Controls.Add(this.label2);
            this.gbCreateAnimal.Controls.Add(this.tbPhoto);
            this.gbCreateAnimal.Controls.Add(this.btBrowsePicture);
            this.gbCreateAnimal.Controls.Add(this.label1);
            this.gbCreateAnimal.Controls.Add(this.DateWalked);
            this.gbCreateAnimal.Controls.Add(this.tbBadHabits);
            this.gbCreateAnimal.Controls.Add(this.lbDate);
            this.gbCreateAnimal.Controls.Add(this.lbBad);
            this.gbCreateAnimal.Controls.Add(this.lbSelect);
            this.gbCreateAnimal.Controls.Add(this.cbAnimalType);
            this.gbCreateAnimal.Controls.Add(this.dtBirth);
            this.gbCreateAnimal.Controls.Add(this.btCreateAnimal);
            this.gbCreateAnimal.Controls.Add(this.lbChip);
            this.gbCreateAnimal.Controls.Add(this.tbName);
            this.gbCreateAnimal.Controls.Add(this.lbName);
            this.gbCreateAnimal.Controls.Add(this.tbChip);
            this.gbCreateAnimal.Location = new System.Drawing.Point(12, 47);
            this.gbCreateAnimal.Name = "gbCreateAnimal";
            this.gbCreateAnimal.Size = new System.Drawing.Size(331, 287);
            this.gbCreateAnimal.TabIndex = 10;
            this.gbCreateAnimal.TabStop = false;
            this.gbCreateAnimal.Text = "Create Animal";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(20, 113);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.lblDateOfBirth.TabIndex = 18;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // tbPhoto
            // 
            this.tbPhoto.Location = new System.Drawing.Point(177, 195);
            this.tbPhoto.Name = "tbPhoto";
            this.tbPhoto.Size = new System.Drawing.Size(121, 20);
            this.tbPhoto.TabIndex = 16;
            // 
            // btBrowsePicture
            // 
            this.btBrowsePicture.Location = new System.Drawing.Point(23, 195);
            this.btBrowsePicture.Name = "btBrowsePicture";
            this.btBrowsePicture.Size = new System.Drawing.Size(121, 26);
            this.btBrowsePicture.TabIndex = 15;
            this.btBrowsePicture.Text = "Browse a photo";
            this.btBrowsePicture.UseVisualStyleBackColor = true;
            this.btBrowsePicture.Click += new System.EventHandler(this.btBrowsePicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 14;
            // 
            // DateWalked
            // 
            this.DateWalked.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateWalked.Location = new System.Drawing.Point(177, 163);
            this.DateWalked.Name = "DateWalked";
            this.DateWalked.Size = new System.Drawing.Size(121, 20);
            this.DateWalked.TabIndex = 13;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Enabled = false;
            this.tbBadHabits.Location = new System.Drawing.Point(177, 134);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(121, 20);
            this.tbBadHabits.TabIndex = 12;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDate.Location = new System.Drawing.Point(20, 163);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(114, 17);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Last date walked";
            // 
            // lbBad
            // 
            this.lbBad.AutoSize = true;
            this.lbBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBad.Location = new System.Drawing.Point(20, 136);
            this.lbBad.Name = "lbBad";
            this.lbBad.Size = new System.Drawing.Size(77, 17);
            this.lbBad.TabIndex = 10;
            this.lbBad.Text = "Bad Habits";
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.listUnReserved);
            this.gpInfo.Controls.Add(this.btUnreserveAnimal);
            this.gpInfo.Controls.Add(this.btReserve);
            this.gpInfo.Controls.Add(this.lbUnreserved);
            this.gpInfo.Controls.Add(this.listReserved);
            this.gpInfo.Controls.Add(this.lbReserved);
            this.gpInfo.Controls.Add(this.btRemove);
            this.gpInfo.Controls.Add(this.lbSelectAnimal);
            this.gpInfo.Controls.Add(this.cbAnimal);
            this.gpInfo.Controls.Add(this.btShowInfo);
            this.gpInfo.Location = new System.Drawing.Point(376, 47);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(688, 478);
            this.gpInfo.TabIndex = 12;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Animal Options";
            // 
            // listUnReserved
            // 
            this.listUnReserved.FormattingEnabled = true;
            this.listUnReserved.Location = new System.Drawing.Point(6, 124);
            this.listUnReserved.Name = "listUnReserved";
            this.listUnReserved.Size = new System.Drawing.Size(315, 342);
            this.listUnReserved.TabIndex = 13;
            // 
            // btUnreserveAnimal
            // 
            this.btUnreserveAnimal.Location = new System.Drawing.Point(495, 61);
            this.btUnreserveAnimal.Name = "btUnreserveAnimal";
            this.btUnreserveAnimal.Size = new System.Drawing.Size(105, 26);
            this.btUnreserveAnimal.TabIndex = 21;
            this.btUnreserveAnimal.Text = "Unreserve Animal";
            this.btUnreserveAnimal.UseVisualStyleBackColor = true;
            this.btUnreserveAnimal.Click += new System.EventHandler(this.btUnreserveAnimal_Click);
            // 
            // btReserve
            // 
            this.btReserve.Location = new System.Drawing.Point(380, 61);
            this.btReserve.Name = "btReserve";
            this.btReserve.Size = new System.Drawing.Size(105, 26);
            this.btReserve.TabIndex = 20;
            this.btReserve.Text = "Reserve Animal";
            this.btReserve.UseVisualStyleBackColor = true;
            this.btReserve.Click += new System.EventHandler(this.btReserve_Click);
            // 
            // lbUnreserved
            // 
            this.lbUnreserved.AutoSize = true;
            this.lbUnreserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbUnreserved.Location = new System.Drawing.Point(6, 100);
            this.lbUnreserved.Name = "lbUnreserved";
            this.lbUnreserved.Size = new System.Drawing.Size(82, 17);
            this.lbUnreserved.TabIndex = 14;
            this.lbUnreserved.Text = "Unreserved";
            // 
            // listReserved
            // 
            this.listReserved.FormattingEnabled = true;
            this.listReserved.Location = new System.Drawing.Point(380, 124);
            this.listReserved.Name = "listReserved";
            this.listReserved.Size = new System.Drawing.Size(302, 342);
            this.listReserved.TabIndex = 19;
            // 
            // lbReserved
            // 
            this.lbReserved.AutoSize = true;
            this.lbReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbReserved.Location = new System.Drawing.Point(377, 100);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(69, 17);
            this.lbReserved.TabIndex = 13;
            this.lbReserved.Text = "Reserved";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(117, 61);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(105, 26);
            this.btRemove.TabIndex = 18;
            this.btRemove.Text = "Remove Animal";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbSelectAnimal
            // 
            this.lbSelectAnimal.AutoSize = true;
            this.lbSelectAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSelectAnimal.Location = new System.Drawing.Point(6, 31);
            this.lbSelectAnimal.Name = "lbSelectAnimal";
            this.lbSelectAnimal.Size = new System.Drawing.Size(93, 17);
            this.lbSelectAnimal.TabIndex = 15;
            this.lbSelectAnimal.Text = "Select Animal";
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(105, 30);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(121, 21);
            this.cbAnimal.TabIndex = 14;
            this.cbAnimal.SelectedIndexChanged += new System.EventHandler(this.cbAnimal_SelectedIndexChanged);
            // 
            // btShowInfo
            // 
            this.btShowInfo.Location = new System.Drawing.Point(6, 61);
            this.btShowInfo.Name = "btShowInfo";
            this.btShowInfo.Size = new System.Drawing.Size(105, 26);
            this.btShowInfo.TabIndex = 14;
            this.btShowInfo.Text = "Show Information";
            this.btShowInfo.UseVisualStyleBackColor = true;
            this.btShowInfo.Click += new System.EventHandler(this.btShowInfo_Click);
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(12, 340);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(331, 185);
            this.pbAnimal.TabIndex = 22;
            this.pbAnimal.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Save";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 537);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.gbCreateAnimal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.gbCreateAnimal.ResumeLayout(false);
            this.gbCreateAnimal.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.Button btCreateAnimal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbChip;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbChip;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label lbDateofBirth;
        private System.Windows.Forms.GroupBox gbCreateAnimal;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbBad;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.DateTimePicker DateWalked;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.Label lbSelectAnimal;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Button btShowInfo;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label lbUnreserved;
        private System.Windows.Forms.ListBox listReserved;
        private System.Windows.Forms.Label lbReserved;
        private System.Windows.Forms.Button btUnreserveAnimal;
        private System.Windows.Forms.Button btReserve;
        private System.Windows.Forms.ListBox listUnReserved;
        private System.Windows.Forms.TextBox tbPhoto;
        private System.Windows.Forms.Button btBrowsePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;

    }
}

