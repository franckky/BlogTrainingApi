using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTraining.Business;
using BlogTraining.DAL;
using BlogTraining.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogTraining.Api.Controllers
{
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogBusiness _blogBusiness;
        public BlogController(
          IBlogBusiness blogBusiness)
        {
            _blogBusiness = blogBusiness;
        }

        [HttpGet("api/GetById/{id:int}")]
        public IActionResult GetById(int id)
        {
            var blogId = _blogBusiness.GetBlog(id);
            return Ok(blogId);
        }

        [HttpGet("api/GetAll")]
        public IActionResult GetAll()
        {
            var blogs = _blogBusiness.GetAllBlog();
            return Ok(blogs);
        }

        [HttpPost("api/Create")]
        public IActionResult Create([FromBody] Blog blog)
        {
            var createBlog = _blogBusiness.CreateBlog(blog);
            return Ok(createBlog);
        }

        [HttpPut("api/Update")]
        public IActionResult Edit([FromBody] Blog blog)
        {
            var editBlog = _blogBusiness.UpdateBlog(blog);

            return Ok(editBlog);
        }

        [HttpDelete("api/Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            _blogBusiness.DeleteBlog(id);

            return NoContent();

        }

    }
}
