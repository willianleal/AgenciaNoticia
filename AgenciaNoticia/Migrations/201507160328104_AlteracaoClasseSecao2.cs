namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoClasseSecao2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Secao", name: "Pessoa_codPessoa", newName: "codPessoa_Gerente");
            RenameIndex(table: "dbo.Secao", name: "IX_Pessoa_codPessoa", newName: "IX_codPessoa_Gerente");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Secao", name: "IX_codPessoa_Gerente", newName: "IX_Pessoa_codPessoa");
            RenameColumn(table: "dbo.Secao", name: "codPessoa_Gerente", newName: "Pessoa_codPessoa");
        }
    }
}
