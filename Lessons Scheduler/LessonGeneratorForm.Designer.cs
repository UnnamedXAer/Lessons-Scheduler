namespace Lessons_Scheduler
{
    partial class LessonGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonGeneratorForm));
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.lookupGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.startGeneratingButton = new System.Windows.Forms.Button();
            this.clearPalnsButton = new System.Windows.Forms.Button();
            this.generatorProgressBar = new System.Windows.Forms.ProgressBar();
            this.generatorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.generateAllButton = new System.Windows.Forms.Button();
            this.currentGeneratedGrNameTextBox = new System.Windows.Forms.TextBox();
            this.summaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generatorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameLabel.Location = new System.Drawing.Point(11, 384);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(106, 29);
            this.groupNameLabel.TabIndex = 13;
            this.groupNameLabel.Text = "Kierunek:";
            // 
            // lookupGroupButton
            // 
            this.lookupGroupButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lookupGroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.lookupGroupButton.Location = new System.Drawing.Point(666, 416);
            this.lookupGroupButton.Name = "lookupGroupButton";
            this.lookupGroupButton.Size = new System.Drawing.Size(43, 33);
            this.lookupGroupButton.TabIndex = 12;
            this.lookupGroupButton.Text = "...";
            this.generatorToolTip.SetToolTip(this.lookupGroupButton, "Kliknij, aby wybrać kierunek.");
            this.lookupGroupButton.UseVisualStyleBackColor = true;
            this.lookupGroupButton.Click += new System.EventHandler(this.lookupGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupNameTextBox.Location = new System.Drawing.Point(16, 416);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.ReadOnly = true;
            this.groupNameTextBox.Size = new System.Drawing.Size(644, 33);
            this.groupNameTextBox.TabIndex = 11;
            // 
            // startGeneratingButton
            // 
            this.startGeneratingButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGeneratingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.startGeneratingButton.Location = new System.Drawing.Point(16, 455);
            this.startGeneratingButton.Name = "startGeneratingButton";
            this.startGeneratingButton.Size = new System.Drawing.Size(194, 61);
            this.startGeneratingButton.TabIndex = 14;
            this.startGeneratingButton.Text = "Skonfiguruj dla wybranego";
            this.generatorToolTip.SetToolTip(this.startGeneratingButton, "Kliknij, aby skonfigurować plan dla wybranego kierunku.");
            this.startGeneratingButton.UseVisualStyleBackColor = true;
            this.startGeneratingButton.Click += new System.EventHandler(this.startGeneratingButton_Click);
            // 
            // clearPalnsButton
            // 
            this.clearPalnsButton.BackColor = System.Drawing.Color.Maroon;
            this.clearPalnsButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPalnsButton.ForeColor = System.Drawing.Color.White;
            this.clearPalnsButton.Location = new System.Drawing.Point(534, 489);
            this.clearPalnsButton.Name = "clearPalnsButton";
            this.clearPalnsButton.Size = new System.Drawing.Size(96, 56);
            this.clearPalnsButton.TabIndex = 18;
            this.clearPalnsButton.Text = "Clear Plans!";
            this.clearPalnsButton.UseVisualStyleBackColor = false;
            this.clearPalnsButton.Visible = false;
            this.clearPalnsButton.Click += new System.EventHandler(this.clearPalnsButton_Click);
            // 
            // generatorProgressBar
            // 
            this.generatorProgressBar.BackColor = System.Drawing.Color.Snow;
            this.generatorProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.generatorProgressBar.Location = new System.Drawing.Point(17, 275);
            this.generatorProgressBar.Name = "generatorProgressBar";
            this.generatorProgressBar.Size = new System.Drawing.Size(692, 51);
            this.generatorProgressBar.TabIndex = 19;
            // 
            // generatorBackgroundWorker
            // 
            this.generatorBackgroundWorker.WorkerReportsProgress = true;
            // 
            // generateAllButton
            // 
            this.generateAllButton.BackColor = System.Drawing.SystemColors.Control;
            this.generateAllButton.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.generateAllButton.Location = new System.Drawing.Point(18, 106);
            this.generateAllButton.Name = "generateAllButton";
            this.generateAllButton.Size = new System.Drawing.Size(247, 44);
            this.generateAllButton.TabIndex = 20;
            this.generateAllButton.Text = "Konfiguruj wszystkie.";
            this.generatorToolTip.SetToolTip(this.generateAllButton, "Kliknij, aby skonfigurować plan dla każdej grupy, która nie ma jeszcze skonfiguro" +
        "wanego planu.");
            this.generateAllButton.UseVisualStyleBackColor = false;
            this.generateAllButton.Click += new System.EventHandler(this.generateAllButton_Click);
            // 
            // currentGeneratedGrNameTextBox
            // 
            this.currentGeneratedGrNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentGeneratedGrNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.currentGeneratedGrNameTextBox.Location = new System.Drawing.Point(18, 203);
            this.currentGeneratedGrNameTextBox.Name = "currentGeneratedGrNameTextBox";
            this.currentGeneratedGrNameTextBox.Size = new System.Drawing.Size(691, 27);
            this.currentGeneratedGrNameTextBox.TabIndex = 21;
            // 
            // summaryRichTextBox
            // 
            this.summaryRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.summaryRichTextBox.Location = new System.Drawing.Point(727, 48);
            this.summaryRichTextBox.Name = "summaryRichTextBox";
            this.summaryRichTextBox.Size = new System.Drawing.Size(583, 497);
            this.summaryRichTextBox.TabIndex = 23;
            this.summaryRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(13, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Aktualny kierunek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Postęp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(722, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Podsumowanie:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 39);
            this.titleLabel.TabIndex = 27;
            this.titleLabel.Text = "Skonfuguruj Plan";
            // 
            // LessonGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 557);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summaryRichTextBox);
            this.Controls.Add(this.currentGeneratedGrNameTextBox);
            this.Controls.Add(this.generateAllButton);
            this.Controls.Add(this.generatorProgressBar);
            this.Controls.Add(this.clearPalnsButton);
            this.Controls.Add(this.startGeneratingButton);
            this.Controls.Add(this.groupNameLabel);
            this.Controls.Add(this.lookupGroupButton);
            this.Controls.Add(this.groupNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonGeneratorForm";
            this.Text = "LessonsScheduler: Automatyczna Konfiguracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Button lookupGroupButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Button startGeneratingButton;
        private System.Windows.Forms.Button clearPalnsButton;
        private System.Windows.Forms.ProgressBar generatorProgressBar;
        private System.ComponentModel.BackgroundWorker generatorBackgroundWorker;
        private System.Windows.Forms.Button generateAllButton;
        private System.Windows.Forms.TextBox currentGeneratedGrNameTextBox;
        private System.Windows.Forms.RichTextBox summaryRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip generatorToolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titleLabel;
    }
}