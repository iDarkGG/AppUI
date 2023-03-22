using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AppDependencies
{
    internal class CurrentDataBuffer
    {
        static private List<UserDataScheme> dataBuffer = new List<UserDataScheme>();

        public UserDataScheme? dataReader()
        {
            foreach (UserDataScheme item in dataBuffer)
            {
                return item;
            }
            return null;
        }

        protected static void BufferStarter()
        {
            UserDataScheme start = new UserDataScheme
            {
                Username = "Admin",
                Password = "Admin123",
                Email = "Admin@gmail.com",
                UserID = 0
            };
            dataBuffer.Add(start);
        }


    }
}
