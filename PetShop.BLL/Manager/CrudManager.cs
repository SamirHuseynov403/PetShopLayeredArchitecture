﻿using AutoMapper;
using Microsoft.EntityFrameworkCore.Query;
using PetShop.BLL.Services;
using PetShop.DAL.Entities;
using PetShop.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace PetShop.BLL.Manager
{
    public class CrudManager<TEntity, TViewModel, TCreateViewModel, TUpdateViewModel> : ICrudService<TEntity, TViewModel, TCreateViewModel, TUpdateViewModel>
where TEntity : BaseEntity
    {
        protected readonly IRepository<TEntity> Repository;
        protected readonly IMapper Mapper;

        public CrudManager(IRepository<TEntity> respository, IMapper mapper)
        {
            Repository = respository;
            Mapper = mapper;
        }

        public virtual async Task CreateAsync(TCreateViewModel model)
        {
            var entity = Mapper.Map<TEntity>(model);
            await Repository.AddAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);

            if (entity == null)
                return false;

            await Repository.DeleteAsync(entity);

            return true;
        }

        public virtual async Task<IEnumerable<TViewModel>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool AsNoTracking = false)
        {
            var entities = await Repository.GetAllAsync(predicate, include, orderBy, AsNoTracking);

            var viewModels = Mapper.Map<IEnumerable<TViewModel>>(entities);

            return viewModels;
        }

        public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool AsNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TViewModel?> GetByIdAsync(int id)
        {
            var entity = await Repository.GetByIdAsync(id);

            if (entity == null)
                return default;

            var viewModel = Mapper.Map<TViewModel>(entity);

            return viewModel;
        }

        public virtual async Task<bool> UpdateAsync(int id, TUpdateViewModel model)
        {
            var entity = await Repository.GetByIdAsync(id);

            if (entity == null)
                return false;

            Mapper.Map(model, entity);

            await Repository.UpdateAsync(entity);

            return true;
        }
    }
}
