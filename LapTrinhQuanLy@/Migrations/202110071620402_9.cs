namespace LapTrinhQuanLy_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "RoleID", c => c.String(maxLength: 10));
            AlterColumn("dbo.Accounts", "PassWord", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "PassWord", c => c.String());
            DropColumn("dbo.Accounts", "RoleID");
        }
    }
}
