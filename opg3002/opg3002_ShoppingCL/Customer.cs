using System;

namespace opg3002_ShoppingCL
{
    public class Customer
    {
        private string lastname;
        private string firstname;
        private DateTime firstRegistered;
        private DateTime becamePremium;
        private DateTime becameGold;
        private DateTime becameDiamond;
        private Cart Basket;
        private int id;
        public Customer(string lastname, string firstname)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.firstRegistered = DateTime.Now;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public DateTime BecameDiamond
        {
            get { return becameDiamond; }
            set { becameDiamond = value; }
        }

        public DateTime BecameGold
        {
            get { return becameGold; }
            set { becameGold = value; }
        }

        public DateTime BecamePremium
        {
            get { return becamePremium; }
            set { becamePremium = value; }
        }

        public DateTime FirstRegistered
        {
            get { return firstRegistered; }
            set { firstRegistered = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int GetTimeSinceFirstRegistration()
        {
            return (int) (DateTime.Now - FirstRegistered).TotalDays;
        }
        public int GetTimeToEligibility()
        {
            return 0;
        }

        public void setFirstRegistered(DateTime firstRegistered)
        {
            FirstRegistered = firstRegistered;
        }

        public int timeAsMember()
        {
            return (int)(DateTime.Now - BecamePremium).TotalDays;
        }

        public int getCountPurchases()
        {
            //Cannot implement without database
            return 0;
        }

        public double getTotalPurchaseAmount()
        {
            //Cannot implement without database
            return 0;
        }
    }
}
