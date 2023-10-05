using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BlogManager
{
    private List<BlogPost> posts;

    private float blogListCounter;

    public BlogManager(List<BlogPost> posts)
    {
        this.posts = posts;
    }

    public void ShowPosts()
    {
        blogListCounter = posts.Count;

        foreach  (BlogPost post in posts)
        {
            blogListCounter--;

            Console.WriteLine(post);
            
            if (blogListCounter == 0)
            {
                Console.WriteLine("There are no more posts to show! Go ahead and post more!");
            }

        }
    }

    public void AddPost()
    {

    }

}