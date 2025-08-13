using Microsoft.Data.SqlClient;
using System.Transactions;


namespace DAL
{
    public class SupplierOperations
    {
       static string cnstring = "server=mazenet-test;Integrated Security=true;database=Northwind;TrustServerCertificate=true";

        public async Task<bool> DeleteSupplier(int id)
        {
            bool status = false;
            //For Example: In Bank app, when funds are transferred from one account to another
            //account, the amt is deducted from the first account and added to the second account,
            //so there are two update statements which are related to each other, at that point 
            //use TransactionScope to handle transactions.
            using (TransactionScope scope = new TransactionScope())
            {
                //mutiple statements in transactions then transaction scope
                try
                {
                    using (SqlConnection cn = new SqlConnection(cnstring))
                    {
                        // SqlConnection cn = new SqlConnection(cnstring);
                        SqlCommand cmd = new SqlCommand("[dbo].[sp_DeleteSupplier]", cn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_SuppID", id);
                        //cn.Open();
                        cn.OpenAsync();   //First step
                                          // cmd.ExecuteNonQuery();
                        await cmd.ExecuteNonQueryAsync();//Second step
                        // cn.Close();
                        //cn.Dispose();
                        await Task.Run(() => scope.Complete()); //Third
                        cn.Close();
                        status = true;
                    }
                }

                catch (Exception ex)
                {

                    await Task.Run(() => scope.Dispose());
                    throw ex;
                }
            
            }
            return status;

        }


        public bool AddSupplier(Supplier supplier) {
            //[dbo].[sp_InsertSupplier]
            //If only single statement is there, use SqlTransaction.
            bool status = false;
            SqlTransaction tran = null;
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
                 tran=cn.BeginTransaction();

            cmd.ExecuteNonQuery();
                tran.Commit();
            cn.Close();
            cn.Dispose();
                status = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
               throw ex;
            }
            return status;
        }

    }
}
