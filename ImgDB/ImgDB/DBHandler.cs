using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgDB
{
    class DBHandler
    {
        const string conString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ImgDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private int ExecuteNonQuery(string query)
        {
            int AffectedRows = 0;
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlCommand com = new SqlCommand(query, con))
            {
                con.Open();
                AffectedRows = com.ExecuteNonQuery();
            }

            return AffectedRows;

        }

        private DataSet ExecuteQuery(string query)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(conString))
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                da.Fill(ds);

            }
            if (ds.Tables[0].Rows.Count == 0)
            {
                throw new Exception("No results");
            }
            return ds;
        }

        public List<Userimg> AllUserimgs()
        {
            List<Userimg> li = new List<Userimg>();
            DataSet ds = new DataSet();
            ds = ExecuteQuery("select * from Images");
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                li.Add(new Userimg((int)r["ID"], (string)r["Title"], (string)r["SerializedImage"]));
            }
            return li;
        }

        public Userimg GetUserimg(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = ExecuteQuery("Select top 1 * from Images where id = " + id);
            }
            catch (Exception)
            {
                throw;
            }
            DataRow r = ds.Tables[0].Rows[0];
            Userimg im = new Userimg((int)r["ID"], (string)r["Title"], (string)r["SerializedImage"]);
            return im;
        }

        public int NewUserimg(Userimg im)
        {
            return ExecuteNonQuery("insert into Images (Title, SerializedImage) " +
                $"values ('{im.Title}', '{im.SerializedImage}')");
        }

        public int UpdateUserimg(Userimg im)
        {
            return ExecuteNonQuery($"update Images set Title = '{im.Title}', SerializedImage = '{im.SerializedImage}' " +
                $"Where ID = {im.ID}");
        }

        public int DeleteUserimg(Userimg im)
        {
            return ExecuteNonQuery($"delete from Images where Id='{im.ID}';");
        }

    }
}
