using System.Collections.Generic;
using Framework.Infrastructure;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleAgg.Service;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IUnitOfWork _uiOfWork;
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleValidator _articleValidator;

        public ArticleApplication(IArticleRepository articleRepository, IArticleValidator articleValidator, IUnitOfWork uiOfWork)
        {
            _articleRepository = articleRepository;
            _articleValidator = articleValidator;
            _uiOfWork = uiOfWork;
        }

        public List<ArticleViewModel> List()
        {
            return _articleRepository.GetList();
        }

        public void Create(CreateArticle command)
        {
            _uiOfWork.BeginTran();
            var article = new Article(command.Title, command.ShortDescription, command.ImageUrl, command.Content, command.ArticleCategoryId, _articleValidator);
            _articleRepository.Create(article);
            _uiOfWork.CommitTran();
        }

        public EditArticle GetBy(long id)
        {
            var article = _articleRepository.Get(id);
            var result = new EditArticle
            {
                ArticleCategoryId = article.ArticleCategoryId,
                Content = article.Content,
                Id = article.Id,
                ImageUrl = article.ImageUrl,
                ShortDescription = article.ShortDescription,
                Title = article.Title
            };
            return result;
        }

        public void Edit(EditArticle command)
        {
            _uiOfWork.BeginTran();
            var article = _articleRepository.Get(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.ImageUrl, command.Content,
                command.ArticleCategoryId);
            _uiOfWork.CommitTran();
        }

        public void Remove(long id)
        {
            _uiOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Remove();
            _uiOfWork.CommitTran();
        }

        public void Active(long id)
        {
            _uiOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Active();
            _uiOfWork.CommitTran();
        }
    }
}