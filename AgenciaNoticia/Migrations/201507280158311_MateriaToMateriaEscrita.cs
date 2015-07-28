namespace AgenciaNoticia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MateriaToMateriaEscrita : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materia", "materiaEscrita", c => c.String(nullable: false));
            DropColumn("dbo.Materia", "materia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Materia", "materia", c => c.String(nullable: false));
            DropColumn("dbo.Materia", "materiaEscrita");
        }
    }
}
