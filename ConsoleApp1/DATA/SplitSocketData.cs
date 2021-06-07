using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class SplitSocketData
    {
        public static string GetValueKey(string message, string key)
        {
            string data = null;
            if (message.IndexOf(key) != -1)
            {
                data = message.Substring(message.IndexOf(key), message.Length - message.IndexOf(key));
                data = data.Remove(0, 4);
                int lenght = int.Parse(data.Substring(0, 4));
                data = data.Remove(0, 4);
                data = data.Substring(0, lenght);
            }
            return data;
        }
    }
}
