using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading;
namespace Guzik
{
    [DefaultEvent("Click")]
    public partial class Przycisk : UserControl
    {
        public Przycisk()
        {
            InitializeComponent();
            int style = AF.NativeWinAPI.GetWindowLong(Handle, AF.NativeWinAPI.GWL_EXSTYLE);
            style |= AF.NativeWinAPI.WS_EX_COMPOSITED;
            AF.NativeWinAPI.SetWindowLong(Handle, AF.NativeWinAPI.GWL_EXSTYLE, style);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int leftRect, int topRect, int rightRect, int bottomRect, int wEllipse, int hEllipse);
        [Description("The text associated with the control")]
        [Category("Appearance")]
        public string Tekst
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                label1.Location = new Point((Width - label1.Width) / 2, (Height - label1.Height) / 2);
            }
        }
        public override Font Font
        {
            get
            {
                return label1.Font;
            }
            set
            {
                base.Font = value;
                label1.Font = value;
                label1.Location = new Point((Width - label1.Width) / 2, (Height - label1.Height) / 2);
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                label1.ForeColor = value;
            }
        }
        public Color a = Color.FromArgb(100, 185, 240);
        public Color b = Color.FromArgb(70, 140, 210);
        protected void onMouseEnter()
        {
            a = Color.FromArgb(100, 185, 240);
            b = Color.FromArgb(70, 140, 210);
            Invalidate();
            Refresh();

        }
        protected void onMouseDown()
        {
            b = Color.FromArgb(100, 185, 240);
            a = Color.FromArgb(70, 140, 210);
            Invalidate();
            Refresh();
        }
        protected void NormalStyle()
        {
            a = Color.FromArgb(100, 185, 240);
            b = Color.FromArgb(70, 140, 210);
            Invalidate();
            Refresh();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            label1.Location = new Point((Width - label1.Width) / 2, (Height - label1.Height) / 2);
            Refresh();
            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e); 
            onMouseEnter();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            NormalStyle();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e); 
            onMouseDown();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            NormalStyle();
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            onMouseEnter();
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            NormalStyle();
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown();
            Thread.Sleep(100);
            base.OnClick(e);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            NormalStyle();
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            onMouseDown();
            Thread.Sleep(100);
            NormalStyle();
        }
        public void PerformClick()
        {
            if (CanSelect)
            {
                OnClick(EventArgs.Empty);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int p = Size.Height / 10;
            base.OnPaint(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width + 1, Size.Height + 1, 3, 3));
            if (Enabled == false)
            {
                a = Color.FromArgb(135, 168, 190);
                b = Color.FromArgb(108, 136, 160);
            }
            LinearGradientBrush lb = new LinearGradientBrush(new Rectangle(0, 0, Size.Width, Size.Height), a, b, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, p, p+1, Size.Width - (p*2), Size.Height - (p*2)-2);
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            NormalStyle();
            Refresh();
        }
    }
}