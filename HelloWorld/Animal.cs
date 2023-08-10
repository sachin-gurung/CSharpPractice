using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Animal {
        //member arguments
        string _name;
        bool _isCarnivorous;
        int _age;

        public Animal()
        {
            Console.WriteLine("1. I don't have any arguments!!");
        }

        public Animal(string name)
            :this()
        {
            this._name = name;
            Console.WriteLine("2. I have a name and my name is {0}", name);
        }
        public Animal(string name, bool isCarnivorous, int age)
            :this(name)
        {
            this._isCarnivorous = isCarnivorous;
            this._age = age;

            Console.WriteLine("3. {0} is {1} year old!!",name,age);
        }
    }
}
