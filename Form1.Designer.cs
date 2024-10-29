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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pie chart maker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number: ";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(131, 130);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(100, 20);
            this.textBox_Input.TabIndex = 2;
            // 
            // btn_AddToList
            // 
            this.btn_AddToList.Location = new System.Drawing.Point(237, 127);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(75, 23);
            this.btn_AddToList.TabIndex = 3;
            this.btn_AddToList.Text = "Add";
            this.btn_AddToList.UseVisualStyleBackColor = true;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // btn_CreatePieChart
            // 
            this.btn_CreatePieChart.Location = new System.Drawing.Point(188, 185);
            this.btn_CreatePieChart.Name = "btn_CreatePieChart";
            this.btn_CreatePieChart.Size = new System.Drawing.Size(75, 51);
            this.btn_CreatePieChart.TabIndex = 4;
            this.btn_CreatePieChart.Text = "Create Pie Chart From List";
            this.btn_CreatePieChart.UseVisualStyleBackColor = true;
            this.btn_CreatePieChart.Click += new System.EventHandler(this.btn_CreatePieChart_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(43, 185);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btn_CreatePieChart);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}

