﻿namespace AspNetCoreEFCoreApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Url { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
