
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace AppDependencies
{
    public class FileParser
    {


        public void CrearBasedeDatos(string Name)
        {
            var DefaultObj = new UserDataScheme()
            {
                Username = "Admin123",
                Email = "Admin@domain.com",
                Password = "Admin123",
                UserID = 0
            };

            var Options = new JsonSerializerOptions {  WriteIndented= true };

            string DefaultValues = JsonSerializer.Serialize( DefaultObj,Options
            );

            using (StreamWriter sw = File.CreateText(Name + ".json"))
            {
                sw.WriteLine(DefaultValues);
            }
        }

        public void Search(string Name, out string Username, out string Email, out string Passsword, out int UserID)
        {
            string jsonString = File.ReadAllText(Name + ".json");
            UserDataScheme Values = JsonSerializer.Deserialize<UserDataScheme>(jsonString);
            Username = Values.Username;
            Email = Values.Email;
            Passsword = Values.Password;
            UserID = Values.UserID;
        }

        
    }
}
