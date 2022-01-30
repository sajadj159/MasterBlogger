using System.Collections.Generic;
using System.Globalization;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Add(AddComment command)
        {
            var comment = new Comment(command.Name, command.Message, command.Email, command.ArticleId);
            _commentRepository.CreateAndSave(comment);
        }

        public List<CommentViewModel> List()
        {
          return  _commentRepository.GetAll();
        }
    }
}