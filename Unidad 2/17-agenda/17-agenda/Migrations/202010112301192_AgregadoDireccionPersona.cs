namespace _17_agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoDireccionPersona : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "PersonaDireccion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personas", "PersonaDireccion");
        }
    }
}
