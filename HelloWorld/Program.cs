namespace HelloWorld {
    /*
     * We rarely have to make Generic list. But this is the way to make it. Instead of making a list for each type, we can make a generic list. Instead of making bookList, IntList, ObjectList, we can make a generic list. This way, we can make a list for any type and we don't lose performance because we are not using object type.
     */

    public partial class Program {
        static void Main(string[] args) {
            var book1 = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(10);
            numbers.Add(20);

            var books = new GenericList<Book>();
            books.Add(new Book());

            //System.Collections.Generic.

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            dictionary.Add("1235", new Book());
            }
        }
    }




