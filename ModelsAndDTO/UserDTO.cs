using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ModelsAndDTO
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public List<UserModel> UserData { get; set; }
        [DataMember]
        public UserModel UserModel { get; set; }

    }
}
