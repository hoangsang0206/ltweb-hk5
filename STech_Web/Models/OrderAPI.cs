﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STech_Web.Models
{
    public class OrderAPI
    {
        public string CustomerName { get; set; }
        public string OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal TotalPaymentAmout { get; set; }
        public string ShipMethod { get; set; }
        public string PaymentMethod { get; set; }

        public OrderAPI(string CustomerName, string OrderID, DateTime OrderDate, decimal TotalPrice, string Status, string Note, decimal DeliveryFee, decimal TotalPaymentAmout, string ShipMethod, string PaymentMethod)
        {
            this.CustomerName = CustomerName;
            this.OrderID = OrderID;
            this.OrderDate = OrderDate;
            this.TotalPrice = TotalPrice;
            this.Status = Status;
            this.Note = Note;
            this.DeliveryFee = DeliveryFee;
            this.TotalPaymentAmout = TotalPaymentAmout;
            this.ShipMethod = ShipMethod;
            this.PaymentMethod = PaymentMethod;
        }
    }
}