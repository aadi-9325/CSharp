using System ;
using System.Collections.Specialized;

namespace events {
    public delegate string mydel(string s);
    public class Program {
        event mydel myevent;
        public string wel(string s)
        {
            return " \t Welocme  " + s;
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.myevent = new mydel(p.wel);
            String Ans = p.myevent("Aditya Ghodke" + " \n\n\n \t Events Fired ");
            Console.WriteLine(Ans);
        }
    }
}
