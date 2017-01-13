using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _encryptedPassword;

        public User()
        {
            
        }

        public User(int id, string name, string email, string encryptedPassword)
        {
            _id = id;
            _name = name;
            _email = email;
            _encryptedPassword = encryptedPassword;
        }

        #region Properties

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
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

        #endregion

    }
}