using System;

namespace SportStudioModel.Entities
{
    [Serializable]
    public class User
    {
        private int id;
        private string name;
        private string email;
        private string encryptedPassword;


        #region Properties

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public string Name
        {
            get { return name; }

            set { name = value; }
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

        #endregion

    }
}