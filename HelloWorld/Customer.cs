using System.Collections.Generic;

namespace HelloWorld {
    public class Customer {
        private int _id; //hide the fields
        private string _name;
        public readonly List<Order> Orders = new List<Order>();

        //get the fields from the methods
        public void setId(int ID) {
            this._id = ID;
            }

        public void setName(string Name) {
            this._name = Name;
            }

        public string getName() {
            return this._name;
            }
        }
    }