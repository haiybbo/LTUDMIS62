using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//khai báo biến global

namespace LTUDMIS62
{
    public partial class frmdanhmuchanghoa : Form
    {//khai báo biến global
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr; //connection string
        int i; //lấy stt dòng hiện tại
        Boolean addnewflag = false;
        public frmdanhmuchanghoa()
        {
            InitializeComponent();
        }

        private void frmdanhmuchanghoa_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-T1KITIMS\\MSSQLSERVER01;Initial Catalog=QLBH; Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select Manhom, MaHH, TenHH, DVT, Dgvnd, Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

        }
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtManhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["DVT"].Value.ToString();
            txtDgVND.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
            txtNuocSX.Text = grdData.Rows[i].Cells["Sanxuat"].Value.ToString();

        }
        private void btnfirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();

        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount - 2];
            }
            NapCT();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            NapCT();

        }

        private void comTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select Distinct " + comTentruong.Text + " from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            comGiatri.DataSource = dt;
            comGiatri.DisplayMember = comTentruong.Text;

        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            sql = " select MaNhom, MaHH, TenHH, DVT, Dgvnd, Sanxuat from tblDMHH " +
             " where " + comTentruong.Text + " =N'" + comGiatri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select MaNhom, MaHH, TenHH, DVT, Dgvnd, Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete from tblDMHH where MaHH='" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;//Chỉ ra câu lệnh đc gán là lệnh nào
                cmd.ExecuteNonQuery();
                grdData.CurrentRow.Dispose();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                NapCT();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới, kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {
                //chỗ này cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {

                    txtManhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
                    txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                    txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                    txtDVT.Text = grdData.Rows[i].Cells["DVT"].Value.ToString();
                    txtDgVND.Text = grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
                    txtNuocSX.Text = grdData.Rows[i].Cells["Sanxuat"].Value.ToString();

                    sql = "update tblDMHH set dgVND=" + txtDgVND.Text + "," +
                          " TenHH=N'" + txtTenHH.Text + "',Dvt='" + txtDVT.Text + "'," +
                          "Sanxuat=N'" + txtNuocSX.Text + "'Where MaHH='" + txtMaHH.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
            }
            else
            {
                //chỗ này là cập nhật thêm mới
                addnewflag = false;
                sql = "insert into tblDMHH (MaNhom, MaHH, TenHH, Dvt, Dgvnd, Sanxuat)" +
                    " Values ('" + txtManhom.Text + "','" + txtMaHH.Text + "',N'" +
                    txtTenHH.Text + "',N'" + txtDVT.Text + "','" + txtDgVND.Text + "',N'" +
                    txtNuocSX.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                //Nạp ngược lại từ txtbox vào bản ghi
                grdData.Rows[i].Cells["MaNhom"].Value = txtManhom.Text;
                grdData.Rows[i].Cells["MaHH"].Value = txtMaHH.Text;
                grdData.Rows[i].Cells["TenHH"].Value = txtTenHH.Text;
                grdData.Rows[i].Cells["DVT"].Value = txtDVT.Text;
                grdData.Rows[i].Cells["Dgvnd"].Value = txtDgVND.Text;
                grdData.Rows[i].Cells["Sanxuat"].Value = txtNuocSX.Text;
                grdData.Refresh();

            }
            btnUpdate.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtManhom.Focus();
            addnewflag = true;
            btnUpdate.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
    }
}
