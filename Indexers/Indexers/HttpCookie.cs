using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    public class HttpCookie
    {
        //We use a dictionary datatype to store the key value pairs in the cookie. A dictionary is a datatype that resides in collections.generic that uses a hash table to store the data, it
        //is a fast way to store data and be able to look it up using a key.

        //Dictionary where the key is type string and the values are type string.
        private readonly Dictionary<string, string> _dictionary;


        public HttpCookie()
        {
            //initialise
            _dictionary = new Dictionary<string, string>();
        }

        //Indexer, return type string as the key and values are string

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
