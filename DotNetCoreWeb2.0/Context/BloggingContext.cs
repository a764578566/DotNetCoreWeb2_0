using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb2._0.Context
{
    public class BloggingContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=10.5.10.76\sql2014;Initial Catalog=dotnet_erp60_clgyl_bigdata;User ID=sa;;Password=95938");
        }
    }

    [Table("cl_ProductCategory")]
    public class ProductCategory
    {
        ///<summary>
        ///初始化  <see cref="ProductCategory"/> 类的新实例。
        ///</summary>
        protected ProductCategory() { }

        ///<summary>
        /// 全编码
        ///</summary>
        public virtual string AllCode { get; set; }

        ///<summary>
        /// 编码
        ///</summary>
        public virtual string Code { get; set; }

        ///<summary>
        /// 相关文档
        ///</summary>
        public virtual string Documents { get; set; }

        ///<summary>
        /// 名称
        ///</summary>
        public virtual string Name { get; set; }

        ///<summary>
        /// 父级编码
        ///</summary>
        public virtual string ParentCode { get; set; }

        ///<summary>
        /// 父级GUID
        ///</summary>
        public virtual Guid? ParentGUID { get; set; }

        ///<summary>
        /// 父级分类名称
        ///</summary>
        public virtual string ParentName { get; set; }

        ///<summary>
        /// 说明
        ///</summary>
        public virtual string Remark { get; set; }

        ///<summary>
        /// 计量单位
        ///</summary>
        public virtual string Unit { get; set; }

        ///<summary>
        /// 材料分类表主键
        ///</summary>
        [Key, Column("ProductCategoryGUID", TypeName = "uniqueidentifier")]
        public virtual Guid ProductCategoryGUID { get; set; }
    }
}
