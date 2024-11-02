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
        public int i = 0; // index for colors List

        // Static list for colors
        public static List<Color> colors = new List<Color>()
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

        // List of numbers entered by the user
        public List<float> numbers = new List<float>();

        // Function to convert input list to a list of degrees summing to 360
        public static List<float> ConvertToDegrees(List<float> values)
        {
            List<float> convertedValues = new List<float>();
            float sum = values.Sum();
            foreach(float f in values)
            {
                convertedValues.Add((f / sum) * 360); // convert to degrees
            }
            return convertedValues;
        }
        
        // Initialize for components
        public Form1()
        {
            InitializeComponent();
        }

        // Event to paint pie chart
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Declare graphics and pen objects
            Graphics graphics = this.CreateGraphics();
            Pen outline = new Pen(Color.Black, 3);

            // Pie chart bounding rectangle
            Rectangle rect = new Rectangle(450, 200, 400, 400);

            // Pie chart label bounding rectangle
            int legendX = 880;
            int legendY = 200;
            int legendWidth = 20;
            int legendHeight = 20;

            // Convert input numbers list to a list of degrees
            List<float> degrees = ConvertToDegrees(numbers);

            //Use DrawPie and FillPie method to create pie chart slices
            float startAngle = 0; // Reset start angle
            for (int i = 0; i < degrees.Count; i++) // Loop through all the slices
            {
                // Draw pie chart slice
                e.Graphics.DrawPie(outline, rect, startAngle, degrees[i]);
                e.Graphics.FillPie(new SolidBrush(colors[i]), rect, startAngle, degrees[i]);

                // Draw the color box for the legend
                Brush colorBrush = new SolidBrush(colors[i]);
                e.Graphics.FillRectangle(colorBrush, legendX, legendY + (i * (legendHeight + 5)), legendWidth, legendHeight);

                // Draw the corresponding label
                e.Graphics.DrawString($"{numbers[i]} - {colors[i].Name} ({(degrees[i] / 360 * 100):0.##}%)",
                    this.Font, Brushes.Black, legendX + legendWidth + 5, legendY + (i * (legendHeight + 5)));

                // Update start angle for the next slice
                startAngle += degrees[i];
            }
        }

        // Event to create the pie chart when button is pressed
        private void btn_CreatePieChart_Click(object sender, EventArgs e)
        {
            this.Refresh(); // Force form to redraw Form1_Paint, this paints the pie chart with the label
        }

        // Event to add an entry to the numbers list
        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            float temp; // temporary variable to store the user input

            // Check if the user input is a valid number
            if ((textBox_Input != null) && (float.TryParse(textBox_Input.Text,out temp)))
            {
                // Check if the number of entries has reached the limit
                if (i < colors.Count)
                {
                    // Limit not yet reached. Add entry
                    listBox.Items.Add(temp + " - " + colors[i].Name);
                    numbers.Add(temp);
                    i++; // index scrolls through colors in list
                }
                else
                {
                    // Limit reached. Show the message
                    MessageBox.Show("Maximum number of entries reached.");
                }
            }
            else
            {
                // Invalid input. Show error message.
                MessageBox.Show("Please enter a valid number.");
            }
            textBox_Input.Text = ""; // Clear textbox input
        }

        // Event to clear the entries and reset the pie chart
        private void btn_ResetList_Click(object sender, EventArgs e)
        {
            // Clear items in list and reset pie chart
            listBox.Items.Clear();
            numbers.Clear();
            i = 0; // reset index to 0
            this.Refresh(); // force redraw
        }
    }
}
