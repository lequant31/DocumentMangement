using DevExpress.XtraEditors;
using System;
using System.Data.OleDb;

namespace DemoAccess
{
    public partial class Changepassword : DevExpress.XtraEditors.XtraForm
    {
        ConganxaEntities ConganxaEntities;
        public Changepassword()
        {
            InitializeComponent();
        }

        private void Changepassword_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            Changerpass();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Changepassword_Enter(object sender, EventArgs e)
        {
            Changerpass();
        }

        private void Changerpass()
        {
            Mahoa _mahoa = new Mahoa();
            string _matkhaucu = _mahoa.EncryptString(Txtoldpass.Text, "lamgico");

            #region checkpassword

            if (_matkhaucu != DinhDanhAccount.Password)
            {
                XtraMessageBox.Show("Mật khẩu không đúng");
                return;
            }
            if (Txtnewpass.Text != Txtnewpassagain.Text)
            {
                XtraMessageBox.Show("Xác nhận mật khẩu mới không trùng với mật khẩu cần thay đổi");
                return;
            }
            if (Txtoldpass.Text == Txtnewpassagain.Text)
            {
                XtraMessageBox.Show("Mật khẩu mới phải khác mật khẩu đang dùng");
                return;
            }

            #endregion checkpassword

            string _matkhau = _mahoa.EncryptString(Txtnewpassagain.Text, "lamgico");
            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    ConganxaEntities.AccountChangePass(DinhDanhAccount.Id_Account,_matkhau);
                    XtraMessageBox.Show("Thay đổi mật khẩu thành công");
                }
                
                // Create the Command and Parameter objects.
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}