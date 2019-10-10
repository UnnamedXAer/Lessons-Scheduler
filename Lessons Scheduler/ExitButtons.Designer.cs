namespace Lessons_Scheduler
{
    partial class ExitButtons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downButton
            // 
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(124)))), ((int)(((byte)(106)))));
            this.downButton.Location = new System.Drawing.Point(0, 0);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(36, 38);
            this.downButton.TabIndex = 0;
            this.downButton.Text = "_";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // XButton
            // 
            this.XButton.FlatAppearance.BorderSize = 0;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(124)))), ((int)(((byte)(106)))));
            this.XButton.Location = new System.Drawing.Point(42, -3);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(36, 38);
            this.XButton.TabIndex = 1;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = true;
            // 
            // ExitButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.downButton);
            this.Name = "ExitButtons";
            this.Size = new System.Drawing.Size(82, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button XButton;
    }
}
