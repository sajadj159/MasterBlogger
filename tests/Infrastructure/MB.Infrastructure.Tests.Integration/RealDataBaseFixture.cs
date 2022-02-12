using System;
using System.Transactions;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.ArticleCategoryAgg.Services;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace MB.Infrastructure.Tests.Integration
{
    public class RealDataBaseFixture: IDisposable
    {

        public MasterBloggerContext Context;
        private readonly IArticleCategoryValidator _validator;
        private readonly IArticleCategoryRepository _categoryRepository;
        private readonly TransactionScope _scope;

        public RealDataBaseFixture()
        {
            _categoryRepository = Substitute.For<IArticleCategoryRepository>();
            _validator = new ArticleCategoryValidator(_categoryRepository);

            var options = new DbContextOptionsBuilder<MasterBloggerContext>()
                .UseSqlServer(
                    "Data Source=.;Initial Catalog=MasterBlogger;Persist Security Info=True;User ID=sa;Password=sa@25253")
                .Options;
            Context = new MasterBloggerContext(options);
            _scope = new TransactionScope();

            var programing = new ArticleCategory("Programing",_validator);
            var web  = new ArticleCategory("Web Api",_validator);
            var tdd = new ArticleCategory("Tdd and Bdd",_validator);

            Context.Add(programing);
            Context.Add(web);
            Context.Add(tdd);
            Context.SaveChanges();

        }
        public void Dispose()
        {
            _scope.Dispose();
            Context.Dispose();
        }
    }
}