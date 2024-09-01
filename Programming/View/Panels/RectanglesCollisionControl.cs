using Programming.Model;
using Programming.Model.Geometry;
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
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Model.Rectangle> _rectanglesList;
        private Model.Rectangle _currentRectangle;
        private Panel _rectanglesPanel;
        private List<Panel> _rectanglePanels = new List<Panel>();
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _rectanglesList = new List<Model.Rectangle>();
            _rectanglesPanel = new Panel();
            _rectanglePanels = new List<Panel>();
            _rectanglesPanel.Paint += rectanglesPanel_Paint;
            IDRectangleBox.ReadOnly = true;
            Controls.Add(_rectanglesPanel);
        }

        private void rectanglesPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var rectangle in _rectanglesList)
            {
                Color fillColor = AppColors.RectangleNoCollision;
                if (rectangle.Color == "Red")
                {
                    fillColor = AppColors.RectangleCollision;
                }
                using (Brush brush = new SolidBrush(fillColor))
                {
                    g.FillRectangle(brush,
                        (float)(rectangle.Center.X - (rectangle.Width / 2)),
                        (float)(rectangle.Center.Y - (rectangle.Length / 2)),
                        (float)rectangle.Width,
                        (float)rectangle.Length);
                }
            }
        }

        private void DrawRectangles()
        {
            rectanglesPanel.Invalidate();
        }

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rectanglesList.Count)
            {
                _currentRectangle = _rectanglesList[selectedIndex];
                RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            }
            else
            {
                RectangleUtils.ClearRectangleInfo(IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            }
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            int canvasWidth = rectanglesPanel.Width;
            int canvasHeight = rectanglesPanel.Height;
            var newRectangle = RectangleFactory.Randomize(canvasWidth, canvasHeight, 30);
            _rectanglesList.Add(newRectangle);
            Panel newPanel = new Panel
            {
                BackColor = AppColors.RectangleNoCollision,
                Size = new Size((int)newRectangle.Width, (int)newRectangle.Length),
                Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Length / 2))
            };
            _rectanglesPanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
            UpdateRectanglesList();
            _currentRectangle = newRectangle;
            RectangleUtils.UpdateRectangleInfo(newRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            DrawRectangles();
            FindCollissions();
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rectanglesList.Count)
            {
                if (selectedIndex < _rectanglePanels.Count)
                {
                    Panel panelToRemove = _rectanglePanels[selectedIndex];
                    _rectanglesPanel.Controls.Remove(panelToRemove);
                    panelToRemove.Dispose();
                    _rectanglePanels.RemoveAt(selectedIndex);
                }
                _rectanglesList.RemoveAt(selectedIndex);
                UpdateRectanglesList();
                if (_rectanglesList.Count > 0)
                {
                    rectanglesListBox.SelectedIndex = Math.Min(selectedIndex, _rectanglesList.Count - 1);
                }
                else
                {
                    RectangleUtils.ClearRectangleInfo(IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                }
                DrawRectangles();
                FindCollissions();
            }
        }

        private void UpdateRectanglesList()
        {
            rectanglesListBox.Items.Clear();
            foreach (var rectangle in _rectanglesList)
            {
                string displayText = $"ID: {rectangle.ID}," + $"L: {rectangle.Length:F2}," + $"W: {rectangle.Width:F2}," + $"X: {rectangle.Center.X:F2}," + $"Y: {rectangle.Center.Y:F2}";
                rectanglesListBox.Items.Add(displayText);
            }
        }

        private void IDRectangleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void XCenterBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(XCenterBox.Text, out double x))
                    {
                        _currentRectangle.SetCenter(Validator.ValidateCoordinate(x, nameof(Point2D.X)), _currentRectangle.Center.Y);
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    XCenterBox.Text = _currentRectangle.Center.X.ToString();
                }
            }
        }

        private void YCenterBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(YCenterBox.Text, out double y))
                    {
                        _currentRectangle.SetCenter(_currentRectangle.Center.X, Validator.ValidateCoordinate(y, nameof(Point2D.Y)));
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    YCenterBox.Text = _currentRectangle.Center.Y.ToString();
                }
            }
        }

        private void widthRectangleBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(widthRectangleBox.Text, out double width))
                    {
                        _currentRectangle.Width = Validator.AssertOnPositiveValue(width, "Width");
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    widthRectangleBox.Text = _currentRectangle.Width.ToString();
                }
            }
        }

        private void lengthRectangleBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(lengthRectangleBox.Text, out double length))
                    {
                        _currentRectangle.Length = Validator.AssertOnPositiveValue(length, "Length");
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lengthRectangleBox.Text = _currentRectangle.Length.ToString();
                }
            }
        }

        private void FindCollissions()
        {
            var collisionGrid = new CollisionGrid(400);

            foreach (var rectangle in _rectanglesList)
            {
                collisionGrid.AddRectangle(rectangle);
            }

            foreach (var rectangle in _rectanglesList)
            {
                var possibleCollisions = collisionGrid.GetPossibleCollisions(rectangle);

                foreach (var potentialCollision in possibleCollisions)
                {
                    if (rectangle != potentialCollision && CollisionManager.IsCollisionRectangles(rectangle, potentialCollision))
                    {
                        rectangle.Color = "Red";
                        potentialCollision.Color = "Red";
                    }
                }
            }

            DrawRectangles();
        }
        public class CollisionGrid
        {
            private readonly int _cellSize;
            private readonly Dictionary<Point, List<Model.Rectangle>> _cells;

            public CollisionGrid(int cellSize)
            {
                _cellSize = cellSize;
                _cells = new Dictionary<Point, List<Model.Rectangle>>();
            }

            public void AddRectangle(Model.Rectangle rectangle)
            {
                var (cellX, cellY) = GetCellCoordinates(rectangle);
                var cellKey = new Point(cellX, cellY);

                if (!_cells.ContainsKey(cellKey))
                {
                    _cells[cellKey] = new List<Model.Rectangle>();
                }

                _cells[cellKey].Add(rectangle);
            }

            public IEnumerable<Model.Rectangle> GetPossibleCollisions(Model.Rectangle rectangle)
            {
                var (cellX, cellY) = GetCellCoordinates(rectangle);
                var cellsToCheck = new List<Point>
                {
                    new Point(cellX, cellY),
                    new Point(cellX + 1, cellY),
                    new Point(cellX - 1, cellY),
                    new Point(cellX, cellY + 1),
                    new Point(cellX, cellY - 1),
                    new Point(cellX + 1, cellY + 1),
                    new Point(cellX - 1, cellY - 1),
                    new Point(cellX + 1, cellY - 1),
                    new Point(cellX - 1, cellY + 1)
                };

                var possibleCollisions = new HashSet<Model.Rectangle>();

                foreach (var cell in cellsToCheck)
                {
                    if (_cells.ContainsKey(cell))
                    {
                        foreach (var rect in _cells[cell])
                        {
                            possibleCollisions.Add(rect);
                        }
                    }
                }

                return possibleCollisions;
            }

            private (int, int) GetCellCoordinates(Model.Rectangle rectangle)
            {
                int x = (int)(rectangle.Center.X / _cellSize);
                int y = (int)(rectangle.Center.Y / _cellSize);
                return (x, y);
            }
        }
    }
}
