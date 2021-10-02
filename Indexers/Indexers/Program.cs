using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**INDEXERS**");

            var cookie = new HttpCookie();
            //name is the key, Paul is the value.
            cookie["name"] = "Paul";
            Console.WriteLine(cookie["name"]);
            cookie["email"] = "myEmail@emailer.com";
            Console.WriteLine(cookie["email"]);
        }
    }
}
