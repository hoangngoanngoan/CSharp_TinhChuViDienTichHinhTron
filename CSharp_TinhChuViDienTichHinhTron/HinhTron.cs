using System.Security.Authentication.ExtendedProtection;

namespace CSharp_TinhChuViDienTichHinhTron
{
    public partial class HinhTron : Form
    {
        public HinhTron()
        {
            InitializeComponent();
        }

        private double bk;
        const double pi = 3.14;

        
        private void GetInfo()
        {
            bk = Convert.ToDouble(txtBK.Text);
        }

        private bool CheckInfo()
        {
            try
            {
                GetInfo();
                return true;
            }
            catch
            {
                MessageBox.Show("Phải nhập số","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        private void TinhCV()
        {
            GetInfo();
            labKQ.Text = "Chu vi: " + bk * pi; 
        }
        private void butTinh_Click(object sender, EventArgs e)
        {
            if (CheckInfo())  TinhCV();
            
        }
    }
}
