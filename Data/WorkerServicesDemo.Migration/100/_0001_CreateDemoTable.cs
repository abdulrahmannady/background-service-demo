using FluentMigrator;
using System;

namespace MLD.Migration
{
    [Migration(1)]
    public class _0001_CreateDemoTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table(WebsiteTables.Demo)
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Value").AsInt32().NotNullable()
                .WithColumn("DateCreated").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now)
                .WithColumn("LastModified").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now);
        }
    }
}
