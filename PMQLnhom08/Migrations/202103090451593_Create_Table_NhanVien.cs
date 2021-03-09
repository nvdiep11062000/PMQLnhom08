namespace PMQLnhom08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NameNv = c.String(nullable: false, maxLength: 128),
                        IDNv = c.Int(nullable: false),
                        AddressNv = c.String(),
                    })
                .PrimaryKey(t => t.NameNv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
