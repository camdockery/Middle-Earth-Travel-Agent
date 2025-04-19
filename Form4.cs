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
    public partial class Form4 : Form
    {
        Location currentLocation;
        PrivateFontCollection customFonts = new PrivateFontCollection();
        String[] companionsChecked;
        String[] mountsChecked;
        Date journeyStart;
        Date journeyEnd;
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
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.Text = "Journey Booked!";
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
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
            label9.Text = "You".PadRight(20);
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

        }
    }
}
