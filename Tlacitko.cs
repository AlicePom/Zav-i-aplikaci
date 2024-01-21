namespace Zavři_aplikaci
{
    public partial class Tlacitko : Form
    {
        public Tlacitko()
        {
            InitializeComponent();
        }

        private void buttonTlacitko_Click(object sender, EventArgs e) // vygenerování náhodné polohy (souřadnic) tlačítka po najetí na tlačítko kurzorem
        {
            Random nahodneCislo = new Random();

            // původní varianta:
            //int novaSouradniceX = nahodneCislo.Next(0, (800 - buttonTlacitko.Size.Width)); 
            //int novaSouradniceY = nahodneCislo.Next(0, (500 - buttonTlacitko.Size.Height));

            // vylepšené řešení:
            int novaSouradniceX = nahodneCislo.Next(0, (ClientSize.Width - buttonTlacitko.Size.Width));
            int novaSouradniceY = nahodneCislo.Next(0, (ClientSize.Height - buttonTlacitko.Size.Height));

            buttonTlacitko.Location = new Point(novaSouradniceX, novaSouradniceY);
        }
    }
}