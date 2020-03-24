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
    public partial class Tienich : DevExpress.XtraEditors.XtraForm
    {
        ConganxaEntities ConganxaEntities;
        public Tienich()
        {
            InitializeComponent();
        }
        private void ReloadLoaiVB()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var getitems = ConganxaEntities.GetAllLoaiVB().ToList();
                    GrcLoaiVB.DataSource = getitems;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ReloadNguoiNhan()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var getitems = ConganxaEntities.GetAllNguoiNhan().ToList();
                    GrcNguoiNhan.DataSource = getitems;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ReloadDoMat()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var getitems = ConganxaEntities.GetAllDomat().ToList();
                    GrcDoMat.DataSource = getitems;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ReloadTacGia()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var getitems = ConganxaEntities.GetAllTacgia().ToList();
                    GrcTacGia.DataSource = getitems;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Tienich_Load(object sender, EventArgs e)
        {
            ReloadDoMat();
            ReloadLoaiVB();
            ReloadNguoiNhan();
            ReloadTacGia();
        }

        private void BtnAddLoaiVB_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.InsertLoaiVB(TxtLoaiVB.Text);
                }
                ReloadLoaiVB();
                XtraMessageBox.Show("Thêm thông tin thành công");
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelLoaiVB_Click(object sender, EventArgs e)
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
                        int Id = (int)GrvLoaiVB.GetFocusedRowCellValue("Id");
                        ConganxaEntities.DeleteLoaiVB(Id);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                        ReloadLoaiVB();
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Xóa thông tin không thành công");
                }
            }
        }

        private void BtnAddDoMat_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.InsertDoMat(TxtDoMat.Text);
                }
                ReloadDoMat();
                XtraMessageBox.Show("Thêm thông tin thành công");
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelDoMat_Click(object sender, EventArgs e)
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
                        int Id = (int)GrvDoMat.GetFocusedRowCellValue("Id");
                        ConganxaEntities.DeleteDoMat(Id);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                        ReloadDoMat();
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Xóa thông tin không thành công");
                }
            }
        }

        private void BtnAddNguoiNhan_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.InsertNguoiNhan(TxtNguoiNhan.Text);
                }
                ReloadNguoiNhan();
                XtraMessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelNguoiNhan_Click(object sender, EventArgs e)
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
                        int Id = (int)GrvNguoiNha.GetFocusedRowCellValue("Id");
                        ConganxaEntities.DeleteNguoiNhan(Id);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                        ReloadNguoiNhan();
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Xóa thông tin không thành công");
                }
            }
        }

        private void BtnAddTacgia_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.InsertTacGia(TxtTacGia.Text);
                }
                ReloadTacGia();
                XtraMessageBox.Show("Thêm thông tin thành công");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelTacgia_Click(object sender, EventArgs e)
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
                        int Id = (int)GrvTacGia.GetFocusedRowCellValue("Id");
                        ConganxaEntities.DeleteTacGia(Id);                       
                        XtraMessageBox.Show("Xóa thông tin thành công");
                        ReloadTacGia();
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Xóa thông tin không thành công");
                }
            }
        }
    }
}