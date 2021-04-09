namespace Entity_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable_KhachHang_AddColum_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "ko", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KkhachHangs", "ko");
        }
    }
}
