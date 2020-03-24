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
    public partial class CreateAccount : DevExpress.XtraEditors.XtraForm
    {
        ConganxaEntities ConganxaEntities;
        public CreateAccount()
        {
            InitializeComponent();
        }
        private bool edit = false;
        private int IdEdit;
        private void ReloadAccount()
        {
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var list = ConganxaEntities.GetAllAccount().ToList();
                    GrcAccount.DataSource = list;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Getnull()
        {
            edit = false;
            TxtFullName.Text = null;
            TxtUserName.Text = null;
            TxtPassword.Text = null;
            RadioStatus.SelectedIndex = 0;
            ComRoles.EditValue = "Staff";
        }
        private void AddAccount()
        {
            #region check field
            if (TxtFullName.Text == "" || TxtFullName.Text == null)
            {
                XtraMessageBox.Show("Không bỏ trống trường Họ tên");
                return;
            }
            if (TxtUserName.Text == "" || TxtUserName.Text == null)
            {
                XtraMessageBox.Show("Không bỏ trống trường Tên đăng nhập");
                return;
            }
            if (TxtPassword.Text == "" || TxtPassword.Text == null)
            {
                XtraMessageBox.Show("Không bỏ trống trường Mật khẩu");
                return;
            }
            #endregion
            if (edit == false)
            {
                Mahoa mahoa = new Mahoa();
                string matkhau = mahoa.EncryptString(TxtPassword.Text,"lamgico");
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.InsertAccount(TxtFullName.Text,TxtUserName.Text,matkhau,ComRoles.Text,(bool?)RadioStatus.EditValue);
                    XtraMessageBox.Show("Thêm tài khoản thành công");                   
                }
            }
            if (edit == true)
            {
                Mahoa mahoa = new Mahoa();
                string matkhau = mahoa.EncryptString(TxtPassword.Text, "lamgico");
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.UpdateAccount(IdEdit,TxtFullName.Text, TxtUserName.Text, matkhau, ComRoles.Text, (bool?)RadioStatus.EditValue);
                    XtraMessageBox.Show("Sửa tài khoản thành công");
                }
            }
        }
        private void LoadEdit()
        {
            ///có commit được không thì bảo
            Mahoa mahoa = new Mahoa();
            edit = true;
            IdEdit = (int)GrvAccount.GetFocusedRowCellValue("ID");
            TxtFullName.EditValue = GrvAccount.GetFocusedRowCellValue("FullName");
            string pass = GrvAccount.GetFocusedRowCellValue("Password").ToString();
            pass = mahoa.Decrypt(pass,"lamgico");
            TxtPassword.EditValue = pass;
            TxtFullName.EditValue = GrvAccount.GetFocusedRowCellValue("FullName");
            TxtUserName.EditValue = GrvAccount.GetFocusedRowCellValue("UserName");
            RadioStatus.EditValue = GrvAccount.GetFocusedRowCellValue("Status");
            ComRoles.EditValue = GrvAccount.GetFocusedRowCellValue("Roles");
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            ReloadAccount();
            ComRoles.EditValue = "Staff";
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Getnull();
        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadEdit();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int Id = (int)GrvAccount.GetFocusedRowCellValue("ID");
                if(Id > 0)
                {
                    using (ConganxaEntities = new ConganxaEntities())
                    {
                        ConganxaEntities.DeleteAccount(Id);
                        XtraMessageBox.Show("Xóa thông tin thành công");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn tài khoản cần xóa");
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadAccount();
            Getnull();
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddAccount();
            Getnull();
            ReloadAccount();
        }

        private void GrvAccount_DoubleClick(object sender, EventArgs e)
        {
            LoadEdit();
        }
    }
}