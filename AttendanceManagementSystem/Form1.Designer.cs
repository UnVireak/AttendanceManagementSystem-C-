namespace AttendanceManagementSystem
{
    partial class MainForm
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
            label1 = new Label();
            timeRecordButton = new Button();
            mangeEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(676, 54);
            label1.TabIndex = 0;
            label1.Text = "Emlpoyee Timesheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.Location = new Point(474, 184);
            timeRecordButton.Margin = new Padding(4, 5, 4, 5);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(218, 52);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // mangeEmployeeButton
            // 
            mangeEmployeeButton.Location = new Point(429, 289);
            mangeEmployeeButton.Margin = new Padding(4, 5, 4, 5);
            mangeEmployeeButton.Name = "mangeEmployeeButton";
            mangeEmployeeButton.Size = new Size(298, 52);
            mangeEmployeeButton.TabIndex = 2;
            mangeEmployeeButton.Text = "Manage Employee";
            mangeEmployeeButton.UseVisualStyleBackColor = true;
            mangeEmployeeButton.Click += mangeEmployeeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1200, 468);
            Controls.Add(mangeEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Click += MainForm_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button mangeEmployeeButton;
    }
}