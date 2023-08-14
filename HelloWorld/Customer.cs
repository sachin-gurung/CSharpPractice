using System.Collections.Generic;

namespace HelloWorld {
    public class Customer {
        public int id;
        public string name;
        public List<Order> Orders = new List<Order>();

        public Customer(int ID) {
            this.id = ID;
            }

        public Customer(int ID, string Name)
            : this(ID) {
            this.name = Name;
            }

        public void createOrder() {
            Orders = new List<Order>();
            }

        }
    }