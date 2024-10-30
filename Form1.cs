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
            Color.Black,
            Color.Blue,
            Color.Green,
            Color.Red,
            Color.Yellow,
            Color.GreenYellow,
            Color.DarkRed
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

            Rectangle rect = new Rectangle(450, 250, 400, 400);

            //e.Graphics.DrawRectangle(outline, rect);

            List<float> degrees = ConvertToDegrees(numbers);

            float startAngle = 0;

            for (int i = 0; i < degrees.Count; i++)
            {
                e.Graphics.DrawPie(outline, rect, startAngle, degrees[i]);
                e.Graphics.FillPie(new SolidBrush(colors[i]), rect, startAngle, degrees[i]);
                startAngle += degrees[i];
            }
        }

        private void btn_CreatePieChart_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            if(textBox_Input != null)
            {
                float temp = float.Parse(textBox_Input.Text);
                listBox.Items.Add(temp + " - " + colors[i].Name);
                numbers.Add(temp);
                textBox_Input.Text = "";
                i++;
            }
        }

        private void btn_ResetList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            numbers.Clear();
            i = 0; //reset index to 0
        }
    }
}
