using System.Collections.Generic;
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

        public void Confirm(long id)
        {
            var comment = _commentRepository.GetBy(id);
            comment.Confirm();
            _commentRepository.Save();
        }

        public void Canceled(long id)
        {
            var comment = _commentRepository.GetBy(id);
            comment.Canceled();
            _commentRepository.Save();
        }
    }
}