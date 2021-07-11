using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameWeek = table.Column<int>(type: "int", nullable: false),
                    HomeID = table.Column<int>(type: "int", nullable: true),
                    AwayID = table.Column<int>(type: "int", nullable: true),
                    GoalsHomeTeam = table.Column<int>(type: "int", nullable: false),
                    GoalsAwayTeam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Teams_AwayID",
                        column: x => x.AwayID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_HomeID",
                        column: x => x.HomeID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    SquadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GameWeek = table.Column<int>(type: "int", nullable: false),
                    GameWeekPoints = table.Column<int>(type: "int", nullable: false),
                    Captain = table.Column<int>(type: "int", nullable: false),
                    ViceCaptain = table.Column<int>(type: "int", nullable: false),
                    Benched1 = table.Column<int>(type: "int", nullable: false),
                    Benched2 = table.Column<int>(type: "int", nullable: false),
                    Benched3 = table.Column<int>(type: "int", nullable: false),
                    Benched4 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => new { x.SquadId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Squads_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerGameStatistics",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    NumOfGoals = table.Column<int>(type: "int", nullable: false),
                    NumOfAssists = table.Column<int>(type: "int", nullable: false),
                    CleanSheet = table.Column<bool>(type: "bit", nullable: false),
                    YellowCard = table.Column<bool>(type: "bit", nullable: false),
                    RedCard = table.Column<bool>(type: "bit", nullable: false),
                    MinutsPlayed = table.Column<int>(type: "int", nullable: false),
                    GoalsConceded = table.Column<int>(type: "int", nullable: false),
                    NumOfOwnGoals = table.Column<int>(type: "int", nullable: false),
                    NumOfSaves = table.Column<int>(type: "int", nullable: false),
                    PenaltiesMissed = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGameStatistics", x => new { x.PlayerId, x.GameId });
                    table.ForeignKey(
                        name: "FK_PlayerGameStatistics_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGameStatistics_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerSquad",
                columns: table => new
                {
                    PlayersPlayerId = table.Column<int>(type: "int", nullable: false),
                    SquadsSquadId = table.Column<int>(type: "int", nullable: false),
                    SquadsUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSquad", x => new { x.PlayersPlayerId, x.SquadsSquadId, x.SquadsUserId });
                    table.ForeignKey(
                        name: "FK_PlayerSquad_Players_PlayersPlayerId",
                        column: x => x.PlayersPlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerSquad_Squads_SquadsSquadId_SquadsUserId",
                        columns: x => new { x.SquadsSquadId, x.SquadsUserId },
                        principalTable: "Squads",
                        principalColumns: new[] { "SquadId", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "TeamName" },
                values: new object[,]
                {
                    { 1, "Arsenal" },
                    { 18, "Watford" },
                    { 17, "Spurs" },
                    { 16, "Southampton" },
                    { 15, "Norwich" },
                    { 14, "Newcastle" },
                    { 13, "Man Utd" },
                    { 12, "Man City" },
                    { 11, "Liverpool" },
                    { 10, "Leeds" },
                    { 9, "Leicester" },
                    { 8, "Everton" },
                    { 7, "Crystal Palace" },
                    { 6, "Chelsea" },
                    { 5, "Burnley" },
                    { 4, "Brighton" },
                    { 3, "Brentford" },
                    { 2, "Aston Villa" },
                    { 19, "West Ham" },
                    { 20, "Wolves" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 1, "Bernd", 1, 5.0, "Leno", 1 },
                    { 309, "Sean", 3, 11.0, "Longstaff", 14 },
                    { 308, "Miguel", 3, 9.0, "Almirón", 14 },
                    { 307, "Allan", 4, 9.0, "Saint-Maximin", 14 },
                    { 306, "Isaac", 3, 6.0, "Hayden", 14 },
                    { 305, "Fabian", 2, 5.0, "Schär", 14 },
                    { 304, "Jacob", 3, 5.0, "Murphy", 14 },
                    { 303, "Emil", 2, 4.0, "Krafth", 14 },
                    { 302, "Javier", 2, 6.0, "Manquillo", 14 },
                    { 301, "Paul", 2, 4.0, "Dummett", 14 },
                    { 300, "Dwight", 4, 8.0, "Gayle", 14 },
                    { 299, "Jamaal", 2, 6.0, "Lascelles", 14 },
                    { 298, "Ryan", 3, 9.0, "Fraser", 14 },
                    { 297, "Jeff", 3, 6.0, "Hendrick", 14 },
                    { 296, "Callum", 4, 10.0, "Wilson", 14 },
                    { 295, "Martin", 1, 4.0, "Dubravka", 14 },
                    { 294, "Karl", 1, 5.0, "Darlow", 14 },
                    { 293, "Ciaran", 2, 5.0, "Clark", 14 },
                    { 292, "Matt", 2, 6.0, "Ritchie", 14 },
                    { 291, "Jonjo", 3, 11.0, "Shelvey", 14 },
                    { 459, "Juan", 3, 8.0, "Mata", 13 },
                    { 290, "Brandon", 2, 5.0, "Williams", 13 },
                    { 289, "Mason", 3, 11.0, "Greenwood", 13 },
                    { 288, "Aaron", 2, 4.0, "Wan-Bissaka", 13 },
                    { 287, "Daniel", 3, 11.0, "James", 13 },
                    { 286, "Eric", 2, 4.0, "Bailly", 13 },
                    { 310, "Joelinton Cássio", 4, 10.0, "Apolinário de Lira", 14 },
                    { 285, "Scott", 3, 6.0, "McTominay", 13 },
                    { 311, "Jamal", 2, 4.0, "Lewis", 14 },
                    { 465, "Federico", 2, 6.0, "Fernández", 14 },
                    { 332, "Theo", 3, 6.0, "Walcott", 16 },
                    { 457, "Dimitris", 2, 4.0, "Giannoulis", 15 },
                    { 456, "Ben", 2, 6.0, "Gibson", 15 },
                    { 449, "Milot", 3, 9.0, "Rashica", 15 },
                    { 448, "Angus", 1, 4.0, "Gunn", 15 },
                    { 331, "Andrew", 2, 5.0, "Omobamidele", 15 },
                    { 330, "Josh", 3, 5.0, "Martin", 15 },
                    { 329, "Adam", 4, 11.0, "Idah", 15 },
                    { 328, "Przemyslaw", 3, 7.0, "Placheta", 15 },
                    { 327, "Jacob", 2, 4.0, "Sørensen", 15 },
                    { 326, "Max", 2, 6.0, "Aarons", 15 },
                    { 325, "Todd", 3, 11.0, "Cantwell", 15 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 324, "Christoph", 2, 4.0, "Zimmermann", 15 },
                    { 323, "Kieran", 3, 10.0, "Dowell", 15 },
                    { 322, "Jordan", 4, 10.0, "Hugill", 15 },
                    { 321, "Sam", 2, 6.0, "Byram", 15 },
                    { 320, "Onel", 3, 6.0, "Hernández", 15 },
                    { 319, "Grant", 2, 4.0, "Hanley", 15 },
                    { 318, "Kenny", 3, 11.0, "McLean", 15 },
                    { 317, "Lukas", 3, 11.0, "Rupp", 15 },
                    { 316, "Marco", 3, 10.0, "Stiepermann", 15 },
                    { 315, "Teemu", 4, 9.0, "Pukki", 15 },
                    { 314, "Tim", 1, 6.0, "Krul", 15 },
                    { 313, "Michael", 1, 6.0, "McGovern", 15 },
                    { 145, "Billy", 3, 6.0, "Gilmour", 15 },
                    { 312, "Matthew", 3, 10.0, "Longstaff", 14 },
                    { 333, "Fraser", 1, 5.0, "Forster", 16 },
                    { 284, "Victor", 2, 5.0, "Lindelöf", 13 },
                    { 282, "Donny", 3, 6.0, "van de Beek", 13 },
                    { 252, "John", 2, 4.0, "Stones", 12 },
                    { 251, "Kevin", 3, 5.0, "De Bruyne", 12 },
                    { 250, "Ilkay", 3, 8.0, "Gündogan", 12 },
                    { 249, "Kyle", 2, 4.0, "Walker", 12 },
                    { 248, "Ben", 2, 6.0, "Davies", 11 },
                    { 247, "Rhys", 2, 6.0, "Williams", 11 },
                    { 246, "Neco", 2, 4.0, "Williams", 11 },
                    { 245, "Konstantinos", 2, 4.0, "Tsimikas", 11 },
                    { 244, "Curtis", 3, 7.0, "Jones", 11 },
                    { 243, "Ibrahima", 2, 6.0, "Konaté", 11 },
                    { 242, "Caoimhin", 1, 4.0, "Kelleher", 11 },
                    { 241, "Nathaniel", 2, 4.0, "Phillips", 11 },
                    { 240, "Diogo", 3, 5.0, "Jota", 11 },
                    { 239, "Naby", 3, 6.0, "Keita", 11 },
                    { 238, "Joseph", 2, 6.0, "Gomez", 11 },
                    { 237, "Trent", 2, 6.0, "Alexander-Arnold", 11 },
                    { 236, "Takumi", 3, 5.0, "Minamino", 11 },
                    { 235, "Divock", 4, 7.0, "Origi", 11 },
                    { 234, "Andrew", 2, 6.0, "Robertson", 11 },
                    { 233, "Mohamed", 3, 11.0, "Salah", 11 },
                    { 232, "Fabio Henrique", 3, 9.0, "Tavares", 11 },
                    { 231, "Alisson", 1, 5.0, "Ramses Becker", 11 },
                    { 230, "Sadio", 3, 9.0, "Mané", 11 },
                    { 229, "Virgil", 2, 4.0, "van Dijk", 11 },
                    { 228, "Roberto", 4, 11.0, "Firmino", 11 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 253, "Benjamin", 2, 5.0, "Mendy", 12 },
                    { 283, "Axel", 2, 5.0, "Tuanzebe", 13 },
                    { 254, "Riyad", 3, 8.0, "Mahrez", 12 },
                    { 256, "João Pedro Cavaco", 2, 5.0, "Cancelo", 12 },
                    { 281, "Marcus", 3, 11.0, "Rashford", 13 },
                    { 280, "Dean", 1, 6.0, "Henderson", 13 },
                    { 279, "Alex Nicolao", 2, 5.0, "Telles", 13 },
                    { 278, "Anthony", 4, 11.0, "Martial", 13 },
                    { 277, "Bruno Miguel", 3, 7.0, "Borges Fernandes", 13 },
                    { 276, "Jesse", 3, 7.0, "Lingard", 13 },
                    { 275, "Luke", 2, 5.0, "Shaw", 13 },
                    { 274, "Frederico", 3, 9.0, "Rodrigues de Paula Santos", 13 },
                    { 273, "Harry", 2, 5.0, "Maguire", 13 },
                    { 272, "Paul", 3, 6.0, "Pogba", 13 },
                    { 271, "Nemanja", 3, 5.0, "Matic", 13 },
                    { 270, "David", 1, 5.0, "de Gea", 13 },
                    { 269, "Edinson", 4, 9.0, "Cavani", 13 },
                    { 453, "Fernando", 3, 8.0, "Luiz Rosa", 12 },
                    { 268, "Ferran", 3, 8.0, "Torres", 12 },
                    { 266, "Rodrigo", 3, 5.0, "Hernandez", 12 },
                    { 265, "Phil", 3, 8.0, "Foden", 12 },
                    { 264, "Oleksandr", 2, 4.0, "Zinchenko", 12 },
                    { 263, "Gabriel Fernando", 4, 8.0, "de Jesus", 12 },
                    { 262, "Rúben Santos", 2, 5.0, "Gato Alves Dias", 12 },
                    { 261, "Bernardo Mota", 3, 6.0, "Veiga de Carvalho e Silva", 12 },
                    { 260, "Zack", 1, 5.0, "Steffen", 12 },
                    { 259, "Aymeric", 2, 4.0, "Laporte", 12 },
                    { 258, "Nathan", 2, 6.0, "Aké", 12 },
                    { 257, "Ederson", 1, 4.0, "Santana de Moraes", 12 },
                    { 255, "Raheem", 3, 8.0, "Sterling", 12 },
                    { 334, "Alex", 1, 6.0, "McCarthy", 16 },
                    { 335, "Oriol", 3, 5.0, "Romeu Vidal", 16 },
                    { 336, "Nathan", 3, 5.0, "Redmond", 16 },
                    { 417, "Arthur", 2, 5.0, "Masuaku", 19 },
                    { 416, "Manuel", 3, 10.0, "Lanzini", 19 },
                    { 415, "Ryan", 2, 5.0, "Fredericks", 19 },
                    { 414, "Craig", 2, 6.0, "Dawson", 19 },
                    { 413, "Michail", 4, 11.0, "Antonio", 19 },
                    { 412, "Andriy", 3, 6.0, "Yarmolenko", 19 },
                    { 411, "Aaron", 2, 4.0, "Cresswell", 19 },
                    { 410, "Winston", 2, 6.0, "Reid", 19 },
                    { 409, "Angelo", 2, 5.0, "Ogbonna", 19 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 408, "Lukasz", 1, 6.0, "Fabianski", 19 },
                    { 407, "Darren", 1, 4.0, "Randolph", 19 },
                    { 406, "Mark", 3, 8.0, "Noble", 19 },
                    { 454, "Matthew", 2, 4.0, "Pollock", 18 },
                    { 450, "Emmanuel", 4, 10.0, "Dennis", 18 },
                    { 405, "Kwadwo", 3, 9.0, "Baah", 18 },
                    { 404, "João Pedro", 4, 7.0, "Junqueira de Jesus", 18 },
                    { 403, "Imrân", 3, 9.0, "Louza", 18 },
                    { 402, "Joseph", 3, 10.0, "Hungbo", 18 },
                    { 401, "Ben", 2, 4.0, "Wilmot", 18 },
                    { 400, "Jeremy", 2, 6.0, "Ngakia", 18 },
                    { 399, "Ismaila", 3, 8.0, "Sarr", 18 },
                    { 398, "Marc", 2, 5.0, "Navarro", 18 },
                    { 397, "Domingos", 3, 7.0, "Quina", 18 },
                    { 396, "Francisco", 2, 5.0, "Sierralta", 18 },
                    { 395, "Ashley", 4, 11.0, "Fletcher", 18 },
                    { 418, "Vladimir", 2, 4.0, "Coufal", 19 },
                    { 394, "Ayotomiwa", 3, 10.0, "Dele-Bashiru", 18 },
                    { 419, "Saïd", 3, 11.0, "Benrahma", 19 },
                    { 421, "Declan", 3, 10.0, "Rice", 19 },
                    { 446, "Yerson", 2, 5.0, "Mosquera Valdelamar", 20 },
                    { 445, "Fabio", 4, 8.0, "Silva", 20 },
                    { 444, "Andreas", 1, 4.0, "Söndergaard", 20 },
                    { 443, "Ki-Jana", 2, 6.0, "Hoever", 20 },
                    { 442, "Owen", 3, 7.0, "Otasowie", 20 },
                    { 441, "Pedro", 3, 11.0, "Lomba Neto", 20 },
                    { 440, "Morgan", 3, 6.0, "Gibbs-White", 20 },
                    { 439, "Max", 2, 5.0, "Kilman", 20 },
                    { 438, "Daniel", 3, 9.0, "Castelo Podence", 20 },
                    { 437, "Nélson", 2, 6.0, "Cabral Semedo", 20 },
                    { 436, "Rúben Diogo", 3, 8.0, "da Silva Neves", 20 },
                    { 435, "Adama", 3, 7.0, "Traoré", 20 },
                    { 434, "Leander", 3, 8.0, "Dendoncker", 20 },
                    { 433, "Jonathan", 2, 6.0, "Castro Otto", 20 },
                    { 432, "Fernando", 2, 4.0, "Marçal", 20 },
                    { 431, "Romain", 2, 5.0, "Saïss", 20 },
                    { 430, "Raúl", 4, 10.0, "Jiménez", 20 },
                    { 429, "Conor", 2, 5.0, "Coady", 20 },
                    { 428, "Willy", 2, 6.0, "Boly", 20 },
                    { 427, "Rui Pedro", 1, 4.0, "dos Santos Patrício", 20 },
                    { 426, "João Filipe Iria", 3, 9.0, "Santos Moutinho", 20 },
                    { 425, "Ben", 2, 4.0, "Johnson", 19 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 424, "Issa", 2, 4.0, "Diop", 19 },
                    { 423, "Pablo", 3, 10.0, "Fornals", 19 },
                    { 422, "Tomas", 3, 5.0, "Soucek", 19 },
                    { 420, "Jarrod", 3, 6.0, "Bowen", 19 },
                    { 393, "Isaac", 4, 7.0, "Success Ajayi", 18 },
                    { 392, "Philip", 3, 9.0, "Zinckernagel", 18 },
                    { 391, "Ken", 3, 6.0, "Sema", 18 },
                    { 360, "Matt", 2, 6.0, "Doherty", 17 },
                    { 359, "Heung-Min", 3, 10.0, "Son", 17 },
                    { 358, "Serge", 2, 5.0, "Aurier", 17 },
                    { 357, "Harry", 4, 8.0, "Kane", 17 },
                    { 356, "Erik", 3, 7.0, "Lamela", 17 },
                    { 355, "Toby", 2, 5.0, "Alderweireld", 17 },
                    { 354, "Moussa", 3, 5.0, "Sissoko", 17 },
                    { 353, "Hugo", 1, 4.0, "Lloris", 17 },
                    { 352, "Joe", 1, 4.0, "Hart", 17 },
                    { 460, "Romain", 2, 4.0, "Perraud", 16 },
                    { 351, "Mohammed", 2, 6.0, "Salisu", 16 },
                    { 350, "Moussa", 3, 8.0, "Djenepo", 16 },
                    { 349, "Ibrahima", 3, 10.0, "Diallo", 16 },
                    { 348, "Michael", 4, 10.0, "Obafemi", 16 },
                    { 347, "William", 3, 7.0, "Smallbone", 16 },
                    { 346, "Nathan", 3, 6.0, "Tella", 16 },
                    { 345, "Che", 4, 11.0, "Adams", 16 },
                    { 344, "Daniel", 4, 8.0, "N'Lundulu", 16 },
                    { 343, "Jan", 2, 5.0, "Bednarek", 16 },
                    { 342, "Kyle", 2, 6.0, "Walker-Peters", 16 },
                    { 341, "James", 3, 8.0, "Ward-Prowse", 16 },
                    { 340, "Jannik", 2, 6.0, "Vestergaard", 16 },
                    { 339, "Stuart", 3, 5.0, "Armstrong", 16 },
                    { 338, "Jack", 2, 5.0, "Stephens", 16 },
                    { 337, "Danny", 4, 10.0, "Ings", 16 },
                    { 361, "Eric", 2, 4.0, "Dier", 17 },
                    { 362, "Lucas", 3, 7.0, "Rodrigues Moura da Silva", 17 },
                    { 363, "Bamidele", 3, 9.0, "Alli", 17 },
                    { 364, "Ben", 2, 5.0, "Davies", 17 },
                    { 390, "Adam", 2, 5.0, "Masina", 18 },
                    { 389, "Daniel", 1, 5.0, "Bachmann", 18 },
                    { 388, "Stipe", 4, 9.0, "Perica", 18 },
                    { 387, "William", 2, 6.0, "Troost-Ekong", 18 },
                    { 386, "Will", 3, 10.0, "Hughes", 18 },
                    { 385, "Nathaniel", 3, 9.0, "Chalobah", 18 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 384, "Christian", 2, 5.0, "Kabasele", 18 },
                    { 383, "Andre", 4, 10.0, "Gray", 18 },
                    { 382, "Francisco", 2, 4.0, "Femenía Far", 18 },
                    { 381, "Tom", 3, 9.0, "Cleverley", 18 },
                    { 380, "Troy", 4, 8.0, "Deeney", 18 },
                    { 379, "Craig", 2, 4.0, "Cathcart", 18 },
                    { 227, "Alex", 3, 6.0, "Oxlade-Chamberlain", 11 },
                    { 378, "Dan", 3, 7.0, "Gosling", 18 },
                    { 376, "Ben", 1, 4.0, "Foster", 18 },
                    { 375, "Tanguy", 3, 9.0, "Ndombele", 17 },
                    { 374, "Joe", 2, 5.0, "Rodon", 17 },
                    { 373, "Oliver", 3, 9.0, "Skipp", 17 },
                    { 372, "Giovani", 3, 7.0, "Lo Celso", 17 },
                    { 371, "Japhet", 2, 6.0, "Tanganga", 17 },
                    { 370, "Sergio", 2, 4.0, "Reguilón", 17 },
                    { 369, "Steven", 3, 11.0, "Bergwijn", 17 },
                    { 368, "Ryan", 2, 5.0, "Sessegnon", 17 },
                    { 367, "Davinson", 2, 6.0, "Sánchez", 17 },
                    { 366, "Harry", 3, 5.0, "Winks", 17 },
                    { 365, "Pierre-Emile", 3, 5.0, "Højbjerg", 17 },
                    { 377, "Danny", 2, 5.0, "Rose", 18 },
                    { 452, "John", 1, 5.0, "Ruddy", 20 },
                    { 226, "Xherdan", 3, 5.0, "Shaqiri", 11 },
                    { 224, "Joel", 2, 4.0, "Matip", 11 },
                    { 62, "Joël", 2, 6.0, "Veltman", 4 },
                    { 61, "Adam", 2, 4.0, "Webster", 4 },
                    { 60, "Solomon", 3, 6.0, "March", 4 },
                    { 59, "Lewis", 2, 4.0, "Dunk", 4 },
                    { 58, "Dan", 2, 4.0, "Burn", 4 },
                    { 57, "Davy", 3, 8.0, "Pröpper", 4 },
                    { 56, "Shane", 2, 5.0, "Duffy", 4 },
                    { 55, "Pascal", 3, 6.0, "Groß", 4 },
                    { 54, "Jason", 1, 5.0, "Steele", 4 },
                    { 53, "Adam", 3, 9.0, "Lallana", 4 },
                    { 97, "Mads", 3, 6.0, "Bidstrup", 3 },
                    { 96, "Bryan", 3, 9.0, "Mbeumo", 3 },
                    { 95, "Halil", 4, 8.0, "Dervişoğlu", 3 },
                    { 94, "Patrik", 1, 5.0, "Gunnarsson", 3 },
                    { 93, "Jan", 3, 8.0, "Zamburek", 3 },
                    { 92, "Ellery", 1, 6.0, "Balcombe", 3 },
                    { 91, "Ethan", 2, 5.0, "Pinnock", 3 },
                    { 90, "Mads", 2, 6.0, "Bech Sørensen", 3 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 89, "Mads", 2, 5.0, "Roerslev Rasmussen", 3 },
                    { 88, "Marcus", 4, 7.0, "Forss", 3 },
                    { 87, "Charlie", 2, 4.0, "Goode", 3 },
                    { 86, "Mathias", 3, 9.0, "Jensen", 3 },
                    { 85, "Saman", 3, 9.0, "Ghoddos", 3 },
                    { 84, "Vitaly", 3, 5.0, "Janelt", 3 },
                    { 83, "Rico", 2, 5.0, "Henry", 3 },
                    { 63, "Neal", 4, 10.0, "Maupay", 4 },
                    { 82, "Pelenda Joshua", 3, 6.0, "Dasilva", 3 },
                    { 64, "Leandro", 3, 8.0, "Trossard", 4 },
                    { 66, "Alireza", 3, 6.0, "Jahanbakhsh", 4 },
                    { 111, "Matej", 4, 11.0, "Vydra", 5 },
                    { 110, "Matthew", 2, 5.0, "Lowton", 5 },
                    { 109, "Chris", 4, 7.0, "Wood", 5 },
                    { 108, "Johann Berg", 3, 9.0, "Gudmundsson", 5 },
                    { 107, "Ashley", 3, 9.0, "Westwood", 5 },
                    { 106, "Ben", 2, 4.0, "Mee", 5 },
                    { 105, "Ashley", 4, 11.0, "Barnes", 5 },
                    { 104, "Jay", 4, 11.0, "Rodriguez", 5 },
                    { 103, "Kevin", 2, 4.0, "Long", 5 },
                    { 102, "Dale", 3, 6.0, "Stephens", 5 },
                    { 101, "Jack", 3, 6.0, "Cork", 5 },
                    { 100, "Erik", 2, 4.0, "Pieters", 5 },
                    { 99, "Phil", 2, 4.0, "Bardsley", 5 },
                    { 98, "James", 2, 5.0, "Tarkowski", 5 },
                    { 462, "Enock", 3, 9.0, "Mwepu", 4 },
                    { 447, "Danny", 4, 10.0, "Welbeck", 4 },
                    { 75, "Jakub", 3, 7.0, "Moder", 4 },
                    { 74, "Alexis", 3, 11.0, "Mac Allister", 4 },
                    { 73, "Steven", 3, 7.0, "Alzate", 4 },
                    { 72, "Aaron", 4, 11.0, "Connolly", 4 },
                    { 71, "Tariq", 2, 5.0, "Lamptey", 4 },
                    { 70, "Yves", 3, 6.0, "Bissouma", 4 },
                    { 69, "Robert", 1, 5.0, "Sánchez", 4 },
                    { 68, "Bernardo", 2, 4.0, "Fernandes Da Silva Junior", 4 },
                    { 67, "Ben", 2, 5.0, "White", 4 },
                    { 65, "Mathew", 1, 4.0, "Ryan", 4 },
                    { 112, "Nick", 1, 5.0, "Pope", 5 },
                    { 81, "Sergi", 3, 9.0, "Canós", 3 },
                    { 79, "Tariqe", 3, 9.0, "Fosu-Henry", 3 },
                    { 26, "Gabriel Teodoro", 3, 9.0, "Martinelli Silva", 1 },
                    { 25, "Mattéo", 3, 10.0, "Guendouzi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 24, "Konstantinos", 2, 4.0, "Mavropanos", 1 },
                    { 23, "Gabriel", 2, 6.0, "Magalhães", 1 },
                    { 22, "Bukayo", 3, 9.0, "Saka", 1 },
                    { 21, "Emile", 3, 11.0, "Smith Rowe", 1 },
                    { 20, "Edward", 4, 10.0, "Nketiah", 1 },
                    { 19, "Joseph", 3, 6.0, "Willock", 1 },
                    { 18, "Lucas", 3, 8.0, "Torreira", 1 },
                    { 17, "Nicolas", 3, 7.0, "Pépé", 1 },
                    { 16, "Kieran", 2, 6.0, "Tierney", 1 },
                    { 15, "Thomas", 3, 11.0, "Partey", 1 },
                    { 14, "Rob", 2, 4.0, "Holding", 1 },
                    { 13, "Ainsley", 3, 9.0, "Maitland-Niles", 1 },
                    { 12, "Mohamed Naser", 3, 6.0, "El Sayed Elneny", 1 },
                    { 11, "Sead", 2, 6.0, "Kolasinac", 1 },
                    { 10, "Calum", 2, 6.0, "Chambers", 1 },
                    { 9, "Héctor", 2, 6.0, "Bellerín", 1 },
                    { 8, "Pablo", 2, 6.0, "Marí", 1 },
                    { 7, "Granit", 3, 7.0, "Xhaka", 1 },
                    { 6, "Alexandre", 4, 7.0, "Lacazette", 1 },
                    { 5, "Cédric", 2, 5.0, "Soares", 1 },
                    { 4, "Pierre-Emerick", 4, 8.0, "Aubameyang", 1 },
                    { 3, "Willian", 3, 11.0, "Borges Da Silva", 1 },
                    { 2, "Rúnar Alex", 1, 5.0, "Rúnarsson", 1 },
                    { 27, "William", 2, 6.0, "Saliba", 1 },
                    { 80, "David", 1, 4.0, "Raya Martin", 3 },
                    { 28, "Jed", 1, 5.0, "Steer", 2 },
                    { 30, "Emiliano", 1, 5.0, "Martínez", 2 },
                    { 78, "Ivan", 4, 8.0, "Toney", 3 },
                    { 77, "Christian", 3, 9.0, "Nørgaard", 3 },
                    { 76, "Pontus", 2, 5.0, "Jansson", 3 },
                    { 52, "Ashley", 2, 6.0, "Young", 2 },
                    { 51, "Jacob", 3, 7.0, "Ramsey", 2 },
                    { 50, "Douglas Luiz", 3, 11.0, "Soares de Paulo", 2 },
                    { 49, "Keinan", 4, 7.0, "Davis", 2 },
                    { 48, "Mbwana Ally", 4, 8.0, "Samatta", 2 },
                    { 47, "Wesley", 4, 7.0, "Moraes", 2 },
                    { 46, "Frédéric", 2, 4.0, "Guilbert", 2 },
                    { 45, "Ezri", 2, 4.0, "Konsa Ngoyo", 2 },
                    { 44, "Matthew", 2, 4.0, "Cash", 2 },
                    { 43, "Emiliano", 3, 6.0, "Buendía Stati", 2 },
                    { 42, "Anwar", 3, 7.0, "El Ghazi", 2 },
                    { 41, "Marvelous", 3, 10.0, "Nakamba", 2 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 40, "Ollie", 4, 10.0, "Watkins", 2 },
                    { 39, "Matt", 2, 5.0, "Targett", 2 },
                    { 38, "Tyrone", 2, 6.0, "Mings", 2 },
                    { 37, "Mahmoud Ahmed", 3, 6.0, "Ibrahim Hassan", 2 },
                    { 36, "Kortney", 2, 4.0, "Hause", 2 },
                    { 35, "John", 3, 5.0, "McGinn", 2 },
                    { 34, "Morgan", 3, 11.0, "Sanson", 2 },
                    { 33, "Jack", 3, 6.0, "Grealish", 2 },
                    { 32, "Bertrand", 3, 6.0, "Traoré", 2 },
                    { 31, "Björn", 2, 5.0, "Engels", 2 },
                    { 29, "Conor", 3, 5.0, "Hourihane", 2 },
                    { 113, "Charlie", 2, 6.0, "Taylor", 5 },
                    { 114, "Will", 1, 5.0, "Norris", 5 },
                    { 115, "Josh", 3, 6.0, "Brownhill", 5 },
                    { 216, "Wilfred", 3, 6.0, "Ndidi", 9 },
                    { 215, "Harvey", 3, 11.0, "Barnes", 9 },
                    { 214, "Hamza", 3, 9.0, "Choudhury", 9 },
                    { 213, "Kelechi", 4, 7.0, "Iheanacho", 9 },
                    { 212, "James", 3, 8.0, "Maddison", 9 },
                    { 211, "Ayoze", 3, 11.0, "Pérez", 9 },
                    { 210, "Youri", 3, 7.0, "Tielemans", 9 },
                    { 209, "Timothy", 2, 5.0, "Castagne", 9 },
                    { 208, "Daniel", 2, 4.0, "Amartey", 9 },
                    { 207, "Ricardo Domingos", 2, 4.0, "Barbosa Pereira", 9 },
                    { 206, "Dennis", 3, 7.0, "Praet", 9 },
                    { 205, "Jamie", 4, 11.0, "Vardy", 9 },
                    { 204, "Danny", 1, 4.0, "Ward", 9 },
                    { 203, "Nampalys", 3, 7.0, "Mendy", 9 },
                    { 202, "Marc", 3, 8.0, "Albrighton", 9 },
                    { 201, "Jonny", 2, 6.0, "Evans", 9 },
                    { 200, "Kasper", 1, 6.0, "Schmeichel", 9 },
                    { 181, "João", 1, 6.0, "Virgínia", 8 },
                    { 180, "Richarlison", 4, 9.0, "de Andrade", 8 },
                    { 179, "Ben", 2, 5.0, "Godfrey", 8 },
                    { 178, "Mason", 2, 5.0, "Holgate", 8 },
                    { 177, "Dominic", 4, 8.0, "Calvert-Lewin", 8 },
                    { 176, "Tom", 3, 7.0, "Davies", 8 },
                    { 175, "Yerry", 2, 4.0, "Mina", 8 },
                    { 174, "Alex", 3, 10.0, "Iwobi", 8 },
                    { 217, "Çaglar", 2, 4.0, "Söyüncü", 9 },
                    { 173, "Abdoulaye", 3, 10.0, "Doucouré", 8 },
                    { 218, "James", 2, 6.0, "Justin", 9 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 220, "Wesley", 2, 6.0, "Fofana", 9 },
                    { 223, "Adrián", 1, 5.0, "San Miguel del Castillo", 11 },
                    { 222, "Jordan", 3, 8.0, "Henderson", 11 },
                    { 221, "James", 3, 11.0, "Milner", 11 },
                    { 463, "Héctor Junior", 2, 6.0, "Firpo Adames", 10 },
                    { 267, "Jack", 3, 5.0, "Harrison", 10 },
                    { 199, "Illan", 1, 4.0, "Meslier", 10 },
                    { 198, "Pascal", 2, 5.0, "Struijk", 10 },
                    { 197, "Jamie", 3, 6.0, "Shackleton", 10 },
                    { 196, "Raphael", 3, 11.0, "Dias Belloli", 10 },
                    { 195, "Ian Carlo", 3, 11.0, "Poveda-Ocampo", 10 },
                    { 194, "Robin", 2, 5.0, "Koch", 10 },
                    { 193, "Tyler", 3, 9.0, "Roberts", 10 },
                    { 192, "Hélder Wander", 3, 5.0, "Sousa de Azevedo e Costa", 10 },
                    { 191, "Kalvin", 3, 7.0, "Phillips", 10 },
                    { 190, "Diego", 2, 4.0, "Llorente", 10 },
                    { 189, "Patrick", 4, 11.0, "Bamford", 10 },
                    { 188, "Stuart", 3, 9.0, "Dallas", 10 },
                    { 187, "Rodrigo", 4, 10.0, "Moreno", 10 },
                    { 186, "Mateusz", 3, 10.0, "Klich", 10 },
                    { 185, "Luke", 2, 5.0, "Ayling", 10 },
                    { 184, "Liam", 2, 4.0, "Cooper", 10 },
                    { 183, "Francisco", 1, 6.0, "Casilla Cortés", 10 },
                    { 182, "Pablo", 3, 5.0, "Hernández Domínguez", 10 },
                    { 458, "Boubakary", 3, 10.0, "Soumaré", 9 },
                    { 455, "Patson", 4, 10.0, "Daka", 9 },
                    { 219, "Luke", 2, 5.0, "Thomas", 9 },
                    { 172, "André Filipe", 3, 10.0, "Tavares Gomes", 8 },
                    { 171, "Allan", 3, 5.0, "Marques Loureiro", 8 },
                    { 170, "Jordan", 1, 5.0, "Pickford", 8 },
                    { 139, "Ethan", 2, 6.0, "Ampadu", 6 },
                    { 138, "Mason", 3, 7.0, "Mount", 6 },
                    { 137, "Christian", 3, 9.0, "Pulisic", 6 },
                    { 136, "Tammy", 4, 9.0, "Abraham", 6 },
                    { 135, "Benjamin", 2, 6.0, "Chilwell", 6 },
                    { 134, "Timo", 4, 11.0, "Werner", 6 },
                    { 133, "Andreas", 2, 6.0, "Christensen", 6 },
                    { 132, "Ruben", 3, 10.0, "Loftus-Cheek", 6 },
                    { 131, "Hakim", 3, 10.0, "Ziyech", 6 },
                    { 130, "N'Golo", 3, 9.0, "Kanté", 6 },
                    { 129, "Kepa", 1, 4.0, "Arrizabalaga", 6 },
                    { 128, "Kurt", 2, 6.0, "Zouma", 6 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[,]
                {
                    { 127, "Antonio", 2, 5.0, "Rüdiger", 6 },
                    { 126, "Michy", 4, 10.0, "Batshuayi", 6 },
                    { 125, "Mateo", 3, 8.0, "Kovacic", 6 },
                    { 124, "Ross", 3, 8.0, "Barkley", 6 },
                    { 123, "Jorge Luiz", 3, 11.0, "Frello Filho", 6 },
                    { 122, "Marcos", 2, 5.0, "Alonso", 6 },
                    { 121, "Thiago", 2, 5.0, "Thiago", 6 },
                    { 120, "Olivier", 4, 11.0, "Giroud", 6 },
                    { 119, "César", 2, 4.0, "Azpilicueta", 6 },
                    { 451, "Nathan", 2, 4.0, "Collins", 5 },
                    { 118, "Dwight", 3, 7.0, "McNeil", 5 },
                    { 117, "Bailey", 1, 4.0, "Peacock-Farrell", 5 },
                    { 116, "Josh", 3, 8.0, "Benson", 5 },
                    { 140, "Callum", 3, 7.0, "Hudson-Odoi", 6 },
                    { 141, "Kai", 3, 8.0, "Havertz", 6 },
                    { 142, "Reece", 2, 6.0, "James", 6 },
                    { 143, "Edouard", 1, 6.0, "Mendy", 6 },
                    { 169, "Michael", 2, 4.0, "Keane", 8 },
                    { 168, "Lucas", 2, 5.0, "Digne", 8 },
                    { 167, "Bernard", 3, 10.0, "Anício Caldeira Duarte", 8 },
                    { 166, "James", 3, 8.0, "Rodríguez", 8 },
                    { 165, "Seamus", 2, 6.0, "Coleman", 8 },
                    { 164, "Gylfi", 3, 8.0, "Sigurdsson", 8 },
                    { 163, "Fabian", 3, 9.0, "Delph", 8 },
                    { 464, "Michael", 3, 9.0, "Olise", 7 },
                    { 162, "Tyrick", 2, 6.0, "Mitchell", 7 },
                    { 161, "Nathan", 2, 4.0, "Ferguson", 7 },
                    { 160, "Eberechi", 3, 5.0, "Eze", 7 },
                    { 159, "Jean-Philippe", 4, 7.0, "Mateta", 7 },
                    { 225, "Thiago", 3, 7.0, "Alcántara do Nascimento", 11 },
                    { 158, "Jarosław", 2, 6.0, "Jach", 7 },
                    { 156, "Jack", 1, 5.0, "Butland", 7 },
                    { 155, "Jeffrey", 3, 5.0, "Schlupp", 7 },
                    { 154, "Wilfried", 3, 9.0, "Zaha", 7 },
                    { 153, "Jordan", 4, 7.0, "Ayew", 7 },
                    { 152, "Luka", 3, 11.0, "Milivojevic", 7 },
                    { 151, "Martin", 2, 5.0, "Kelly", 7 },
                    { 150, "Cheikhou", 2, 5.0, "Kouyaté", 7 },
                    { 149, "Christian", 4, 8.0, "Benteke", 7 },
                    { 148, "James", 3, 8.0, "McArthur", 7 },
                    { 147, "James", 2, 6.0, "Tomkins", 7 },
                    { 146, "Vicente", 1, 5.0, "Guaita", 7 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[] { 144, "Conor", 3, 5.0, "Gallagher", 6 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[] { 157, "Jairo", 3, 7.0, "Riedewald", 7 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "Position", "Price", "Surname", "TeamID" },
                values: new object[] { 461, "Francisco", 3, 11.0, "Machado Mota de Castro Trincão", 20 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_AwayID",
                table: "Games",
                column: "AwayID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeID",
                table: "Games",
                column: "HomeID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGameStatistics_GameId",
                table: "PlayerGameStatistics",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamID",
                table: "Players",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSquad_SquadsSquadId_SquadsUserId",
                table: "PlayerSquad",
                columns: new[] { "SquadsSquadId", "SquadsUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Squads_UserId",
                table: "Squads",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerGameStatistics");

            migrationBuilder.DropTable(
                name: "PlayerSquad");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
