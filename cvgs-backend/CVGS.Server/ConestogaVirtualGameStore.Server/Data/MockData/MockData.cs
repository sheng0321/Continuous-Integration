using ConestogaVirtualGameStore.Server.Data.Enums;
using ConestogaVirtualGameStore.Server.Data.Models;

namespace ConestogaVirtualGameStore.Server.Data.MockData
{
    public static class MockData
    {
        public static List<CvgsEvent> GetMockEvents()
        {
            return new List<CvgsEvent>
         {
            new CvgsEvent
            {
                Id = Guid.NewGuid(),
                EventName = "Tech Conference 2024",
                EventDescription = "A conference about the latest in technology.",
                EventDateTime = DateTime.Now.AddDays(10),
                UpdateTime = DateTime.Now
            },
            new CvgsEvent
            {
                Id = Guid.NewGuid(),
                EventName = "Gaming Expo",
                EventDescription = "An expo showcasing the latest in gaming.",
                EventDateTime = DateTime.Now.AddDays(20),
                UpdateTime = DateTime.Now
            },
            new CvgsEvent
            {
                Id = Guid.NewGuid(),
                EventName = "AI Workshop",
                EventDescription = "A workshop on artificial intelligence and machine learning.",
                EventDateTime = DateTime.Now.AddDays(30),
                UpdateTime = DateTime.Now
            },
            new CvgsEvent
            {
                Id = Guid.NewGuid(),
                EventName = "Cybersecurity Summit",
                EventDescription = "A summit discussing the latest in cybersecurity.",
                EventDateTime = DateTime.Now.AddDays(40),
                UpdateTime = DateTime.Now
            },
            new CvgsEvent
            {
                Id = Guid.NewGuid(),
                EventName = "Cloud Computing Meetup",
                EventDescription = "A meetup for cloud computing enthusiasts.",
                EventDateTime = DateTime.Now.AddDays(50),
                UpdateTime = DateTime.Now
            }
            };
        }

        public static readonly Guid ActionCategoryId = Guid.NewGuid();
        public static readonly Guid AdventureCategoryId = Guid.NewGuid();
        public static readonly Guid RpgCategoryId = Guid.NewGuid();
        public static readonly Guid SimulationCategoryId = Guid.NewGuid();
        public static readonly Guid StrategyCategoryId = Guid.NewGuid();
        public static readonly Guid SportsCategoryId = Guid.NewGuid();
        public static readonly Guid PuzzleCategoryId = Guid.NewGuid();
        public static readonly Guid HorrorCategoryId = Guid.NewGuid();
        public static readonly Guid RacingCategoryId = Guid.NewGuid();
        public static readonly Guid FightingCategoryId = Guid.NewGuid();

        public static List<GameCategory> GetGameCategories()
        {
            return new List<GameCategory>
            {
                new GameCategory { Id = ActionCategoryId, Name = "Action" },
                new GameCategory { Id = AdventureCategoryId, Name = "Adventure" },
                new GameCategory { Id = RpgCategoryId, Name = "RPG" },
                new GameCategory { Id = SimulationCategoryId, Name = "Simulation" },
                new GameCategory { Id = StrategyCategoryId, Name = "Strategy" },
                new GameCategory { Id = SportsCategoryId, Name = "Sport" },
                new GameCategory { Id = PuzzleCategoryId, Name = "Puzzle" },
                new GameCategory { Id = HorrorCategoryId, Name = "Horror" },
                new GameCategory { Id = RacingCategoryId, Name = "Racing" },
                new GameCategory { Id = FightingCategoryId, Name = "Fighting" }
            };
        }

