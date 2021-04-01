using System;
using System.ComponentModel.DataAnnotations;

namespace BlogTraining.Entities
{
    public class Blog
    {
		[Key]
		public int Id { get; set; }

		public string Creator { get; set; }

		public string Title { get; set; }

		public string Body { get; set; }

		public DateTime Dt { get; set; }
	}
}
