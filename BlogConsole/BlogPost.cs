﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BlogPost 
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Author { get; set; }
    public DateTime TimePosted { get; private set; }

    public BlogPost(string title, string body, string author)
    {
        Title = title;
        Body = body;
        Author = author;
        TimePosted = DateTime.Now;
                
    }

    public void ReadPost()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Body: " + Body);
        Console.WriteLine("By: " +  Author);
        Console.WriteLine("Date Posted: " +  TimePosted);
    }
}

