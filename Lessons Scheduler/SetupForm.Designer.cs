namespace Lessons_Scheduler
{
    partial class SetupForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupPathLabel = new System.Windows.Forms.Label();
            this.groupPathTexBox = new System.Windows.Forms.TextBox();
            this.personPlanLabel = new System.Windows.Forms.Label();
            this.peoplePathTextBox = new System.Windows.Forms.TextBox();
            this.maxLessonLabel = new System.Windows.Forms.Label();
            this.maxLessonsTextBox = new System.Windows.Forms.TextBox();
            this.groupPathLookupButton = new System.Windows.Forms.Button();
            this.peoplePathLookupButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 36);
            this.titleLabel.TabIndex = 32;
            this.titleLabel.Text = "Ustawienia";
            // 
            // groupPathLabel
            // 
            this.groupPathLabel.AutoSize = true;
            this.groupPathLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupPathLabel.Location = new System.Drawing.Point(12, 62);
            this.groupPathLabel.Name = "groupPathLabel";
            this.groupPathLabel.Size = new System.Drawing.Size(262, 23);
            this.groupPathLabel.TabIndex = 34;
            this.groupPathLabel.Text = "Ścieżka dla planów dla kierunku :";
            // 
            // groupPathTexBox
            // 
            this.groupPathTexBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.groupPathTexBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupPathTexBox.Location = new System.Drawing.Point(18, 88);
            this.groupPathTexBox.Name = "groupPathTexBox";
            this.groupPathTexBox.Size = new System.Drawing.Size(715, 30);
            this.groupPathTexBox.TabIndex = 33;
            this.groupPathTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupPathTexBox_KeyPress);
            // 
            // personPlanLabel
            // 
            this.personPlanLabel.AutoSize = true;
            this.personPlanLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.personPlanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.personPlanLabel.Location = new System.Drawing.Point(12, 142);
            this.personPlanLabel.Name = "personPlanLabel";
            this.personPlanLabel.Size = new System.Drawing.Size(237, 23);
            this.personPlanLabel.TabIndex = 36;
            this.personPlanLabel.Text = "Ścieżka dla planów dla osoby:";
            // 
            // peoplePathTextBox
            // 
            this.peoplePathTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.peoplePathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.peoplePathTextBox.Location = new System.Drawing.Point(16, 168);
            this.peoplePathTextBox.Name = "peoplePathTextBox";
            this.peoplePathTextBox.Size = new System.Drawing.Size(717, 30);
            this.peoplePathTextBox.TabIndex = 35;
            this.peoplePathTextBox.TextChanged += new System.EventHandler(this.peoplePathTextBox_TextChanged);
            this.peoplePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupPathTexBox_KeyPress);
            // 
            // maxLessonLabel
            // 
            this.maxLessonLabel.AutoSize = true;
            this.maxLessonLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.maxLessonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.maxLessonLabel.Location = new System.Drawing.Point(14, 222);
            this.maxLessonLabel.Name = "maxLessonLabel";
            this.maxLessonLabel.Size = new System.Drawing.Size(346, 23);
            this.maxLessonLabel.TabIndex = 38;
            this.maxLessonLabel.Text = "Domyślnie maksymalna ilość lekcji na dzień:";
            // 
            // maxLessonsTextBox
            // 
            this.maxLessonsTextBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.maxLessonsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.maxLessonsTextBox.Location = new System.Drawing.Point(16, 248);
            this.maxLessonsTextBox.Name = "maxLessonsTextBox";
            this.maxLessonsTextBox.Size = new System.Drawing.Size(47, 30);
            this.maxLessonsTextBox.TabIndex = 37;
            // 
            // groupPathLookupButton
            // 
            this.groupPathLookupButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupPathLookupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupPathLookupButton.Location = new System.Drawing.Point(745, 89);
            this.groupPathLookupButton.Name = "groupPathLookupButton";
            this.groupPathLookupButton.Size = new System.Drawing.Size(43, 27);
            this.groupPathLookupButton.TabIndex = 39;
            this.groupPathLookupButton.Text = "...";
            this.groupPathLookupButton.UseVisualStyleBackColor = true;
            this.groupPathLookupButton.Click += new System.EventHandler(this.groupPathLookupButton_Click);
            // 
            // peoplePathLookupButton
            // 
            this.peoplePathLookupButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peoplePathLookupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.peoplePathLookupButton.Location = new System.Drawing.Point(745, 169);
            this.peoplePathLookupButton.Name = "peoplePathLookupButton";
            this.peoplePathLookupButton.Size = new System.Drawing.Size(43, 27);
            this.peoplePathLookupButton.TabIndex = 40;
            this.peoplePathLookupButton.Text = "...";
            this.peoplePathLookupButton.UseVisualStyleBackColor = true;
            this.peoplePathLookupButton.Click += new System.EventHandler(this.peoplePathLookupButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.saveButton.Location = new System.Drawing.Point(653, 242);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 40);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.peoplePathLookupButton);
            this.Controls.Add(this.groupPathLookupButton);
            this.Controls.Add(this.maxLessonLabel);
            this.Controls.Add(this.maxLessonsTextBox);
            this.Controls.Add(this.personPlanLabel);
            this.Controls.Add(this.peoplePathTextBox);
            this.Controls.Add(this.groupPathLabel);
            this.Controls.Add(this.groupPathTexBox);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LessonsScheduler: Ustawienia";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label groupPathLabel;
        private System.Windows.Forms.TextBox groupPathTexBox;
        private System.Windows.Forms.Label personPlanLabel;
        private System.Windows.Forms.TextBox peoplePathTextBox;
        private System.Windows.Forms.Label maxLessonLabel;
        private System.Windows.Forms.TextBox maxLessonsTextBox;
        private System.Windows.Forms.Button groupPathLookupButton;
        private System.Windows.Forms.Button peoplePathLookupButton;
        private System.Windows.Forms.Button saveButton;
    }
}