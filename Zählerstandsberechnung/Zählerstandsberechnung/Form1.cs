using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zählerstandsberechnung
{
    public partial class Form1 : Form
    {
        double JanuarProzentsatz = 12.33 / 100;
        double FebruarProzentsatz = 10.33 / 100;
        double MärzProzentsatz = 8.33 / 100;
        double AprilProzentsatz = 7.33 / 100;
        double MaiProzentsatz = 6.35 / 100;
        double JuniProzentsatz = 6.33 / 100;
        double JuliProzentsatz = 5.34 / 100;
        double AugustProzentsatz = 5.34 / 100;
        double SeptemberProzentsatz = 6.33 / 100;
        double OktoberProzentsatz = 9.33 / 100;
        double NovemberProzentsatz = 10.33 / 100;
        double DezemberProzentsatz = 12.33 / 100;
        double linearProzentsatz = 8.33 / 100;
        

        public Form1()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public double EachDay (DateTime start, DateTime ende, double linearerTagesverbrauch )
        {

            double aktuellerProzentwert = 0;
            double gewichteterJahresverbrauch = 0;


            for (DateTime day = start.Date; day.Date <= ende.Date; day = day.AddDays(1))
            {
                switch (day.Month)
                {
                    case 1:
                        System.Diagnostics.Debug.WriteLine("Januar (" + JanuarProzentsatz + ")");
                        aktuellerProzentwert = JanuarProzentsatz;
                        break;
                    case 2:
                        System.Diagnostics.Debug.WriteLine("Februar (" + FebruarProzentsatz + ")");
                        aktuellerProzentwert = FebruarProzentsatz;
                        break;
                    case 3:
                        System.Diagnostics.Debug.WriteLine("März (" + MärzProzentsatz + ")");
                        aktuellerProzentwert = MärzProzentsatz;
                        break;
                    case 4:
                        System.Diagnostics.Debug.WriteLine("April (" + AprilProzentsatz + ")");
                        aktuellerProzentwert = AprilProzentsatz;
                        break;  
                    case 5:
                        System.Diagnostics.Debug.WriteLine("Mai (" + MaiProzentsatz + ")");
                        aktuellerProzentwert = MaiProzentsatz;
                        break;
                    case 6:
                        System.Diagnostics.Debug.WriteLine("Juni (" + JuniProzentsatz + ")");
                        aktuellerProzentwert = JuniProzentsatz;
                        break;
                    case 7:
                        System.Diagnostics.Debug.WriteLine("Juli (" + JuliProzentsatz + ")");
                        aktuellerProzentwert = JuliProzentsatz;
                        break;
                    case 8:
                        System.Diagnostics.Debug.WriteLine("August (" + AugustProzentsatz + ")");
                        aktuellerProzentwert = AugustProzentsatz;
                        break;
                   case 9:
                        System.Diagnostics.Debug.WriteLine("September (" + SeptemberProzentsatz + ")");
                        aktuellerProzentwert = SeptemberProzentsatz;
                        break;
                    case 10:
                        System.Diagnostics.Debug.WriteLine("Oktober (" + OktoberProzentsatz + ")");
                        aktuellerProzentwert = OktoberProzentsatz;
                        break;
                    case 11:
                        System.Diagnostics.Debug.WriteLine("November (" + NovemberProzentsatz + ")");
                        aktuellerProzentwert = NovemberProzentsatz;
                        break;
                    case 12:
                        System.Diagnostics.Debug.WriteLine("Dezember(" + DezemberProzentsatz + ")");
                        aktuellerProzentwert = DezemberProzentsatz;
                        break;
                    default:
                        System.Diagnostics.Debug.WriteLine("FEHLER!");
                        break;
                    }

                double gewichteterTagesverbrauch = linearerTagesverbrauch * aktuellerProzentwert / linearProzentsatz;
                gewichteterJahresverbrauch += gewichteterTagesverbrauch;               
            }

            return gewichteterJahresverbrauch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahl1_i = 0, zahl2_i = 0, ergebnis_i = 0, linearerTagesverbrauch = 0, Jahr= 0, gewichteterTagesverbrauch = 0, gewichteterJahresverbrauch = 0;
            TimeSpan differenz_zeit;
            TimeSpan differenz_zahl;

            

            DateTime start = dateTimePickerStart.Value;
            DateTime ende = dateTimePickerEnde.Value;

           

            


            try
            {
                zahl1_i = Convert.ToDouble(zS_1.Text);
                zahl2_i = Convert.ToDouble(zS_2.Text);

                ergebnis_i = zahl1_i - zahl2_i;

                differenz_zeit = dateTimePickerEnde.Value - dateTimePickerStart.Value;

                linearerTagesverbrauch =  ergebnis_i / differenz_zeit.Days;
                  tagesverbrauch.Text = Convert.ToString(linearerTagesverbrauch);
                  tagesverbrauch.Text = linearerTagesverbrauch.ToString("0.00");   

                zD.Text = differenz_zeit.Days.ToString() + " Tag(e) ";
                //textBox2.Text = differenz_zeit.

                Jahr = linearerTagesverbrauch * 365;
                  jV.Text = Jahr.ToString();

                  gewichteterTagesverbrauch = linearerTagesverbrauch * JanuarProzentsatz / linearProzentsatz;
                  tbx_gewichteterTagesverbrauch.Text = gewichteterTagesverbrauch.ToString();
                       
                gewichteterJahresverbrauch = EachDay(start, ende, linearerTagesverbrauch);
                tbx_gewichteterJahresverbrauch.Text = gewichteterJahresverbrauch.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
                return;
            }
            zS_D.Text = Convert.ToString(ergebnis_i);
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbx_gewichteterTagesverbrauch_TextChanged(object sender, EventArgs e)
        {

        }

        private void zS_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void zS_2_Enter(object sender, EventArgs e)
        {
            if (zS_2.Text == "Zählerstand")
                zS_2.Text = "";
        }

        private void zS_2_Leave(object sender, EventArgs e)
        {
            if (zS_2.Text == "")
                zS_2.Text = "Zählerstand";
        }

        private void zS_1_Enter(object sender, EventArgs e)
        {
            if (zS_1.Text == "Zählerstand")
                zS_1.Text = "";
        }

        private void zS_1_Leave(object sender, EventArgs e)
        {
            if (zS_1.Text == "")
                zS_1.Text = "Zählerstand"; 
        }
    }
}
