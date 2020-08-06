using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Practice_Session
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public List<UserData> UserData { get; set; }
        [DataMember]
        public UserData userMod { get; set; }
    }
}
