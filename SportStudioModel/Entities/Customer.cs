using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class Customer
    {
        private int _id;
        private string _email;
        private string _encryptedPassword;
        private string _phoneNumber;
        private string _name;
        private DateTime _createdAt;
        private string _address;

        #region Properties;

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public string Email
        {
            get { return _email; }

            set { _email = value; }
        }

        public string EncryptedPassword
        {
            get { return _encryptedPassword; }

            set { _encryptedPassword = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }

            set { _phoneNumber = value; }
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }

            set { _createdAt = value; }
        }

        public string Address
        {
            get { return _address; }

            set { _address = value; }
        }

        #endregion
    }
}