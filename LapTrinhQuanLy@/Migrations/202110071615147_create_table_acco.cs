namespace LapTrinhQuanLy_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_acco : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Roles");
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UseName = c.String(nullable: false, maxLength: 128, unicode: false),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.UseName);
            
            AlterColumn("dbo.Roles", "RoleID", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Roles", "RoleID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleID", c => c.String(nullable: false, maxLength: 10, unicode: false));
            DropTable("dbo.Accounts");
            AddPrimaryKey("dbo.Roles", "RoleID");
        }
    }
}
