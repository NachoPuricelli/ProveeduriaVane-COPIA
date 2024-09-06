using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProveeDesk
{
    internal class RoundButton : Button
    {
        private bool _isHovered = false;
        private bool _isPressed = false;

        public RoundButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.MouseEnter += RoundButton_MouseEnter;
            this.MouseLeave += RoundButton_MouseLeave;
            this.MouseDown += RoundButton_MouseDown;
            this.MouseUp += RoundButton_MouseUp;
        }

        private void RoundButton_MouseEnter(object sender, EventArgs e)
        {
            _isHovered = true;
            this.Invalidate(); // Redibuja el botón para mostrar el estado de hover
        }

        private void RoundButton_MouseLeave(object sender, EventArgs e)
        {
            _isHovered = false;
            this.Invalidate(); // Redibuja el botón para mostrar el estado de no hover
        }

        private void RoundButton_MouseDown(object sender, MouseEventArgs e)
        {
            _isPressed = true;
            this.Invalidate(); // Redibuja el botón para mostrar el estado de presionado
        }

        private void RoundButton_MouseUp(object sender, MouseEventArgs e)
        {
            _isPressed = false;
            this.Invalidate(); // Redibuja el botón para mostrar el estado de no presionado
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Determinar el color de fondo basado en el estado del botón
            Color backgroundColor = _isPressed ? Color.FromArgb(50, 80, 50) : (_isHovered ? Color.FromArgb(80, 130, 80) : Color.FromArgb(0, 100, 0));

            // Dibujar sombra
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                using (PathGradientBrush shadowBrush = new PathGradientBrush(path))
                {
                    shadowBrush.CenterColor = Color.FromArgb(50, Color.Black); // Sombra más tenue
                    shadowBrush.SurroundColors = new Color[] { Color.Transparent };
                    e.Graphics.FillPath(shadowBrush, path);
                }
            }

            // Dibujar el fondo del botón
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillEllipse(brush, 0, 0, ClientSize.Width, ClientSize.Height);
            }

            // Crear una región redonda para el botón
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grPath);

            // Dibujar la tilde blanca
            using (GraphicsPath checkMarkPath = new GraphicsPath())
            {
                int offset = ClientSize.Width / 6;
                int strokeWidth = 6;
                PointF[] points = {
                    new PointF(ClientSize.Width / 4f, ClientSize.Height / 2f),
                    new PointF(ClientSize.Width / 2f - offset / 2f, ClientSize.Height / 2f + offset),
                    new PointF(ClientSize.Width - offset, ClientSize.Height / 3f)
                };

                checkMarkPath.AddLine(points[0], points[1]);
                checkMarkPath.AddLine(points[1], points[2]);

                using (Pen pen = new Pen(Color.White, strokeWidth))
                {
                    e.Graphics.DrawPath(pen, checkMarkPath);
                }
            }

            // Opcional: Agregar borde al botón para un acabado más pulido
            using (Pen borderPen = new Pen(Color.DarkGreen, 2))
            {
                e.Graphics.DrawEllipse(borderPen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }
    }
}
