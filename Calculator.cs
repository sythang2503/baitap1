using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congtrunhanchia
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double s1;
        double s2;

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa + sob;
                lblkq.Text = soa + " + " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {
                
                lblkq.Text = "Nhập sai dữ liệu";
            }
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa - sob;
                lblkq.Text = soa + " - " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {

                lblkq.Text = "Nhập sai dữ liệu";
            }
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa * sob;
                lblkq.Text = soa + " * " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {

                lblkq.Text = "Nhập sai dữ liệu";
            }
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa / sob;
                if (sob == 0)
                {
                    lblkq.Text = "Không thể chia cho 0";
                }
                else
                {
                    lblkq.Text = soa + " / " + sob + " = " + kq.ToString();
                }
                
                
            }
            catch (Exception)
            {
                lblkq.Text = "Nhập sai dữ liệu";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
