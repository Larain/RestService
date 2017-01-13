using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Product
    {
        private int _id;
        private double _price;
        private string _name;
        private DateTime _createdAt;

        #region Properties

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        #endregion

    }
}