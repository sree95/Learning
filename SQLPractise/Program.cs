using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionobj();
        }

        private static void SqlConnectionobj()
        {
            DataTable dtable = new DataTable();
                 
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=HYD-SPARIMI01; Database=TestDB;Trusted_Connection=True";
                conn.Open();
                using (SqlCommand command = new SqlCommand("select * from dbo.Employee where ManagerId = 1", conn))
                {
                    //SQL insert query insert into dbo.Employee values(@employeeId,@employeeName,@managerID,@salary);
                    //command.Parameters.Add(new SqlParameter("employeeId", 8));
                    //command.Parameters.Add(new SqlParameter("employeeName", "Alibaba"));
                    //command.Parameters.Add(new SqlParameter("managerID", 1));
                    //command.Parameters.Add(new SqlParameter("salary", 100000));

                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine($"{reader[0]} | {reader[1]} | {reader[2]} | {reader[3]} |");
                    //    }
                    //}

                    using (SqlDataAdapter adpater = new SqlDataAdapter(command))
                    {
                        adpater.Fill(dtable);
                    }

                    var uniqueRows = dtable.AsEnumerable().Distinct(DataRowComparer.Default);

                    DataTable dt = uniqueRows.CopyToDataTable();


                    var duplicates = dtable.AsEnumerable().GroupBy(r => r[0]).Where(x => x.Count() > 1);

                    foreach (var item in duplicates)
                    {
                        foreach (var item1 in item)
                        {
                            var array = item1.ItemArray;

                            foreach (var item2 in array)
                            {
                                Console.WriteLine(item2);
                            }

                        }
                    }

                    Console.WriteLine(dt.Rows.Count);

                    Console.WriteLine(dtable.Rows.Count);
                    //Console.WriteLine(command.ExecuteNonQuery()); 
                }
            }
        }
    }
}
