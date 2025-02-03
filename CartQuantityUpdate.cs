using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class CartQuantityUpdate : Form
    {
        int id;
        public CartQuantityUpdate(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        SqlConnection con;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\8. EIGHTH SEMESTER\C#\Project\MAIN PROJECT\database\Game_Mart.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon();
                int newQuantity;
                int stock;
                double price,newPrice;
                bool isWritten = int.TryParse(textBox1.Text, out newQuantity);
                try
                {
                    if (isWritten)
                    {
                        try
                        {
                            SqlCommand Checkstock = new SqlCommand("SELECT GStock FROM PRODUCT_TABLE WHERE GameID = @gameID", con);
                            Checkstock.Parameters.AddWithValue("@gameID", id);
                            object result = Checkstock.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                stock = Convert.ToInt32(result);
                                if (newQuantity <= stock)
                                {
                                    using (SqlCommand checkCartPrice = new SqlCommand("SELECT Price, Quantity FROM CartTable WHERE GameID = @gameID", con))
                                    {
                                        checkCartPrice.Parameters.AddWithValue("@gameID", id);
                                        using (SqlDataReader reader = checkCartPrice.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                double PriceFromCart = reader.GetDouble(0);
                                                int QFromCart = reader.GetInt32(1);
                                                price = PriceFromCart / QFromCart;
                                                newPrice = price * newQuantity;
                                                newPrice = float.Parse(newPrice.ToString("F2"));
                                            }
                                            else
                                            {
                                                MessageBox.Show("Unable to retrieve the value of game price");
                                                return;
                                            }
                                        }
                                    }

                                    using (SqlCommand updateQuantity = new SqlCommand("UPDATE CartTable SET Quantity = @quantity, Price = @price WHERE GameID = @gameID", con))
                                    {
                                        updateQuantity.Parameters.AddWithValue("@gameID", id);
                                        updateQuantity.Parameters.AddWithValue("@quantity", newQuantity);
                                        updateQuantity.Parameters.AddWithValue("@price", newPrice);
                                        updateQuantity.ExecuteNonQuery();
                                    }

                                    using (SqlCommand updateStock = new SqlCommand("UPDATE PRODUCT_TABLE SET GStock = GStock - @quantity WHERE GameID = @gameID", con))
                                    {
                                        updateStock.Parameters.AddWithValue("@quantity", newQuantity);
                                        updateStock.Parameters.AddWithValue("@gameID", id);
                                        updateStock.ExecuteNonQuery();
                                    }

                                    CartPage cartPage = new CartPage();
                                    cartPage.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Stock limit exceded");
                                    return;
                                }
                            }
                    }
                        catch(Exception ex ) { MessageBox.Show("Unable to retrive the value of game stock" + ex); }



            }
                    else
                    {
                        MessageBox.Show("Please write a valid quantity");
                        return;
                    }
                }
                catch { }
            }
            catch (Exception ex) { MessageBox.Show("Something wrong happened"); }
        }

        private void CartQuantityUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
