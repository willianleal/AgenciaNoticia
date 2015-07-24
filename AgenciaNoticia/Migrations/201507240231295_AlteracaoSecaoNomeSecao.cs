namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoSecaoNomeSecao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Secao", "Nome", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Secao", "secao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Secao", "secao", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Secao", "Nome");
        }
    }
}
