namespace Lessons_Scheduler
{
    partial class CreateSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSubjectForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.subjectTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LaboratoryCheckBox = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.projectCheckBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExerciseCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lecturecCheckBox = new System.Windows.Forms.CheckBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.maxHoursNoLabel = new System.Windows.Forms.Label();
            this.maxHoursNoTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.subjectColorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.subjectTypeGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(213, 36);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Dodaj Przedmiot";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.subjectTypeGroupBox);
            this.panel1.Controls.Add(this.addRoomButton);
            this.panel1.Controls.Add(this.maxHoursNoLabel);
            this.panel1.Controls.Add(this.maxHoursNoTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 414);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ColorLabel);
            this.panel2.Controls.Add(this.colorButton);
            this.panel2.Controls.Add(this.colorPanel);
            this.panel2.Location = new System.Drawing.Point(292, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 131);
            this.panel2.TabIndex = 24;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.ColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.ColorLabel.Location = new System.Drawing.Point(3, 3);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(56, 23);
            this.ColorLabel.TabIndex = 22;
            this.ColorLabel.Text = "Kolor:";
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.colorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.colorButton.Location = new System.Drawing.Point(7, 97);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(112, 30);
            this.colorButton.TabIndex = 23;
            this.colorButton.Text = "Wybierz kolor";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.White;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(7, 31);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(112, 60);
            this.colorPanel.TabIndex = 21;
            // 
            // subjectTypeGroupBox
            // 
            this.subjectTypeGroupBox.Controls.Add(this.label2);
            this.subjectTypeGroupBox.Controls.Add(this.panel5);
            this.subjectTypeGroupBox.Controls.Add(this.panel6);
            this.subjectTypeGroupBox.Controls.Add(this.panel4);
            this.subjectTypeGroupBox.Controls.Add(this.panel3);
            this.subjectTypeGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectTypeGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.subjectTypeGroupBox.Location = new System.Drawing.Point(24, 159);
            this.subjectTypeGroupBox.Name = "subjectTypeGroupBox";
            this.subjectTypeGroupBox.Size = new System.Drawing.Size(161, 200);
            this.subjectTypeGroupBox.TabIndex = 19;
            this.subjectTypeGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Typ zajęć:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LaboratoryCheckBox);
            this.panel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.panel5.Location = new System.Drawing.Point(6, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 29);
            this.panel5.TabIndex = 23;
            // 
            // LaboratoryCheckBox
            // 
            this.LaboratoryCheckBox.AutoSize = true;
            this.LaboratoryCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LaboratoryCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.LaboratoryCheckBox.Location = new System.Drawing.Point(3, 3);
            this.LaboratoryCheckBox.Name = "LaboratoryCheckBox";
            this.LaboratoryCheckBox.Size = new System.Drawing.Size(134, 27);
            this.LaboratoryCheckBox.TabIndex = 15;
            this.LaboratoryCheckBox.Text = "Laboratorium";
            this.LaboratoryCheckBox.UseVisualStyleBackColor = true;
            this.LaboratoryCheckBox.CheckedChanged += new System.EventHandler(this.LaboratoryCheckBox_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.projectCheckBox);
            this.panel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(6, 157);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 29);
            this.panel6.TabIndex = 24;
            // 
            // projectCheckBox
            // 
            this.projectCheckBox.AutoSize = true;
            this.projectCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.projectCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.projectCheckBox.Location = new System.Drawing.Point(3, 2);
            this.projectCheckBox.Name = "projectCheckBox";
            this.projectCheckBox.Size = new System.Drawing.Size(84, 27);
            this.projectCheckBox.TabIndex = 16;
            this.projectCheckBox.Text = "Project";
            this.projectCheckBox.UseVisualStyleBackColor = true;
            this.projectCheckBox.CheckedChanged += new System.EventHandler(this.projectCheckBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ExerciseCheckBox);
            this.panel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(6, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 29);
            this.panel4.TabIndex = 22;
            // 
            // ExerciseCheckBox
            // 
            this.ExerciseCheckBox.AutoSize = true;
            this.ExerciseCheckBox.Checked = true;
            this.ExerciseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExerciseCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExerciseCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.ExerciseCheckBox.Location = new System.Drawing.Point(3, 3);
            this.ExerciseCheckBox.Name = "ExerciseCheckBox";
            this.ExerciseCheckBox.Size = new System.Drawing.Size(105, 27);
            this.ExerciseCheckBox.TabIndex = 14;
            this.ExerciseCheckBox.Text = "Ćwiczenia";
            this.ExerciseCheckBox.UseVisualStyleBackColor = true;
            this.ExerciseCheckBox.CheckedChanged += new System.EventHandler(this.ExerciseCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lecturecCheckBox);
            this.panel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(6, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 29);
            this.panel3.TabIndex = 21;
            // 
            // lecturecCheckBox
            // 
            this.lecturecCheckBox.AutoSize = true;
            this.lecturecCheckBox.Checked = true;
            this.lecturecCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lecturecCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lecturecCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lecturecCheckBox.Location = new System.Drawing.Point(3, 2);
            this.lecturecCheckBox.Name = "lecturecCheckBox";
            this.lecturecCheckBox.Size = new System.Drawing.Size(88, 27);
            this.lecturecCheckBox.TabIndex = 13;
            this.lecturecCheckBox.Text = "Wykład";
            this.lecturecCheckBox.UseVisualStyleBackColor = true;
            this.lecturecCheckBox.CheckedChanged += new System.EventHandler(this.lecturecCheckBox_CheckedChanged);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.addRoomButton.Location = new System.Drawing.Point(115, 365);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(202, 40);
            this.addRoomButton.TabIndex = 8;
            this.addRoomButton.Text = "Dodaj przedmiot";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // maxHoursNoLabel
            // 
            this.maxHoursNoLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxHoursNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.maxHoursNoLabel.Location = new System.Drawing.Point(46, 103);
            this.maxHoursNoLabel.Name = "maxHoursNoLabel";
            this.maxHoursNoLabel.Size = new System.Drawing.Size(166, 46);
            this.maxHoursNoLabel.TabIndex = 5;
            this.maxHoursNoLabel.Text = "Maks. ilość godzin w jednym dniu:";
            this.maxHoursNoLabel.Visible = false;
            // 
            // maxHoursNoTextBox
            // 
            this.maxHoursNoTextBox.Font = new System.Drawing.Font("Calibri", 16F);
            this.maxHoursNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.maxHoursNoTextBox.Location = new System.Drawing.Point(220, 110);
            this.maxHoursNoTextBox.Name = "maxHoursNoTextBox";
            this.maxHoursNoTextBox.Size = new System.Drawing.Size(131, 34);
            this.maxHoursNoTextBox.TabIndex = 3;
            this.maxHoursNoTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 16F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.nameLabel.Location = new System.Drawing.Point(19, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 27);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nazwa:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.nameTextBox.Location = new System.Drawing.Point(115, 13);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(304, 87);
            this.nameTextBox.TabIndex = 0;
            // 
            // CreateSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(469, 479);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateSubjectForm";
            this.Text = "LessonsScheduler: Dodaj Przedmiot";
            this.Load += new System.EventHandler(this.CreateSubjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.subjectTypeGroupBox.ResumeLayout(false);
            this.subjectTypeGroupBox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label maxHoursNoLabel;
        private System.Windows.Forms.TextBox maxHoursNoTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox subjectTypeGroupBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox LaboratoryCheckBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox projectCheckBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ExerciseCheckBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox lecturecCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog subjectColorDialog;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel panel2;
    }
}