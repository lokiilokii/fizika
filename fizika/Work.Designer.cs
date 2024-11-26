using System.Windows.Forms;
using System;

namespace fizika
{
    public class FormWork : Form
    {
        private TextBox Force;
        private TextBox Distance;
        private Button CalculateWork;
        private Label WorkResult;

        public FormWork()
        {
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            this.Text = "Izračun rada";
            this.Size = new System.Drawing.Size(300, 200);

            Label lblForce = new Label();
            lblForce.Text = "Unesite silu (N):";
            lblForce.Location = new System.Drawing.Point(10, 20);
            this.Controls.Add(lblForce);

            Force = new TextBox();
            Force.Location = new System.Drawing.Point(150, 20);
            this.Controls.Add(Force);

            Label lblDistance = new Label();
            lblDistance.Text = "Unesite put (m):";
            lblDistance.Location = new System.Drawing.Point(10, 60);
            this.Controls.Add(lblDistance);

            Distance = new TextBox();
            Distance.Location = new System.Drawing.Point(150, 60);
            this.Controls.Add(Distance);

            CalculateWork = new Button();
            CalculateWork.Text = "Izračunaj rad";
            CalculateWork.Location = new System.Drawing.Point(10, 100);
            CalculateWork.Click += BtnCalculateWork_Click;
            this.Controls.Add(CalculateWork);

            WorkResult = new Label();
            WorkResult.Location = new System.Drawing.Point(10, 140);
            this.Controls.Add(WorkResult);
        }

        public void BtnCalculateWork_Click(object sender, EventArgs e)
        {
            try
            {
                double force = Convert.ToDouble(Force.Text);
                double distance = Convert.ToDouble(Distance.Text);

                double work = force * distance;

                WorkResult.Text = "Obavljeni rad: " + work.ToString("F2") + " J";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška u unosu podataka. Provjerite unos!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}