        public static List<Game> GetGames()
        {
            return new List<Game>
            {
                // Action Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Call of Duty: Modern Warfare",
                    Overview = "A first-person shooter game with intense multiplayer action.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 49.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Doom Eternal",
                    Overview = "A fast-paced first-person shooter with intense gameplay.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 39.99M,
                    GamesInStock = 10,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Far Cry 5",
                    Overview = "An action-adventure first-person shooter game set in an open world.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 44.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Assassin’s Creed Valhalla",
                    Overview = "An open-world action RPG set in Viking-era Norway and England.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 59.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Gears 5",
                    Overview = "A third-person shooter game with a gripping storyline.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 39.99M,
                    GamesInStock = 12,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Halo Infinite",
                    Overview = "The latest installment in the popular Halo series with intense action gameplay.",
                    ThumbnailPath = null,
                    GameCategoryId = ActionCategoryId,
                    Price = 59.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Adventure Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Legend of Zelda: Breath of the Wild",
                    Overview = "An open-world adventure game set in the kingdom of Hyrule.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 59.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Uncharted 4: A Thief's End",
                    Overview = "An action-adventure game following the treasure-hunting adventures of Nathan Drake.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 39.99M,
                    GamesInStock = 12,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Red Dead Redemption 2",
                    Overview = "An epic tale of life in America’s unforgiving heartland.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 49.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Tomb Raider",
                    Overview = "The origin story of Lara Croft as she becomes the Tomb Raider.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 29.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Horizon Zero Dawn",
                    Overview = "A post-apocalyptic adventure game where players battle robotic creatures.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 39.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Witcher 3: Wild Hunt",
                    Overview = "An open-world fantasy RPG with a rich storyline and complex characters.",
                    ThumbnailPath = null,
                    GameCategoryId = AdventureCategoryId,
                    Price = 44.99M,
                    GamesInStock = 10,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // RPG Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Final Fantasy XV",
                    Overview = "An epic RPG with a rich storyline and immersive world.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 49.99M,
                    GamesInStock = 12,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Elder Scrolls V: Skyrim",
                    Overview = "An open-world RPG set in the fantasy land of Tamriel.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 39.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Cyberpunk 2077",
                    Overview = "An RPG set in a dystopian future with immersive open-world gameplay.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 59.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Persona 5",
                    Overview = "A stylish RPG that follows high school students with secret supernatural abilities.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 29.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Dragon Age: Inquisition",
                    Overview = "An RPG set in a rich fantasy world with strategic combat.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 34.99M,
                    GamesInStock = 14,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Mass Effect 2",
                    Overview = "A sci-fi RPG with an engaging storyline and moral choices.",
                    ThumbnailPath = null,
                    GameCategoryId = RpgCategoryId,
                    Price = 24.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Simulation Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Sims 4",
                    Overview = "A life simulation game where you can create and control people.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 39.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Cities: Skylines",
                    Overview = "A city-building simulation game where you design and manage a city.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 29.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Planet Zoo",
                    Overview = "A zoo management simulation game where you build and run a zoo.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 44.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Microsoft Flight Simulator",
                    Overview = "A flight simulation game with realistic aircraft and world modeling.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 59.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Farming Simulator 22",
                    Overview = "A simulation game where you manage a farm with realistic machinery.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 39.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Two Point Hospital",
                    Overview = "A hospital management simulation game with humor and strategic depth.",
                    ThumbnailPath = null,
                    GameCategoryId = SimulationCategoryId,
                    Price = 34.99M,
                    GamesInStock = 16,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Strategy Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Civilization VI",
                    Overview = "A turn-based strategy game where you build and expand an empire.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 29.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Starcraft II",
                    Overview = "A real-time strategy game with futuristic warfare and intense battles.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 24.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "XCOM 2",
                    Overview = "A turn-based strategy game where players defend Earth from alien invasion.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 34.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Total War: Three Kingdoms",
                    Overview = "A grand strategy game set in ancient China during the Three Kingdoms period.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 49.99M,
                    GamesInStock = 12,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Age of Empires II: Definitive Edition",
                    Overview = "A real-time strategy game that lets players build and battle in historical settings.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 19.99M,
                    GamesInStock = 30,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Company of Heroes 2",
                    Overview = "A WWII real-time strategy game focusing on squad-based tactics.",
                    ThumbnailPath = null,
                    GameCategoryId = StrategyCategoryId,
                    Price = 29.99M,
                    GamesInStock = 14,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Sports Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "FIFA 24",
                    Overview = "A football simulation game with realistic gameplay.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 59.99M,
                    GamesInStock = 30,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "NBA 2K24",
                    Overview = "A basketball simulation game with updated rosters and gameplay improvements.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 49.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Madden NFL 24",
                    Overview = "A football simulation game featuring the NFL teams and players.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 59.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "MLB The Show 23",
                    Overview = "A baseball simulation game with realistic graphics and gameplay.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 39.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Tony Hawk's Pro Skater 1 + 2",
                    Overview = "A skateboarding game featuring iconic locations and tricks.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 29.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "WWE 2K23",
                    Overview = "A professional wrestling simulation game with realistic moves and characters.",
                    ThumbnailPath = null,
                    GameCategoryId = SportsCategoryId,
                    Price = 49.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Puzzle Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Tetris Effect",
                    Overview = "A mesmerizing puzzle game with stunning visuals and music.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 29.99M,
                    GamesInStock = 30,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Portal 2",
                    Overview = "A physics-based puzzle game with mind-bending challenges.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 19.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Witness",
                    Overview = "An open-world puzzle game with complex and visually engaging challenges.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 39.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Baba Is You",
                    Overview = "A unique puzzle game where you manipulate rules to solve puzzles.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 14.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Candy Crush Saga",
                    Overview = "A popular match-three puzzle game with hundreds of challenging levels.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 0.99M,
                    GamesInStock = 50,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Monument Valley",
                    Overview = "A visually stunning puzzle game with impossible architecture and optical illusions.",
                    ThumbnailPath = null,
                    GameCategoryId = PuzzleCategoryId,
                    Price = 9.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Horror Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Resident Evil Village",
                    Overview = "A survival horror game with a gripping storyline.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 59.99M,
                    GamesInStock = 10,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Silent Hill 2",
                    Overview = "A classic horror game known for its psychological elements and atmosphere.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 39.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Outlast",
                    Overview = "A first-person horror game where you explore an abandoned asylum.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 19.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Amnesia: The Dark Descent",
                    Overview = "A survival horror game that emphasizes hiding over fighting.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 14.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "The Evil Within",
                    Overview = "A horror game with intense combat and a chilling story.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 29.99M,
                    GamesInStock = 12,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Alien: Isolation",
                    Overview = "A horror game where you evade an alien on a deserted space station.",
                    ThumbnailPath = null,
                    GameCategoryId = HorrorCategoryId,
                    Price = 24.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Racing Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Need for Speed: Heat",
                    Overview = "A high-octane racing game with customizable cars.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 39.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Forza Horizon 4",
                    Overview = "An open-world racing game set in a dynamic environment.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 49.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Gran Turismo Sport",
                    Overview = "A racing simulator with realistic graphics and physics.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 29.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Mario Kart 8 Deluxe",
                    Overview = "A fun and fast-paced kart racing game with iconic Nintendo characters.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 59.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "F1 2021",
                    Overview = "An official Formula 1 racing simulation game with realistic graphics.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 39.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Dirt Rally 2.0",
                    Overview = "A rally racing game with challenging tracks and realistic driving physics.",
                    ThumbnailPath = null,
                    GameCategoryId = RacingCategoryId,
                    Price = 34.99M,
                    GamesInStock = 17,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },

                // Fighting Category
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Street Fighter V",
                    Overview = "A classic fighting game with a roster of diverse characters.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 19.99M,
                    GamesInStock = 25,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Mortal Kombat 11",
                    Overview = "A brutal and action-packed fighting game with iconic characters.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 29.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Tekken 7",
                    Overview = "A popular fighting game with deep combat mechanics and diverse characters.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 24.99M,
                    GamesInStock = 18,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Dragon Ball FighterZ",
                    Overview = "An anime-style fighting game featuring characters from the Dragon Ball series.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 34.99M,
                    GamesInStock = 22,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Injustice 2",
                    Overview = "A superhero fighting game featuring characters from the DC Universe.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 39.99M,
                    GamesInStock = 15,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                },
                new Game
                {
                    Id = Guid.NewGuid(),
                    GameName = "Soulcalibur VI",
                    Overview = "A weapon-based fighting game with unique characters and combat styles.",
                    ThumbnailPath = null,
                    GameCategoryId = FightingCategoryId,
                    Price = 29.99M,
                    GamesInStock = 20,
                    IsDelete = false,
                    UpdateTime = DateTime.Now
                }
            };
        }

        // Seeding FavoritePlatform data
        public static List<FavoritePlatform> GetMockPlatforms()
        {
            return new List<FavoritePlatform>
            {
                new FavoritePlatform { Id = Guid.NewGuid(), Name = "PC" },
                new FavoritePlatform { Id = Guid.NewGuid(), Name = "PlayStation" },
                new FavoritePlatform { Id = Guid.NewGuid(), Name = "Xbox" },
                new FavoritePlatform { Id = Guid.NewGuid(), Name = "Nintendo Switch" },
                new FavoritePlatform { Id = Guid.NewGuid(), Name = "Mobile" }
            };
        }

        // Seeding Language data
        public static List<Language> GetMockLanguages()
        {
            return new List<Language>
            {
                new Language { Id = Guid.NewGuid(), Name = "English" },
                new Language { Id = Guid.NewGuid(), Name = "Spanish" },
                new Language { Id = Guid.NewGuid(), Name = "French" },
                new Language { Id = Guid.NewGuid(), Name = "German" },
                new Language { Id = Guid.NewGuid(), Name = "Japanese" }
            };
        }
    }
}
        

    
