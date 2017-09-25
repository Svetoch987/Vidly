namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillMovies : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT[dbo].[Movies] ON
            INSERT INTO[dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId], [NumberAvailable], [Description], [MovieImageId]) VALUES(26, N'Green mile', N'1999-05-21 00:00:00', N'2017-02-21 00:00:00', 5, 1, 5, N'Accused of the terrible crime, John Coffey is in the death row of the prison Cold Mountain. The newcomer had amazing growth and was frighteningly calm, which, however, did not in any way affect the attitude of the unit''s chief, Paul Edgcombe, who was accustomed to carrying out the verdict.
            The giant surprised everyone later when it turned out that he has an incredible magical power...', 28)

            INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId], [NumberAvailable], [Description], [MovieImageId]) VALUES(29, N'Ring', N'2002-09-21 00:00:00', N'2014-09-14 00:00:00', 7, 3, 5, N'
            The phone call follows after watching some mysterious video tape, after which everyone who watches it dies.The victim is given only one week, and then the inevitable death follows.

            The main character Rachel is a journalist, investigates these terrible events, and accidentally the cassette gets to her son, also threatened with death. Now she has to race with death in an attempt to change something and find an explanation for everything that is happening...', 30)
            
            INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId], [NumberAvailable], [Description], [MovieImageId]) VALUES(30, N'Shawshank redemption', N'1994-05-12 00:00:00', N'2015-08-12 00:00:00', 10, 1, 10, N'
            A successful banker, Andy Dufrain, is accused of murdering his own wife and her lover.Once in a prison called Shawshank, he encounters the cruelty and lawlessness that reigns on both sides of the lattice. Everyone who enters these walls becomes their slave for the rest of his life.But Andy, armed with a living mind and good heart, refuses to put up with the verdict of fate and begins to work out an incredibly daring plan for his release.', 32)

            INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId], [NumberAvailable], [Description], [MovieImageId]) VALUES(31, N'Shrek', N'2003-06-24 00:00:00', N'2016-02-28 00:00:00', 14, 2, 7, N'Once upon a time there was a big green giant named Shrek in the fairy-tale state. He lived in splendid isolation in the forest, in the swamp, which he considered his own. But once an evil short man - Lord Farquad, ruler of a magical kingdom, ruthlessly drove to Shrekovo the swamp of all fairy dwellers.

            And the carefree life of the green giant came to an end. But Lord Farquad promised to return the Shrek to the swamp if the giant gets him the beautiful princess Fiona, who languishes in an impregnable tower guarded by a fire-breathing dragon ...', 34)
            
            INSERT INTO [dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [NumberInStock], [GenreId], [NumberAvailable], [Description], [MovieImageId]) VALUES(32, N'Zootopia', N'2014-06-24 00:00:00', N'2017-08-23 00:00:00', 12, 4, 6, N'Welcome to the Zootopia - a modern city, inhabited by a variety of animals, from huge elephants to tiny mice. Zootopia is divided into regions that completely repeat the natural habitat of different inhabitants - there is also an elite area of ​​Sahara and inhospitable Tundratown. In this city, a new police officer appears, the cheerful rabbit Judy Hopps, who from the first days of work understands how difficult it is to be small and fluffy among big and strong police officers. Judy grabs the first opportunity to prove herself, despite the fact that her partner will be a garrulous cunning fox Nick Wilde. Together they will have to solve a complex matter, on which the fate of all inhabitants of the beast will depend.', 36)
            SET IDENTITY_INSERT[dbo].[Movies]
            OFF
        ");
        }
        
    public override void Down()
        {
        }
    }
}
