﻿namespace PieChart
{
    partial class Form1
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_TextboxInput = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.btn_CreatePieChart = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_ResetList = new System.Windows.Forms.Button();
            this.lbl_Listbox = new System.Windows.Forms.Label();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(51, 60);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(224, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Pie Chart Maker";
            // 
            // lbl_TextboxInput
            // 
            this.lbl_TextboxInput.AutoSize = true;
            this.lbl_TextboxInput.Location = new System.Drawing.Point(53, 166);
            this.lbl_TextboxInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TextboxInput.Name = "lbl_TextboxInput";
            this.lbl_TextboxInput.Size = new System.Drawing.Size(103, 16);
            this.lbl_TextboxInput.TabIndex = 1;
            this.lbl_TextboxInput.Text = "Enter a number: ";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(175, 160);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(132, 22);
            this.textBox_Input.TabIndex = 2;
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(316, 156);
            this.btn_AddToList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(100, 28);
            this.btn_AddToList.TabIndex = 3;
            this.btn_AddToList.Text = "Add To List";
            this.btn_AddToList.UseVisualStyleBackColor = true;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // btn_CreatePieChart
            // 
            this.btn_CreatePieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_CreatePieChart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_CreatePieChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreatePieChart.Location = new System.Drawing.Point(283, 352);
            this.btn_CreatePieChart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreatePieChart.Name = "btn_CreatePieChart";
            this.btn_CreatePieChart.Size = new System.Drawing.Size(133, 28);
            this.btn_CreatePieChart.TabIndex = 4;
            this.btn_CreatePieChart.Text = "Create Pie Chart";
            this.btn_CreatePieChart.UseVisualStyleBackColor = false;
            this.btn_CreatePieChart.Click += new System.EventHandler(this.btn_CreatePieChart_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(175, 209);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(240, 116);
            this.listBox.TabIndex = 5;
            // 
            // btn_ResetList
            // 
            this.btn_ResetList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_ResetList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResetList.Location = new System.Drawing.Point(175, 352);
            this.btn_ResetList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ResetList.Name = "btn_ResetList";
            this.btn_ResetList.Size = new System.Drawing.Size(100, 28);
            this.btn_ResetList.TabIndex = 6;
            this.btn_ResetList.Text = "Reset List";
            this.btn_ResetList.UseVisualStyleBackColor = false;
            this.btn_ResetList.Click += new System.EventHandler(this.btn_ResetList_Click);
            // 
            // lbl_Listbox
            // 
            this.lbl_Listbox.AutoSize = true;
            this.lbl_Listbox.Location = new System.Drawing.Point(53, 209);
            this.lbl_Listbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Listbox.Name = "lbl_Listbox";
            this.lbl_Listbox.Size = new System.Drawing.Size(99, 16);
            this.lbl_Listbox.TabIndex = 7;
            this.lbl_Listbox.Text = "List of numbers:";
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.AutoSize = true;
            this.lbl_Instruction.Location = new System.Drawing.Point(53, 113);
            this.lbl_Instruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(1047, 16);
            this.lbl_Instruction.TabIndex = 8;
            this.lbl_Instruction.Text = "Enter a number to add to the list below.The pie chart maker will take the numbers" +
    " from the list and create a pie chart of them. Each slice represents the number\'" +
    "s part from the total.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1579, 1055);
            this.Controls.Add(this.lbl_Instruction);
            this.Controls.Add(this.lbl_Listbox);
            this.Controls.Add(this.btn_ResetList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_CreatePieChart);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.lbl_TextboxInput);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pie Chart Maker";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_TextboxInput;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.Button btn_CreatePieChart;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_ResetList;
        private System.Windows.Forms.Label lbl_Listbox;
        private System.Windows.Forms.Label lbl_Instruction;
    }
}

