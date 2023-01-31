namespace ResizeImage
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Threading;

    public partial class Form1 : Form
    {

        Image img;
        string[] fileType = { ".png", ".jpeg", ".jpg", ".gif" };
        int imgWidth;
        int imgHeight;

        public Form1()
        {
            InitializeComponent();
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.Items.Add("Romana");
            comboBoxLanguage.SelectedItem = null;

            textBoxWidth.Enabled = false;
            textBoxHeight.Enabled = false;
            labelWidth.Enabled = false;
            labelHeight.Enabled = false;
            labelType.Enabled = false;
            comboBoxFileType.Enabled = false;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem.ToString() == "English")
            {
                ChangeLanguage("en-US");
            }
            else if (comboBoxLanguage.SelectedItem.ToString() == "Romana")
            {
                ChangeLanguage("ro-RO");
            }
            else
            {
                ChangeLanguage("en-US");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images | *.png;*.jpg;*.jpeg;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxSelect.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxSave.Text = fbd.SelectedPath;
            }
        }

        private void checkBoxAutoResize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoResize.Checked) 
            {
                textBoxWidth.Enabled = false;
                textBoxHeight.Enabled = false;
                labelWidth.Enabled = false;
                labelHeight.Enabled = false;
                labelType.Enabled = false;
                comboBoxFileType.Enabled = false;
            }
            else
            {
                textBoxWidth.Enabled = true;
                textBoxHeight.Enabled = true;
                labelWidth.Enabled = true;
                labelHeight.Enabled = true;
                labelType.Enabled = true;
                comboBoxFileType.Enabled = true;
            }
        }

        //Resize without center and crop
        static Image Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(image, 0, 0, w, h);
            graphics.Dispose();

            return bmp;
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            if (textBoxSelect.Text != null && textBoxSave.Text != null)
            {
                int w = Convert.ToInt32(textBoxWidth.Text);
                int h = Convert.ToInt32(textBoxHeight.Text);
                img = Resize(img, w, h);
                ((Button)sender).Enabled = false;
            }
            else
            {
                MessageBox.Show("Selectati imaginea si alegeti zona de salvare!");
            }

            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            for (var i = 0; i < 100; i++) progressBar1.Value++;
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            int dot = 0; 
            int slash = 0;
            for (int j = textBoxSelect.Text.Length - 1; j >= 0; j--)
            {
                if (textBoxSelect.Text[j] == '.')
                    dot = j;
                else if (textBoxSelect.Text[j] == '\\')
                {
                    slash = j;
                    break;
                }
            }
        }
    }
}