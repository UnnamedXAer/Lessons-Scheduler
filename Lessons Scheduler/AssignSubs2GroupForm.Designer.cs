namespace Lessons_Scheduler
{
    partial class AssignSubs2GroupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignSubs2GroupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.openPersonLookupButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeSubjectButton = new System.Windows.Forms.Button();
            this.unlikSubjectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clearSubNameButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.subNameSearchLabel = new System.Windows.Forms.Label();
            this.subNameSearchBox = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.lookupGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.assignedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notAssignedDataGridView = new System.Windows.Forms.DataGridView();
            this.notAssignedCheckBoxCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notAssignedSubIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAssignedSubNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notAssignedSubTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignSubsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teacherLabel);
            this.panel1.Controls.Add(this.groupNameLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.teacherTextBox);
            this.panel1.Controls.Add(this.lookupGroupButton);
            this.panel1.Controls.Add(this.openPersonLookupButton);
            this.panel1.Controls.Add(this.groupNameTextBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.removeSubjectButton);
            this.panel1.Controls.Add(this.unlikSubjectButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 660);
            this.panel1.TabIndex = 1;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.teacherTextBox.Location = new System.Drawing.Point(451, 115);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(450, 27);
            this.teacherTextBox.TabIndex = 26;
            this.teacherTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teacherTextBox_KeyPress);
            // 
            // openPersonLookupButton
            // 
            this.openPersonLookupButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openPersonLookupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openPersonLookupButton.Location = new System.Drawing.Point(907, 112);
            this.openPersonLookupButton.Name = "openPersonLookupButton";
            this.openPersonLookupButton.Size = new System.Drawing.Size(43, 30);
            this.openPersonLookupButton.TabIndex = 30;
            this.openPersonLookupButton.Text = "...";
            this.openPersonLookupButton.UseVisualStyleBackColor = true;
            this.openPersonLookupButton.Click += new System.EventHandler(this.openPersonLookupButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.saveButton.Location = new System.Drawing.Point(1054, 624);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 30);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeSubjectButton
            // 
            this.removeSubjectButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSubjectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.removeSubjectButton.Location = new System.Drawing.Point(3, 625);
            this.removeSubjectButton.Name = "removeSubjectButton";
            this.removeSubjectButton.Size = new System.Drawing.Size(141, 30);
            this.removeSubjectButton.TabIndex = 29;
            this.removeSubjectButton.Text = "Usuń Przedmiot";
            this.assignSubsToolTip.SetToolTip(this.removeSubjectButton, "Całkowicie usuwa przedmioty (zaznaczone na liście z nieprzypisanymi przedmiotami)" +
        " z systemu.");
            this.removeSubjectButton.UseVisualStyleBackColor = true;
            this.removeSubjectButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // unlikSubjectButton
            // 
            this.unlikSubjectButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unlikSubjectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.unlikSubjectButton.Location = new System.Drawing.Point(451, 295);
            this.unlikSubjectButton.Name = "unlikSubjectButton";
            this.unlikSubjectButton.Size = new System.Drawing.Size(99, 30);
            this.unlikSubjectButton.TabIndex = 26;
            this.unlikSubjectButton.Text = "< Usuń";
            this.assignSubsToolTip.SetToolTip(this.unlikSubjectButton, "Usuń zaznaczone przedmioty z listy dla wybranego kierunku.");
            this.unlikSubjectButton.UseVisualStyleBackColor = true;
            this.unlikSubjectButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.addButton.Location = new System.Drawing.Point(451, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 30);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Dodaj >";
            this.assignSubsToolTip.SetToolTip(this.addButton, "Dodaj zaznaczone przedmioty do listy dla wybranego kierunku.");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.clearSubNameButton);
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.subNameSearchLabel);
            this.panel5.Controls.Add(this.subNameSearchBox);
            this.panel5.Location = new System.Drawing.Point(9, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 92);
            this.panel5.TabIndex = 3;
            // 
            // clearSubNameButton
            // 
            this.clearSubNameButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearSubNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.clearSubNameButton.Location = new System.Drawing.Point(388, 57);
            this.clearSubNameButton.Name = "clearSubNameButton";
            this.clearSubNameButton.Size = new System.Drawing.Size(43, 30);
            this.clearSubNameButton.TabIndex = 15;
            this.clearSubNameButton.Text = "Clr";
            this.clearSubNameButton.UseVisualStyleBackColor = true;
            this.clearSubNameButton.Click += new System.EventHandler(this.clearSubNameButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(284, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 30);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // subNameSearchLabel
            // 
            this.subNameSearchLabel.AutoSize = true;
            this.subNameSearchLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.subNameSearchLabel.Location = new System.Drawing.Point(3, 2);
            this.subNameSearchLabel.Name = "subNameSearchLabel";
            this.subNameSearchLabel.Size = new System.Drawing.Size(60, 19);
            this.subNameSearchLabel.TabIndex = 25;
            this.subNameSearchLabel.Text = "Nazwa: ";
            // 
            // subNameSearchBox
            // 
            this.subNameSearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.subNameSearchBox.Location = new System.Drawing.Point(7, 24);
            this.subNameSearchBox.Name = "subNameSearchBox";
            this.subNameSearchBox.Size = new System.Drawing.Size(425, 27);
            this.subNameSearchBox.TabIndex = 23;
            this.subNameSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subNameSearchBox_KeyPress);
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameLabel.Location = new System.Drawing.Point(451, 41);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(106, 29);
            this.groupNameLabel.TabIndex = 14;
            this.groupNameLabel.Text = "Kierunek:";
            // 
            // lookupGroupButton
            // 
            this.lookupGroupButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lookupGroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lookupGroupButton.Location = new System.Drawing.Point(1158, 44);
            this.lookupGroupButton.Name = "lookupGroupButton";
            this.lookupGroupButton.Size = new System.Drawing.Size(43, 28);
            this.lookupGroupButton.TabIndex = 12;
            this.lookupGroupButton.Text = "...";
            this.lookupGroupButton.UseVisualStyleBackColor = true;
            this.lookupGroupButton.Click += new System.EventHandler(this.lookupGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.BackColor = System.Drawing.Color.White;
            this.groupNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameTextBox.Location = new System.Drawing.Point(563, 44);
            this.groupNameTextBox.Multiline = true;
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.ReadOnly = true;
            this.groupNameTextBox.Size = new System.Drawing.Size(589, 27);
            this.groupNameTextBox.TabIndex = 11;
            this.groupNameTextBox.TextChanged += new System.EventHandler(this.groupNameTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.assignedDataGridView);
            this.panel3.Location = new System.Drawing.Point(556, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 458);
            this.panel3.TabIndex = 1;
            // 
            // assignedDataGridView
            // 
            this.assignedDataGridView.AllowUserToAddRows = false;
            this.assignedDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assignedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assignedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.assignedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.assignedDataGridView.Name = "assignedDataGridView";
            this.assignedDataGridView.RowHeadersWidth = 10;
            this.assignedDataGridView.Size = new System.Drawing.Size(642, 455);
            this.assignedDataGridView.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = " ";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Typ przedmiotu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeacherFullName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Wykładowca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notAssignedDataGridView);
            this.panel2.Location = new System.Drawing.Point(3, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 483);
            this.panel2.TabIndex = 0;
            // 
            // notAssignedDataGridView
            // 
            this.notAssignedDataGridView.AllowUserToAddRows = false;
            this.notAssignedDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notAssignedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.notAssignedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAssignedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notAssignedCheckBoxCol,
            this.notAssignedSubIdCol,
            this.notAssignedSubNameCol,
            this.notAssignedSubTypeCol});
            this.notAssignedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.notAssignedDataGridView.Name = "notAssignedDataGridView";
            this.notAssignedDataGridView.RowHeadersWidth = 10;
            this.notAssignedDataGridView.Size = new System.Drawing.Size(435, 475);
            this.notAssignedDataGridView.TabIndex = 0;
            this.notAssignedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notAssignedDataGridView_CellContentClick);
            // 
            // notAssignedCheckBoxCol
            // 
            this.notAssignedCheckBoxCol.HeaderText = " ";
            this.notAssignedCheckBoxCol.Name = "notAssignedCheckBoxCol";
            this.notAssignedCheckBoxCol.Width = 20;
            // 
            // notAssignedSubIdCol
            // 
            this.notAssignedSubIdCol.DataPropertyName = "Id";
            this.notAssignedSubIdCol.HeaderText = "";
            this.notAssignedSubIdCol.Name = "notAssignedSubIdCol";
            this.notAssignedSubIdCol.ReadOnly = true;
            this.notAssignedSubIdCol.Visible = false;
            this.notAssignedSubIdCol.Width = 5;
            // 
            // notAssignedSubNameCol
            // 
            this.notAssignedSubNameCol.DataPropertyName = "Name";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notAssignedSubNameCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.notAssignedSubNameCol.HeaderText = "Nazwa";
            this.notAssignedSubNameCol.Name = "notAssignedSubNameCol";
            this.notAssignedSubNameCol.ReadOnly = true;
            this.notAssignedSubNameCol.Width = 300;
            // 
            // notAssignedSubTypeCol
            // 
            this.notAssignedSubTypeCol.DataPropertyName = "TypeName";
            this.notAssignedSubTypeCol.HeaderText = "Typ przedmiotu";
            this.notAssignedSubTypeCol.Name = "notAssignedSubTypeCol";
            this.notAssignedSubTypeCol.ReadOnly = true;
            this.notAssignedSubTypeCol.Width = 90;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(3, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(253, 36);
            this.titleLabel.TabIndex = 31;
            this.titleLabel.Text = "Przypisz Przedmioty";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.teacherLabel.Location = new System.Drawing.Point(452, 93);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(89, 19);
            this.teacherLabel.TabIndex = 32;
            this.teacherLabel.Text = "Prowadzący:";
            // 
            // AssignSubs2GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignSubs2GroupForm";
            this.Text = "LessonsScheduler: Przypisz Przedmioty";
            this.Load += new System.EventHandler(this.AssignSubs2GroupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView notAssignedDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView assignedDataGridView;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Button lookupGroupButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label subNameSearchLabel;
        private System.Windows.Forms.TextBox subNameSearchBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button unlikSubjectButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearSubNameButton;
        private System.Windows.Forms.ToolTip assignSubsToolTip;
        private System.Windows.Forms.Button removeSubjectButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn notAssignedCheckBoxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn notAssignedSubIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn notAssignedSubNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn notAssignedSubTypeCol;
        private System.Windows.Forms.Button openPersonLookupButton;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label teacherLabel;
    }
}