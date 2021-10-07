namespace LapTrinhQuanLy_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.String(nullable: false, maxLength: 10, unicode: false),
                        RoleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleID);
            
            AlterColumn("dbo.Persons", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "Address", c => c.String(unicode: false));
            DropTable("dbo.Roles");
        }
    }
}
