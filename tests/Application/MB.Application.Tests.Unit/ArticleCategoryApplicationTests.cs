using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Framework.Infrastructure;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using Microsoft.EntityFrameworkCore.Query.Internal;
using NSubstitute;
using Xunit;

namespace MB.Application.Tests.Unit
{
    public class ArticleCategoryApplicationTests
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidator _validator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ArticleCategoryApplication _articleCategoryApplication;

        public ArticleCategoryApplicationTests()
        {
            _articleCategoryRepository = Substitute.For<IArticleCategoryRepository>();
            _validator = Substitute.For<IArticleCategoryValidator>();
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _articleCategoryApplication =
                new ArticleCategoryApplication(_articleCategoryRepository, _validator, _unitOfWork);
        }
        [Fact]
        public void List_ShouldReturnAListOfArticleCategory()
        {
            //Arrange
            _articleCategoryRepository.GetAll().Returns(new List<ArticleCategory>());

            //Act
            var list = _articleCategoryApplication.List();

            //Assert
            list.Should().HaveCountGreaterOrEqualTo(0);
            list.Should().BeOfType<List<ArticleCategoryViewModel>>();
            _articleCategoryRepository.Received().GetAll();
        }

        [Fact]
        public void Create_ShouldCreateNewArticleCategory()
        {
            //Arrange
            const string title = "Something";
            var articleCategory = new CreateArticleCategory() { Title = title };

            //Act
            _articleCategoryApplication.Create(articleCategory);
            var category = new ArticleCategory(articleCategory.Title, _validator);

            //Assert
            _articleCategoryRepository.ReceivedWithAnyArgs().Create(category);
        }

        [Fact]
        public void Rename_ShouldRenameArticleCategoryTitle()
        {
            //Arrange
            const string title = "something";
            var articleCategory = new ArticleCategory(title, _validator);
            var renameArticleCategory = new RenameArticleCategory { Title = articleCategory.Title, Id = articleCategory.Id };
            _articleCategoryRepository.Get(articleCategory.Id).Returns(articleCategory);

            //Act
            _articleCategoryApplication.Rename(renameArticleCategory);

            //Assert
            _articleCategoryRepository.Received().Get(articleCategory.Id);
        }
    }
}
