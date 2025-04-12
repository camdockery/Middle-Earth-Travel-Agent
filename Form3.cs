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

namespace Middle_Earth_Travel_Agent
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

        PrivateFontCollection customFonts = new PrivateFontCollection();

        private void LoadCustomFont()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Middleearth-ao6m.ttf");
            customFonts.AddFontFile(fontPath);

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 10F, FontStyle.Regular);
            label1.Font = customFont;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
        }
    }
}
