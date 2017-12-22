using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web.SessionState;
using System.Web.UI.HtmlControls;
using System.IO;

namespace RestaurantForm
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var appDataPath = Server.MapPath("~/Images/uploads/");
            //if (!Directory.Exists(appDataPath))
            //{
            //    Directory.CreateDirectory(appDataPath);
            //}
            //string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/uploads/"));
            //List<ListItem> files = new List<ListItem>();
            //foreach (string filePath in filePaths)
            //{
            //    string fileName = Path.GetFileName(filePath);
            //    files.Add(new ListItem(fileName, "~/Images/uploads/" + fileName));
            //}
            //GridView1.DataSource = files;
            //GridView1.DataBind();
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        

        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                byte[] bytes = (byte[])(e.Row.DataItem as DataRowView)["Content"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                (e.Row.FindControl("Image1") as System.Web.UI.WebControls.Image).ImageUrl = "data:image/png;base64," + base64String;
            }
        }
        private void BindGrid()
        {
            string constr = @"DATA source=35.202.169.219; Database=restaurantm;User ID=adminRest; Password='raj123456789';default command timeout=0;"; ;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM m_customer_img";
                    cmd.Connection = con;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
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
                    a = 0;
                }
                if (RadioButtonList1.SelectedIndex == 1)
                {
                    a = 1;
                }
                String connectionString = @"DATA source=35.202.169.219; Database=restaurantm;User ID=adminRest; Password='raj123456789';default command timeout=0;";
                string Query = "insert into m_customer_details(ctm_f_name,ctm_l_name,ctm_city,ctm_p_code,ctm_p_number,ctm_province,ctm_food,ctm_pickup_delivery,ctm_comments) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + provinceValue + "','" + strCheckValue + "','" + a + "','" + TextBox6.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection connection = new MySqlConnection(connectionString);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader2;
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
                String connectionString = @"DATA source=35.202.169.219; Database=restaurantm;User ID=adminRest; Password='raj123456789';default command timeout=0;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM m_customer_details where ctm_f_name='" + TextBox1.Text + "' and ctm_l_name='" + TextBox2.Text + "'", connection);
                    MySqlDataReader dr = command.ExecuteReader();

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
        //public void Submit1_ServerClick(Object sender, System.EventArgs e)
        //{

        //    if ((File1.PostedFile != null) && (File1.PostedFile.ContentLength > 0))
        //    {
        //        string fn = System.IO.Path.GetFileName(File1.PostedFile.FileName);
        //        string SaveLocation = Server.MapPath("images/uploads") + "\\" + fn;
        //        try
        //        {
        //            File1.PostedFile.SaveAs(SaveLocation);
        //            Response.Write("The file has been uploaded.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Response.Write("Error: " + ex.Message);
        //            //Note: Exception.Message returns a detailed message that describes the current exception. 
        //            //For security reasons, we do not recommend that you return Exception.Message to end users in 
        //            //production environments. It would be better to put a generic error message. 
        //        }
        //    }
        //    else
        //    {
        //        Response.Write("Please select a file to upload.");
        //    }
        //}
        protected void UploadFile(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string constr = @"DATA source=35.202.169.219; Database=restaurantm;User ID=adminRest; Password='raj123456789';default command timeout=0;";
                    using (MySqlConnection con = new MySqlConnection(constr))
                    {
                        string query = "INSERT INTO m_customer_img(file_name, file_type, content) VALUES (@FileName, @ContentType, @Content)";
                        using (MySqlCommand cmd = new MySqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@FileName", filename);
                            cmd.Parameters.AddWithValue("@ContentType", contentType);
                            cmd.Parameters.AddWithValue("@Content", bytes);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}