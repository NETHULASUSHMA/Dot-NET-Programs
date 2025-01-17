﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WinFormsAppSushma
{
    public partial class StorePWithMultipleParameters : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-GQJ50NH\\SQLSERVER2022;User Id=sa;Password=user123;Database=Employeedb");
        SqlCommand cmd; SqlParameter p1;
        SqlDataReader dr;
        public StorePWithMultipleParameters()
        {
            InitializeComponent();
        }

        //private void lblEmpDesignation_Click(object sender, EventArgs e)
        //{

        //}

        //private void lblEmpDOJ_Click(object sender, EventArgs e)
        //{

        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(textBox1.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = textBox2.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdesign", SqlDbType.VarChar);
            p1.Value = textBox3.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(textBox4.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(textBox5.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(textBox6.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)Inserted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempname", SqlDbType.VarChar);
            p1.Value = txtEmpName.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdesign", SqlDbType.VarChar);
            p1.Value = txtEmpDesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdoj", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtEmpDOJ.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempsal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpSal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@Pempdept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpDept.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "Record(s)Updated");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add(p1);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "Record(s)deleted");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Employeetb where EmpId=" + textBox1.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();
            }
            else
            {
                MessageBox.Show("records not found");
                dr.Close();
            }
            con.Close();

        }
    }
}
