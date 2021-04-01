using System.Linq;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Shared.Application
{
    /// <summary>
    /// ReadOnly应用服务
    /// </summary>
    public abstract class LapisReadOnlyAppService<TEntity, TEntityDto, TKey> : LapisReadOnlyAppService<TEntity, TEntityDto, TKey, PagedAndSortedResultRequestDto>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected LapisReadOnlyAppService(IRepository<TEntity, TKey> repository)
            : base(repository)
        {
        }
    }

    /// <summary>
    /// ReadOnly应用服务
    /// </summary>
    public abstract class LapisReadOnlyAppService<TEntity, TEntityDto, TKey, TGetListInput> : ReadOnlyAppService<TEntity, TEntityDto, TKey, TGetListInput>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected new ICurrentUser CurrentUser => LazyGetRequiredService(ref _currentUser);
        private ICurrentUser _currentUser;

        protected LapisReadOnlyAppService(IRepository<TEntity, TKey> repository)
            : base(repository)
        {
        }

        protected override IQueryable<TEntity> CreateFilteredQuery(TGetListInput input)
        {
            return base.CreateFilteredQuery(input);
        }
    }
}