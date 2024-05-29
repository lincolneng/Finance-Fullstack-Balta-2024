﻿using Finance.Core.Models;
using Finance.Core.Requests.Categories;
using Finance.Core.Responses;

namespace Finance.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(GetByIdCategoryRequest request);
    Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoryRequest request);
}
