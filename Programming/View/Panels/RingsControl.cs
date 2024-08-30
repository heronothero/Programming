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
        private Ring[] _rings;
        private Ring _currentRing;
        private Random random = new Random();
        public RingsControl()
        {
            InitializeComponent();
            InitializeRings();
            UpdateRingFields();
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
    }
}
