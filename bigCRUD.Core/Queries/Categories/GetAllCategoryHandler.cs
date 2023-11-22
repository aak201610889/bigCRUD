
using bigCRUD.Application.Models;
using bigCRUD.Core.Queries.Categories;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository;
using MediatR;

namespace bigCRUD.Core.Queries.Products
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, Response<List<Category>>>
    {

        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Response<List<Category>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAll();
        }


    }
}
