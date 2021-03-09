namespace PMQLnhom08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        NameKH = c.String(nullable: false, maxLength: 128),
                        AddressKH = c.String(),
                        SDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NameKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
