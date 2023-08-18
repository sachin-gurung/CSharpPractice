using System;

namespace HelloWorld
{
    public partial class Program
    {
        public class BookList {
            public void Add(Book book) {
                throw new NotImplementedException();
            }

            public Book this[int index] {
                get { throw new NotImplementedException(); }
            }
        }
    }
}