namespace Lessons_Scheduler
{
    partial class CreateRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoomForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.sitsNoLabel = new System.Windows.Forms.Label();
            this.sitsNoTextBox = new System.Windows.Forms.TextBox();
            this.wingLabel = new System.Windows.Forms.Label();
            this.wingTextBox = new System.Windows.Forms.TextBox();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(142, 36);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Dodaj Sale";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addRoomButton);
            this.panel1.Controls.Add(this.sitsNoLabel);
            this.panel1.Controls.Add(this.sitsNoTextBox);
            this.panel1.Controls.Add(this.wingLabel);
            this.panel1.Controls.Add(this.wingTextBox);
            this.panel1.Controls.Add(this.roomNoLabel);
            this.panel1.Controls.Add(this.roomNoTextBox);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(49, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 291);
            this.panel1.TabIndex = 2;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.addRoomButton.Location = new System.Drawing.Point(138, 225);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(202, 40);
            this.addRoomButton.TabIndex = 8;
            this.addRoomButton.Text = "Dodaj sale";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // sitsNoLabel
            // 
            this.sitsNoLabel.AutoSize = true;
            this.sitsNoLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sitsNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.sitsNoLabel.Location = new System.Drawing.Point(77, 112);
            this.sitsNoLabel.Name = "sitsNoLabel";
            this.sitsNoLabel.Size = new System.Drawing.Size(130, 29);
            this.sitsNoLabel.TabIndex = 5;
            this.sitsNoLabel.Text = "Ilość miejsc:";
            // 
            // sitsNoTextBox
            // 
            this.sitsNoTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sitsNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.sitsNoTextBox.Location = new System.Drawing.Point(223, 109);
            this.sitsNoTextBox.Name = "sitsNoTextBox";
            this.sitsNoTextBox.Size = new System.Drawing.Size(199, 37);
            this.sitsNoTextBox.TabIndex = 4;
            // 
            // wingLabel
            // 
            this.wingLabel.AutoSize = true;
            this.wingLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.wingLabel.Location = new System.Drawing.Point(106, 71);
            this.wingLabel.Name = "wingLabel";
            this.wingLabel.Size = new System.Drawing.Size(101, 29);
            this.wingLabel.TabIndex = 3;
            this.wingLabel.Text = "Skrzydło:";
            // 
            // wingTextBox
            // 
            this.wingTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.wingTextBox.Location = new System.Drawing.Point(223, 68);
            this.wingTextBox.Name = "wingTextBox";
            this.wingTextBox.Size = new System.Drawing.Size(199, 37);
            this.wingTextBox.TabIndex = 2;
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomNoLabel.Location = new System.Drawing.Point(120, 30);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(87, 29);
            this.roomNoLabel.TabIndex = 1;
            this.roomNoLabel.Text = "Numer:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomNoTextBox.Location = new System.Drawing.Point(223, 27);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(199, 37);
            this.roomNoTextBox.TabIndex = 0;
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 371);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateRoomForm";
            this.Text = "LessonsScheduler: Dodaj Sale";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label sitsNoLabel;
        private System.Windows.Forms.TextBox sitsNoTextBox;
        private System.Windows.Forms.Label wingLabel;
        private System.Windows.Forms.TextBox wingTextBox;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.TextBox roomNoTextBox;
    }
}