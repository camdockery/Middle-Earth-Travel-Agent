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
        PrivateFontCollection customFonts = new PrivateFontCollection();
        Location currentLocation;
        public Form3(Location currentLocation, PrivateFontCollection customFonts)
        {
            InitializeComponent();
            this.currentLocation = currentLocation;
            this.customFonts = customFonts;
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }


        String[] companions;
        String[] months;

        private void LoadCustomFont()
        {

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 8F, FontStyle.Regular);
            label1.Font = customFont;
            label2.Font = customFont3;
            label3.Font = customFont3;
            label4.Font = customFont3;
            label5.Font = customFont3;
            button1.Font = customFont2;
            button2.Font = customFont3;
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
            button2.BackColor = ColorTranslator.FromHtml("#e3b737");
            companions = CompanionLoader.LoadCompanions();
            months = MonthsLoader.LoadMonths();
            String[] mounts = { "Horse", "Great Eagle" };
            int totalDaysOrYears = 30;
            int currentYear = 3018;
            for (int i = 1; i <= totalDaysOrYears; i++)
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
            MessageBox.Show(comboBox2.SelectedIndex.ToString());
            int selected = comboBox1.SelectedIndex;
            int selected2 = comboBox2.SelectedIndex;
            int selected3 = comboBox3.SelectedIndex;
            int selected4 = comboBox4.SelectedIndex;
            int selected5 = comboBox5.SelectedIndex;
            int selected6 = comboBox6.SelectedIndex;
            int year1 = -1;
            int year2 = -1;
            int day1 = -1;
            int day2 = -1;
            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
            {
                year1 = (int)comboBox3.SelectedItem;
                year2 = (int)comboBox6.SelectedItem;
                day1 = (int)comboBox2.SelectedItem;
                day2 = (int)comboBox5.SelectedItem;
            }

            if (selected == -1 || selected2 == -1 || selected3 == -1 || selected4 == -1 || selected5 == -1 || selected6 == -1)
            {
                MessageBox.Show("Finish booking information");
            }
            else if (year1 > year2 || (year1 == year2) && ((selected > selected4) || ((selected == selected4) && (day1 > day2))))
            {
                MessageBox.Show("Invalid booking date");
            }
            else
            {

                String month1 = "empty";
                String month2 = "empty";
                if (comboBox1.SelectedItem != null && comboBox4.SelectedItem != null)
                {
                    month1 = (String)comboBox1.SelectedItem;
                    month2 = (String)comboBox4.SelectedItem;
                }
                String[] companionsChecked = new String[checkedListBox1.CheckedItems.Count];
                for(int i = 0; i <  checkedListBox1.CheckedItems.Count; i++)
                {
                    if(checkedListBox1.CheckedItems[i] != null)
                    {
                        companionsChecked[i] = checkedListBox1.CheckedItems[i].ToString();
                    }                  
                }
                String[] mountsChecked = new String[checkedListBox2.CheckedItems.Count];
                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    if (checkedListBox2.CheckedItems[i] != null)
                    {
                        mountsChecked[i] = checkedListBox2.CheckedItems[i].ToString();
                    }
                }
                Date journeyStart = new Date();
                Date journeyEnd = new Date();
                journeyStart.month = month1;
                journeyStart.day = day1;
                journeyStart.year = year1;
                journeyEnd.month = month2;
                journeyEnd.day = day2;
                journeyEnd.year = year2;
                Form4 form = new Form4(currentLocation, customFonts, companionsChecked, mountsChecked, journeyStart, journeyEnd);
                this.Hide();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
