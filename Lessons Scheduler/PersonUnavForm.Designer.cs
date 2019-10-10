namespace Lessons_Scheduler
{
    partial class PersonUnavForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonUnavForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.openPersonFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameSearchLabel = new System.Windows.Forms.Label();
            this.lastNameSearchBox = new System.Windows.Forms.TextBox();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.firstNameSearchBox = new System.Windows.Forms.TextBox();
            this.plus0Label = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.unavListBox = new System.Windows.Forms.ListBox();
            this.savePersonUnavButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.hoursListBox = new System.Windows.Forms.ListBox();
            this.daysListBox = new System.Windows.Forms.ListBox();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.openPersonFormLinkLabel);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.lastNameSearchLabel);
            this.panel1.Controls.Add(this.lastNameSearchBox);
            this.panel1.Controls.Add(this.firstNameSearchLabel);
            this.panel1.Controls.Add(this.firstNameSearchBox);
            this.panel1.Controls.Add(this.plus0Label);
            this.panel1.Controls.Add(this.plusLabel);
            this.panel1.Controls.Add(this.unavListBox);
            this.panel1.Controls.Add(this.savePersonUnavButton);
            this.panel1.Controls.Add(this.moveLeftButton);
            this.panel1.Controls.Add(this.moveRightButton);
            this.panel1.Controls.Add(this.hoursListBox);
            this.panel1.Controls.Add(this.daysListBox);
            this.panel1.Controls.Add(this.peopleListBox);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 472);
            this.panel1.TabIndex = 0;
            // 
            // openPersonFormLinkLabel
            // 
            this.openPersonFormLinkLabel.AutoSize = true;
            this.openPersonFormLinkLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openPersonFormLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openPersonFormLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.openPersonFormLinkLabel.Location = new System.Drawing.Point(428, 12);
            this.openPersonFormLinkLabel.Name = "openPersonFormLinkLabel";
            this.openPersonFormLinkLabel.Size = new System.Drawing.Size(107, 23);
            this.openPersonFormLinkLabel.TabIndex = 30;
            this.openPersonFormLinkLabel.TabStop = true;
            this.openPersonFormLinkLabel.Text = "Dodaj osobę";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(385, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 30);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lastNameSearchLabel
            // 
            this.lastNameSearchLabel.AutoSize = true;
            this.lastNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchLabel.Location = new System.Drawing.Point(11, 58);
            this.lastNameSearchLabel.Name = "lastNameSearchLabel";
            this.lastNameSearchLabel.Size = new System.Drawing.Size(88, 23);
            this.lastNameSearchLabel.TabIndex = 29;
            this.lastNameSearchLabel.Text = "Nazwisko:";
            // 
            // lastNameSearchBox
            // 
            this.lastNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.lastNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lastNameSearchBox.Location = new System.Drawing.Point(105, 55);
            this.lastNameSearchBox.Name = "lastNameSearchBox";
            this.lastNameSearchBox.Size = new System.Drawing.Size(248, 30);
            this.lastNameSearchBox.TabIndex = 26;
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(11, 15);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(49, 23);
            this.firstNameSearchLabel.TabIndex = 28;
            this.firstNameSearchLabel.Text = "Imię:";
            // 
            // firstNameSearchBox
            // 
            this.firstNameSearchBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.firstNameSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.firstNameSearchBox.Location = new System.Drawing.Point(105, 12);
            this.firstNameSearchBox.Name = "firstNameSearchBox";
            this.firstNameSearchBox.Size = new System.Drawing.Size(248, 30);
            this.firstNameSearchBox.TabIndex = 25;
            // 
            // plus0Label
            // 
            this.plus0Label.AutoSize = true;
            this.plus0Label.Font = new System.Drawing.Font("Calibri", 14F);
            this.plus0Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.plus0Label.Location = new System.Drawing.Point(291, 202);
            this.plus0Label.Name = "plus0Label";
            this.plus0Label.Size = new System.Drawing.Size(19, 23);
            this.plus0Label.TabIndex = 24;
            this.plus0Label.Text = "+";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.plusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.plusLabel.Location = new System.Drawing.Point(446, 202);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(19, 23);
            this.plusLabel.TabIndex = 23;
            this.plusLabel.Text = "+";
            // 
            // unavListBox
            // 
            this.unavListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.unavListBox.FormattingEnabled = true;
            this.unavListBox.Location = new System.Drawing.Point(663, 12);
            this.unavListBox.Name = "unavListBox";
            this.unavListBox.Size = new System.Drawing.Size(331, 407);
            this.unavListBox.TabIndex = 6;
            // 
            // savePersonUnavButton
            // 
            this.savePersonUnavButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savePersonUnavButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.savePersonUnavButton.Location = new System.Drawing.Point(812, 436);
            this.savePersonUnavButton.Name = "savePersonUnavButton";
            this.savePersonUnavButton.Size = new System.Drawing.Size(182, 31);
            this.savePersonUnavButton.TabIndex = 5;
            this.savePersonUnavButton.Text = "Zapisz";
            this.savePersonUnavButton.UseVisualStyleBackColor = true;
            this.savePersonUnavButton.Click += new System.EventHandler(this.savePersonUnavButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveLeftButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.moveLeftButton.Location = new System.Drawing.Point(595, 233);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(62, 31);
            this.moveLeftButton.TabIndex = 4;
            this.moveLeftButton.Text = "Usuń";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveRightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.moveRightButton.Location = new System.Drawing.Point(595, 169);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(62, 31);
            this.moveRightButton.TabIndex = 3;
            this.moveRightButton.Text = "Dodaj";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // hoursListBox
            // 
            this.hoursListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.hoursListBox.FormattingEnabled = true;
            this.hoursListBox.Location = new System.Drawing.Point(470, 169);
            this.hoursListBox.Name = "hoursListBox";
            this.hoursListBox.Size = new System.Drawing.Size(119, 95);
            this.hoursListBox.TabIndex = 2;
            // 
            // daysListBox
            // 
            this.daysListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.daysListBox.FormattingEnabled = true;
            this.daysListBox.Location = new System.Drawing.Point(317, 180);
            this.daysListBox.Name = "daysListBox";
            this.daysListBox.Size = new System.Drawing.Size(123, 69);
            this.daysListBox.TabIndex = 1;
            // 
            // peopleListBox
            // 
            this.peopleListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.Location = new System.Drawing.Point(3, 107);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(282, 342);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.SelectedIndexChanged += new System.EventHandler(this.peopleListBox_SelectedIndexChanged);
            // 
            // PersonUnavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1023, 513);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonUnavForm";
            this.Text = "LessonsScheduler: Zdefiniuj Zajętość";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button savePersonUnavButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.ListBox hoursListBox;
        private System.Windows.Forms.ListBox daysListBox;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.ListBox unavListBox;
        private System.Windows.Forms.Label plus0Label;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.LinkLabel openPersonFormLinkLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lastNameSearchLabel;
        private System.Windows.Forms.TextBox lastNameSearchBox;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.TextBox firstNameSearchBox;
    }
}