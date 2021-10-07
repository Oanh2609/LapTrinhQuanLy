namespace LapTrinhQuanLy_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Persons");
            AddColumn("dbo.Persons", "Companny", c => c.String());
            AddColumn("dbo.Persons", "Address", c => c.String(unicode: false));
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Persons", "PersonID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Persons", "PersonID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Persons");
            AlterColumn("dbo.Persons", "PersonID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            DropColumn("dbo.Persons", "Discriminator");
            DropColumn("dbo.Persons", "Address");
            DropColumn("dbo.Persons", "Companny");
            AddPrimaryKey("dbo.Persons", "PersonID");
        }
    }
}
