namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAtualizacaoToMateria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materia", "dataAtualizacao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materia", "dataAtualizacao");
        }
    }
}
