namespace Guzik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.przycisk1 = new Guzik.Przycisk();
            this.SuspendLayout();
            // 
            // przycisk1
            // 
            this.przycisk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.przycisk1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.przycisk1.Location = new System.Drawing.Point(12, 12);
            this.przycisk1.Name = "przycisk1";
            this.przycisk1.Size = new System.Drawing.Size(160, 32);
            this.przycisk1.TabIndex = 0;
            this.przycisk1.Tekst = "Przycisk1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.przycisk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Przycisk przycisk1;

    }
}

