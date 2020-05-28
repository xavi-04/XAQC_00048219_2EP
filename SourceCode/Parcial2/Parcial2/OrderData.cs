using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    class OrderData
    {
        public static List<Order> getLista()
        {
            string sql = "select * from APPORDER";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Order> lista = new List<Order>();
            foreach (DataRow fila in dt.Rows)
            {
                Order ped = new Order();
                User u = new User();
                ped.IdOrder = Convert.ToInt32(fila[0].ToString());
                ped.CreateDate = Convert.ToDateTime(fila[1].ToString());
                ped.IdProduct = ped.IdOrder = Convert.ToInt32(fila[2].ToString());
                ped.IdAddress = Convert.ToInt32(fila[3].ToString());


                lista.Add(ped);
            }
            return lista;
        }
    }
}