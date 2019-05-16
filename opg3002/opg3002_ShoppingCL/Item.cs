using System;
using System.Collections.Generic;
using System.Text;

namespace opg3002_ShoppingCL
{
    class Item
    {
        private int id;
        private bool hasGeneralDiscount;
        private double generalDiscountPct;
        private double membershipDiscountPct;
        private double normalPrice;
        private double currentPrice;
        private int currentStock;

        public int CurrentStock
        {
            get { return currentStock; }
            set { currentStock = value; }
        }

        public double CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        public double NormalPrice
        {
            get { return normalPrice; }
            set { normalPrice = value; }
        }

        public double MembershipDiscountPct
        {
            get { return membershipDiscountPct; }
            set { membershipDiscountPct = value; }
        }

        public double GeneralDiscountPct
        {
            get { return generalDiscountPct; }
            set { generalDiscountPct = value; }
        }

        public bool HasGeneralDiscount
        {
            get { return hasGeneralDiscount; }
            set { hasGeneralDiscount = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Cur(Customer customer)
        {
            double discountApplier = 0;
            if (HasGeneralDiscount)
            {
                discountApplier += GeneralDiscountPct;

                if (customer.BecamePremium != null)
                {
                    discountApplier += 0.05;
                }
                else if (customer.BecameGold != null)
                {
                    discountApplier += 0.075;
                }
                
                if (customer.BecameDiamond != null)
                {
                    discountApplier += 0.127;
                }
            }
            return normalPrice - normalPrice * discountApplier;
        }

    }
}
