using JetBrains.Annotations;
using System.Collections.Generic;
using Volo.Abp;

namespace Laison.Lapis.PermissionManagement.Domain
{
    public class PermissionWithGrantedProviders
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 是否授权
        /// </summary>
        public bool IsGranted { get; set; }

        /// <summary>
        /// 权限提供信息
        /// </summary>
        public List<PermissionValueProviderInfo> Providers { get; set; }

        public PermissionWithGrantedProviders([NotNull] string name, bool isGranted)
        {
            Check.NotNull(name, nameof(name));

            Name = name;
            IsGranted = isGranted;

            Providers = new List<PermissionValueProviderInfo>();
        }
    }
}