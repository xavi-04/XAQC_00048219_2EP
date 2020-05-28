using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    class AddressData
    {
        public static List<Address> getLista()
        {
            string sql = "select * from ADDRESS";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address ad = new Address();
                ad.IdAddress = Convert.ToInt32(fila[0].ToString());
                ad.IdUser = Convert.ToInt32(fila[1].ToString());
                ad.Addreess= fila[1].ToString();
            


                lista.Add(ad);
            }
            return lista;
        }
    }
}