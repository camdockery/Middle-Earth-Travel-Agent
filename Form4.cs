using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Middle_Earth_Travel_Agent
{
    /*
     * The page that is displayed after a journey has been successfully booked
     */
    public partial class Form4 : Form
    {
        Location currentLocation;
        PrivateFontCollection customFonts = new PrivateFontCollection();
        String[] companionsChecked;
        String[] mountsChecked;
        Date journeyStart;
        Date journeyEnd;
        /*
         * The constructor for the form
         * @param currentLocation the currently selected location to book
         * @param customFonts the custom Middle Earth font
         * @param companionsChecked the list of companions that were selected to bring on the journey
         * @param mountsChecked the list of mounts that were selected to bring on the journey
         * @param journeyStart the starting date(month, day, year) of the journey
         * @param journeyEnd the ending date(month, day, year) of the journey
         */
        public Form4(Location currentLocation, PrivateFontCollection customFonts, String[] companionsChecked, String[] mountsChecked, Date journeyStart, Date journeyEnd)
        {
            InitializeComponent();
            this.currentLocation = currentLocation;
            this.customFonts = customFonts;
            this.companionsChecked = companionsChecked;
            this.mountsChecked = mountsChecked;
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
            this.journeyStart = journeyStart;
            this.journeyEnd = journeyEnd;
        }

        /*
         * Loads the custom Middle Earth style font on all the text
         */
        private void LoadCustomFont()
        {

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 10F, FontStyle.Regular);
            label1.Font = customFont;
            label2.Font = customFont2;
            label3.Font = customFont2;
            label4.Font = customFont3;
            label5.Font = customFont3;
            label6.Font = customFont2;
            label7.Font = customFont3;
            label8.Font = customFont2;
            label9.Font = customFont3;
            label10.Font = customFont2;
            label11.Font = customFont3;
        }

        /*
         * The different text and actions formed when the form loads in 
         */
        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.Text = "Journey Booked!";
            //Changes the title background color
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
            //Changes the title text color
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label2.Text = "The Journey Begins:";
            label2.BackColor = ColorTranslator.FromHtml("#f5eece");
            label2.ForeColor = ColorTranslator.FromHtml("#b87316");
            label3.Text = "The Journey Ends:";
            label3.BackColor = ColorTranslator.FromHtml("#f5eece");
            label3.ForeColor = ColorTranslator.FromHtml("#b87316");
            label4.Text = journeyStart.month + ", " + journeyStart.day + ", " + journeyStart.year;
            label4.BackColor = ColorTranslator.FromHtml("#f5eece");
            label5.Text = journeyEnd.month + ", " + journeyEnd.day + ", " + journeyEnd.year;
            label5.BackColor = ColorTranslator.FromHtml("#f5eece");
            label6.Text = "Journeying To:";
            label6.BackColor = ColorTranslator.FromHtml("#f5eece");
            label6.ForeColor = ColorTranslator.FromHtml("#b87316");
            label8.Text = "Members of the Fellowship";
            label8.BackColor = ColorTranslator.FromHtml("#f5eece");
            label8.ForeColor = ColorTranslator.FromHtml("#b87316");
            label7.Text = currentLocation.name;
            label7.BackColor = ColorTranslator.FromHtml("#f5eece");
            label9.BackColor = ColorTranslator.FromHtml("#f5eece");
            //Adds You to the companions on the screen and pads 20 space characters
            label9.Text = "You".PadRight(20);
            //Starts at 1 cause You was just added, ensures there are 3 max companions per line
            int companionCounter = 1;
            foreach(string companion in companionsChecked)
            {
                if (companionCounter != 2)
                {
                    label9.Text += companion.PadRight(20);
                    companionCounter++;
                }
                else
                {
                    label9.Text += companion + "\n";
                    companionCounter = 0;
                }         
            }
            label10.ForeColor = ColorTranslator.FromHtml("#b87316");
            label10.Text = "Mounts:";
            label11.BackColor = ColorTranslator.FromHtml("#f5eece");
            label11.Text = "";
            //Adds the selected mounts to the screen but adds none if no mounts are selected
            foreach(string mount in mountsChecked)
            {
                label11.Text += mount.PadRight(20);
            }
            if(label11.Text == "")
            {
                label11.Text = "None";

            }
        }
    }
}
