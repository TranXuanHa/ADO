using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLLichCongTac;
using BUS_QLLichCongTac;
using System.Data.SqlClient;

namespace GUI_QLLichCongTac
{
    public partial class GUI_LichCongTac : Form
    {
        BUS_LichCongTac busCT = new BUS_LichCongTac();
        public GUI_LichCongTac()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GUI_LichCongTac_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busCT.GetLichCongTac();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                // Xóa
                if (busCT.XoaLichCongTac(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = busCT.GetLichCongTac(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_LichCongTac ct = new DTO_LichCongTac(ID, dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text, comboBox2.Text, textBox1.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                    // Sửa
                    if (busCT.SuaLichCongTac(ct))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busCT.GetLichCongTac(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Chuyển giá trị lên form
            dateTimePicker1.Text = row.Cells[1].Value.ToString();
            dateTimePicker2.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();
            textBox1.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
            {
                // Tạo DTo
                DTO_LichCongTac ct = new DTO_LichCongTac(0, dateTimePicker1.Text, dateTimePicker2.Text, comboBox1.Text, comboBox2.Text, textBox1.Text); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busCT.ThemLichCongTac(ct))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = busCT.GetLichCongTac(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");

            }
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public DataTable GetTable()
        {
            con = new SqlConnection("Data Source=DESKTOP-3AABFT6;Initial Catalog=LCT;Integrated Security=True;Pooling=False");
            con.Open();
            cmd = new SqlCommand("select * from LICHCONGTAC", con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
            return dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(GetTable());
            dv.Sort = "STT";
            dataGridView1.DataSource = dv;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(GetTable());
            dv.RowFilter = "NGUOIDANGKY = 'Trần Xuân Hạ'";
            dataGridView1.DataSource = dv;
        }

        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged_2(object sender, EventArgs e)
        {

        }
    }
}
