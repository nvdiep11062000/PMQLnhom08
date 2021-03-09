namespace PMQLnhom08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_MatHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatHangs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MatHangs");
        }
    }
}
