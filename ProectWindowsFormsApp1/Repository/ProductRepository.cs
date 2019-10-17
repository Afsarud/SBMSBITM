using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProectWindowsFormsApp1.Repository
{
    class ProductRepository
    {
        public bool Add(Product product)
        {
            bool IsAdded = false;
            try
            {
                //Connection 
                string connectionString = @"server = DESKTOP-SSEF4DE; Database= SMS; Integrated Security= True ";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                // Command 
                string commandString = @"insert into Products values('" + product.ProductCode + "','" + product.ProductName + "','" + product.ReorderLevel + "','" + product.ProductDescription + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    IsAdded = true;
                }
                sqlConnection.Close();

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return IsAdded;
        }
    }
}
