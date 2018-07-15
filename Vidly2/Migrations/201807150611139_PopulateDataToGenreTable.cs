namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres VALUES (2, 'Action')");
            Sql("INSERT INTO Genres VALUES (3, 'Family')");
            Sql("INSERT INTO Genres VALUES (4, 'Romance')");        
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id = 1");
            Sql("DELETE FROM Genres WHERE Id = 2");
            Sql("DELETE FROM Genres WHERE Id = 3");
            Sql("DELETE FROM Genres WHERE Id = 4");
        }
    }
}
