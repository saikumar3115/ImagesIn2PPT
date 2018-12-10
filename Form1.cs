using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using Application = Microsoft.Office.Interop.PowerPoint.Application;

namespace CreatePPT
{
    public partial class Form1 : Form
    {
        List<string> allowedExtensions = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                var settings = ConfigurationManager.AppSettings;
                foreach (var key in settings.AllKeys)
                {
                    allowedExtensions.Add(settings[key]);
                }

                if (string.IsNullOrWhiteSpace(txtSourceImages.Text))
                {
                    MessageBox.Show("Please Select the Source of the images");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTarget.Text))
                {
                    MessageBox.Show("Please Select the Target of the images");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtfileName.Text))
                {
                    MessageBox.Show("Please give name of the file");
                    return;
                }
                button1.Enabled = false;
                Application ppt = new Application();
                Microsoft.Office.Interop.PowerPoint.Slides slides;
                Microsoft.Office.Interop.PowerPoint._Slide slide;
                Microsoft.Office.Interop.PowerPoint.TextRange objRange;

                Presentation presentation = ppt.Presentations.Add(MsoTriState.msoTrue);

                CustomLayout customLayout = presentation.SlideMaster.CustomLayouts[Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutText];

                var files = new DirectoryInfo(txtSourceImages.Text).GetFiles();
                foreach (var file in files)
                {
                    if (!allowedExtensions.Contains(file.Extension))
                        continue;
                    slides = presentation.Slides;
                    slide = slides.AddSlide(1, customLayout);


                    objRange = slide.Shapes[1].TextFrame.TextRange;
                    objRange.Text = !string.IsNullOrWhiteSpace(txtTitle.Text) ? txtTitle.Text : "";
                    objRange.Font.Name = "Verdana";
                    objRange.Font.Size = 32;

                    objRange = slide.Shapes[2].TextFrame.TextRange;

                    Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[2];
                    slide.Shapes.AddPicture(Path.Combine(txtSourceImages.Text, file.FullName), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, shape.Left, shape.Top, shape.Width, shape.Height);

                    slide.NotesPage.Shapes[2].TextFrame.TextRange.Text = !string.IsNullOrWhiteSpace(txtTextFrame.Text) ? txtTextFrame.Text : "";
                }
                presentation.SaveAs(Path.Combine(txtTarget.Text, txtfileName.Text + ".pptx"), Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);

                //  presentation.Close();
                // ppt.Quit();
                button1.Enabled = true;
            }
            catch (Exception ex)
            {

                new LogWriter(ex.InnerException.ToString());
                new LogWriter(ex.StackTrace.ToString());
                new LogWriter(ex.Message.ToString());
            }
        }


        private void selectSource_Click(object sender, EventArgs e)
        {

            this.fbDDialog = new System.Windows.Forms.FolderBrowserDialog();
            fbDDialog.ShowNewFolderButton = true;
            DialogResult result = fbDDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSourceImages.Text = fbDDialog.SelectedPath;
                Environment.SpecialFolder root = fbDDialog.RootFolder;
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            fbdTarget.ShowNewFolderButton = true;
            DialogResult result = fbdTarget.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtTarget.Text = fbdTarget.SelectedPath;
                Environment.SpecialFolder root = fbDDialog.RootFolder;
            }
        }
    }
}
