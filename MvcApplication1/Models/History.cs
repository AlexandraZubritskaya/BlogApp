using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using MvcApplication1.Models.Repository;

namespace MvcApplication1.Models
{
    public class History

    {
        private readonly PostModel post;
        private readonly ICollection<string> comments;
        public History(PostModel post, ICollection<string> comments)
        {
            this.post = post;
            this.comments = comments;
        }
       
       public History() 
        {
            post = new PostModel("This is an article title",
                "<p> nfdkfldfk </p>", DateTime.Now);
            comments = CommentRepository.Comments;

        }

        public PostModel Post
        {
            get
            {
                return post;
            }
        }
        public ICollection<string> Comments
        {
            get {
                return comments;
            }
        }
        public AddCommentModel NewComment { get; set; }

        
    }
}