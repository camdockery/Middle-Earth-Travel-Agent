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
    public partial class Form2 : Form
    {
        List<Location> locations;
        Location currentLocation;
        PrivateFontCollection customFonts = new PrivateFontCollection();
        public Form2(List<Location> locations, Location currentLocation, PrivateFontCollection customFonts)
        {
            InitializeComponent();
            this.locations = locations;
            this.currentLocation = currentLocation;
            this.customFonts = customFonts;
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

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
            //String? activities = "";
            //activities.Join(activities, currentLocation.activities);
            if (currentLocation.activities != null)
            {
                label7.Text = String.Join(", ", currentLocation.activities);
            }
            label8.Text = "Recommended Season";
            label9.Text = currentLocation.recommendedSeason;
        }

        private void LoadCustomFont()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Middleearth-ao6m.ttf");
            customFonts.AddFontFile(fontPath);

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            //Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
