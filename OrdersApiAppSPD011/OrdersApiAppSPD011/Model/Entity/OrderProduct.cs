﻿namespace OrdersApiAppSPD011.Model.Entity
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderProduct()
        {

            Quantity = 0;
        }
    }
}
