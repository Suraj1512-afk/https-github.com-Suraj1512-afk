using ModelsAndDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ConsumingWcfServiceAgeCalculatorExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Student> GetStudentDetails()
        {
            List<Student> stuList = new List<Student>();
            stuList.Add(new Student { ID = "123", Name = "Ramakrishna" });
            stuList.Add(new Student { ID = "123", Name = "Suraj" });
            return stuList;
        }

        public int Calculatedays(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);
            int dateToDays = DateTime.Now.Subtract(dt).Days;
            return dateToDays;
        }

        public UserDTO GetUsersData(UserDTO userDTO)
        {
            var w = new WebClient();
            string url = "https://jsonplaceholder.typicode.com/todos";
            var data = w.DownloadString(url);
            string json = "{\"UserData\":" + data + "}";
            var userData = JsonConvert.DeserializeObject<UserDTO>(json);
            return userData;
        }
    }
}
