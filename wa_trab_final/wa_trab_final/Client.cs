using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wa_trab_final
{
    class Client
    {
        private int id;
        private string name;
        private string mail;
        private string doc;

        public Client()
        {
            id = 0;
            name = "";
            mail = "";
            doc = "";
        }

        public Client(int _id, string _name, string _mail, string _doc) {
            id = _id;
            name = _name;
            mail = _mail;
            doc = _doc;
        }

        public void setId(int _id)
        {
            id = _id;
        }
        public int getId() {
            return id;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setMail(string _mail)
        {
            mail = _mail;
        }
        public string getMail()
        {
            return mail;
        }
        public void setDoc(string _doc)
        {
            doc = _doc;
        }
        public string getDoc()
        {
            return doc;
        }
    }
}
