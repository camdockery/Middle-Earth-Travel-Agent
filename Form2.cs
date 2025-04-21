using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Middle_Earth_Travel_Agent
{
    /*
     * The explore location page
     */
    public partial class Form2 : Form
    {
        Location currentLocation;
        PrivateFontCollection customFonts = new PrivateFontCollection();
        public Form2(Location currentLocation, PrivateFontCollection customFonts)
        {
            InitializeComponent();
            this.currentLocation = currentLocation;
            this.customFonts = customFonts;
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

        /*
        * The different text and actions formed when the form loads in 
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.Text = currentLocation.name;
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
            label2.Text = "Description: ";
            label3.Text = currentLocation.description;
            label4.Text = "Region: ";
            label5.Text = currentLocation.region;
            label6.Text = "Activities: ";
            if (currentLocation.activities != null)
            {
                label7.Text = String.Join(", ", currentLocation.activities);
            }
            label8.Text = "Recommended Season";
            label9.Text = currentLocation.recommendedSeason;
        }

        /*
         * Loads the custom Middle Earth style font on all the text
         */
        private void LoadCustomFont()
        {
            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 10F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 8F, FontStyle.Regular);
            label1.Font = customFont;
            label2.Font = customFont2;
            label3.Font = customFont2;
            label4.Font = customFont2;
            label5.Font = customFont2;
            label6.Font = customFont2;
            label7.Font = customFont2;
            label8.Font = customFont2;
            label9.Font = customFont2;
            button1.Font = customFont3;
            label2.BackColor = ColorTranslator.FromHtml("#f5eece");
            label3.BackColor = ColorTranslator.FromHtml("#f5eece");
            label4.BackColor = ColorTranslator.FromHtml("#f5eece");
            label5.BackColor = ColorTranslator.FromHtml("#f5eece");
            label6.BackColor = ColorTranslator.FromHtml("#f5eece");
            label7.BackColor = ColorTranslator.FromHtml("#f5eece");
            label8.BackColor = ColorTranslator.FromHtml("#f5eece");
            label9.BackColor = ColorTranslator.FromHtml("#f5eece");
            button1.BackColor = ColorTranslator.FromHtml("#e3b737");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
