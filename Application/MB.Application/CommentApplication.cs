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
            var comments = _commentRepository.GetAll();

            var commentViewModels = new List<CommentViewModel>();
            foreach (var comment in comments)
            {
                commentViewModels.Add(new CommentViewModel()
                {
                    Id = comment.Id,
                    Name = comment.Name,
                    Email = comment.Email,
                    Status = comment.Status,
                    Article = comment.Article.Title,
                    CreationDate = comment.CreationDate.ToString(CultureInfo.InvariantCulture)
                });
            }

            return commentViewModels;
        }
    }
}