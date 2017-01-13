using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using SportStudioModel;
using SportStudioModel.DBLayer;
using SportStudioModel.Entities;

namespace RestService
{
    public class WcfRestService : IRestService {

        #region WcfRestService Members

        //http://localhost:35798/WcfRestService.svc/getuserbyid/55
        //http://tonkonozhenko.com/shop/
        public User GetUserById(string id) {
            return DatabaseManager.GetUser(Convert.ToInt16(id));
        }

        public List<SportStudioModel.Entities.User> GetUsersList()
        {
            return DatabaseManager.GetAllUsers();
        }

        public void SaveNewUser(User asd)
        {
            var request = OperationContext.Current.IncomingMessageProperties.Via.ToString();

            string[] mainParts = request.Split('&');
            string[] splitedLeft = mainParts[0].Split('/');

            string dirtyName = splitedLeft.Last();
            string dirtyEmail = mainParts.Last();

            string name = dirtyName.Split('=').Last();
            string email = dirtyEmail.Split('=').Last();

            User newUser = new User();
            newUser.Email = email;
            newUser.Name = name;
            DatabaseManager.CreateNewUser(newUser);
        }

        #endregion
    }
}