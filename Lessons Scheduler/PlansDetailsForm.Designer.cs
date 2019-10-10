namespace Lessons_Scheduler
{
    partial class PlansDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlansDetailsForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.deletePlanButton = new System.Windows.Forms.Button();
            this.printSummaryCheckBox = new System.Windows.Forms.CheckBox();
            this.toPDFCheckBox = new System.Windows.Forms.CheckBox();
            this.toHtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.UnselectAllButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.printPlanButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.yearSearchLabel = new System.Windows.Forms.Label();
            this.groupYearSearchBox = new System.Windows.Forms.TextBox();
            this.groupNameSearchLabel = new System.Windows.Forms.Label();
            this.groupNameSearchBox = new System.Windows.Forms.TextBox();
            this.plansDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.GroupYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupStudNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LesCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubsCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printButtontTolTip = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(272, 36);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Zarządzaj Kierunkami";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.deleteGroupButton);
            this.mainPanel.Controls.Add(this.deletePlanButton);
            this.mainPanel.Controls.Add(this.printSummaryCheckBox);
            this.mainPanel.Controls.Add(this.toPDFCheckBox);
            this.mainPanel.Controls.Add(this.toHtmlCheckBox);
            this.mainPanel.Controls.Add(this.UnselectAllButton);
            this.mainPanel.Controls.Add(this.selectAllButton);
            this.mainPanel.Controls.Add(this.printPlanButton);
            this.mainPanel.Controls.Add(this.searchButton);
            this.mainPanel.Controls.Add(this.yearSearchLabel);
            this.mainPanel.Controls.Add(this.groupYearSearchBox);
            this.mainPanel.Controls.Add(this.groupNameSearchLabel);
            this.mainPanel.Controls.Add(this.groupNameSearchBox);
            this.mainPanel.Controls.Add(this.plansDataGridView);
            this.mainPanel.Location = new System.Drawing.Point(14, 61);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1096, 586);
            this.mainPanel.TabIndex = 9;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.deleteGroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.deleteGroupButton.Location = new System.Drawing.Point(171, 511);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(150, 30);
            this.deleteGroupButton.TabIndex = 31;
            this.deleteGroupButton.Text = "Usuń Kierunek";
            this.printButtontTolTip.SetToolTip(this.deleteGroupButton, "Usuń zaznaczone kierunki.\r\nSpowoduje także usunięcie planu dla danego kierunku.");
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // deletePlanButton
            // 
            this.deletePlanButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.deletePlanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.deletePlanButton.Location = new System.Drawing.Point(4, 511);
            this.deletePlanButton.Name = "deletePlanButton";
            this.deletePlanButton.Size = new System.Drawing.Size(150, 30);
            this.deletePlanButton.TabIndex = 30;
            this.deletePlanButton.Text = "Usuń Plan";
            this.printButtontTolTip.SetToolTip(this.deletePlanButton, "Usuń plan dla każdego z zaznaczonych kierunków\r\n.");
            this.deletePlanButton.UseVisualStyleBackColor = true;
            this.deletePlanButton.Click += new System.EventHandler(this.deletePlanButton_Click);
            // 
            // printSummaryCheckBox
            // 
            this.printSummaryCheckBox.AutoSize = true;
            this.printSummaryCheckBox.Checked = true;
            this.printSummaryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printSummaryCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printSummaryCheckBox.Location = new System.Drawing.Point(481, 465);
            this.printSummaryCheckBox.Name = "printSummaryCheckBox";
            this.printSummaryCheckBox.Size = new System.Drawing.Size(97, 23);
            this.printSummaryCheckBox.TabIndex = 29;
            this.printSummaryCheckBox.Text = "Informacja";
            this.printButtontTolTip.SetToolTip(this.printSummaryCheckBox, "Zaznacz aby wygenerować informacje o brakach w przygotowanym planie jeśli jakieś " +
        "wystąpiły.");
            this.printSummaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // toPDFCheckBox
            // 
            this.toPDFCheckBox.AutoSize = true;
            this.toPDFCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toPDFCheckBox.Location = new System.Drawing.Point(694, 465);
            this.toPDFCheckBox.Name = "toPDFCheckBox";
            this.toPDFCheckBox.Size = new System.Drawing.Size(53, 23);
            this.toPDFCheckBox.TabIndex = 28;
            this.toPDFCheckBox.Text = "PDF";
            this.printButtontTolTip.SetToolTip(this.toPDFCheckBox, "Zaznacz aby stworzyć plik PDF.");
            this.toPDFCheckBox.UseVisualStyleBackColor = true;
            // 
            // toHtmlCheckBox
            // 
            this.toHtmlCheckBox.AutoSize = true;
            this.toHtmlCheckBox.Checked = true;
            this.toHtmlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toHtmlCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toHtmlCheckBox.Location = new System.Drawing.Point(604, 465);
            this.toHtmlCheckBox.Name = "toHtmlCheckBox";
            this.toHtmlCheckBox.Size = new System.Drawing.Size(59, 23);
            this.toHtmlCheckBox.TabIndex = 27;
            this.toHtmlCheckBox.Text = "Html";
            this.printButtontTolTip.SetToolTip(this.toHtmlCheckBox, "Zaznacz aby stworzyć plik Html.");
            this.toHtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // UnselectAllButton
            // 
            this.UnselectAllButton.Font = new System.Drawing.Font("Calibri", 8F);
            this.UnselectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.UnselectAllButton.Location = new System.Drawing.Point(124, 465);
            this.UnselectAllButton.Name = "UnselectAllButton";
            this.UnselectAllButton.Size = new System.Drawing.Size(114, 23);
            this.UnselectAllButton.TabIndex = 26;
            this.UnselectAllButton.Text = "Odznacz wszystkie";
            this.printButtontTolTip.SetToolTip(this.UnselectAllButton, "Odznacz wszystkie pozycje na liście.");
            this.UnselectAllButton.UseVisualStyleBackColor = true;
            this.UnselectAllButton.Click += new System.EventHandler(this.UnselectAllButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Font = new System.Drawing.Font("Calibri", 8F);
            this.selectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.selectAllButton.Location = new System.Drawing.Point(4, 465);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(114, 23);
            this.selectAllButton.TabIndex = 25;
            this.selectAllButton.Text = "Zaznacz wszystkie";
            this.printButtontTolTip.SetToolTip(this.selectAllButton, "Zaznacz wszystkie pozycje na liście.");
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // printPlanButton
            // 
            this.printPlanButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.printPlanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.printPlanButton.Location = new System.Drawing.Point(647, 511);
            this.printPlanButton.Name = "printPlanButton";
            this.printPlanButton.Size = new System.Drawing.Size(150, 30);
            this.printPlanButton.TabIndex = 24;
            this.printPlanButton.Text = "Zapisz";
            this.printButtontTolTip.SetToolTip(this.printPlanButton, "Stwórz plik z planem dla każdej z zaznaczonych kierunków.");
            this.printPlanButton.UseVisualStyleBackColor = true;
            this.printPlanButton.Click += new System.EventHandler(this.printPlanButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(428, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 30);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yearSearchLabel
            // 
            this.yearSearchLabel.AutoSize = true;
            this.yearSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.yearSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.yearSearchLabel.Location = new System.Drawing.Point(6, 49);
            this.yearSearchLabel.Name = "yearSearchLabel";
            this.yearSearchLabel.Size = new System.Drawing.Size(44, 23);
            this.yearSearchLabel.TabIndex = 23;
            this.yearSearchLabel.Text = "Rok:";
            // 
            // groupYearSearchBox
            // 
            this.groupYearSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupYearSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupYearSearchBox.Location = new System.Drawing.Point(100, 46);
            this.groupYearSearchBox.Name = "groupYearSearchBox";
            this.groupYearSearchBox.Size = new System.Drawing.Size(65, 30);
            this.groupYearSearchBox.TabIndex = 20;
            // 
            // groupNameSearchLabel
            // 
            this.groupNameSearchLabel.AutoSize = true;
            this.groupNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameSearchLabel.Location = new System.Drawing.Point(6, 6);
            this.groupNameSearchLabel.Name = "groupNameSearchLabel";
            this.groupNameSearchLabel.Size = new System.Drawing.Size(71, 23);
            this.groupNameSearchLabel.TabIndex = 22;
            this.groupNameSearchLabel.Text = "Nazwa: ";
            // 
            // groupNameSearchBox
            // 
            this.groupNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameSearchBox.Location = new System.Drawing.Point(100, 3);
            this.groupNameSearchBox.Name = "groupNameSearchBox";
            this.groupNameSearchBox.Size = new System.Drawing.Size(478, 30);
            this.groupNameSearchBox.TabIndex = 19;
            // 
            // plansDataGridView
            // 
            this.plansDataGridView.AllowUserToAddRows = false;
            this.plansDataGridView.AllowUserToDeleteRows = false;
            this.plansDataGridView.AllowUserToOrderColumns = true;
            this.plansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.CheckBoxes,
            this.GroupName,
            this.GroupYear,
            this.GroupStudNo,
            this.LesCnt,
            this.SubsCnt});
            this.plansDataGridView.Location = new System.Drawing.Point(4, 82);
            this.plansDataGridView.Name = "plansDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plansDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.plansDataGridView.Size = new System.Drawing.Size(894, 377);
            this.plansDataGridView.TabIndex = 10;
            this.plansDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plansDataGridView_CellContentClick);
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "GroupId";
            this.GroupId.HeaderText = "Id Grupy";
            this.GroupId.Name = "GroupId";
            this.GroupId.Visible = false;
            // 
            // CheckBoxes
            // 
            this.CheckBoxes.HeaderText = " ";
            this.CheckBoxes.Name = "CheckBoxes";
            this.CheckBoxes.Width = 30;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "Nazwa";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GroupName.Width = 400;
            // 
            // GroupYear
            // 
            this.GroupYear.DataPropertyName = "GroupYear";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroupYear.DefaultCellStyle = dataGridViewCellStyle1;
            this.GroupYear.HeaderText = "Rok";
            this.GroupYear.Name = "GroupYear";
            this.GroupYear.ReadOnly = true;
            // 
            // GroupStudNo
            // 
            this.GroupStudNo.DataPropertyName = "GroupStudNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GroupStudNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.GroupStudNo.HeaderText = "Ilość Studentów";
            this.GroupStudNo.Name = "GroupStudNo";
            this.GroupStudNo.ReadOnly = true;
            // 
            // LesCnt
            // 
            this.LesCnt.DataPropertyName = "LessonsCnt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LesCnt.DefaultCellStyle = dataGridViewCellStyle3;
            this.LesCnt.HeaderText = "Ilość Lekcji";
            this.LesCnt.Name = "LesCnt";
            this.LesCnt.ReadOnly = true;
            // 
            // SubsCnt
            // 
            this.SubsCnt.DataPropertyName = "SubjectsCnt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubsCnt.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubsCnt.HeaderText = "Ilość Przedmiotów";
            this.SubsCnt.Name = "SubsCnt";
            this.SubsCnt.ReadOnly = true;
            this.SubsCnt.Width = 120;
            // 
            // PlansDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1122, 659);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PlansDetailsForm";
            this.Text = "LessonsScheduler: Zarządzaj Kierunkami";
            this.Load += new System.EventHandler(this.PlansDetailsForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView plansDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label yearSearchLabel;
        private System.Windows.Forms.TextBox groupYearSearchBox;
        private System.Windows.Forms.Label groupNameSearchLabel;
        private System.Windows.Forms.TextBox groupNameSearchBox;
        private System.Windows.Forms.Button printPlanButton;
        private System.Windows.Forms.ToolTip printButtontTolTip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox toPDFCheckBox;
        private System.Windows.Forms.CheckBox toHtmlCheckBox;
        private System.Windows.Forms.Button UnselectAllButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.CheckBox printSummaryCheckBox;
        private System.Windows.Forms.Button deletePlanButton;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxes;
        private System.Windows.Forms.DataGridViewLinkColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupStudNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LesCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubsCnt;
    }
}