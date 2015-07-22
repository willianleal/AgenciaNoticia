namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class voltaalteracao1e2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Secao", new[] { "Pessoa_codPessoa" });
            DropColumn("dbo.Secao", "codPessoa_Gerente");
            RenameColumn(table: "dbo.Secao", name: "Pessoa_codPessoa", newName: "codPessoa_Gerente");
            AlterColumn("dbo.Secao", "codPessoa_Gerente", c => c.Int(nullable: false));
            CreateIndex("dbo.Secao", "codPessoa_Gerente");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Secao", new[] { "codPessoa_Gerente" });
            AlterColumn("dbo.Secao", "codPessoa_Gerente", c => c.Int());
            RenameColumn(table: "dbo.Secao", name: "codPessoa_Gerente", newName: "Pessoa_codPessoa");
            AddColumn("dbo.Secao", "codPessoa_Gerente", c => c.Int(nullable: false));
            CreateIndex("dbo.Secao", "Pessoa_codPessoa");
        }
    }
}
