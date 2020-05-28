using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    class ProductData
    {
        public static List<Product> getLista()
        {
            string sql = "select * from PRODUCT";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product pr = new Product();
                pr.IdProduct = Convert.ToInt32(fila[0].ToString());
                pr.IdBusiness = Convert.ToInt32(fila[1].ToString());
                pr.Name = fila[2].ToString();
              

                lista.Add(pr);
            }
            return lista;
        }     
    }
}