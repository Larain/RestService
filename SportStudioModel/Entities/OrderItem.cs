using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class OrderItem
    {
        private int _id;
        private int _orderId;
        private int _productId;
        private decimal _quantity;
        private int _pricePerUnit;
        private DateTime _createdAt;

        #region Properties

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public int OrderId
        {
            get { return _orderId; }

            set { _orderId = value; }
        }

        public int ProductId
        {
            get { return _productId; }

            set { _productId = value; }
        }

        public decimal Quantity
        {
            get { return _quantity; }

            set { _quantity = value; }
        }

        public int PricePerUnit
        {
            get { return _pricePerUnit; }

            set { _pricePerUnit = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }

            set { _createdAt = value; }
        }

        #endregion

    }
}