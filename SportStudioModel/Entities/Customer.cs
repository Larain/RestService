using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Customer
    {
        private int id;
        private string email;
        private string encryptedPassword;
        private string phoneNumber;
        private string name;
        private DateTime createdAt;
        private string address;

        #region Properties;

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public string Email
        {
            get { return email; }

            set { email = value; }
        }

        public string EncryptedPassword
        {
            get { return encryptedPassword; }

            set { encryptedPassword = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }

            set { phoneNumber = value; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }

            set { createdAt = value; }
        }

        public string Address
        {
            get { return address; }

            set { address = value; }
        }

        #endregion
    }
}