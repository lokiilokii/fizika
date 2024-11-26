using System.Windows.Forms;
using System;

namespace fizika
{
    public class FormEnergy : Form
    {
        private TextBox Mass;
        private TextBox Velocity;
        private Button CalculateEnergy;
        private Label EnergyResult;

        public FormEnergy()
        {
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            this.Text = "Izračun kinetičke energije";
            this.Size = new System.Drawing.Size(300, 200);

            Label lblMass = new Label();
            lblMass.Text = "Unesite masu (kg):";
            lblMass.Location = new System.Drawing.Point(10, 20);
            this.Controls.Add(lblMass);

            Mass = new TextBox();
            Mass.Location = new System.Drawing.Point(150, 20);
            this.Controls.Add(Mass);

            Label lblVelocity = new Label();
            lblVelocity.Text = "Unesite brzinu (m/s):";
            lblVelocity.Location = new System.Drawing.Point(10, 60);
            this.Controls.Add(lblVelocity);

            Velocity = new TextBox();
            Velocity.Location = new System.Drawing.Point(150, 60);
            this.Controls.Add(Velocity);

            CalculateEnergy = new Button();
            CalculateEnergy.Text = "Izračunaj energiju";
            CalculateEnergy.Location = new System.Drawing.Point(10, 100);
            CalculateEnergy.Click += BtnCalculateEnergy_Click;
            this.Controls.Add(CalculateEnergy);

            EnergyResult = new Label();
            EnergyResult.Location = new System.Drawing.Point(10, 140);
            this.Controls.Add(EnergyResult);
        }

        public void BtnCalculateEnergy_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = Convert.ToDouble(Mass.Text);
                double velocity = Convert.ToDouble(Velocity.Text);

                double kineticEnergy = 0.5 * mass * Math.Pow(velocity, 2);

                EnergyResult.Text = "Kinetička energija: " + kineticEnergy.ToString("F2") + " J";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka. Provjerite unos!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}