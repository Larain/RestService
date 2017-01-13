using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Order
    {
        private int id;
        private int customerID;
        private int managerID;
        private DateTime createdAt;

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int CustomerId
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public int ManagerID
        {
            get { return managerID; }

            set { managerID = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        #endregion

    }
}