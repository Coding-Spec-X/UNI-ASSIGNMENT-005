using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brick_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brickDrawingPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void drawButton_Click(object sender, EventArgs e)
        {

            //THE WIDTH OF THE BRICK
            const int FLAG_SECTION_WIDTH = 600/3;
            //THE HEIGHT OF A BRICK
            const int FLAG_SECTION_HEIGHT = 800;

            //WHERE TO DRAW THE GRAPHICS
            Graphics paper = brickDrawingPictureBox.CreateGraphics();
            //BRUSH USED TO FILL IN THE FLAG SECTIONS
            SolidBrush sectionBlue = new SolidBrush(Color.Blue);
            SolidBrush sectionWhite = new SolidBrush(Color.White);
            SolidBrush sectionRed = new SolidBrush(Color.Red);
            ////X POSITION TO THE CURRENT SQUARE
            int x = 0;
            //Y IS THE BOTTOM OF THE PICTURE BOX MINUS THE HEIGHT TO SET THE Y POSITION OF THE TOP LEFT HAND CORNER
            int y = brickDrawingPictureBox.Height - FLAG_SECTION_HEIGHT;
            try
            {
                //FILL SINGLE RECTANGLE FLAG SECTION
                    paper.FillRectangle(sectionWhite, x, y, FLAG_SECTION_WIDTH*3, FLAG_SECTION_HEIGHT);
                    paper.FillRectangle(sectionRed, x, y, FLAG_SECTION_WIDTH*2, FLAG_SECTION_HEIGHT);
                    paper.FillRectangle(sectionBlue, x, y, FLAG_SECTION_WIDTH, FLAG_SECTION_HEIGHT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
