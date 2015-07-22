namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracao1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Secao", "codPessoa_Gerente", "dbo.Pessoa");
            DropIndex("dbo.Secao", new[] { "codPessoa_Gerente" });
            AddColumn("dbo.Secao", "Pessoa_codPessoa", c => c.Int());
            CreateIndex("dbo.Secao", "Pessoa_codPessoa");
            AddForeignKey("dbo.Secao", "Pessoa_codPessoa", "dbo.Pessoa", "codPessoa");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Secao", "Pessoa_codPessoa", "dbo.Pessoa");
            DropIndex("dbo.Secao", new[] { "Pessoa_codPessoa" });
            DropColumn("dbo.Secao", "Pessoa_codPessoa");
            CreateIndex("dbo.Secao", "codPessoa_Gerente");
            AddForeignKey("dbo.Secao", "codPessoa_Gerente", "dbo.Pessoa", "codPessoa");
        }
    }
}
