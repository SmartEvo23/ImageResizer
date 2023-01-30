namespace ResizeImage
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Romana");
            comboBoxLanguage.SelectedItem = null;

            Image img;
            string[] fileType = { ".png", ".jpeg", ".jpg", ".gif" };
            int imgWidth;
            int imgHeight;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem.ToString() == "English")
            {
                ChangeLanguage("en");
            }
            else if (comboBoxLanguage.SelectedItem.ToString() == "Romana")
            {
                ChangeLanguage("ro-RO");
            }
            else
            {
                ChangeLanguage("en-EN");
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
    }
}