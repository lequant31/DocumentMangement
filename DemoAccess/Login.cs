using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoAccess
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private ConganxaEntities ConganxaEntities;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SkinName = Properties.Settings.Default.skin;
        }

        private void Dangnhap()
        {
            Mahoa _mahoa = new Mahoa();
            string _matkhau = _mahoa.EncryptString(TxtPassword.Text, "lamgico");

            try
            {
                using (ConganxaEntities = new ConganxaEntities())
                {
                    var Account = ConganxaEntities.AccountLogin(TxtUsername.Text, _matkhau, true).FirstOrDefault();
                    if (Account != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        DinhDanhAccount.Id_Account = Account.ID;
                        DinhDanhAccount.FullName = Account.FullName;
                        DinhDanhAccount.UserName = Account.UserName;
                        DinhDanhAccount.Status = Account.Status;
                        DinhDanhAccount.Roles = Account.Roles;
                        DinhDanhAccount.Password = Account.Password;
                    }
                    else
                    {
                        XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu\nHoặc tài khoản đã bị khóa");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            Dangnhap();
        }
    }
}