using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DemoAccess
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private ConganxaEntities ConganxaEntities;

        public Form1()
        {
            InitializeComponent();
        }

        private int Idedit;
        private bool edit;
        public string pathfile = "";
        public string namefile;
        public string targetPath = @"D:\PhanmemQLVB\SaveFilePdf\";
        public string oldfile = "";
        public string status;
        public int years = 0;

        private void Loadform()
        {
            btn_infor.Caption = "Xin chào " + DinhDanhAccount.FullName + " bạn là " + DinhDanhAccount.Roles;

            // Provide the query string with a parameter placeholder.
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var LoaiVB = ConganxaEntities.GetAllLoaiVB().ToList();
                    foreach (var item in LoaiVB)
                    {
                        ComTenLoai.Properties.Items.Add(item.TenLoaiVB);
                    }
                    var DoMat = ConganxaEntities.GetAllDomat().ToList();
                    foreach (var item in DoMat)
                    {
                        ComDoMat.Properties.Items.Add(item.TenDoMat);
                    }
                    var NguoiNhan = ConganxaEntities.GetAllNguoiNhan().ToList();
                    foreach (var item in NguoiNhan)
                    {
                        ComNoinhan.Properties.Items.Add(item.TenNguoiNhan);
                    }
                    var Tacgia = ConganxaEntities.GetAllTacgia().ToList();

                    foreach (var item in Tacgia)
                    {
                        ComTacgia.Properties.Items.Add(item.Tentacgia);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void CapNhatDuLieu()
        {
            BtnPathfile.Text = namefile;
        }

        private void LoadGridcontrol(int nam)
        {
            nam = years;
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var thongtin = ConganxaEntities.GetAllThongtin(nam).ToList();
                    GrcVanBan.DataSource = thongtin;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi bảng thông tin chung");
            }
        }

        private void Getnull()
        {
            edit = false;
            TxtKyhieu.Text = null;
            TxtLienKet.Text = null;
            TxtSoden.Text = null;
            TxtSokyhieu.Text = null;
            Memghichu.Text = null;
            MemoNoidung.Text = null;
            DateNgayden.EditValue = null;
            DateNgaydukienhoanthanh.EditValue = null;
            DateNgaythang.EditValue = null;
            DateNgayhoanthanh.EditValue = null;
            BtnPathfile.EditValue = "";
        }

        private void FuncAdd()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    if (RadioStatus.SelectedIndex==0)
                    {
                        status = "VB đến";
                        layoutControlItem1.Text = "Ngày đên";
                    }
                    if (RadioStatus.SelectedIndex==1)
                    {
                        status = "VB đi";
                        layoutControlItem1.Text = "Ngày đi";
                    }
                    if (edit == false)
                    {
                        ConganxaEntities.InsertThongtin(status,(DateTime?)DateNgayden.EditValue, TxtSoden.Text, ComTacgia.Text, TxtSokyhieu.Text, (DateTime?)DateNgaythang.EditValue,
                            ComTenLoai.Text, TxtKyhieu.Text, ComDoMat.Text, ComNoinhan.Text, (DateTime?)DateNgaydukienhoanthanh.EditValue, MemoNoidung.Text, Memghichu.Text,
                            (DateTime?)DateNgayhoanthanh.EditValue, CheckHoanthanh.Checked, CheckChuahoanthanh.Checked, TxtLienKet.Text, BtnPathfile.Text, DateTime.Now, DinhDanhAccount.UserName);
                        if (pathfile != "")
                        {
                            File.Move(pathfile, targetPath + BtnPathfile.Text);
                        }
                        XtraMessageBox.Show("Lưu thông tin thành công");
                    }
                    if (edit == true)
                    {
                        ConganxaEntities.UpdateThongtin(Idedit,status, (DateTime?)DateNgayden.EditValue, TxtSoden.Text, ComTacgia.Text, TxtSokyhieu.Text, (DateTime?)DateNgaythang.EditValue,
                            ComTenLoai.Text, TxtKyhieu.Text, ComDoMat.Text, ComNoinhan.Text, (DateTime?)DateNgaydukienhoanthanh.EditValue, MemoNoidung.Text, Memghichu.Text,
                            (DateTime?)DateNgayhoanthanh.EditValue, CheckHoanthanh.Checked, CheckChuahoanthanh.Checked, TxtLienKet.Text, BtnPathfile.Text, DateTime.Now, DinhDanhAccount.UserName);
                        if (oldfile != BtnPathfile.Text)
                        {
                            if (oldfile != "")
                            {
                                File.Delete(targetPath + oldfile);
                            }
                            
                            File.Move(pathfile, targetPath + BtnPathfile.Text);
                        }
                        XtraMessageBox.Show("Lưu thông tin thành công");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Funcloadedit()
        {
            edit = true;
            if (GrvVanBan.GetFocusedRowCellValue("Status").ToString()== "VB đến")
            {
                RadioStatus.SelectedIndex = 0;
            }
            else
            {
                RadioStatus.SelectedIndex = 1;
            }
            Idedit = (int)GrvVanBan.GetFocusedRowCellValue("ID");
            DateNgayden.EditValue = GrvVanBan.GetFocusedRowCellValue("Ngayden");
            TxtSoden.EditValue = GrvVanBan.GetFocusedRowCellValue("SoDen");
            ComTacgia.EditValue = GrvVanBan.GetFocusedRowCellValue("Tentacgia");
            TxtSokyhieu.EditValue = GrvVanBan.GetFocusedRowCellValue("Sokyhieu");
            DateNgaythang.EditValue = GrvVanBan.GetFocusedRowCellValue("Ngaythang");
            ComTenLoai.EditValue = GrvVanBan.GetFocusedRowCellValue("TenLoaiVB");
            TxtKyhieu.EditValue = GrvVanBan.GetFocusedRowCellValue("KyHieu");
            ComDoMat.EditValue = GrvVanBan.GetFocusedRowCellValue("TenDoMat");
            ComNoinhan.EditValue = GrvVanBan.GetFocusedRowCellValue("NguoiNhan");
            DateNgaydukienhoanthanh.EditValue = GrvVanBan.GetFocusedRowCellValue("Ngaydukienhoanthanh");
            MemoNoidung.EditValue = GrvVanBan.GetFocusedRowCellValue("Trichyeunoidung");
            Memghichu.EditValue = GrvVanBan.GetFocusedRowCellValue("Ghichu");
            CheckHoanthanh.EditValue = GrvVanBan.GetFocusedRowCellValue("Hoanthanh");
            CheckChuahoanthanh.EditValue = GrvVanBan.GetFocusedRowCellValue("Chuahoanthanh");
            TxtLienKet.EditValue = GrvVanBan.GetFocusedRowCellValue("VBlienket");
            BtnPathfile.EditValue = GrvVanBan.GetFocusedRowCellValue("Dinhkemfile");
            oldfile = GrvVanBan.GetFocusedRowCellValue("Dinhkemfile").ToString();
            DateNgayhoanthanh.EditValue = GrvVanBan.GetFocusedRowCellValue("NgayHoanThanh");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Chờ 1 chút");
            SplashScreenManager.Default.SetWaitFormDescription("Đang xử lý...");

            try
            {
                UserLookAndFeel.Default.SkinName = Properties.Settings.Default.skin;
                years = DateTime.Now.Year;
                BarYears.EditValue = years;
                if (DinhDanhAccount.Roles != "Admin")
                {
                    BtnCreateAccount.Visibility = BarItemVisibility.Never;
                }
                Loadform();
                LoadGridcontrol(years);
            }
            finally
            {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Chờ 1 chút");
            SplashScreenManager.Default.SetWaitFormDescription("Đang xử lý...");
            years = DateTime.Now.Year;
            BarYears.EditValue = years;
            try
            {
                Loadform();
                LoadGridcontrol(years);
            }
            finally
            {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Getnull();
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region check file Exits
            if (edit==false)
            {
                if (File.Exists(targetPath + BtnPathfile.Text))
                {
                    XtraMessageBox.Show("Tên file đã tồn tại trong cơ sở dữ liệu.\n Vui lòng đổi tên file.");
                    return;
                }
            }
            #endregion check file Exits

            FuncAdd();
            Getnull();
            LoadGridcontrol(years);
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region check permission

            if (DinhDanhAccount.Roles != "Admin")
            {
                XtraMessageBox.Show("Bạn không có quyền xóa");
                return;
            }

            #endregion check permission
            if (XtraMessageBox.Show("Bạn có muốn xóa thông tin?", "Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            else
            {
                try
                {
                    using (ConganxaEntities = new ConganxaEntities())
                    {
                        int Id = (int)GrvVanBan.GetFocusedRowCellValue("ID");
                        ConganxaEntities.DeleteThongtin(Id);
                        string namefile = GrvVanBan.GetFocusedRowCellValue("Dinhkemfile").ToString();
                        if (namefile != "")
                        {
                            File.Delete(targetPath + namefile);
                        }
                        XtraMessageBox.Show("Xóa thông tin thành công");
                        LoadGridcontrol(years);
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Xóa thông tin không thành công");
                }
            }
           
        }

        private void GrvVanBan_DoubleClick(object sender, EventArgs e)
        {
            Funcloadedit();
        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Funcloadedit();
        }

        private void BtnPathfile_DoubleClick(object sender, EventArgs e)
        {
            if (RadioFile.SelectedIndex == 0)
            {
                Imagestopdf imagestopdf = new Imagestopdf(this);
                imagestopdf.ShowDialog();
            }
            if (RadioFile.SelectedIndex == 1)
            {
                OpenFileDialog openFile = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = @"Pdf Files (*.pdf)|*pdf",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(openFile.FileName);
                    BtnPathfile.Text = fi.Name;
                    pathfile = fi.FullName;
                }
            }
        }

        private void RepositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            ViewPdf viewPdf = new ViewPdf
            {
                FileNamePdf = targetPath + GrvVanBan.GetFocusedRowCellValue("Dinhkemfile").ToString()
            };
            viewPdf.ShowDialog();
        }

        private void RepositoryItemHyperLinkEdit1_Click(object sender, EventArgs e)
        {
            ViewPdf viewPdf = new ViewPdf
            {
                FileNamePdf = targetPath + GrvVanBan.GetFocusedRowCellValue("Dinhkemfile").ToString()
            };
            viewPdf.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.skin = UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
        }

        private void BtnTienich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tienich tienich = new Tienich();
            tienich.Show();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Changepassword changepassword = new Changepassword();
            changepassword.ShowDialog();
        }

        private void BtnCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void GrvVanBan_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void GrvVanBan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
          
            if (e.Column.FieldName == "Status")
            {
                string status = GrvVanBan.GetRowCellDisplayText(e.RowHandle, GrvVanBan.Columns["Status"]);
                if (status == "VB đến")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Green);
                }
                if (status == "VB đi")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.OrangeRed);
                }
            }
        }

        private void RadioStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (RadioStatus.SelectedIndex == 0)
            {
                layoutControlItem1.Text = "Ngày đến";
                layoutControlItem2.Text = "Số đến";
            }
            if (RadioStatus.SelectedIndex == 1)
            {
                layoutControlItem1.Text = "Ngày đi";
                layoutControlItem2.Text = "Số đi";
            }
        }

        private void BarYears_EditValueChanged(object sender, EventArgs e)
        {
            #region check dieukien
            if(!String.IsNullOrEmpty(BarYears.EditValue.ToString()))
            #endregion
            years =Int32.Parse(BarYears.EditValue.ToString());
            LoadGridcontrol(years);
        }
    }
}