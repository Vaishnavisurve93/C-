using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeFirstApproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlogPostContext Bpc = new BlogPostContext();


            Bpc.Blogs.ToList();
            Bpc.Posts.ToList();


            /* foreach (Blog blog in blogs) {
             Console.WriteLine(blog);

             }
             Console.WriteLine("*****************************");
             foreach (Post post in posts) {
             Console.WriteLine(post);
             }*/
        }
    }
}
