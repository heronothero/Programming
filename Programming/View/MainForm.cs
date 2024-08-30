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
        private Ring[] _rings;
        private Ring _currentRing;
        private Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            //collisionRectanglesBox.ReadOnly = true;
            collisionRingsBox.ReadOnly = true;
            //InitializeMovies();
            InitializeRings();
            UpdateRingFields();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeRings()
        {
            _rings = new Ring[5];
            for (int i = 0; i < _rings.Length; i++)
            {
                double innerRadius = random.NextDouble() * 50;
                double outerRadius = innerRadius + random.NextDouble() * 50;
                Point2D center = new Point2D(random.Next(0, 100), random.Next(0, 100));
                _rings[i] = new Ring(center, innerRadius, outerRadius);
                ringsBox.Items.Add($"Кольцо {i + 1}");
            }
            if (_rings.Length > 0)
            {
                _currentRing = _rings[0];
                UpdateRingFields();
            }
        }

        private void UpdateRingFields()
        {
            if (_currentRing != null)
            {
                innerRadiusBox.Text = _currentRing.InnerRadius.ToString();
                outerRadiusBox.Text = _currentRing.OuterRadius.ToString();
                areaBox.Text = _currentRing.Area.ToString("F2");
            }
        }

        private void ringsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ringsBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rings.Length)
            {
                _currentRing = _rings[selectedIndex];
                UpdateRingFields();
            }
            StringBuilder collisionResults = new StringBuilder();
            for (int i = 0; i < _rings.Length; i++)
            {
                if (i != selectedIndex)
                {
                    bool isCollision = CollisionManager.IsCollisionRings(_currentRing, _rings[i]);
                    collisionResults.AppendLine($"Ring {selectedIndex + 1} vs Ring {i + 1}: {isCollision}");
                }
            }
            collisionRingsBox.Text = collisionResults.ToString();
        }

        private void innerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void areaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void collisionRectanglesBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesBox.SelectedIndex >= 0)
            {
                int selectedIndex = RectanglesBox.SelectedIndex;
                if (selectedIndex < _rectangles.Length - 1)
                {
                    Model.Rectangle rectangle1 = _rectangles[selectedIndex];
                    Model.Rectangle rectangle2 = _rectangles[selectedIndex + 1];
                    bool isCollision = CollisionManager.IsCollisionRectangles(rectangle1, rectangle2);
                    collisionRectanglesBox.Text = isCollision ? "Collision Detected" : "No Collision";
                }
            }
        }*/

        private void collisionRingsBox_TextChanged(object sender, EventArgs e)
        {
            if (ringsBox.SelectedIndex >= 0)
            {
                int selectedIndex = ringsBox.SelectedIndex;
                if (selectedIndex < _rings.Length - 1)
                {
                    Ring ring1 = _rings[selectedIndex];
                    Ring ring2 = _rings[selectedIndex + 1];
                    bool isCollision = CollisionManager.IsCollisionRings(ring1, ring2);
                    collisionRingsBox.Text = isCollision ? "Collision Detected" : "No Collision";
                }
            }
        }
    }
}
