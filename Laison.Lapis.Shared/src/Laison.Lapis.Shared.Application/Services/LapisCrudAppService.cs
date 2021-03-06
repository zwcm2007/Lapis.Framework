using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Laison.Lapis.Shared.Application
{
    /// <summary>
    /// Crud应用服务
    /// </summary>
    public abstract class LapisCrudAppService<TEntity, TEntityDto, TKey, TGetListInput> : LapisCrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TEntityDto, TEntityDto>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected LapisCrudAppService(IRepository<TEntity, TKey> repository)
            : base(repository)
        {
        }
    }

    /// <summary>
    /// Crud应用服务
    /// </summary>
    public abstract class LapisCrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput> : CrudAppService<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected LapisCrudAppService(IRepository<TEntity, TKey> repository)
            : base(repository)
        {
        }

        protected override Task<IQueryable<TEntity>> CreateFilteredQueryAsync(TGetListInput input)
        {
            return base.CreateFilteredQueryAsync(input);
        }
    }
}