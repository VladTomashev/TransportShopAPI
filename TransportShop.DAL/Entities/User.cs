﻿namespace TransportShop.DAL.Entities
{
    public class User : AbstractEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
        public Account Account { get; set; }
    }
}
