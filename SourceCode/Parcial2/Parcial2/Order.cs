﻿using System;

namespace Parcial2
{
    class Order
    {
        
        private int idOrder;
        private DateTime createDate;
        private int idProduct;
        private int idAddress;

        public Order()
        {
        }

        public Order(int idOrder, DateTime createDate, int idProduct, int idAddress)
        {
            this.idOrder = idOrder;
            this.createDate = createDate;
            this.idProduct = idProduct;
            this.idAddress = idAddress;
        }

        public int IdOrder
        {
            get => idOrder;
            set => idOrder = value;
        }

        public DateTime CreateDate
        {
            get => createDate;
            set => createDate = value;
        }

        public int IdProduct
        {
            get => idProduct;
            set => idProduct = value;
        }

        public int IdAddress
        {
            get => idAddress;
            set => idAddress = value;
        }
    }
}