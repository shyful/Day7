﻿namespace listOfStudentsp3App
{
    partial class ListOfThreeStudents
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastnametextBox = new System.Windows.Forms.TextBox();
            this.firstnametextBox = new System.Windows.Forms.TextBox();
            this.regnotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearallButton = new System.Windows.Forms.Button();
            this.showallButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastnametextBox);
            this.groupBox1.Controls.Add(this.firstnametextBox);
            this.groupBox1.Controls.Add(this.regnotextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // lastnametextBox
            // 
            this.lastnametextBox.Location = new System.Drawing.Point(128, 148);
            this.lastnametextBox.Name = "lastnametextBox";
            this.lastnametextBox.Size = new System.Drawing.Size(207, 20);
            this.lastnametextBox.TabIndex = 5;
            // 
            // firstnametextBox
            // 
            this.firstnametextBox.Location = new System.Drawing.Point(128, 88);
            this.firstnametextBox.Name = "firstnametextBox";
            this.firstnametextBox.Size = new System.Drawing.Size(207, 20);
            this.firstnametextBox.TabIndex = 4;
            // 
            // regnotextBox
            // 
            this.regnotextBox.Location = new System.Drawing.Point(128, 36);
            this.regnotextBox.Name = "regnotextBox";
            this.regnotextBox.Size = new System.Drawing.Size(207, 20);
            this.regnotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // clearallButton
            // 
            this.clearallButton.Location = new System.Drawing.Point(335, 317);
            this.clearallButton.Name = "clearallButton";
            this.clearallButton.Size = new System.Drawing.Size(75, 23);
            this.clearallButton.TabIndex = 7;
            this.clearallButton.Text = "Clear All";
            this.clearallButton.UseVisualStyleBackColor = true;
            this.clearallButton.Click += new System.EventHandler(this.clearallButton_Click);
            // 
            // showallButton
            // 
            this.showallButton.Location = new System.Drawing.Point(227, 317);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(75, 23);
            this.showallButton.TabIndex = 6;
            this.showallButton.Text = "Show All";
            this.showallButton.UseVisualStyleBackColor = true;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(119, 317);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ListOfThreeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearallButton);
            this.Controls.Add(this.showallButton);
            this.Controls.Add(this.saveButton);
            this.Name = "ListOfThreeStudents";
            this.Text = "ListOfThreeStudents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lastnametextBox;
        private System.Windows.Forms.TextBox firstnametextBox;
        private System.Windows.Forms.TextBox regnotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearallButton;
        private System.Windows.Forms.Button showallButton;
        private System.Windows.Forms.Button saveButton;
    }
}

