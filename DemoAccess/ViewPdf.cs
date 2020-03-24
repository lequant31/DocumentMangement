using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DemoAccess
{
    public partial class ViewPdf : DevExpress.XtraEditors.XtraForm
    {
        public string FileNamePdf;
        public ViewPdf()
        {
            InitializeComponent();
        }

        private void ViewPdf_Load(object sender, EventArgs e)
        {
            try
            {
                pdfViewer1.LoadDocument(FileNamePdf);
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Không tìm thấy tài liệu đính kèm.\nTài liệu đính kèm đã bị xóa hoặc di chuyển sang thu mục khác.");
                this.Close();
            }
        }
    }
}