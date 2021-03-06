﻿using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Module.Inventory.EntityFrameworkCore
{
    public class InventoryModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public InventoryModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}