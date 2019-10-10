namespace Lessons_Scheduler
{
    partial class CreateSummaryForPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSummaryForPerson));
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.toPDFCheckBox = new System.Windows.Forms.CheckBox();
            this.toHtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.printPlanButton = new System.Windows.Forms.Button();
            this.UnselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personFullName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LesCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.identifierSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.IdentifierSearchLabel = new System.Windows.Forms.Label();
            this.firstNameSearchBox = new System.Windows.Forms.TextBox();
            this.lastNameSearchLabel = new System.Windows.Forms.Label();
            this.lastNameSearchBox = new System.Windows.Forms.TextBox();
            this.ButtonsTolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(242, 36);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Zarządzaj Osobami";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletePersonButton);
            this.panel1.Controls.Add(this.toPDFCheckBox);
            this.panel1.Controls.Add(this.toHtmlCheckBox);
            this.panel1.Controls.Add(this.printPlanButton);
            this.panel1.Controls.Add(this.UnselectAllButton);
            this.panel1.Controls.Add(this.selectAllButton);
            this.panel1.Controls.Add(this.peopleDataGridView);
            this.panel1.Controls.Add(this.firstNameSearchLabel);
            this.panel1.Controls.Add(this.identifierSearchBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.IdentifierSearchLabel);
            this.panel1.Controls.Add(this.firstNameSearchBox);
            this.panel1.Controls.Add(this.lastNameSearchLabel);
            this.panel1.Controls.Add(this.lastNameSearchBox);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 586);
            this.panel1.TabIndex = 10;
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.deletePersonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.deletePersonButton.Location = new System.Drawing.Point(3, 547);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(150, 30);
            this.deletePersonButton.TabIndex = 37;
            this.deletePersonButton.Text = "Usuń Osoby";
            this.ButtonsTolTip.SetToolTip(this.deletePersonButton, "Usuń zaznaczone osoby w tabeli.\r\n\r\nUsunięcie osoby spowoduje usunięcie:\r\n- Przedm" +
        "iotu do którego jest przypisana.\r\n- Wszystkich planów dla grup do których przedm" +
        "iot był przypisany.");
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // toPDFCheckBox
            // 
            this.toPDFCheckBox.AutoSize = true;
            this.toPDFCheckBox.Checked = true;
            this.toPDFCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toPDFCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toPDFCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.toPDFCheckBox.Location = new System.Drawing.Point(687, 504);
            this.toPDFCheckBox.Name = "toPDFCheckBox";
            this.toPDFCheckBox.Size = new System.Drawing.Size(53, 23);
            this.toPDFCheckBox.TabIndex = 36;
            this.toPDFCheckBox.Text = "PDF";
            this.ButtonsTolTip.SetToolTip(this.toPDFCheckBox, "Stwórz plik Pdf.");
            this.toPDFCheckBox.UseVisualStyleBackColor = true;
            // 
            // toHtmlCheckBox
            // 
            this.toHtmlCheckBox.AutoSize = true;
            this.toHtmlCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toHtmlCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.toHtmlCheckBox.Location = new System.Drawing.Point(622, 505);
            this.toHtmlCheckBox.Name = "toHtmlCheckBox";
            this.toHtmlCheckBox.Size = new System.Drawing.Size(59, 23);
            this.toHtmlCheckBox.TabIndex = 35;
            this.toHtmlCheckBox.Text = "Html";
            this.ButtonsTolTip.SetToolTip(this.toHtmlCheckBox, "Stwórz plik Html.");
            this.toHtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // printPlanButton
            // 
            this.printPlanButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.printPlanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.printPlanButton.Location = new System.Drawing.Point(590, 547);
            this.printPlanButton.Name = "printPlanButton";
            this.printPlanButton.Size = new System.Drawing.Size(150, 30);
            this.printPlanButton.TabIndex = 34;
            this.printPlanButton.Text = "Zapisz";
            this.ButtonsTolTip.SetToolTip(this.printPlanButton, "Stwórz pliki dla wybranych pozycji w tabeli.");
            this.printPlanButton.UseVisualStyleBackColor = true;
            this.printPlanButton.Click += new System.EventHandler(this.printPlanButton_Click);
            // 
            // UnselectAllButton
            // 
            this.UnselectAllButton.Font = new System.Drawing.Font("Calibri", 8F);
            this.UnselectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.UnselectAllButton.Location = new System.Drawing.Point(123, 505);
            this.UnselectAllButton.Name = "UnselectAllButton";
            this.UnselectAllButton.Size = new System.Drawing.Size(114, 23);
            this.UnselectAllButton.TabIndex = 33;
            this.UnselectAllButton.Text = "Odznacz wszystkie";
            this.ButtonsTolTip.SetToolTip(this.UnselectAllButton, "Odznacz wszystkie wiersze w tabeli.");
            this.UnselectAllButton.UseVisualStyleBackColor = true;
            this.UnselectAllButton.Click += new System.EventHandler(this.UnselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Font = new System.Drawing.Font("Calibri", 8F);
            this.selectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.selectAllButton.Location = new System.Drawing.Point(3, 505);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(114, 23);
            this.selectAllButton.TabIndex = 32;
            this.selectAllButton.Text = "Zaznacz wszystkie";
            this.ButtonsTolTip.SetToolTip(this.selectAllButton, "Zaznacz wszstkie wiersze w tabeli.");
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToAddRows = false;
            this.peopleDataGridView.AllowUserToDeleteRows = false;
            this.peopleDataGridView.AllowUserToOrderColumns = true;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.CheckBoxes,
            this.Identifier,
            this.personFullName,
            this.LesCnt});
            this.peopleDataGridView.Location = new System.Drawing.Point(3, 121);
            this.peopleDataGridView.Name = "peopleDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.peopleDataGridView.Size = new System.Drawing.Size(737, 377);
            this.peopleDataGridView.TabIndex = 31;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "Id";
            this.PersonId.HeaderText = "Id Osoby";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // CheckBoxes
            // 
            this.CheckBoxes.HeaderText = " ";
            this.CheckBoxes.Name = "CheckBoxes";
            this.CheckBoxes.Width = 30;
            // 
            // Identifier
            // 
            this.Identifier.DataPropertyName = "Identifier";
            this.Identifier.HeaderText = "Id";
            this.Identifier.Name = "Identifier";
            this.Identifier.ReadOnly = true;
            this.Identifier.Width = 160;
            // 
            // personFullName
            // 
            this.personFullName.DataPropertyName = "FullName";
            this.personFullName.HeaderText = "Nazwa";
            this.personFullName.Name = "personFullName";
            this.personFullName.ReadOnly = true;
            this.personFullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.personFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.personFullName.Width = 405;
            // 
            // LesCnt
            // 
            this.LesCnt.DataPropertyName = "LessonsCnt";
            this.LesCnt.HeaderText = "Ilość Lekcji";
            this.LesCnt.Name = "LesCnt";
            this.LesCnt.ReadOnly = true;
            this.LesCnt.Width = 99;
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(41, 53);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(49, 23);
            this.firstNameSearchLabel.TabIndex = 30;
            this.firstNameSearchLabel.Text = "Imię:";
            // 
            // identifierSearchBox
            // 
            this.identifierSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.identifierSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.identifierSearchBox.Location = new System.Drawing.Point(446, 50);
            this.identifierSearchBox.Name = "identifierSearchBox";
            this.identifierSearchBox.Size = new System.Drawing.Size(128, 30);
            this.identifierSearchBox.TabIndex = 29;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(590, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 30);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // IdentifierSearchLabel
            // 
            this.IdentifierSearchLabel.AutoSize = true;
            this.IdentifierSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.IdentifierSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.IdentifierSearchLabel.Location = new System.Drawing.Point(356, 53);
            this.IdentifierSearchLabel.Name = "IdentifierSearchLabel";
            this.IdentifierSearchLabel.Size = new System.Drawing.Size(84, 23);
            this.IdentifierSearchLabel.TabIndex = 28;
            this.IdentifierSearchLabel.Text = "Nr Ident.:";
            // 
            // firstNameSearchBox
            // 
            this.firstNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchBox.Location = new System.Drawing.Point(96, 50);
            this.firstNameSearchBox.Name = "firstNameSearchBox";
            this.firstNameSearchBox.Size = new System.Drawing.Size(239, 30);
            this.firstNameSearchBox.TabIndex = 25;
            // 
            // lastNameSearchLabel
            // 
            this.lastNameSearchLabel.AutoSize = true;
            this.lastNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchLabel.Location = new System.Drawing.Point(2, 9);
            this.lastNameSearchLabel.Name = "lastNameSearchLabel";
            this.lastNameSearchLabel.Size = new System.Drawing.Size(88, 23);
            this.lastNameSearchLabel.TabIndex = 27;
            this.lastNameSearchLabel.Text = "Nazwisko:";
            // 
            // lastNameSearchBox
            // 
            this.lastNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchBox.Location = new System.Drawing.Point(96, 6);
            this.lastNameSearchBox.Name = "lastNameSearchBox";
            this.lastNameSearchBox.Size = new System.Drawing.Size(478, 30);
            this.lastNameSearchBox.TabIndex = 24;
            // 
            // CreateSummaryForPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateSummaryForPerson";
            this.Text = "LessonsScheduler: Zarządzaj Osobami";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label IdentifierSearchLabel;
        private System.Windows.Forms.TextBox firstNameSearchBox;
        private System.Windows.Forms.Label lastNameSearchLabel;
        private System.Windows.Forms.TextBox lastNameSearchBox;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.TextBox identifierSearchBox;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.Button UnselectAllButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.CheckBox toPDFCheckBox;
        private System.Windows.Forms.CheckBox toHtmlCheckBox;
        private System.Windows.Forms.Button printPlanButton;
        private System.Windows.Forms.ToolTip ButtonsTolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewLinkColumn personFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LesCnt;
        private System.Windows.Forms.Button deletePersonButton;
    }
}