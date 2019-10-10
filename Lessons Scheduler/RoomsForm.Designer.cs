namespace Lessons_Scheduler
{
    partial class RoomsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.ChecboxesRoomsCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoomIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomWingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomSitsNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.romoveRoomButton = new System.Windows.Forms.Button();
            this.wingLabel = new System.Windows.Forms.Label();
            this.roomWingTextBox = new System.Windows.Forms.TextBox();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 36);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Zarządzaj Salami";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roomsDataGridView);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.romoveRoomButton);
            this.panel1.Controls.Add(this.wingLabel);
            this.panel1.Controls.Add(this.roomWingTextBox);
            this.panel1.Controls.Add(this.roomNoLabel);
            this.panel1.Controls.Add(this.roomNoTextBox);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 523);
            this.panel1.TabIndex = 4;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AllowUserToDeleteRows = false;
            this.roomsDataGridView.AllowUserToOrderColumns = true;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChecboxesRoomsCol,
            this.RoomIdCol,
            this.RoomNoCol,
            this.RoomWingCol,
            this.RoomSitsNoCol});
            this.roomsDataGridView.Location = new System.Drawing.Point(70, 59);
            this.roomsDataGridView.Name = "roomsDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.roomsDataGridView.Size = new System.Drawing.Size(387, 422);
            this.roomsDataGridView.TabIndex = 10;
            // 
            // ChecboxesRoomsCol
            // 
            this.ChecboxesRoomsCol.HeaderText = " ";
            this.ChecboxesRoomsCol.Name = "ChecboxesRoomsCol";
            this.ChecboxesRoomsCol.Width = 25;
            // 
            // RoomIdCol
            // 
            this.RoomIdCol.DataPropertyName = "Id";
            this.RoomIdCol.HeaderText = "roomid";
            this.RoomIdCol.Name = "RoomIdCol";
            this.RoomIdCol.ReadOnly = true;
            this.RoomIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomIdCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RoomIdCol.Visible = false;
            this.RoomIdCol.Width = 5;
            // 
            // RoomNoCol
            // 
            this.RoomNoCol.DataPropertyName = "RoomNo";
            this.RoomNoCol.HeaderText = "Nr sali";
            this.RoomNoCol.Name = "RoomNoCol";
            this.RoomNoCol.ReadOnly = true;
            // 
            // RoomWingCol
            // 
            this.RoomWingCol.DataPropertyName = "Wing";
            this.RoomWingCol.HeaderText = "Skrzydło";
            this.RoomWingCol.Name = "RoomWingCol";
            this.RoomWingCol.ReadOnly = true;
            // 
            // RoomSitsNoCol
            // 
            this.RoomSitsNoCol.DataPropertyName = "SitsCnt";
            this.RoomSitsNoCol.HeaderText = "Ilość miejsc";
            this.RoomSitsNoCol.Name = "RoomSitsNoCol";
            this.RoomSitsNoCol.ReadOnly = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.searchButton.Location = new System.Drawing.Point(421, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 27);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // romoveRoomButton
            // 
            this.romoveRoomButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.romoveRoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.romoveRoomButton.Location = new System.Drawing.Point(393, 487);
            this.romoveRoomButton.Name = "romoveRoomButton";
            this.romoveRoomButton.Size = new System.Drawing.Size(124, 31);
            this.romoveRoomButton.TabIndex = 8;
            this.romoveRoomButton.Text = "Usuń sale";
            this.romoveRoomButton.UseVisualStyleBackColor = true;
            this.romoveRoomButton.Click += new System.EventHandler(this.romoveRoomButton_Click);
            // 
            // wingLabel
            // 
            this.wingLabel.AutoSize = true;
            this.wingLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.wingLabel.Location = new System.Drawing.Point(226, 15);
            this.wingLabel.Name = "wingLabel";
            this.wingLabel.Size = new System.Drawing.Size(65, 19);
            this.wingLabel.TabIndex = 3;
            this.wingLabel.Text = "Skrzydło:";
            // 
            // roomWingTextBox
            // 
            this.roomWingTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomWingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomWingTextBox.Location = new System.Drawing.Point(297, 12);
            this.roomWingTextBox.Name = "roomWingTextBox";
            this.roomWingTextBox.Size = new System.Drawing.Size(108, 27);
            this.roomWingTextBox.TabIndex = 2;
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomNoLabel.Location = new System.Drawing.Point(8, 15);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(56, 19);
            this.roomNoLabel.TabIndex = 1;
            this.roomNoLabel.Text = "Numer:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.roomNoTextBox.Location = new System.Drawing.Point(70, 12);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(108, 27);
            this.roomNoTextBox.TabIndex = 0;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 583);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomsForm";
            this.Text = "LessonsScheduler: Zarządzaj Salami";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button romoveRoomButton;
        private System.Windows.Forms.Label wingLabel;
        private System.Windows.Forms.TextBox roomWingTextBox;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChecboxesRoomsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomWingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomSitsNoCol;
    }
}