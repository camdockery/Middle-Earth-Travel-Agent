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
        public Form4(Location currentLocation, PrivateFontCollection customFonts)
        {
            InitializeComponent();
            this.currentLocation = currentLocation;
            this.customFonts = customFonts;
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

        private void LoadCustomFont()
        {

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            //Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            //Font customFont3 = new Font(customFonts.Families[0], 8F, FontStyle.Regular);
            label1.Font = customFont;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
        }
    }
}
