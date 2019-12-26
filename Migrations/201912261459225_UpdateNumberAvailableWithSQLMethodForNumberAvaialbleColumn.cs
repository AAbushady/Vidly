namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberAvailableWithSQLMethodForNumberAvaialbleColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = InStock");
        }
        
        public override void Down()
        {
        }
    }
}
