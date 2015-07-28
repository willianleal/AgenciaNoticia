namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentario",
                c => new
                    {
                        codComentario = c.Int(nullable: false),
                        codMateria = c.Int(nullable: false),
                        codPessoa = c.Int(nullable: false),
                        titulo = c.String(nullable: false, maxLength: 100),
                        comentario = c.String(nullable: false),
                        dataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.codComentario, t.codMateria })
                .ForeignKey("dbo.Materia", t => t.codMateria)
                .ForeignKey("dbo.Pessoa", t => t.codPessoa)
                .Index(t => t.codMateria)
                .Index(t => t.codPessoa);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        codMateria = c.Int(nullable: false, identity: true),
                        codPessoa_Jornalista = c.Int(nullable: false),
                        codPessoa_Revisor = c.Int(nullable: false),
                        codPessoa_Publicador = c.Int(nullable: false),
                        nome = c.String(nullable: false, maxLength: 100),
                        materia = c.String(nullable: false),
                        codSecao = c.Int(nullable: false),
                        status = c.String(nullable: false),
                        dataCadastro = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.codMateria)
                .ForeignKey("dbo.Pessoa", t => t.codPessoa_Jornalista)
                .ForeignKey("dbo.Pessoa", t => t.codPessoa_Publicador)
                .ForeignKey("dbo.Pessoa", t => t.codPessoa_Revisor)
                .ForeignKey("dbo.Secao", t => t.codSecao)
                .Index(t => t.codPessoa_Jornalista)
                .Index(t => t.codPessoa_Revisor)
                .Index(t => t.codPessoa_Publicador)
                .Index(t => t.codSecao);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        codPessoa = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        funcao = c.String(nullable: false),
                        ddd = c.String(nullable: false, maxLength: 2),
                        telefone = c.String(nullable: false, maxLength: 9),
                        email = c.String(nullable: false, maxLength: 50),
                        ativo = c.Boolean(nullable: false),
                        dataCadastro = c.DateTime(nullable: false),
                        senha = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.codPessoa);
            
            CreateTable(
                "dbo.Secao",
                c => new
                    {
                        codSecao = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        codPessoa_Gerente = c.Int(nullable: false),
                        dataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.codSecao)
                .ForeignKey("dbo.Pessoa", t => t.codPessoa_Gerente)
                .Index(t => t.codPessoa_Gerente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentario", "codPessoa", "dbo.Pessoa");
            DropForeignKey("dbo.Comentario", "codMateria", "dbo.Materia");
            DropForeignKey("dbo.Materia", "codSecao", "dbo.Secao");
            DropForeignKey("dbo.Secao", "codPessoa_Gerente", "dbo.Pessoa");
            DropForeignKey("dbo.Materia", "codPessoa_Revisor", "dbo.Pessoa");
            DropForeignKey("dbo.Materia", "codPessoa_Publicador", "dbo.Pessoa");
            DropForeignKey("dbo.Materia", "codPessoa_Jornalista", "dbo.Pessoa");
            DropIndex("dbo.Secao", new[] { "codPessoa_Gerente" });
            DropIndex("dbo.Materia", new[] { "codSecao" });
            DropIndex("dbo.Materia", new[] { "codPessoa_Publicador" });
            DropIndex("dbo.Materia", new[] { "codPessoa_Revisor" });
            DropIndex("dbo.Materia", new[] { "codPessoa_Jornalista" });
            DropIndex("dbo.Comentario", new[] { "codPessoa" });
            DropIndex("dbo.Comentario", new[] { "codMateria" });
            DropTable("dbo.Secao");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Materia");
            DropTable("dbo.Comentario");
        }
    }
}
