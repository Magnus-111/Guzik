using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guzik
{
    public partial class Przycisk : UserControl
    {
        public Przycisk()
        {
            InitializeComponent();
        }

        [Description("The text associated with the control")]
        [Category("Appearance")]
        public string Tekst
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
                this.label1.Location = new Point(this.Size.Width / 2 - this.label1.Size.Width / 2, (this.Size.Height / 2 - this.label1.Size.Height / 2) + 1);
            }
        }

        public override Font Font
        {
            get
            {
                return this.label1.Font;
            }
            set
            {
                this.label1.Font = value;
                base.Font = this.label1.Font;
                this.label1.Location = new Point(this.Size.Width / 2 - this.label1.Size.Width / 2, (this.Size.Height / 2 - this.label1.Size.Height / 2) + 1);
            }
        }

        public Color a;
        public Color b;

        protected void onMouseEnter()
        {
            a = Color.FromArgb(99, 184, 240);
            b = Color.FromArgb(70, 140, 208);
            this.Invalidate();
        }

        protected void onMouseDown()
        {
            a = Color.FromArgb(70, 140, 208);
            b = Color.FromArgb(99, 184, 240);
            this.Invalidate();
        }

        protected void Normal()
        {
            onMouseEnter();
        }

        private void Przycisk_Load(object sender, EventArgs e)
        {
            Normal();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.label1.Location = new Point(this.Size.Width / 2 - this.label1.Size.Width / 2, (this.Size.Height / 2 - this.label1.Size.Height / 2) + 1);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            onMouseEnter();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Normal();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            onMouseDown();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            onMouseEnter();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter();
            OnMouseEnter(e);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Normal();
            OnMouseLeave(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown();
            OnMouseDown(e);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseEnter();
            OnMouseEnter(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics r = e.Graphics;
            Rectangle pr = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            base.OnPaint(e);
            if (this.Enabled == false)
            {
                this.BackColor = Color.FromArgb(79, 97, 121);
                a = Color.FromArgb(150, 180, 200);
                b = Color.FromArgb(70, 90, 115);
            }
            else
            {
                this.BackColor = Color.FromArgb(56, 102, 163);
                a = Color.FromArgb(99, 184, 240);
                b = Color.FromArgb(70, 140, 208);
            }
            LinearGradientBrush lb = new LinearGradientBrush(pr, a, b, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, 5, 5, this.Size.Width - 10, this.Size.Height - 10);
            r.DrawString(this.Tekst, this.Font, new SolidBrush(this.ForeColor), new RectangleF(new PointF(this.Width / 2 - this.label1.Width / 2, (this.Height / 2 - this.label1.Height / 2) + 1), new SizeF(this.Size.Width, this.Size.Height)));
            this.Invalidate();
        }

        private void Przycisk_FontChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Przycisk_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}