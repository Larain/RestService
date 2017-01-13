using System;
using System.Collections.Generic;
using System.Web.UI.WebControls.WebParts;
using SportStudioModel;
using SportStudioModel.Entities;

namespace RestService
{
    public class WcfRestService : IRestService {

        string connectionString;

        public WcfRestService() {
            ConnectToDataBase();
        }

        private void ConnectToDataBase() {
            connectionString = "";
        }

        #region WcfRestService Members

        public string XMLData(string text)
        {
            return "Sample  test text for XML response: " + text;
        }

        public string JSONData(string text)
        {
            return "Sample  test text for JSON response: " + text;
        }

        public User GetUserById(string id) {
            //http://localhost:35798/WcfRestService.svc/getuserbyid/55
            return DatabaseManager.GetUser(Convert.ToInt16(id));
        }

        public string GetUserByEmail(string email) {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}