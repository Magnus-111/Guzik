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
    }
}