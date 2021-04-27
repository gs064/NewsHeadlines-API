using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsHeadlines_API_.Models;

namespace NewsHeadlines_API_.Data
{
    public class NewsHeadlines_API_Context : DbContext
    {
        public NewsHeadlines_API_Context (DbContextOptions<NewsHeadlines_API_Context> options)
            : base(options)
        {
        }

        public DbSet<NewsHeadlines_API_.Models.News> News { get; set; }
    }
}
