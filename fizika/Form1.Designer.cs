using System;
using System.Windows.Forms;

namespace fizika
{
    public partial class Form1 : Form
    {
        Button KineticEnergy;
        Button Work;

       public Form1()
        {
          InitializeComponents();
        }
        public void InitializeComponents()
        {

            this.Text = "Izračun kinetičke energije i rada";
            this.Size = new System.Drawing.Size(300, 200);

            KineticEnergy = new Button();
            KineticEnergy.Text = "Kinetička energija";
            KineticEnergy.Location = new System.Drawing.Point(50, 30);
            KineticEnergy.Click += BtnKineticEnergy_Click;
            this.Controls.Add(KineticEnergy);

            Work = new Button();
            Work.Text = "Izračun rada";
            Work.Location = new System.Drawing.Point(50, 80);
            Work.Click += BtnWork_Click;
            this.Controls.Add(Work);
        }

        public void BtnKineticEnergy_Click(object sender, EventArgs e)
        {
            Energy formEnergy = new Energy();
            formEnergy.Show();
        }


        public void BtnWork_Click(object sender, EventArgs e)
        {
            Work formWork = new Work();
            formWork.Show();
        }

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form ());
        }
    }
}
    


