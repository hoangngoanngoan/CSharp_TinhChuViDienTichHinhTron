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
                MessageBox.Show("Phải nhập số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string TinhCV()
        {
            GetInfo();
            return labKQ.Text = "Chu vi: " + bk * pi + Environment.NewLine;
        }

        private string TinhDT()
        {
            GetInfo();
            return labKQ.Text = "Diện tích: " + bk * bk * pi + Environment.NewLine;
        }

        private void butTinh_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
                labKQ.Text = TinhCV() + TinhDT();     
        }

        private void butCV_Click(object sender, EventArgs e)
        {
            if (CheckInfo()) TinhCV();
        }

        private void butDT_Click(object sender, EventArgs e)
        {
            if (CheckInfo()) TinhDT();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
