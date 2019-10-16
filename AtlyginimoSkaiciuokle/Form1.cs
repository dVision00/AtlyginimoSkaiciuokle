using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlyginimoSkaiciuokle
{
    public partial class Form1 : Form
    {

        public double NPD(double atlyginimasB)
        {
            if (atlyginimasB > 555)
            {
                return Math.Round(300 - 0.15 * (atlyginimasB - 555), 2);
            }
            else
            {
                return 300;
            }
        }

        public double GMP(double atlyginimasB)
        {
            return Math.Round((atlyginimasB - NPD(atlyginimasB)) * 0.2, 2);
        }

        public double sodraPSD(double atlyginimasB)
        {
            return Math.Round((atlyginimasB * 0.0698), 2); ;
        }

        public double sodraVSDp(double atlyginimasB)
        {
            var pesnija = lstBoxPensija.GetItemText(lstBoxPensija.SelectedItem);
            var socDraud = 12.52;

            if (pesnija == "3.0%")
            {
                return Math.Round((atlyginimasB * (socDraud + 3)) / 100, 2); ;
            }
            if (pesnija == "1.8%")
            {
                return Math.Round((atlyginimasB * (socDraud + 1.8)) / 100, 2);
            }
            else
            {
                return Math.Round(atlyginimasB * 0.1250, 2);
            }

        }

        public double sodraDrbv(double atlyginimasB)
        {
            return Math.Round(atlyginimasB * 0.0177, 2); ;
        }

        public double atlyginimasBruto(double atlyginimasB)
        {
            return Math.Round(atlyginimasB - GMP(atlyginimasB) - sodraPSD(atlyginimasB) - sodraVSDp(atlyginimasB), 0); ;
        }

        //-----------------------------

        public Form1()
        {
            InitializeComponent();
        }


        private void tBoxAtlyginimas_TextChanged(object sender, EventArgs e)
        {
            double ivestasAt = 0;

            if (double.TryParse(tBoxAtlyginimas.Text, out ivestasAt))
            {
                ivestasAt = double.Parse(tBoxAtlyginimas.Text);

                lbNPD.Text = "Pritaikytas NPD: " + NPD(ivestasAt);
                lbGMP.Text = "Gyventojų pajamų mokestis: " + GMP(ivestasAt);
                lbSodraPSD.Text = "Sodra. Sveikatos draudimas: " + sodraPSD(ivestasAt);
                lbSodraVSDpens.Text = "Sodra. Pensijų ir soc. draudimas: " + sodraVSDp(ivestasAt);
                lbDrdvSodra.Text = "Darbdavio sumokami mokesčiai. Sodra: " + sodraDrbv(ivestasAt);
                lbIRankas.Text = Convert.ToString(atlyginimasBruto(ivestasAt));
            }
            else
            {
                MessageBox.Show("Galimaivesti tik skaicius!");
                tBoxAtlyginimas.Text = Convert.ToString(0);
            }

        }

        public void offsetToNet()
        {
            double atIRANKAS = 0;
            lstBoxPensija.SelectedIndex = lstBoxNetoPensija.SelectedIndex;
            if (double.TryParse(tBoxNeto.Text, out atIRANKAS))
            {
                atIRANKAS = double.Parse(tBoxNeto.Text);
                tBoxAtlyginimas.Text = Convert.ToString(atIRANKAS);
                double ivestasAt = Math.Round(double.Parse(tBoxAtlyginimas.Text), 0);

                while (tBoxNeto.Text != lbIRankas.Text)
                {
                    if (atIRANKAS < double.Parse(lbIRankas.Text))
                    {
                        ivestasAt = ivestasAt - 1;
                    }
                    else
                    {
                        ivestasAt = ivestasAt + 1;
                    }
                    tBoxAtlyginimas.Text = Convert.ToString(Math.Round(ivestasAt, 0));
                }
                lblNetoNPD.Text = lbNPD.Text;
                lblNetoGPM.Text = lbGMP.Text;
                lblNetoSodraPSD.Text = lbSodraPSD.Text;
                lblNetoSodraVSDpens.Text = lbSodraVSDpens.Text;
                lblNetoDrdvSodra.Text = lbDrdvSodra.Text;
                lblNetoAntPop.Text = tBoxAtlyginimas.Text;
            }
            else
            {
                MessageBox.Show("Galimaivesti tik skaicius!");
                tBoxNeto.Text = Convert.ToString(0);
            }


        }
        private void tBoxNeto_TextChanged(object sender, EventArgs e)
        {
            offsetToNet();
        }
        private void lstBoxNetoPensija_SelectedIndexChanged(object sender, EventArgs e)
        {
            offsetToNet();
        }
    }
}






