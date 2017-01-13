using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class OrderItem
    {
        private int id;
        private int orderID;
        private int productID;
        private decimal quantity;
        private int pricePerUnit;
        private DateTime createdAt;

        #region Properties

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public int OrderID
        {
            get { return orderID; }

            set { orderID = value; }
        }

        public int ProductID
        {
            get { return productID; }

            set { productID = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }

            set { quantity = value; }
        }

        public int PricePerUnit
        {
            get { return pricePerUnit; }

            set { pricePerUnit = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }

            set { createdAt = value; }
        }

        #endregion

    }
}