using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Product
    {
        private int id;
        private double price;
        private string name;
        private DateTime createdAt;

        #region Properties

        public int ID
        {
            get { return id; }

            set { id = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        #endregion

    }
}