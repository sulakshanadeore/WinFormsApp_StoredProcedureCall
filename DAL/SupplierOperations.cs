using Microsoft.Data.SqlClient;


namespace DAL
{
    public class SupplierOperations
    {
       static string cnstring = "server=mazenet-test;Integrated Security=true;database=Northwind;TrustServerCertificate=true";
        public bool AddSupplier(Supplier supplier) {
            //[dbo].[sp_InsertSupplier]
            bool status = false;
            try
            {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("[dbo].[sp_InsertSupplier]", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_companyName",supplier.CompanyName);
            cmd.Parameters.AddWithValue("@p_ContactName", supplier.ContactName);
            cmd.Parameters.AddWithValue("@p_ContactTitle", supplier.ContactTitle);
            cmd.Parameters.AddWithValue("@p_Address", supplier.Address);
            cmd.Parameters.AddWithValue("@p_City", supplier.City);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
                status = true;
            }
            catch (Exception ex)
            {
               throw ex;
            }
            return status;
        }

    }
}
