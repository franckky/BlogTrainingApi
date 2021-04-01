using BlogTraining.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogTraining.DAL
{
    public interface IBlogDAL
    {
        Blog AddBlog(Blog blog);
        Blog UpdateBlog(Blog blog);
        Blog GetBlog(int id);
        IEnumerable<Blog> GetAllBlog();
        void DeleteBlog(int id);
    }
}
