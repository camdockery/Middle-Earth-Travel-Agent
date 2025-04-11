using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Middle_Earth_Travel_Agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

        PrivateFontCollection customFonts = new PrivateFontCollection();
        List<Location> locations = new List<Location>();

        private void LoadCustomFont()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Middleearth-ao6m.ttf");
            customFonts.AddFontFile(fontPath);

            Font customFont = new Font(customFonts.Families[0], 25F, FontStyle.Bold);
            Font customFont2 = new Font(customFonts.Families[0], 15F, FontStyle.Regular);
            Font customFont3 = new Font(customFonts.Families[0], 10F, FontStyle.Regular);
            label1.Font = customFont;
            comboBox1.Font = customFont3;
            button1.Font = customFont2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
            button1.BackColor = ColorTranslator.FromHtml("#e3b737");
            locations =  LocationLoader.LoadLocations();
            //Object[] locationNames = new object[locations.Count];
            //for (int i = 0; i < locations.Count; i++)
            //{
            //    object? name = locations[i].name;
            //    if(name != null)
            //    {
            //        locationNames[i] = name;
            //    }
            //}
            String[] locationNames = new string[locations.Count];
            for (int i = 0; i < locations.Count; i++)
            {
                String? name = locations[i].name;
                if (name != null)
                {
                    locationNames[i] = name;
                }
                
            }
            this.comboBox1.Items.AddRange(locationNames);


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                String? item = (string?)comboBox1.SelectedItem;
                MessageBox.Show(item);
            }
            
        }

    }

}
