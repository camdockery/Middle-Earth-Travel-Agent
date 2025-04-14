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
        String[] companions;

        private void LoadCustomFont()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Middleearth-ao6m.ttf");
            customFonts.AddFontFile(fontPath);

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 8F, FontStyle.Regular);
            label1.Font = customFont;
            label2.Font = customFont3;
            label3.Font = customFont3;
            button1.Font = customFont2;
            checkedListBox1.Font = customFont3;
            checkedListBox2.Font = customFont3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            checkedListBox1.CheckOnClick = true;
            checkedListBox2.CheckOnClick = true;
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
            label2.BackColor = ColorTranslator.FromHtml("#f5eece");
            label3.BackColor = ColorTranslator.FromHtml("#f5eece");
            button1.BackColor = ColorTranslator.FromHtml("#e3b737");
            companions = CompanionLoader.LoadCompanions();
            String[] mounts = {"Horse", "Great Eagle"};
            checkedListBox1.Items.AddRange(companions);
            checkedListBox2.Items.AddRange(mounts);
            label2.Text = "Bring a Mount?";
            label3.Text = "Start a Fellowship?";
            monthCalendar1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
