using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            //collisionRectanglesBox.ReadOnly = true;
            //collisionRingsBox.ReadOnly = true;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void collisionRingsBox_TextChanged(object sender, EventArgs e)
        {
            /*if (ringsBox.SelectedIndex >= 0)
            {
                int selectedIndex = ringsBox.SelectedIndex;
                if (selectedIndex < _rings.Length - 1)
                {
                    Ring ring1 = _rings[selectedIndex];
                    Ring ring2 = _rings[selectedIndex + 1];
                    bool isCollision = CollisionManager.IsCollisionRings(ring1, ring2);
                    collisionRingsBox.Text = isCollision ? "Collision Detected" : "No Collision";
                }
            }*/
        }
    }
}
