using BlogTraining.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogTraining.DAL
{
    public class BlogDAL : IBlogDAL
    {
        private readonly BlogTrainingDbContext _context;

        public BlogDAL(BlogTrainingDbContext context)
        {
            _context = context;
        }

        public Blog AddBlog(Blog blog)
        {

            _context.Add(blog);
            _context.SaveChanges();

            return blog;
        }

        public Blog UpdateBlog(Blog blog)
        {
            _context.Update(blog);
            _context.SaveChanges();

            return blog;
        }

        public Blog GetBlog(int id)
        {
            return _context.Blogs.SingleOrDefault(b => b.Id == id);
        }

        public IEnumerable<Blog> GetAllBlog()
        {
            return _context.Blogs.AsEnumerable();
        }

        public void DeleteBlog(int id)
        {
            var BlogId = this.GetBlog(id);
            _context.Remove(BlogId);
            _context.SaveChanges();
        }

    }
}
