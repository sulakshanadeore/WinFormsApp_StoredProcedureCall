using Microsoft.Data.SqlClient;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomersOrders
    {
        public List<string> cities = new List<string>();
        public List<string> names = new List<string>();

        static string cnstring = "server=mazenet-test;Integrated Security=true;database=Northwind;TrustServerCertificate=true;MultipleActiveResultSets=true";

        public async Task GetData()
        {

            using (SqlConnection cn = new SqlConnection(cnstring))
            {
                await cn.OpenAsync();

                Task<List<string>> getsupplierNames = GetSuppliersNamesAsync(cn);
                Task<List<string>> getSupplierCities = GetSupplierCitiesAsync(cn);

                
                await Task.WhenAll(getsupplierNames, getSupplierCities);

                var suppliersNamesData = getsupplierNames.Result;
                var suppliersCitiesData = getSupplierCities.Result;

             

                suppliersCitiesData.ForEach(city => cities.Add(city));
                suppliersNamesData.ForEach(n=>names.Add(n));




            }
        }

        private static async Task<List<string>> GetSupplierCitiesAsync(SqlConnection cn)
        {
           List<string> Citylist = new List<string>();
            string query = "Select distinct city from suppliers";
            using (SqlCommand cmd=new SqlCommand(query,cn))
            {
                using (SqlDataReader dr=await cmd.ExecuteReaderAsync())
                {

                    while (await dr.ReadAsync())
                    {
                        Citylist.Add(dr["City"].ToString());
                    }
                }
            
            }
            return Citylist;
        }

        private static async Task<List<string>> GetSuppliersNamesAsync(SqlConnection cn)
        {
            List<string> Nameslist = new List<string>();
            string query = "Select CompanyName from suppliers";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                {

                    while (await dr.ReadAsync())
                    {
                        Nameslist.Add(dr["CompanyName"].ToString());
                    }
                }

            }
            return Nameslist;
        }
    }
}
