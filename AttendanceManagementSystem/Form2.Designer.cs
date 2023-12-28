namespace AttendanceManagementSystem
{
    partial class EmployeeForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addnewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            identityTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 46);
            label1.TabIndex = 0;
            label1.Text = "Employee Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 1;
            label2.Text = "Identity Id:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 3;
            label4.Text = "Position:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 478);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 4;
            label5.Text = "Card No:";
            // 
            // addnewButton
            // 
            addnewButton.Location = new Point(68, 591);
            addnewButton.Margin = new Padding(4, 5, 4, 5);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(168, 52);
            addnewButton.TabIndex = 5;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = true;
            addnewButton.Click += addnewButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(309, 591);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(168, 52);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(542, 591);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(168, 52);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // identityTextBox
            // 
            identityTextBox.Location = new Point(231, 173);
            identityTextBox.Margin = new Padding(4, 5, 4, 5);
            identityTextBox.Name = "identityTextBox";
            identityTextBox.ReadOnly = true;
            identityTextBox.Size = new Size(309, 39);
            identityTextBox.TabIndex = 8;
          //  identityTextBox.TextChanged += identityTextBox_TextChanged;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(231, 272);
            fullnameTextBox.Margin = new Padding(4, 5, 4, 5);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(309, 39);
            fullnameTextBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(231, 368);
            positionTextBox.Margin = new Padding(4, 5, 4, 5);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(309, 39);
            positionTextBox.TabIndex = 10;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(231, 471);
            cardnoTextBox.Margin = new Padding(4, 5, 4, 5);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(309, 39);
            cardnoTextBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(604, 173);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(583, 343);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(910, 591);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(159, 53);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1200, 684);
            Controls.Add(deleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(cardnoTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(fullnameTextBox);
            Controls.Add(identityTextBox);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addnewButton;
        private Button saveButton;
        private Button updateButton;
        private TextBox identityTextBox;
        private TextBox fullnameTextBox;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private DataGridView dataGridView1;
        private Button deleteButton;
    }
}