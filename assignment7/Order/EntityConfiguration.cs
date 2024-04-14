using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class YourEntityConfiguration : EntityTypeConfiguration<Commodity>
    {
        public YourEntityConfiguration()
        {
            // 指定数据库中的 ID 字段
            Property(e => e.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // 指定实体对象中的 ID 属性
            Property(e => e.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); // 如果不需要数据库生成ID，则设置为None
        }
    }
}
