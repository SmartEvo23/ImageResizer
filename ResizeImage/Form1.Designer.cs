namespace ResizeImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.selectImage = new System.Windows.Forms.Label();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Label();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.checkBoxAutoResize = new System.Windows.Forms.CheckBox();
            this.labelRatio = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nr1 = new System.Windows.Forms.Label();
            this.nr2 = new System.Windows.Forms.Label();
            this.sageti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // selectImage
            // 
            resources.ApplyResources(this.selectImage, "selectImage");
            this.selectImage.Name = "selectImage";
            this.selectImage.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSelect
            // 
            resources.ApplyResources(this.textBoxSelect, "textBoxSelect");
            this.textBoxSelect.Name = "textBoxSelect";
            // 
            // buttonSelect
            // 
            resources.ApplyResources(this.buttonSelect, "buttonSelect");
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // saveImage
            // 
            resources.ApplyResources(this.saveImage, "saveImage");
            this.saveImage.Name = "saveImage";
            // 
            // textBoxSave
            // 
            resources.ApplyResources(this.textBoxSave, "textBoxSave");
            this.textBoxSave.Name = "textBoxSave";
            // 
            // buttonSave1
            // 
            resources.ApplyResources(this.buttonSave1, "buttonSave1");
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
            // 
            // checkBoxAutoResize
            // 
            resources.ApplyResources(this.checkBoxAutoResize, "checkBoxAutoResize");
            this.checkBoxAutoResize.Checked = true;
            this.checkBoxAutoResize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoResize.Name = "checkBoxAutoResize";
            this.checkBoxAutoResize.UseVisualStyleBackColor = true;
            this.checkBoxAutoResize.CheckedChanged += new System.EventHandler(this.checkBoxAutoResize_CheckedChanged);
            // 
            // labelRatio
            // 
            resources.ApplyResources(this.labelRatio, "labelRatio");
            this.labelRatio.Name = "labelRatio";
            // 
            // labelWidth
            // 
            resources.ApplyResources(this.labelWidth, "labelWidth");
            this.labelWidth.Name = "labelWidth";
            // 
            // textBoxWidth
            // 
            resources.ApplyResources(this.textBoxWidth, "textBoxWidth");
            this.textBoxWidth.Name = "textBoxWidth";
            // 
            // labelHeight
            // 
            resources.ApplyResources(this.labelHeight, "labelHeight");
            this.labelHeight.Name = "labelHeight";
            // 
            // textBoxHeight
            // 
            resources.ApplyResources(this.textBoxHeight, "textBoxHeight");
            this.textBoxHeight.Name = "textBoxHeight";
            // 
            // labelType
            // 
            resources.ApplyResources(this.labelType, "labelType");
            this.labelType.Name = "labelType";
            // 
            // comboBoxFileType
            // 
            resources.ApplyResources(this.comboBoxFileType, "comboBoxFileType");
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Items.AddRange(new object[] {
            resources.GetString("comboBoxFileType.Items"),
            resources.GetString("comboBoxFileType.Items1"),
            resources.GetString("comboBoxFileType.Items2"),
            resources.GetString("comboBoxFileType.Items3")});
            this.comboBoxFileType.Name = "comboBoxFileType";
            // 
            // labelHelp
            // 
            resources.ApplyResources(this.labelHelp, "labelHelp");
            this.labelHelp.Name = "labelHelp";
            // 
            // buttonShow
            // 
            resources.ApplyResources(this.buttonShow, "buttonShow");
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonResize
            // 
            resources.ApplyResources(this.buttonResize, "buttonResize");
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonSave2
            // 
            resources.ApplyResources(this.buttonSave2, "buttonSave2");
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // labelProgress
            // 
            resources.ApplyResources(this.labelProgress, "labelProgress");
            this.labelProgress.Name = "labelProgress";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // nr1
            // 
            resources.ApplyResources(this.nr1, "nr1");
            this.nr1.ForeColor = System.Drawing.Color.Red;
            this.nr1.Name = "nr1";
            // 
            // nr2
            // 
            resources.ApplyResources(this.nr2, "nr2");
            this.nr2.ForeColor = System.Drawing.Color.Red;
            this.nr2.Name = "nr2";
            // 
            // sageti
            // 
            resources.ApplyResources(this.sageti, "sageti");
            this.sageti.ForeColor = System.Drawing.Color.Red;
            this.sageti.Name = "sageti";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sageti);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.comboBoxFileType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelRatio);
            this.Controls.Add(this.checkBoxAutoResize);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.selectImage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.labelLanguage);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLanguage;
        private ComboBox comboBoxLanguage;
        private Label selectImage;
        private TextBox textBoxSelect;
        private Button buttonSelect;
        private Label saveImage;
        private TextBox textBoxSave;
        private Button buttonSave1;
        private CheckBox checkBoxAutoResize;
        private Label labelRatio;
        private Label labelWidth;
        private TextBox textBoxWidth;
        private Label labelHeight;
        private TextBox textBoxHeight;
        private Label labelType;
        private ComboBox comboBoxFileType;
        private Label labelHelp;
        private Button buttonShow;
        private Button buttonResize;
        private Button buttonSave2;
        private Label labelProgress;
        private ProgressBar progressBar1;
        private Label nr1;
        private Label nr2;
        private Label sageti;
    }
}