namespace PieChart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.btn_CreatePieChart = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_ResetList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pie Chart Maker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number: ";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(175, 160);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(132, 22);
            this.textBox_Input.TabIndex = 2;
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(316, 156);
            this.btn_AddToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_CreatePieChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(240, 116);
            this.listBox.TabIndex = 5;
            // 
            // btn_ResetList
            // 
            this.btn_ResetList.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_ResetList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResetList.Location = new System.Drawing.Point(175, 352);
            this.btn_ResetList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ResetList.Name = "btn_ResetList";
            this.btn_ResetList.Size = new System.Drawing.Size(100, 28);
            this.btn_ResetList.TabIndex = 6;
            this.btn_ResetList.Text = "Reset List";
            this.btn_ResetList.UseVisualStyleBackColor = false;
            this.btn_ResetList.Click += new System.EventHandler(this.btn_ResetList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "List of numbers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1064, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter a number to add to the list below.The pie chart maker will take the numbers" +
    " from the list and create a pie chart off of them. Each slice represents the num" +
    "ber\'s part from the total.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ResetList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_CreatePieChart);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.Button btn_CreatePieChart;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_ResetList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

