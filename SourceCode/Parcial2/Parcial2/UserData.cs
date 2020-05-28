using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    public class UserData
    {
        public static List<User> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.IdUser = Convert.ToInt32(fila[0].ToString());
                u.FullName = fila[1].ToString();
                u.UserName = fila[2].ToString();
                u.Password = fila[3].ToString();
                u.UserType = Convert.ToBoolean(fila[4].ToString());


                lista.Add(u);
            }
            return lista;
        }
    }
}