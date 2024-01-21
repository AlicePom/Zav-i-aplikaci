namespace Zavři_aplikaci
{
    partial class Tlacitko
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTlacitko = new Button();
            SuspendLayout();
            // 
            // buttonTlacitko
            // 
            buttonTlacitko.Location = new Point(329, 167);
            buttonTlacitko.Name = "buttonTlacitko";
            buttonTlacitko.Size = new Size(98, 39);
            buttonTlacitko.TabIndex = 0;
            buttonTlacitko.Text = "Zavři aplikaci";
            buttonTlacitko.UseVisualStyleBackColor = true;
            buttonTlacitko.Click += buttonTlacitko_Click;
            buttonTlacitko.MouseEnter += buttonTlacitko_Click;
            // 
            // Tlacitko
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(buttonTlacitko);
            Name = "Tlacitko";
            ShowIcon = false;
            Text = "Tlačítko zavři aplikaci";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTlacitko;
    }
}