using bigCRUD.Application.Models;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository;

namespace bigCRUD.Core.Commands.Categories
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Response<Category>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        public async Task<Response<Category>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var response = await _categoryRepository.Create(request.category);

            return response;
        }
    }
}
