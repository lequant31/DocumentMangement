using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DemoAccess
{
    public partial class Imagestopdf : DevExpress.XtraEditors.XtraForm
    {
        private Form1 GetForm1;

        public Imagestopdf(Form1 form1)
        {
            GetForm1 = form1;
            InitializeComponent();
        }

        private void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Chờ 1 chút");
            SplashScreenManager.Default.SetWaitFormDescription("Đang xử lý...");
            try
            {
                OpenFileDialog openFile = new OpenFileDialog
                {
                    Multiselect = true,
                    Filter = @"Image Files (*.JPG,*.PNG)|*JPG;*PNG",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (openFile.ShowDialog() != DialogResult.OK) return;
                foreach (String file in openFile.FileNames)
                {
                    ListFile.Items.Add(file.ToString());
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void BtnSaveasFile_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Chờ 1 chút");
            SplashScreenManager.Default.SetWaitFormDescription("Đang xử lý...");
            if (ListFile.Items.Count > 0)
            {
                try
                {
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Đang khởi tạo file Pdf";
                    foreach (String file in ListFile.Items)
                    {
                        PdfPage page = document.AddPage();
                        if (Radiohuonggiay.SelectedIndex == 1)
                        {
                            page.Orientation = PageOrientation.Landscape;
                        }

                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        DrawImage(gfx, file, 0, 0, (int)page.Width, (int)page.Height);
                    }
                    if (document.PageCount > 0)
                    {
                        string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string _pathfile = str+"\\" + TxtSaveasFile.Text+ DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                        document.Save(_pathfile);
                        GetForm1.pathfile = _pathfile;
                        GetForm1.namefile = Path.GetFileName(_pathfile);
                        GetForm1.CapNhatDuLieu();
                    }
                }
                finally
                {
                    SplashScreenManager.CloseForm(false);
                }
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng thêm file ảnh cần lưu");
            }
        }

        private void Imagestopdf_Load(object sender, EventArgs e)
        {

        }
    }
}