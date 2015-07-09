namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeFieldFuncaoAndAtivo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "funcao", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoa", "ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "ativo", c => c.String(nullable: false));
            AlterColumn("dbo.Pessoa", "funcao", c => c.Int(nullable: false));
        }
    }
}
