using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU1.VS2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine("...");
            BaseStringClass stringObject = new XMLStringClass();

            string version;
            version = stringObject.GetStringValue().Result;

            bool result;
            result = stringObject.HasBooleanValue();

            Console.Write("Done");
            Console.ReadLine();
        }
    }

    public abstract class BaseStringClass : IBaseStringParse
    {
        public string StringToParse
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public async Task<string> GetStringValue()
        {

            string xyz = "abc";
            var T1 = Task1();
            var T2 = Task2();
            await T1;
            await T2;            

            return xyz;
        }

        //TODO:NTTung
        private Task Task2()
        {
            return Task.Delay(300);
        }

        private Task Task1()
        {
            return Task.Delay(200);
        }

        public bool HasBooleanValue()
        {
            var blogs = new List<Blog>
          {
              new Blog() {Name = "ABC", Url ="http://abc.com" },
              new Blog() {Name = "Github", Url ="http://github.com" }
          };

            var blog = blogs.First(item => item.Url.Contains("github"));
            return blog != null;
        }
    }

    class Blog
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class XMLStringClass : BaseStringClass
    {

    }

}
