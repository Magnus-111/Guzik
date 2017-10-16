using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}