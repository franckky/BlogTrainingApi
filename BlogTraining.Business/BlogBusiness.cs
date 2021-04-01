using BlogTraining.DAL;
using BlogTraining.Entities;
using System.Collections;
using System.Collections.Generic;

namespace BlogTraining.Business
{
    public class BlogBusiness:IBlogBusiness
    {
        private IBlogDAL _blogDAL;

        public BlogBusiness(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public Blog GetBlog(int id)
        {
            return _blogDAL.GetBlog(id);
        }

        public IEnumerable<Blog> GetAllBlog()
        {
            return _blogDAL.GetAllBlog();
        }

        public Blog CreateBlog(Blog blog)
        {
            return _blogDAL.AddBlog(blog);
        }

        public Blog UpdateBlog(Blog blog)
        {
            return _blogDAL.UpdateBlog(blog);
        }

        public void DeleteBlog(int id)
        {
            _blogDAL.DeleteBlog(id);
        }
    }
}
