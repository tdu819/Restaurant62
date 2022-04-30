﻿using Restaurant62.DAL.Abstract.Repository;
using Restaurant62.DAL.Impl.Context;
using Restaurant62.DAL.Impl.Repository.Base;
using Restaurant62.Entities;

namespace Restaurant62.DAL.Impl.Repository;

public class IngredientRepository : GenericRepository<int, Ingredient>, IIngredientRepository
{
    public IngredientRepository(RestaurantDbContext dbContext) : base(dbContext)
    {
    }
}