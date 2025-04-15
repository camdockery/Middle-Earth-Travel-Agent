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
        String[] months;

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
            label4.Font = customFont3;
            label5.Font = customFont3;
            button1.Font = customFont2;
            checkedListBox1.Font = customFont3;
            checkedListBox2.Font = customFont3;
            comboBox1.Font = customFont3;
            comboBox2.Font = customFont3;
            comboBox3.Font = customFont3;
            comboBox4.Font = customFont3;
            comboBox5.Font = customFont3;
            comboBox6.Font = customFont3;
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
            label4.BackColor = ColorTranslator.FromHtml("#f5eece");
            label5.BackColor = ColorTranslator.FromHtml("#f5eece");
            button1.BackColor = ColorTranslator.FromHtml("#e3b737");
            companions = CompanionLoader.LoadCompanions();
            months = MonthsLoader.LoadMonths();
            String[] mounts = {"Horse", "Great Eagle"};
            int totalDaysOrYears = 30;
            int currentYear = 3018;
            for (int i = 0; i <= totalDaysOrYears; i++)
            {
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(currentYear);
                comboBox5.Items.Add(i);
                comboBox6.Items.Add(currentYear);
                currentYear++;
            }

            checkedListBox1.Items.AddRange(companions);
            checkedListBox2.Items.AddRange(mounts);
            comboBox1.Items.AddRange(months);
            comboBox4.Items.AddRange(months);
            label2.Text = "Bring a Mount?";
            label3.Text = "Start a Fellowship?";
            label4.Text = "When Does the Journey Begin?";
            label5.Text = "When Does the Journey End?";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
