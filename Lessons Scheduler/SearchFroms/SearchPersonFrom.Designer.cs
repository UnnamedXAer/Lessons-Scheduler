namespace Lessons_Scheduler.SearchFroms
{
    partial class SearchPersonFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.personSearchPanel = new System.Windows.Forms.Panel();
            this.hidePersonSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openPersonFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lastNameSearchLabel = new System.Windows.Forms.Label();
            this.lastNameSearchBox = new System.Windows.Forms.TextBox();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectPersonButtonDataGridView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameSearchBox = new System.Windows.Forms.TextBox();
            this.personSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personSearchPanel
            // 
            this.personSearchPanel.AutoSize = true;
            this.personSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personSearchPanel.Controls.Add(this.hidePersonSearchButton);
            this.personSearchPanel.Controls.Add(this.label1);
            this.personSearchPanel.Controls.Add(this.openPersonFormLinkLabel);
            this.personSearchPanel.Controls.Add(this.button1);
            this.personSearchPanel.Controls.Add(this.lastNameSearchLabel);
            this.personSearchPanel.Controls.Add(this.lastNameSearchBox);
            this.personSearchPanel.Controls.Add(this.firstNameSearchLabel);
            this.personSearchPanel.Controls.Add(this.peopleDataGridView);
            this.personSearchPanel.Controls.Add(this.firstNameSearchBox);
            this.personSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.personSearchPanel.Name = "personSearchPanel";
            this.personSearchPanel.Size = new System.Drawing.Size(583, 445);
            this.personSearchPanel.TabIndex = 31;
            // 
            // hidePersonSearchButton
            // 
            this.hidePersonSearchButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hidePersonSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.hidePersonSearchButton.Location = new System.Drawing.Point(475, 407);
            this.hidePersonSearchButton.Name = "hidePersonSearchButton";
            this.hidePersonSearchButton.Size = new System.Drawing.Size(99, 30);
            this.hidePersonSearchButton.TabIndex = 27;
            this.hidePersonSearchButton.Text = "Anuluj";
            this.hidePersonSearchButton.UseVisualStyleBackColor = true;
            this.hidePersonSearchButton.Click += new System.EventHandler(this.hidePersonSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Wybierz osobe";
            // 
            // openPersonFormLinkLabel
            // 
            this.openPersonFormLinkLabel.AutoSize = true;
            this.openPersonFormLinkLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openPersonFormLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openPersonFormLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openPersonFormLinkLabel.Location = new System.Drawing.Point(467, 41);
            this.openPersonFormLinkLabel.Name = "openPersonFormLinkLabel";
            this.openPersonFormLinkLabel.Size = new System.Drawing.Size(107, 23);
            this.openPersonFormLinkLabel.TabIndex = 19;
            this.openPersonFormLinkLabel.TabStop = true;
            this.openPersonFormLinkLabel.Text = "Dodaj osobę";
            this.openPersonFormLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openPersonFormLinkLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.button1.Location = new System.Drawing.Point(424, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameSearchLabel
            // 
            this.lastNameSearchLabel.AutoSize = true;
            this.lastNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchLabel.Location = new System.Drawing.Point(2, 90);
            this.lastNameSearchLabel.Name = "lastNameSearchLabel";
            this.lastNameSearchLabel.Size = new System.Drawing.Size(88, 23);
            this.lastNameSearchLabel.TabIndex = 18;
            this.lastNameSearchLabel.Text = "Nazwisko:";
            // 
            // lastNameSearchBox
            // 
            this.lastNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchBox.Location = new System.Drawing.Point(96, 87);
            this.lastNameSearchBox.Name = "lastNameSearchBox";
            this.lastNameSearchBox.Size = new System.Drawing.Size(248, 30);
            this.lastNameSearchBox.TabIndex = 15;
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(2, 47);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(49, 23);
            this.firstNameSearchLabel.TabIndex = 16;
            this.firstNameSearchLabel.Text = "Imię:";
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToAddRows = false;
            this.peopleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.peopleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.peopleDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.selectPersonButtonDataGridView,
            this.Identifier,
            this.fullName});
            this.peopleDataGridView.Location = new System.Drawing.Point(3, 123);
            this.peopleDataGridView.MultiSelect = false;
            this.peopleDataGridView.Name = "peopleDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.peopleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.peopleDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.peopleDataGridView.Size = new System.Drawing.Size(572, 278);
            this.peopleDataGridView.TabIndex = 17;
            this.peopleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleDataGridView_CellContentClick);
            this.peopleDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleDataGridView_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            // 
            // selectPersonButtonDataGridView
            // 
            this.selectPersonButtonDataGridView.HeaderText = "";
            this.selectPersonButtonDataGridView.MinimumWidth = 15;
            this.selectPersonButtonDataGridView.Name = "selectPersonButtonDataGridView";
            this.selectPersonButtonDataGridView.Width = 15;
            // 
            // Identifier
            // 
            this.Identifier.DataPropertyName = "Identifier";
            this.Identifier.HeaderText = "Identyfikator";
            this.Identifier.Name = "Identifier";
            this.Identifier.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "FullName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullName.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullName.HeaderText = "Imie I Nazwisko";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 430;
            // 
            // firstNameSearchBox
            // 
            this.firstNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchBox.Location = new System.Drawing.Point(96, 44);
            this.firstNameSearchBox.Name = "firstNameSearchBox";
            this.firstNameSearchBox.Size = new System.Drawing.Size(248, 30);
            this.firstNameSearchBox.TabIndex = 14;
            // 
            // SearchPersonFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 445);
            this.Controls.Add(this.personSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchPersonFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LessonsScheduler: Wyszukiwanie";
            this.personSearchPanel.ResumeLayout(false);
            this.personSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel personSearchPanel;
        private System.Windows.Forms.Button hidePersonSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel openPersonFormLinkLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lastNameSearchLabel;
        private System.Windows.Forms.TextBox lastNameSearchBox;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.TextBox firstNameSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn selectPersonButtonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
    }
}