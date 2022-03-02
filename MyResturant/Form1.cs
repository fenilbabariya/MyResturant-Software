using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace MyResturant
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            
            lblTableTitle.Text = "";
            panelMenu.Hide();
            panelLogo.BringToFront();
            panelSocialMedia.BringToFront();
            
            panelLoginManager.Hide();
            panelLoginRece.Hide();
            panelLeftManager.Hide();
            panelLeftRece.Hide();
            
            //Receptionist's Panel
            tableFood.Hide();
            tableDrinks.Hide();
            tableDessert.Hide();
            tableBeverage.Hide();
            tableCPswRece.Hide();
            panelCart.Hide();
            
            //Manager's Panel
            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
            tableCPswManager.Hide();
            panelTableMenu.Hide();
            panelEmployee.Hide();
            panelTotalSelling.Hide();
        }
        
        private void btnManager_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
            panelMenu.Top = btnManager.Top;
            panelLoginManager.Show();
            panelLoginRece.Hide();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
            panelMenu.Top = btnReceptionist.Top;
            panelLoginManager.Hide();
            panelLoginRece.Show();
        }

        private void ManagerUName_Enter(object sender, EventArgs e)
        {
            if (ManagerUName.Text == "Username")
            {
                ManagerUName.Text = "";
                ManagerUName.ForeColor = Color.White;
            }
        }

        private void ManagerUName_Leave(object sender, EventArgs e)
        {
            if (ManagerUName.Text == "")
            {
                ManagerUName.Text = "Username";
                ManagerUName.ForeColor = Color.Silver;
            }
        }

        private void ManagerPsw_Enter(object sender, EventArgs e)
        {
            if (ManagerPsw.Text == "Password")
            {
                ManagerPsw.Text = "";
                ManagerPsw.ForeColor = Color.White;
                ManagerPsw.UseSystemPasswordChar = true;
            }
        }

        private void ManagerPsw_Leave(object sender, EventArgs e)
        {
            if (ManagerPsw.Text == "")
            {
                ManagerPsw.Text = "Password";
                ManagerPsw.ForeColor = Color.Silver;
                ManagerPsw.UseSystemPasswordChar = false;
            }
        }

        private void ReceUName_Enter(object sender, EventArgs e)
        {
            if (ReceUName.Text == "Username")
            {
                ReceUName.Text = "";
                ReceUName.ForeColor = Color.White;
            }
        }

        private void ReceUName_Leave(object sender, EventArgs e)
        {
            if (ReceUName.Text == "")
            {
                ReceUName.Text = "Username";
                ReceUName.ForeColor = Color.Silver;
            }
        }

        private void RecePsw_Enter(object sender, EventArgs e)
        {
            if (RecePsw.Text == "Password")
            {
                RecePsw.Text = "";
                RecePsw.ForeColor = Color.White;
                RecePsw.UseSystemPasswordChar = true;
            }
        }

        private void RecePsw_Leave(object sender, EventArgs e)
        {
            if (RecePsw.Text == "")
            {
                RecePsw.Text = "Password";
                RecePsw.ForeColor = Color.Silver;
                RecePsw.UseSystemPasswordChar = false;
            }
        }
        //Receptionist Login
        private void btnLoginRece_Click(object sender, EventArgs e)
        {
            pictureBoxSlider.Hide();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Rece where Rece ='" + ReceUName.Text + "'and Password ='" + RecePsw.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                txtNameRece.Text = ReceUName.Text;
                panelLeft.Hide();
                panelLeftRece.Show();
                tableFood.Show();
                lblTableTitle.Text = "Food Panel";

                ReceUName.Text = "Username";
                ReceUName.ForeColor = Color.Silver;
                RecePsw.Text = "Password";
                RecePsw.ForeColor = Color.Silver;
                RecePsw.UseSystemPasswordChar = false;

                if (lblPrice1.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("select Price from Food where ID = 1", conn);
                    SqlDataReader read1 = cmd1.ExecuteReader();
                    while (read1.Read())
                    {
                        lblPrice1.Text = read1.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("select Price from Food where ID = 2", conn);
                    SqlDataReader read2 = cmd2.ExecuteReader();
                    while (read2.Read())
                    {
                        lblPrice2.Text = read2.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("select Price from Food where ID = 3", conn);
                    SqlDataReader read3 = cmd3.ExecuteReader();
                    while (read3.Read())
                    {
                        lblPrice3.Text = read3.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select Price from Food where ID = 4", conn);
                    SqlDataReader read4 = cmd4.ExecuteReader();
                    while (read4.Read())
                    {
                        lblPrice4.Text = read4.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd5 = new SqlCommand("select Price from Food where ID = 5", conn);
                    SqlDataReader read5 = cmd5.ExecuteReader();
                    while (read5.Read())
                    {
                        lblPrice5.Text = read5.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd6 = new SqlCommand("select Price from Food where ID = 6", conn);
                    SqlDataReader read6 = cmd6.ExecuteReader();
                    while (read6.Read())
                    {
                        lblPrice6.Text = read6.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd7 = new SqlCommand("select Price from Food where ID = 7", conn);
                    SqlDataReader read7 = cmd7.ExecuteReader();
                    while (read7.Read())
                    {
                        lblPrice7.Text = read7.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd8 = new SqlCommand("select Price from Food where ID = 8", conn);
                    SqlDataReader read8 = cmd8.ExecuteReader();
                    while (read8.Read())
                    {
                        lblPrice8.Text = read8.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd9 = new SqlCommand("select Price from Food where ID = 9", conn);
                    SqlDataReader read9 = cmd9.ExecuteReader();
                    while (read9.Read())
                    {
                        lblPrice9.Text = read9.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd10 = new SqlCommand("select Price from Food where ID = 10", conn);
                    SqlDataReader read10 = cmd10.ExecuteReader();
                    while (read10.Read())
                    {
                        lblPrice10.Text = read10.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd11 = new SqlCommand("select Price from Food where ID = 11", conn);
                    SqlDataReader read11 = cmd11.ExecuteReader();
                    while (read11.Read())
                    {
                        lblPrice11.Text = read11.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd12 = new SqlCommand("select Price from Food where ID = 12", conn);
                    SqlDataReader read12 = cmd12.ExecuteReader();
                    while (read12.Read())
                    {
                        lblPrice12.Text = read12.GetValue(0).ToString();
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Manager Login
        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            pictureBoxSlider.Hide();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Manager where Username ='" + ManagerUName.Text + "'and Password ='" + ManagerPsw.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                lblTableTitle.Text = "Home Panel";
                txtNameManager.Text = ManagerUName.Text;
                panelLeft.Hide();
                panelLeftManager.Show();
                tableEditFood.Show();
                panelTableMenu.Show();

                if (txtUpdateFoodPrice1.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("select Price from Food where ID = 1", conn);
                    SqlDataReader read1 = cmd1.ExecuteReader();
                    while (read1.Read())
                    {
                        txtUpdateFoodPrice1.Text = read1.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("select Price from Food where ID = 2", conn);
                    SqlDataReader read2 = cmd2.ExecuteReader();
                    while (read2.Read())
                    {
                        txtUpdateFoodPrice2.Text = read2.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("select Price from Food where ID = 3", conn);
                    SqlDataReader read3 = cmd3.ExecuteReader();
                    while (read3.Read())
                    {
                        txtUpdateFoodPrice3.Text = read3.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select Price from Food where ID = 4", conn);
                    SqlDataReader read4 = cmd4.ExecuteReader();
                    while (read4.Read())
                    {
                        txtUpdateFoodPrice4.Text = read4.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd5 = new SqlCommand("select Price from Food where ID = 5", conn);
                    SqlDataReader read5 = cmd5.ExecuteReader();
                    while (read5.Read())
                    {
                        txtUpdateFoodPrice5.Text = read5.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd6 = new SqlCommand("select Price from Food where ID = 6", conn);
                    SqlDataReader read6 = cmd6.ExecuteReader();
                    while (read6.Read())
                    {
                        txtUpdateFoodPrice6.Text = read6.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd7 = new SqlCommand("select Price from Food where ID = 7", conn);
                    SqlDataReader read7 = cmd7.ExecuteReader();
                    while (read7.Read())
                    {
                        txtUpdateFoodPrice7.Text = read7.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd8 = new SqlCommand("select Price from Food where ID = 8", conn);
                    SqlDataReader read8 = cmd8.ExecuteReader();
                    while (read8.Read())
                    {
                        txtUpdateFoodPrice8.Text = read8.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd9 = new SqlCommand("select Price from Food where ID = 9", conn);
                    SqlDataReader read9 = cmd9.ExecuteReader();
                    while (read9.Read())
                    {
                        txtUpdateFoodPrice9.Text = read9.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd10 = new SqlCommand("select Price from Food where ID = 10", conn);
                    SqlDataReader read10 = cmd10.ExecuteReader();
                    while (read10.Read())
                    {
                        txtUpdateFoodPrice10.Text = read10.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd11 = new SqlCommand("select Price from Food where ID = 11", conn);
                    SqlDataReader read11 = cmd11.ExecuteReader();
                    while (read11.Read())
                    {
                        txtUpdateFoodPrice11.Text = read11.GetValue(0).ToString();
                    }
                    conn.Close();

                    conn.Open();
                    SqlCommand cmd12 = new SqlCommand("select Price from Food where ID = 12", conn);
                    SqlDataReader read12 = cmd12.ExecuteReader();
                    while (read12.Read())
                    {
                        txtUpdateFoodPrice12.Text = read12.GetValue(0).ToString();
                    }
                    conn.Close();
                }

                ManagerUName.Text = "Username";
                ManagerUName.ForeColor = Color.Silver;
                ManagerPsw.Text = "Password";
                ManagerPsw.ForeColor = Color.Silver;
                ManagerPsw.UseSystemPasswordChar = false;
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tasks of Manager
        private void btnHomeManager_Click(object sender, EventArgs e)
        {
            panelMenuManager.Top = btnHomeManager.Top;
            lblTableTitle.Text = "Home Panel";
            tableEditFood.Show();
            tableCPswManager.Hide();
            panelTableMenu.Show();
            panelEmployee.Hide();
            panelTotalSelling.Hide();
        }

        private void btnEmpManager_Click(object sender, EventArgs e)
        {
            panelMenuManager.Top = btnEmpManager.Top;
            lblTableTitle.Text = "Employee Panel";

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Rece", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
            conn.Close();

            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
            tableCPswManager.Hide();
            panelTableMenu.Hide();
            panelTotalSelling.Hide();
            panelEmployee.Show();
        }

        private void btnTotalSelling_Click(object sender, EventArgs e)
        {
            panelMenuManager.Top = btnTotalSelling.Top;
            lblTableTitle.Text = "Total Selling";
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(Price) from Total_Selling", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblTotalRupee.Text = read.GetValue(0).ToString();
            }
            conn.Close();

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Total_Selling", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTotalSelling.DataSource = dt;
            conn.Close();

            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
            tableCPswManager.Hide();
            panelTableMenu.Hide();
            panelEmployee.Hide();
            panelTotalSelling.Show();
        }

        private void btnChangePswManager_Click(object sender, EventArgs e)
        {
            panelMenuManager.Top = btnChangePswManager.Top;
            lblTableTitle.Text = "Change Password";
            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
            tableCPswManager.Show();
            panelTableMenu.Hide();
            panelEmployee.Hide();
            panelTotalSelling.Hide();
        }

        private void btnLogoutManager_Click(object sender, EventArgs e)
        {
            panelMenuManager.Top = btnLogoutManager.Top;
            DialogResult dr1 = MessageBox.Show("Are you sure You want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr1 == DialogResult.Yes)
            {
                panelLeft.Show();
                pictureBoxSlider.Show();
                panelLeftManager.Hide();
                lblTableTitle.Text = "";
                tableEditFood.Hide();
                tableEditDrinks.Hide();
                tableEditDessert.Hide();
                tableEditBeverage.Hide();
                tableCPswManager.Hide();
                panelTableMenu.Hide();
                panelEmployee.Hide();
                panelTotalSelling.Hide();
            }
        }
        //Tasks of Receptionist
        private void btnFoods_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnFoods.Top;
            tableFood.Show();
            lblTableTitle.Text = "Food Panel";
            tableDrinks.Hide();
            tableDessert.Hide();
            tableBeverage.Hide();
            tableCPswRece.Hide();
            panelCart.Hide();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnDrinks.Top;
            tableDrinks.Show();
            lblTableTitle.Text = "Drinks Panel";
            tableFood.Hide();
            tableDessert.Hide();
            tableBeverage.Hide();
            tableCPswRece.Hide();
            panelCart.Hide();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (lblPrice13.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Drinks where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    lblPrice13.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Drinks where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    lblPrice14.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Drinks where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    lblPrice15.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Drinks where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    lblPrice16.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Drinks where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    lblPrice17.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Drinks where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    lblPrice18.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Drinks where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    lblPrice19.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Drinks where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    lblPrice20.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Drinks where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    lblPrice21.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Drinks where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    lblPrice22.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Drinks where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    lblPrice23.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Drinks where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    lblPrice24.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnDessert.Top;
            tableDessert.Show();
            lblTableTitle.Text = "Dessert Panel";
            tableFood.Hide();
            tableDrinks.Hide();
            tableBeverage.Hide();
            tableCPswRece.Hide();
            panelCart.Hide();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (lblPrice25.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Dessert where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    lblPrice25.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Dessert where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    lblPrice26.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Dessert where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    lblPrice27.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Dessert where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    lblPrice28.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Dessert where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    lblPrice29.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Dessert where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    lblPrice30.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Dessert where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    lblPrice31.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Dessert where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    lblPrice32.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Dessert where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    lblPrice33.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Dessert where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    lblPrice34.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Dessert where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    lblPrice35.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Dessert where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    lblPrice36.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnBeverage.Top;
            tableBeverage.Show();
            lblTableTitle.Text = "Beverage Panel";
            tableFood.Hide();
            tableDrinks.Hide();
            tableDessert.Hide();
            tableCPswRece.Hide();
            panelCart.Hide();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (lblPrice37.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Beverage where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    lblPrice37.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Beverage where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    lblPrice38.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Beverage where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    lblPrice39.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Beverage where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    lblPrice40.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Beverage where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    lblPrice41.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Beverage where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    lblPrice42.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Beverage where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    lblPrice43.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Beverage where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    lblPrice44.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Beverage where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    lblPrice45.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Beverage where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    lblPrice46.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Beverage where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    lblPrice47.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Beverage where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    lblPrice48.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Cart", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewBill.DataSource = dt;
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(Price) from Cart", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblTotalBill.Text = read.GetValue(0).ToString();
            }
            conn.Close();

            panelMenuRece.Top = btnCart.Top;
            lblTableTitle.Text = "Cart Panel";
            tableFood.Hide();
            tableDrinks.Hide();
            tableDessert.Hide();
            tableBeverage.Hide();
            tableCPswRece.Hide();
            panelCart.Show();
        }

        private void btnChangePswRece_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnChangePswRece.Top;
            lblTableTitle.Text = "Change Password";
            tableFood.Hide();
            tableDrinks.Hide();
            tableDessert.Hide();
            tableBeverage.Hide();
            tableCPswRece.Show();
            panelCart.Hide();
        }

        private void btnLogoutRece_Click(object sender, EventArgs e)
        {
            panelMenuRece.Top = btnLogoutRece.Top;
            DialogResult dr2 = MessageBox.Show("Are you sure You want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr2 == DialogResult.Yes)
            {
                panelLeft.Show();
                pictureBoxSlider.Show();
                panelLeftRece.Hide();
                tableFood.Hide();
                tableDrinks.Hide();
                tableDessert.Hide();
                tableBeverage.Hide();
                tableCPswRece.Hide();
                panelCart.Hide();
                lblTableTitle.Text = "";
            }
        }
        
        //Change Password Manager
        private void btnChangeManager_Click(object sender, EventArgs e)
        {
            if (txttableCpswUnameManager.Text == txtNameManager.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("update Manager set Password ='" + txttableCpswPswManager.Text + "' where Username = '" + txttableCpswUnameManager.Text + "' ", conn);
                sda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Updated...", "Update", MessageBoxButtons.OK);
                txttableCpswUnameManager.Text = "";
                txttableCpswPswManager.Text = "";
            }
            else
            {
                MessageBox.Show("You can't change other users Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttableCpswUnameManager.Text = "";
                txttableCpswPswManager.Text = "";
            }
        }
        
        //Change Password Receptionist
        private void btnChangeRece_Click_1(object sender, EventArgs e)
        {
            if (txttableCpswUnameRece.Text == txtNameRece.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("update Rece set Password ='" + txttableCpswPswRece.Text + "' where Rece = '" + txttableCpswUnameRece.Text + "' ", conn);
                sda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Updated...", "Update", MessageBoxButtons.OK);
                txttableCpswUnameRece.Text = "";
                txttableCpswPswRece.Text = "";
            }
            else 
            {
                MessageBox.Show("You can't change other users Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttableCpswUnameRece.Text = "";
                txttableCpswPswRece.Text = "";
            }
        }
        //Add to Cart Buttons
        private void btnCart1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MARGHERITA PIZZA','" + lblPrice1.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'BURGER','" + lblPrice2.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'GRILLED SANDWICH','" + lblPrice3.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'FRENCH FRIES','" + lblPrice4.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'HOT DOG','" + lblPrice5.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'SPRING ROLL','" + lblPrice6.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'PASTA','" + lblPrice7.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'SAMOSA','" + lblPrice8.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MANCHURIAN DRY','" + lblPrice9.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'NOODLES','" + lblPrice10.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MOMOS','" + lblPrice11.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'SEV PURI','" + lblPrice12.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'COCA COLA','" + lblPrice13.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart14_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'THUMS UP','" + lblPrice14.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart15_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( '7 UP','" + lblPrice15.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart16_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'PEPSI','" + lblPrice16.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart17_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MOUNTAIN DEW','" + lblPrice17.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart18_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MIRINDA','" + lblPrice18.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart19_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'RED BULL','" + lblPrice19.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart20_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MONSTER','" + lblPrice20.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart21_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'STING','" + lblPrice21.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart22_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'OCEAN ONE8','" + lblPrice22.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart23_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'LEMON JUICE','" + lblPrice23.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart24_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'WATERMELON JUICE','" + lblPrice24.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart25_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'CHOCOLATE CAKE','" + lblPrice25.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart26_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'STRAWBERRY CAKE','" + lblPrice26.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart27_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'PINEAPPLE CAKE','" + lblPrice27.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart28_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'CHOHOLATE PASTRY','" + lblPrice28.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart29_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'STRAWBERRY PASTRY','" + lblPrice29.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart30_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'PINEAPPLE PASTRY','" + lblPrice30.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart31_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'CHOCOLATE ICE CREAM','" + lblPrice31.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart32_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'STRAWBERRY ICE CREAM','" + lblPrice32.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart33_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'BUTTERSCOTCH ICE CREAM','" + lblPrice33.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart34_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'AMUL-COOKIES N CREAM','" + lblPrice34.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart35_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'KWALITY WALLS-BLACKCURRENT','" + lblPrice35.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart36_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'VADILAL-SITAFAL','" + lblPrice36.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart37_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'TEA AND COOKIES','" + lblPrice37.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart38_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'COLD COFFEE','" + lblPrice38.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart39_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'HOT COFFEE','" + lblPrice39.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart40_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'BOURNVITA','" + lblPrice40.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart41_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'HOT COCO','" + lblPrice41.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart42_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'COLD COCO','" + lblPrice42.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart43_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'OREO SHAKE','" + lblPrice43.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart44_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'CHOCOLATE SHAKE','" + lblPrice44.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart45_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'STRAWBERRY ICE CREAM','" + lblPrice45.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart46_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'BROWNIE ICE CREAM','" + lblPrice46.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart47_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'MANGO MASTANI','" + lblPrice47.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        private void btnCart48_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("insert into Cart values ( 'PEANUT BUTTER SHAKE','" + lblPrice48.Text + "') ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Item Inserted...", "Insert", MessageBoxButtons.OK);
        }

        //Button Menu Panel 
        private void btnTableEditFood_Click(object sender, EventArgs e)
        {
            tableEditFood.Show();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
        }

        private void btnTableEditDrinks_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (txtUpdateDrinksPrice1.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Drinks where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    txtUpdateDrinksPrice1.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Drinks where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    txtUpdateDrinksPrice2.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Drinks where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    txtUpdateDrinksPrice3.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Drinks where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    txtUpdateDrinksPrice4.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Drinks where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    txtUpdateDrinksPrice5.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Drinks where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    txtUpdateDrinksPrice6.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Drinks where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    txtUpdateDrinksPrice7.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Drinks where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    txtUpdateDrinksPrice8.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Drinks where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    txtUpdateDrinksPrice9.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Drinks where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    txtUpdateDrinksPrice10.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Drinks where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    txtUpdateDrinksPrice11.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Drinks where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    txtUpdateDrinksPrice12.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
            tableEditFood.Hide();
            tableEditDrinks.Show();
            tableEditDessert.Hide();
            tableEditBeverage.Hide();
        }

        private void btnTableEditDessert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (txtUpdateDessertPrice1.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Dessert where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    txtUpdateDessertPrice1.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Dessert where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    txtUpdateDessertPrice2.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Dessert where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    txtUpdateDessertPrice3.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Dessert where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    txtUpdateDessertPrice4.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Dessert where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    txtUpdateDessertPrice5.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Dessert where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    txtUpdateDessertPrice6.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Dessert where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    txtUpdateDessertPrice7.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Dessert where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    txtUpdateDessertPrice8.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Dessert where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    txtUpdateDessertPrice9.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Dessert where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    txtUpdateDessertPrice10.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Dessert where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    txtUpdateDessertPrice11.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Dessert where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    txtUpdateDessertPrice12.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Show();
            tableEditBeverage.Hide();
        }

        private void btnTableEditBeverage_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            if (txtUpdateBeveragePrice1.Text != "")
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select Price from Beverage where ID = 1", conn);
                SqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    txtUpdateBeveragePrice1.Text = read1.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Price from Beverage where ID = 2", conn);
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    txtUpdateBeveragePrice2.Text = read2.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select Price from Beverage where ID = 3", conn);
                SqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    txtUpdateBeveragePrice3.Text = read3.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd4 = new SqlCommand("select Price from Beverage where ID = 4", conn);
                SqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    txtUpdateBeveragePrice4.Text = read4.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd5 = new SqlCommand("select Price from Beverage where ID = 5", conn);
                SqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    txtUpdateBeveragePrice5.Text = read5.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd6 = new SqlCommand("select Price from Beverage where ID = 6", conn);
                SqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    txtUpdateBeveragePrice6.Text = read6.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd7 = new SqlCommand("select Price from Beverage where ID = 7", conn);
                SqlDataReader read7 = cmd7.ExecuteReader();
                while (read7.Read())
                {
                    txtUpdateBeveragePrice7.Text = read7.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd8 = new SqlCommand("select Price from Beverage where ID = 8", conn);
                SqlDataReader read8 = cmd8.ExecuteReader();
                while (read8.Read())
                {
                    txtUpdateBeveragePrice8.Text = read8.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd9 = new SqlCommand("select Price from Beverage where ID = 9", conn);
                SqlDataReader read9 = cmd9.ExecuteReader();
                while (read9.Read())
                {
                    txtUpdateBeveragePrice9.Text = read9.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd10 = new SqlCommand("select Price from Beverage where ID = 10", conn);
                SqlDataReader read10 = cmd10.ExecuteReader();
                while (read10.Read())
                {
                    txtUpdateBeveragePrice10.Text = read10.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd11 = new SqlCommand("select Price from Beverage where ID = 11", conn);
                SqlDataReader read11 = cmd11.ExecuteReader();
                while (read11.Read())
                {
                    txtUpdateBeveragePrice11.Text = read11.GetValue(0).ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand cmd12 = new SqlCommand("select Price from Beverage where ID = 12", conn);
                SqlDataReader read12 = cmd12.ExecuteReader();
                while (read12.Read())
                {
                    txtUpdateBeveragePrice12.Text = read12.GetValue(0).ToString();
                }
                conn.Close();
            }
            
            tableEditFood.Hide();
            tableEditDrinks.Hide();
            tableEditDessert.Hide();
            tableEditBeverage.Show();
        }

        //Update Food Panel
        private void btnUpdateFood1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice1.Text + "' where ID = 1 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice2.Text + "' where ID = 2 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood3_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice3.Text + "' where ID = 3 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood4_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice4.Text + "' where ID = 4 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood5_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice5.Text + "' where ID = 5 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood6_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice6.Text + "' where ID = 6 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood7_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice7.Text + "' where ID = 7 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood8_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice8.Text + "' where ID = 8 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood9_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice9.Text + "' where ID = 9 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood10_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice10.Text + "' where ID = 10 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood11_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice11.Text + "' where ID = 11 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateFood12_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Food set Price ='" + txtUpdateFoodPrice12.Text + "' where ID = 12 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        //Update Drinks Panel
        private void btnUpdateDrinks1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice1.Text + "' where ID = 1 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice2.Text + "' where ID = 2 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice3.Text + "' where ID = 3 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice4.Text + "' where ID = 4 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice5.Text + "' where ID = 5 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice6.Text + "' where ID = 6 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice7.Text + "' where ID = 7 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice8.Text + "' where ID = 8 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice9.Text + "' where ID = 9 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice10.Text + "' where ID = 10 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice11.Text + "' where ID = 11 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDrinks12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Drinks set Price ='" + txtUpdateDrinksPrice12.Text + "' where ID = 12 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }
        //Update Dessert Panel

        private void btnUpdateDessert1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice1.Text + "' where ID = 1 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice2.Text + "' where ID = 2 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice3.Text + "' where ID = 3 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice4.Text + "' where ID = 4 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice5.Text + "' where ID = 5 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice6.Text + "' where ID = 6 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice7.Text + "' where ID = 7 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice8.Text + "' where ID = 8 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice9.Text + "' where ID = 9 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice10.Text + "' where ID = 10 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice11.Text + "' where ID = 11 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateDessert12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Dessert set Price ='" + txtUpdateDessertPrice12.Text + "' where ID = 12 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        //Update Beverage Panel
        private void btnUpdateBeverage1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice1.Text + "' where ID = 1 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice2.Text + "' where ID = 2 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice3.Text + "' where ID = 3 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice4.Text + "' where ID = 4 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice5.Text + "' where ID = 5 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice6.Text + "' where ID = 6 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice7.Text + "' where ID = 7 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice8.Text + "' where ID = 8 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice9.Text + "' where ID = 9 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice10.Text + "' where ID = 10 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice11.Text + "' where ID = 11 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }

        private void btnUpdateBeverage12_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sda = new SqlCommand("update Beverage set Price ='" + txtUpdateBeveragePrice12.Text + "' where ID = 12 ", conn);
            sda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated...", "Update", MessageBoxButtons.OK);
        }
        //Panel Employee
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            if (txtUNameEmployee.Text == "" || txtPswEmployee.Text == "")
            {
                MessageBox.Show("Usernamae or Password must not be blank","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand sda = new SqlCommand("insert into Rece values ('" + txtUNameEmployee.Text + "','" + txtPswEmployee.Text + "') ", conn);
                    sda.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Employee Inserted...", "Insert", MessageBoxButtons.OK);
                    txtUNameEmployee.Text = "";
                    txtPswEmployee.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Username already exists!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (txtUNameEmployee.Text == "" || txtPswEmployee.Text == "")
            {
                MessageBox.Show("Usernamae or Password must not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("update Rece set Password ='" + txtPswEmployee.Text + "' where Rece = '" + txtUNameEmployee.Text + "' ", conn);
                sda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Updated...", "Update", MessageBoxButtons.OK);
                txtUNameEmployee.Text = "";
                txtPswEmployee.Text = "";
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txtUNameEmployee.Text == "" || txtPswEmployee.Text == "")
            {
                MessageBox.Show("Usernamae or Password must not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("delete from Rece where Rece = '" +txtUNameEmployee.Text+ "'", conn);
                sda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee Deleted...", "Delete", MessageBoxButtons.OK);
                txtUNameEmployee.Text = "";
                txtPswEmployee.Text = "";
            }
        }

        private void btnRefreshEmployee_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Rece", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
            conn.Close();
        }
        //Cart Panel Tasks
        private void btnClearItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure you want to Clear All Items?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                lblTotalBill.Text = "";
                txtCustomerName.Text = "";

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("delete from Cart", conn);
                sda.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Cart", conn);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridViewBill.DataSource = dt;
                conn.Close();
            }
        }

        private void printBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panelPrintBill.Width, this.panelPrintBill.Height);
            panelPrintBill.DrawToBitmap(bm, new Rectangle(0, 0, this.panelPrintBill.Width, this.panelPrintBill.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewBill.Rows.Count > 0)
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printBill.Print();
                }
                txtCustomerName.Text = "";

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("insert into Total_Selling values ('" + dateTimePickerBill.Value.ToString("dd-MM-yyyy") + "', '...','00') ", conn);
                sda.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand sda2 = new SqlCommand("insert into Total_Selling (Item, Price) select Item, Price from Cart", conn);
                sda2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand sda3 = new SqlCommand("delete from Cart", conn);
                sda3.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlDataAdapter sda4 = new SqlDataAdapter("select * from Cart", conn);
                DataTable dt = new DataTable();
                sda4.Fill(dt);
                dataGridViewBill.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter Some Item in Cart","Oops",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        //Tasks of Panel Total Selliing
        private void btnClearTotalSelling_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure you want to Clear All Items?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                lblTotalRupee.Text = "00";
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand sda = new SqlCommand("delete from Total_Selling", conn);
                sda.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Total_Selling", conn);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridViewTotalSelling.DataSource = dt;
                conn.Close();
            }
        }

        private void btnRefreshTotalSelling_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MyResturant\MyResturant\Resturant.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Total_Selling", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTotalSelling.DataSource = dt;
            conn.Close();

            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(Price) from Total_Selling", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblTotalRupee.Text = read.GetValue(0).ToString();
            }
            conn.Close();

            if (lblTotalRupee.Text == "")
            {
                lblTotalRupee.Text = "00";
            }
        }
        
        //Social Media Links
        private void btnFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/fdz.foodzone.3/");
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/fdz.foodzone/");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/FDFoodzone");
        }
        
        private int imgno = 1;
        private void LoadNextImage()
        {
            if (imgno == 6)
            {
                imgno = 1;
            }
            pictureBoxSlider.ImageLocation = string.Format(@"Images/{0}.jpg",imgno);
            imgno++;
        }
        private void timerSlider_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
