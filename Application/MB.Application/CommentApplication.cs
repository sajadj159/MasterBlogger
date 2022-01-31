using System.Collections.Generic;
using Framework.Infrastructure;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICommentRepository _commentRepository;

        public CommentApplication(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AddComment command)
        {
            _unitOfWork.BeginTran();
            var comment = new Comment(command.Name, command.Message, command.Email, command.ArticleId);
            _commentRepository.Create(comment);
            _unitOfWork.CommitTran();
        }

        public List<CommentViewModel> List()
        {
            return _commentRepository.GetList();
        }

        public void Confirm(long id)
        {
            _unitOfWork.BeginTran();
            var comment = _commentRepository.Get(id);
            comment.Confirm();
            _unitOfWork.CommitTran();
        }

        public void Canceled(long id)
        {
            _unitOfWork.BeginTran();
            var comment = _commentRepository.Get(id);
            comment.Canceled();
            _unitOfWork.CommitTran();
        }
    }
}