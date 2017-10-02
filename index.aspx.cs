using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Configuration;

namespace RestaurantForm
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        int a;
        string s = "";
        public void orderEvent(object sender, EventArgs e)
        {
            try
            {
                string provinceValue = "";
                if (DropDownList1.TabIndex == 0)
                {
                    provinceValue = "Alberta";
                }
                if (DropDownList1.TabIndex == 1)
                {
                    provinceValue = "British Columbia";
                }
                if (DropDownList1.TabIndex == 2)
                {
                    provinceValue = "Manitoba";
                }
                if (DropDownList1.TabIndex == 3)
                {
                    provinceValue = "New Brunswick";
                }
                if (DropDownList1.TabIndex == 4)
                {
                    provinceValue = "Newfoundland";
                }
                if (DropDownList1.TabIndex == 5)
                {
                    provinceValue = "Nova Scotia";
                }
                if (DropDownList1.TabIndex == 6)
                {
                    provinceValue = "Ontario";
                }
                if (DropDownList1.TabIndex == 7)
                {
                    provinceValue = "Quebec";
                }
                //checkbox values 
                string strCheckValue = "";
                if (CheckBox1.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox1.Text;
                }
                if (CheckBox2.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox2.Text;
                }
                if (CheckBox3.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox3.Text;
                }
                if (CheckBox4.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox4.Text;
                }
                if (CheckBox5.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox5.Text;
                }
                if (CheckBox6.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox6.Text;
                }
                if (CheckBox7.Checked)
                {
                    strCheckValue = strCheckValue + "," + CheckBox7.Text;
                }
                //foreach (Control cc in this.Controls)
                //{
                //    if(cc is CheckBox)
                //    {
                //        CheckBox b = (CheckBox)cc;
                //        if (b.Checked)
                //        {
                //            s = b.Text + " " + s;
                //        }
                //    }
                //}

                if (RadioButtonList1.SelectedIndex == 0)
                {
                    a    = 0;
                }
                if (RadioButtonList1.SelectedIndex == 1)
                {
                    a = 1;
                }
                string Query = "insert into m_customer_details(ctm_f_name,ctm_l_name,ctm_city,ctm_p_code,ctm_p_number,ctm_province,ctm_food,ctm_pickup_delivery,ctm_comments) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + provinceValue + "','" + strCheckValue + "','" + a + "','" + TextBox6.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
                //This is command class which will handle the query and connection object.  
                OdbcCommand MyCommand2 = new OdbcCommand(Query, connection);
                OdbcDataReader MyReader2;
                connection.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                while (MyReader2.Read())
                {
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Label10.Text = ex.Message;
            }
        }
        public void rememberMeEvent(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
                {
                    connection.Open();
                    OdbcCommand command = new OdbcCommand("SELECT * FROM m_customer_details where ctm_f_name='" + TextBox1.Text + "' and ctm_l_name='" + TextBox2.Text + "'", connection);
                    OdbcDataReader dr = command.ExecuteReader();

                    if (dr == null || !dr.HasRows)
                    {
                        Label10.Text = "user not found";
                    }
                    else
                    {
                        while (dr.Read())
                        {


                            TextBox3.Text = dr["ctm_city"].ToString();
                            TextBox4.Text = dr["ctm_p_code"].ToString();
                            TextBox5.Text = dr["ctm_p_number"].ToString();
                            String provinceStr = dr["ctm_province"].ToString();
                            //Dropdown list selection for province
                            if (provinceStr == "Alberta")
                            {
                                DropDownList1.SelectedIndex = 0;
                            }
                            if (provinceStr == "British Columbia")
                            {
                                DropDownList1.SelectedIndex = 1;

                            }
                            if (provinceStr == "Manitoba")
                            {
                                DropDownList1.SelectedIndex = 2;

                            }
                            if (provinceStr == "New Brunswick")
                            {
                                DropDownList1.SelectedIndex = 3;

                            }
                            if (provinceStr == "Newfoundland")
                            {
                                DropDownList1.SelectedIndex = 4;

                            }
                            if (provinceStr == "Nova Scotia")
                            {
                                DropDownList1.SelectedIndex = 5;

                            }
                            if (provinceStr == "Ontario")
                            {
                                DropDownList1.SelectedIndex = 6;
                            }
                            //radio button value display
                            int radioBtnValue = Convert.ToInt32(dr["ctm_pickup_delivery"].ToString());
                            if (radioBtnValue == 0)
                            {
                                RadioButtonList1.SelectedIndex = 0;
                            }
                            if (radioBtnValue == 1)
                            {
                                RadioButtonList1.SelectedIndex = 1;
                            }
                            //comment box value display
                            TextBox6.Text = dr["ctm_comments"].ToString();
                            Label10.Text = "";
                            //checkbox value display
                            CheckBox[] checkboxes = new CheckBox[] {
    CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7
};

                            string aa = dr["ctm_food"].ToString();
                            string[] a = aa.Split(',');
                            Label10.Text = a[2].ToString();

                            foreach (CheckBox b in checkboxes)
                            {
                                b.Checked = false;
                                for (int j = 1; j < a.Length; j++)
                                {
                                    if (a[j].ToString() == b.Text)
                                    {
                                        b.Checked = true;
                                    }   
                                }
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                Response.Write("An error occured: " + ex.Message);
            }
        }
    }
}