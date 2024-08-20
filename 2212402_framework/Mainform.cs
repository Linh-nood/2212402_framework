using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212402_framework
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        //click đôi vào chương trình sẽ tự động tạo sự kiện này
       
      

        private void button1_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được ghặp bạn", "Thông điệp chào mừng");
        }

      

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text=txtTen.Text;
        }
    }
}
