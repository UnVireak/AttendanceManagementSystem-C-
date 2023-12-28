namespace AttendanceManagementSystem
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            currentTimeLabel = new Label();
            label3 = new Label();
            cardnoTextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(481, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Clock Form";
            label1.Click += label1_Click;
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            currentTimeLabel.Location = new Point(525, 87);
            currentTimeLabel.Margin = new Padding(4, 0, 4, 0);
            currentTimeLabel.MaximumSize = new Size(600, 0);
            currentTimeLabel.MinimumSize = new Size(600, 0);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(600, 46);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            currentTimeLabel.Click += currentTimeLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 2;
            label3.Text = "Card No:";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(446, 183);
            cardnoTextBox.Margin = new Padding(4, 5, 4, 5);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(384, 39);
            cardnoTextBox.TabIndex = 3;
            // 
            // clockinButton
            // 
            clockinButton.Location = new Point(289, 304);
            clockinButton.Margin = new Padding(4, 5, 4, 5);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(168, 52);
            clockinButton.TabIndex = 4;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Location = new Point(685, 304);
            clockoutButton.Margin = new Padding(4, 5, 4, 5);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(168, 52);
            clockoutButton.TabIndex = 5;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = true;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 405);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(label3);
            Controls.Add(currentTimeLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ClockManagement";
            Text = "Clock Management";
            Load += ClockManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentTimeLabel;
        private Label label3;
        private TextBox cardnoTextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}