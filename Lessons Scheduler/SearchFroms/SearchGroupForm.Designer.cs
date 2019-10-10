namespace Lessons_Scheduler.SearchFroms
{
    partial class SearchGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGroupForm));
            this.lookupGroupPanel = new System.Windows.Forms.Panel();
            this.openGroupFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.lookupDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameSearchBox = new System.Windows.Forms.Label();
            this.groupYearSearchBox = new System.Windows.Forms.Label();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.yearSearchBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lookupGrupTitleLabel = new System.Windows.Forms.Label();
            this.lookupGroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lookupGroupPanel
            // 
            this.lookupGroupPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.lookupGroupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lookupGroupPanel.Controls.Add(this.openGroupFormLinkLabel);
            this.lookupGroupPanel.Controls.Add(this.searchButton);
            this.lookupGroupPanel.Controls.Add(this.lookupDataGridView);
            this.lookupGroupPanel.Controls.Add(this.groupNameSearchBox);
            this.lookupGroupPanel.Controls.Add(this.groupYearSearchBox);
            this.lookupGroupPanel.Controls.Add(this.nameSearchBox);
            this.lookupGroupPanel.Controls.Add(this.yearSearchBox);
            this.lookupGroupPanel.Location = new System.Drawing.Point(12, 42);
            this.lookupGroupPanel.Name = "lookupGroupPanel";
            this.lookupGroupPanel.Size = new System.Drawing.Size(607, 402);
            this.lookupGroupPanel.TabIndex = 10;
            // 
            // openGroupFormLinkLabel
            // 
            this.openGroupFormLinkLabel.AutoSize = true;
            this.openGroupFormLinkLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openGroupFormLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openGroupFormLinkLabel.Location = new System.Drawing.Point(495, 2);
            this.openGroupFormLinkLabel.Name = "openGroupFormLinkLabel";
            this.openGroupFormLinkLabel.Size = new System.Drawing.Size(106, 19);
            this.openGroupFormLinkLabel.TabIndex = 21;
            this.openGroupFormLinkLabel.TabStop = true;
            this.openGroupFormLinkLabel.Text = "Dodaj kierunek";
            this.openGroupFormLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openGroupFormLinkLabel_LinkClicked);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(499, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 27);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lookupDataGridView
            // 
            this.lookupDataGridView.AllowUserToDeleteRows = false;
            this.lookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lookupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectButton,
            this.id,
            this.year,
            this.name});
            this.lookupDataGridView.Location = new System.Drawing.Point(6, 91);
            this.lookupDataGridView.Name = "lookupDataGridView";
            this.lookupDataGridView.Size = new System.Drawing.Size(594, 306);
            this.lookupDataGridView.TabIndex = 5;
            this.lookupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lookupDataGridView_CellContentClick);
            this.lookupDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lookupDataGridView_CellContentDoubleClick);
            this.lookupDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lookupDataGridView_CellMouseEnter);
            // 
            // selectButton
            // 
            this.selectButton.DataPropertyName = "\"◉\"";
            this.selectButton.HeaderText = "";
            this.selectButton.Name = "selectButton";
            this.selectButton.ToolTipText = "Kliknij aby wybrać.";
            this.selectButton.Width = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MaxInputLength = 1;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 60;
            // 
            // year
            // 
            this.year.DataPropertyName = "Year";
            this.year.HeaderText = "Rok";
            this.year.MaxInputLength = 1;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Nazwa";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 400;
            // 
            // groupNameSearchBox
            // 
            this.groupNameSearchBox.AutoSize = true;
            this.groupNameSearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameSearchBox.Location = new System.Drawing.Point(7, 39);
            this.groupNameSearchBox.Name = "groupNameSearchBox";
            this.groupNameSearchBox.Size = new System.Drawing.Size(56, 19);
            this.groupNameSearchBox.TabIndex = 4;
            this.groupNameSearchBox.Text = "Nazwa:";
            // 
            // groupYearSearchBox
            // 
            this.groupYearSearchBox.AutoSize = true;
            this.groupYearSearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupYearSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupYearSearchBox.Location = new System.Drawing.Point(7, 6);
            this.groupYearSearchBox.Name = "groupYearSearchBox";
            this.groupYearSearchBox.Size = new System.Drawing.Size(37, 19);
            this.groupYearSearchBox.TabIndex = 3;
            this.groupYearSearchBox.Text = "Rok:";
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameSearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.nameSearchBox.Location = new System.Drawing.Point(69, 36);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(424, 27);
            this.nameSearchBox.TabIndex = 2;
            // 
            // yearSearchBox
            // 
            this.yearSearchBox.BackColor = System.Drawing.SystemColors.Control;
            this.yearSearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.yearSearchBox.Location = new System.Drawing.Point(69, 3);
            this.yearSearchBox.Name = "yearSearchBox";
            this.yearSearchBox.Size = new System.Drawing.Size(75, 27);
            this.yearSearchBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(544, 450);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 32);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.lookupGroupCancelButton_Click);
            // 
            // lookupGrupTitleLabel
            // 
            this.lookupGrupTitleLabel.AutoSize = true;
            this.lookupGrupTitleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lookupGrupTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lookupGrupTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.lookupGrupTitleLabel.Name = "lookupGrupTitleLabel";
            this.lookupGrupTitleLabel.Size = new System.Drawing.Size(148, 23);
            this.lookupGrupTitleLabel.TabIndex = 11;
            this.lookupGrupTitleLabel.Text = "Wybierz Kierunek";
            // 
            // SearchGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(631, 485);
            this.Controls.Add(this.lookupGrupTitleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lookupGroupPanel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LessonsScheduler: Wyszukiwanie";
            this.Load += new System.EventHandler(this.SearchGroupForm_Load);
            this.lookupGroupPanel.ResumeLayout(false);
            this.lookupGroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lookupGroupPanel;
        private System.Windows.Forms.DataGridView lookupDataGridView;
        private System.Windows.Forms.Label groupNameSearchBox;
        private System.Windows.Forms.Label groupYearSearchBox;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.TextBox yearSearchBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lookupGrupTitleLabel;
        private System.Windows.Forms.LinkLabel openGroupFormLinkLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewButtonColumn selectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}