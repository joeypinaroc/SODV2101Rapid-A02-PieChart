using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public int i = 0; //index for colors List
        public static List<Color> colors = new List<Color>() //static list for colors
        {
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Red,
            Color.Violet,
            Color.Orange,
            Color.GreenYellow,
            Color.PaleVioletRed,
            Color.BlueViolet,
            Color.Cyan,
            Color.DarkRed,
            Color.Magenta,
            Color.OrangeRed,
            Color.Teal,
            Color.Brown
        };
        public List<float> numbers = new List<float>();
        public static List<float> ConvertToDegrees(List<float> values) //convert input list to a list of degrees summing to 360
        {
            List<float> convertedValues = new List<float>();
            float sum = values.Sum();
            foreach(float f in values)
            {
                convertedValues.Add((f / sum) * 360);
            }
            return convertedValues;
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen outline = new Pen(Color.Black, 3);

            Rectangle rect = new Rectangle(450, 200, 400, 400);

            // Draw the legend
            int legendX = 880;
            int legendY = 200;
            int legendWidth = 20;
            int legendHeight = 20;

            List<float> degrees = ConvertToDegrees(numbers); //convert input numbers list to a list of degrees

            //use DrawPie and FillPie method to create pie chart slices
            float startAngle = 0;
            for (int i = 0; i < degrees.Count; i++)
            {
                e.Graphics.DrawPie(outline, rect, startAngle, degrees[i]);
                e.Graphics.FillPie(new SolidBrush(colors[i]), rect, startAngle, degrees[i]);
                startAngle += degrees[i];

                // Draw the color box for the legend
                Brush colorBrush = new SolidBrush(colors[i]);
                e.Graphics.FillRectangle(colorBrush, legendX, legendY + (i * (legendHeight + 5)), legendWidth, legendHeight);

                // Draw the corresponding label
                e.Graphics.DrawString(numbers[i].ToString() + " - " + colors[i].Name,
                    this.Font, Brushes.Black, legendX + legendWidth + 5, legendY + (i * (legendHeight + 5)));
            }
        }

        private void btn_CreatePieChart_Click(object sender, EventArgs e)
        {
            this.Refresh(); //force form to redraw Form1_Paint, this paints the pie chart
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            float temp;
            if ((textBox_Input != null) && (float.TryParse(textBox_Input.Text,out temp)))
            {
                if (i < colors.Count)
                {
                    listBox.Items.Add(temp + " - " + colors[i].Name);
                    numbers.Add(temp);
                    i++; //index scrolls through colors list
                }
                else
                {
                    MessageBox.Show("Maximum number of entries reached.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
            textBox_Input.Text = ""; // Clear textbox input
        }

        private void btn_ResetList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            numbers.Clear();
            i = 0; //reset index to 0
            this.Refresh();
        }
    }
}
