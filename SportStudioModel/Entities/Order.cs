using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Order
    {
        private int _id;
        private int _customerId;
        private int _managerId;
        private DateTime _createdAt;

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public int ManagerId
        {
            get { return _managerId; }

            set { _managerId = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        #endregion

    }
}