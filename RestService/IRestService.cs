using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using SportStudioModel.Entities;

namespace RestService
{

    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "GetUserById/{id}")]
        User GetUserById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "GetUsersList")]
        List<SportStudioModel.Entities.User> GetUsersList();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, 
        UriTemplate = "NewUser")]
        [OperationContract]
        void SaveNewUser(User sstring);
    }

    //[DataContract]
    //public class User
    //{
    //    [DataMember]
    //    private string name { get; set; }

    //    [DataMember]
    //    private string email { get; set; }

    //    [DataMember]
    //    private string encryptedPassword { get; set; }
    //}
}