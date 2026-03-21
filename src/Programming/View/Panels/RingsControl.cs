using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RingsControl : UserControl
    {
        /// <summary>
        /// A private property of rings' array.
        /// </summary>
        private Ring[] _rings;

        /// <summary>
        /// A private property of a current ring.
        /// </summary>
        private Ring _currentRing;

        /// <summary>
        /// A private property of random.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Initializing components.
        /// </summary>
        public RingsControl()
        {
            InitializeComponent();
            InitializeRings();
            UpdateRingFields();
        }

        /// <summary>
        /// The rings array in which user chooses a ring and sees info in textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }

        /// <summary>
        /// The field of a ring's inner radius.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void innerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of a ring's outer radius.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of a ring's area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void areaBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// A function of initializing 5 rings with random values.
        /// </summary>
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

        /// <summary>
        /// A function of updating current ring's fields.
        /// </summary>
        private void UpdateRingFields()
        {
            if (_currentRing != null)
            {
                innerRadiusBox.Text = _currentRing.InnerRadius.ToString();
                outerRadiusBox.Text = _currentRing.OuterRadius.ToString();
                areaBox.Text = _currentRing.Area.ToString("F2");
            }
        }
    }
}
