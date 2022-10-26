using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace application_78
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P7K57AH\SQLEXPRESS;Initial Catalog=DB2;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("insert into Home values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox3.Text) + "','" + TextBox4.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();
        }
        void LoadRecord()
        {
            SqlCommand comd = new SqlCommand("select * from Home", con);
            SqlDataAdapter d = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand commd = new SqlCommand("update  Home set StudentName = '" + TextBox2.Text + "',Address='" + DropDownList1.SelectedValue + "',Age='" + double.Parse(TextBox3.Text) + "',contact='" + TextBox4.Text + "' where StudentID='" + int.Parse(TextBox1.Text) + "'", con);
            commd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand commd = new SqlCommand("delete Home where StudentID='" + int.Parse(TextBox1.Text) + "'", con);
            commd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comd = new SqlCommand("select * from Home where StudentID='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from  Home where  StudentID='" + int.Parse(TextBox1.Text) + "'", con);

            SqlDataReader redr = comm.ExecuteReader();
            while (redr.Read())
            {
                TextBox2.Text = redr.GetValue(1).ToString();
                DropDownList1.SelectedValue = redr.GetValue(2).ToString();
                TextBox3.Text = redr.GetValue(3).ToString();
                TextBox4.Text = redr.GetValue(4).ToString();
            }

        }
    }
}