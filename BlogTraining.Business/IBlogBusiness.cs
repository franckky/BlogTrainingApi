using BlogTraining.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogTraining.Business
{
    public interface IBlogBusiness
    {
        Blog GetBlog(int id);
        IEnumerable<Blog> GetAllBlog();
        Blog CreateBlog(Blog blog);
        Blog UpdateBlog(Blog blog);
        void DeleteBlog(int id);

    }
}
