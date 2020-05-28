﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial2
{
    class BusinessData
    {
        public static List<Business> getLista()
        {
            string sql = "select * from BUSINESS";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Business> lista = new List<Business>();
            foreach (DataRow fila in dt.Rows)
            {
                Business bu = new Business();
             
                bu.IdBusiness = Convert.ToInt32(fila[0].ToString());
                bu.Name = fila[1].ToString();
                bu.Description = fila[2].ToString();
               

                lista.Add(bu);
            }
            return lista;
        }
    }
}