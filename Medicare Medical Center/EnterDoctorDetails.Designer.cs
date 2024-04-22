﻿namespace Medicare_Medical_Center
{
    partial class EnterDoctorDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            firstNameTB = new TextBox();
            secondNameTB = new TextBox();
            emailTB = new TextBox();
            phoneNoTB = new TextBox();
            hospitalNameTB = new TextBox();
            saveDataBtn = new Button();
            specializationTB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "First_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 168);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 2;
            label3.Text = "Second_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 233);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 301);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "Phone_No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 365);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 5;
            label6.Text = "Hospital";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 431);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 6;
            label7.Text = "Specialization";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(274, 94);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(216, 29);
            firstNameTB.TabIndex = 7;
            // 
            // secondNameTB
            // 
            secondNameTB.Location = new Point(274, 165);
            secondNameTB.Name = "secondNameTB";
            secondNameTB.Size = new Size(216, 29);
            secondNameTB.TabIndex = 8;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(274, 225);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(216, 29);
            emailTB.TabIndex = 9;
            // 
            // phoneNoTB
            // 
            phoneNoTB.Location = new Point(274, 293);
            phoneNoTB.Name = "phoneNoTB";
            phoneNoTB.Size = new Size(216, 29);
            phoneNoTB.TabIndex = 10;
            // 
            // hospitalNameTB
            // 
            hospitalNameTB.Location = new Point(274, 365);
            hospitalNameTB.Name = "hospitalNameTB";
            hospitalNameTB.Size = new Size(216, 29);
            hospitalNameTB.TabIndex = 11;
            // 
            // saveDataBtn
            // 
            saveDataBtn.Location = new Point(274, 483);
            saveDataBtn.Name = "saveDataBtn";
            saveDataBtn.Size = new Size(114, 36);
            saveDataBtn.TabIndex = 13;
            saveDataBtn.Text = "Save Data";
            saveDataBtn.UseVisualStyleBackColor = true;
            saveDataBtn.Click += saveDataBtn_Click;
            // 
            // specializationTB
            // 
            specializationTB.Location = new Point(274, 423);
            specializationTB.Name = "specializationTB";
            specializationTB.Size = new Size(216, 29);
            specializationTB.TabIndex = 14;
            // 
            // EnterDoctorDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(specializationTB);
            Controls.Add(saveDataBtn);
            Controls.Add(hospitalNameTB);
            Controls.Add(phoneNoTB);
            Controls.Add(emailTB);
            Controls.Add(secondNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EnterDoctorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox firstNameTB;
        private TextBox secondNameTB;
        private TextBox emailTB;
        private TextBox phoneNoTB;
        private TextBox hospitalNameTB;
        private Button saveDataBtn;
        private TextBox specializationTB;
    }
}
