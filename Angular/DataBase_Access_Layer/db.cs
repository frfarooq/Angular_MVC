using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Angular.Models;
using System.ComponentModel.DataAnnotations;
namespace Angular.DataBase_Access_Layer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void Add_record(Registeration rs)
        {
            SqlCommand cmd = new SqlCommand("SPtext", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",rs.id);
            cmd.Parameters.AddWithValue("@name", rs.name);
            cmd.Parameters.AddWithValue("@phone",rs.phone);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Fatch_record()
        {
            SqlCommand cmd = new SqlCommand("SPfatch",con);
         
        }
    }
}