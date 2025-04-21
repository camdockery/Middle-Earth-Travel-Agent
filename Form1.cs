using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Middle_Earth_Travel_Agent
{
    /*
     * The start page
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#f5eece");
        }

        PrivateFontCollection customFonts = new PrivateFontCollection();
        List<Location> locations = new();
        Location currentLocation = new();


        /*
         * Loads the custom Middle Earth style font on all the text
         */
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
            button2.Font = customFont2;

        }

        /*
        * The different text and actions formed when the form loads in 
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomFont();
            label1.ForeColor = ColorTranslator.FromHtml("#b87316");
            label1.BackColor = ColorTranslator.FromHtml("#f5eece");
            button1.BackColor = ColorTranslator.FromHtml("#e3b737");
            button2.BackColor = ColorTranslator.FromHtml("#e3b737");
            //Loads the locations from the locations.json
            locations = LocationLoader.LoadLocations();
            String[] locationNames = new string[locations.Count];
            //If the location is not null, add it's name to the list
            for (int i = 0; i < locations.Count; i++)
            {
                String? name = locations[i].name;
                if (name != null)
                {
                    locationNames[i] = name;
                }

            }
            //Add the location names to the selection for either exploring or booking
            this.comboBox1.Items.AddRange(locationNames);


        }

        /*
         * The Explore It! button
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //If the user has selected a location
            if (comboBox1.SelectedIndex != -1)
            {
                currentLocation = locations[comboBox1.SelectedIndex];
                var form = new Form2(currentLocation, customFonts);
                form.Show();
                this.Hide();
            }

        }

        /*
         * The Book It! button
         */
        private void button2_Click(object sender, EventArgs e)
        {
            //If the user has selected a location
            if (comboBox1.SelectedIndex != -1)
            {
                currentLocation = locations[comboBox1.SelectedIndex];
                var form = new Form3(currentLocation, customFonts);
                form.Show();
                this.Hide();
            }

        }

    }

}
