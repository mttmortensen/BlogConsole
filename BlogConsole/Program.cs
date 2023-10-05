using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        BlogPost post = new BlogPost("First Post", "I'm just saying hey, doing another console app", "Matt Mortensen");

        List<BlogPost> posts = new List<BlogPost>();

        posts.Add(post);

        BlogManager manager = new BlogManager(posts);

        manager.ShowPosts();  

        Console.ReadLine();
    }
}

