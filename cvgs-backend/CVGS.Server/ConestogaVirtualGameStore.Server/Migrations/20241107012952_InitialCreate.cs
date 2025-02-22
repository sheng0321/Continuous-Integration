using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConestogaVirtualGameStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CvgsEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvgsEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePlatform",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePlatform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthOfDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsReceivePromotionalEmails = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GamesInStock = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_GameCategories_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberPreference",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FavoritePlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GameCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberPreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberPreference_FavoritePlatform_FavoritePlatformId",
                        column: x => x.FavoritePlatformId,
                        principalTable: "FavoritePlatform",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MemberPreference_GameCategories_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberPreference_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AptSuite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_UserProfiles_MemberID",
                        column: x => x.MemberID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "EventRegisters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRegisters_CvgsEvents_EventId",
                        column: x => x.EventId,
                        principalTable: "CvgsEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRegisters_UserProfiles_MemberId",
                        column: x => x.MemberId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_UserProfiles_MemberID",
                        column: x => x.MemberID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    WishListID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.WishListID);
                    table.ForeignKey(
                        name: "FK_WishLists_UserProfiles_MemberID",
                        column: x => x.MemberID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "GameReviews",
                columns: table => new
                {
                    ReviewID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameReviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_GameReviews_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameReviews_UserProfiles_MemberID",
                        column: x => x.MemberID,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.GameID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CvgsEvents",
                columns: new[] { "Id", "EventDateTime", "EventDescription", "EventName", "IsDeleted", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("06dc607a-a32a-4576-ba42-fc0501ba46c9"), new DateTime(2024, 12, 26, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4559), "A meetup for cloud computing enthusiasts.", "Cloud Computing Meetup", false, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4561) },
                    { new Guid("38c580f8-f43f-4d01-abde-00dc37baacc7"), new DateTime(2024, 12, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4537), "A workshop on artificial intelligence and machine learning.", "AI Workshop", false, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4539) },
                    { new Guid("85d69f5b-68db-40ba-9f69-011572ab93bb"), new DateTime(2024, 12, 16, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4544), "A summit discussing the latest in cybersecurity.", "Cybersecurity Summit", false, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4545) },
                    { new Guid("a7d33357-c975-4676-9470-8a17c3f145d8"), new DateTime(2024, 11, 16, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4451), "A conference about the latest in technology.", "Tech Conference 2024", false, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4514) },
                    { new Guid("d6fa8e2e-98c5-42e6-adb8-bbf5cb4c0b14"), new DateTime(2024, 11, 26, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4524), "An expo showcasing the latest in gaming.", "Gaming Expo", false, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4527) }
                });

            migrationBuilder.InsertData(
                table: "FavoritePlatform",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09b5cafe-d0bf-4ccf-b4a0-fdff5e4f570f"), "Nintendo Switch" },
                    { new Guid("60e5e8d5-c9c6-4eeb-a701-427f51eb5c8a"), "PC" },
                    { new Guid("b9052b74-0303-48d5-ab14-bfbf6d3e749a"), "Xbox" },
                    { new Guid("c8c80c67-b340-4570-bac4-15f8d792982f"), "PlayStation" },
                    { new Guid("d354dfc6-6f69-4c57-b8d4-56dc6bb474a6"), "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Puzzle" },
                    { new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Fighting" },
                    { new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Simulation" },
                    { new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Adventure" },
                    { new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Action" },
                    { new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Racing" },
                    { new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Strategy" },
                    { new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "RPG" },
                    { new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "Sport" },
                    { new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2acd6855-a685-4818-9073-32283d1089c0"), "Spanish" },
                    { new Guid("6c358b17-83ce-4f28-825c-ea7f5f921b08"), "Japanese" },
                    { new Guid("70d7bd8b-aa95-4d42-8e48-d958ef9c5b30"), "French" },
                    { new Guid("7d9561d2-133f-4c3f-a6b2-9b52d1228df6"), "English" },
                    { new Guid("c4350b26-3908-4030-84b4-2c187bac8412"), "German" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameCategoryId", "GameName", "GamesInStock", "IsDelete", "Overview", "Price", "ThumbnailPath", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("01257f62-597d-4ec3-bc4d-fe6972579b45"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Dragon Age: Inquisition", 14, false, "An RPG set in a rich fantasy world with strategic combat.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4999) },
                    { new Guid("0146bfa6-f721-49b4-ba2e-aeff3ad13a78"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Mass Effect 2", 22, false, "A sci-fi RPG with an engaging storyline and moral choices.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5518) },
                    { new Guid("085a941a-1e69-4784-9b3a-709e65637bf4"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Age of Empires II: Definitive Edition", 30, false, "A real-time strategy game that lets players build and battle in historical settings.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5073) },
                    { new Guid("0ac4a728-b286-472f-814b-a58208bc4707"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Dragon Ball FighterZ", 22, false, "An anime-style fighting game featuring characters from the Dragon Ball series.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5275) },
                    { new Guid("0ddc8550-da25-4bf4-b948-b7f88612aa21"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Alien: Isolation", 18, false, "A horror game where you evade an alien on a deserted space station.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5682) },
                    { new Guid("0e20b1be-f5d0-4ec6-bea4-1a74f0570d36"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Amnesia: The Dark Descent", 25, false, "A survival horror game that emphasizes hiding over fighting.", 14.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5671) },
                    { new Guid("10e59fd6-9dc7-40a1-a741-b346e82d1177"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "The Evil Within", 12, false, "A horror game with intense combat and a chilling story.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5201) },
                    { new Guid("132167e7-68c5-4a1f-96cc-86ed8c7e5013"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "XCOM 2", 15, false, "A turn-based strategy game where players defend Earth from alien invasion.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5061) },
                    { new Guid("158433cf-38d8-493c-a1ce-270b6f5d5c86"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Starcraft II", 20, false, "A real-time strategy game with futuristic warfare and intense battles.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5055) },
                    { new Guid("174c7e26-7c1d-4073-a058-302fa6cd3599"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Uncharted 4: A Thief's End", 12, false, "An action-adventure game following the treasure-hunting adventures of Nathan Drake.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4946) },
                    { new Guid("17de9734-5d9b-409a-8f63-ff297409ca2d"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Soulcalibur VI", 20, false, "A weapon-based fighting game with unique characters and combat styles.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5741) },
                    { new Guid("190f227a-3616-4cdf-bc33-ccfe6fa38d44"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Red Dead Redemption 2", 20, false, "An epic tale of life in America’s unforgiving heartland.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5465) },
                    { new Guid("19316a84-a5f9-4c3e-bbd1-3e52ec9bccac"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Civilization VI", 18, false, "A turn-based strategy game where you build and expand an empire.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5555) },
                    { new Guid("199a5484-917f-465f-982a-1f6837b4e9c3"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Resident Evil Village", 10, false, "A survival horror game with a gripping storyline.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5178) },
                    { new Guid("1b7fe563-27b8-4c4d-b625-20965f9f27bb"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Soulcalibur VI", 20, false, "A weapon-based fighting game with unique characters and combat styles.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5290) },
                    { new Guid("1c5431f6-cff0-49f9-b323-c1625dc42d44"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Silent Hill 2", 15, false, "A classic horror game known for its psychological elements and atmosphere.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5661) },
                    { new Guid("1e70d134-d909-4053-8a37-7b594f463196"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Baba Is You", 25, false, "A unique puzzle game where you manipulate rules to solve puzzles.", 14.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5155) },
                    { new Guid("201a8c95-fc7a-4247-9614-5edf429315dc"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Outlast", 20, false, "A first-person horror game where you explore an abandoned asylum.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5666) },
                    { new Guid("20f3a088-065c-4d73-bca5-9d4eb6fe18f9"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Assassin’s Creed Valhalla", 18, false, "An open-world action RPG set in Viking-era Norway and England.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5437) },
                    { new Guid("228f6c82-74e7-48a7-8ccd-b10f35211777"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Injustice 2", 15, false, "A superhero fighting game featuring characters from the DC Universe.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5281) },
                    { new Guid("27acc786-f475-4d87-8cb6-790bb1b890cc"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Gears 5", 12, false, "A third-person shooter game with a gripping storyline.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5442) },
                    { new Guid("2846792e-48eb-4f1d-aae4-7994096606b5"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Doom Eternal", 10, false, "A fast-paced first-person shooter with intense gameplay.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5423) },
                    { new Guid("28f1f5ca-1871-4b1d-9029-bc85c6bfd7d1"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Silent Hill 2", 15, false, "A classic horror game known for its psychological elements and atmosphere.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5183) },
                    { new Guid("2ac90553-66a6-4c96-bcc8-dc117e22ade8"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Street Fighter V", 25, false, "A classic fighting game with a roster of diverse characters.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5716) },
                    { new Guid("2af84878-1272-4f25-9da7-bad66e8caa1f"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Planet Zoo", 20, false, "A zoo management simulation game where you build and run a zoo.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5535) },
                    { new Guid("2e9d2e7e-6734-4842-b378-687bd23251af"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Two Point Hospital", 16, false, "A hospital management simulation game with humor and strategic depth.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5044) },
                    { new Guid("2f85d694-0b45-48ee-94cd-db391bf2acd5"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Candy Crush Saga", 50, false, "A popular match-three puzzle game with hundreds of challenging levels.", 0.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5644) },
                    { new Guid("3031b64b-e42c-4772-9e79-ad8b7f2a4bd9"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "The Elder Scrolls V: Skyrim", 20, false, "An open-world RPG set in the fantasy land of Tamriel.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5497) },
                    { new Guid("332ffafa-9000-43bc-9b7a-66ab133e5e11"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Halo Infinite", 22, false, "The latest installment in the popular Halo series with intense action gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5450) },
                    { new Guid("357c5865-b1e4-4d24-9a45-7c92f78b6c0b"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Portal 2", 20, false, "A physics-based puzzle game with mind-bending challenges.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5140) },
                    { new Guid("365efae8-b781-4a3f-8bba-35a1859fa9cd"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Call of Duty: Modern Warfare", 20, false, "A first-person shooter game with intense multiplayer action.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5417) },
                    { new Guid("398560c8-1b54-49d2-8334-5d4b4ce3d548"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Farming Simulator 22", 22, false, "A simulation game where you manage a farm with realistic machinery.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5545) },
                    { new Guid("3a5820ac-6332-45cc-9861-2a08f0da2dd2"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Final Fantasy XV", 12, false, "An epic RPG with a rich storyline and immersive world.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5492) },
                    { new Guid("3acaaf3c-ae34-4a0a-96f0-5389f2bc2544"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Assassin’s Creed Valhalla", 18, false, "An open-world action RPG set in Viking-era Norway and England.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4917) },
                    { new Guid("3c5bf8ee-3993-4acd-b383-2558837c883a"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Farming Simulator 22", 22, false, "A simulation game where you manage a farm with realistic machinery.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5036) },
                    { new Guid("3c65ac51-eb4e-42ed-ad1a-8d289ad84d67"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "MLB The Show 23", 18, false, "A baseball simulation game with realistic graphics and gameplay.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5606) },
                    { new Guid("3e4c1229-94af-44b6-a3ce-9f904700a168"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Mortal Kombat 11", 20, false, "A brutal and action-packed fighting game with iconic characters.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5262) },
                    { new Guid("3f1713ff-3703-4a40-8e8b-f7e87dd9c889"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Planet Zoo", 20, false, "A zoo management simulation game where you build and run a zoo.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5023) },
                    { new Guid("3fb051d5-75a7-442b-8a7a-5886ed83a22f"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Two Point Hospital", 16, false, "A hospital management simulation game with humor and strategic depth.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5550) },
                    { new Guid("48975600-a93a-444e-9fcc-d4ea62efb48c"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Tomb Raider", 18, false, "The origin story of Lara Croft as she becomes the Tomb Raider.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5476) },
                    { new Guid("4aae2f73-62f4-43cf-9179-b1e5c9ec1234"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Persona 5", 18, false, "A stylish RPG that follows high school students with secret supernatural abilities.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4994) },
                    { new Guid("4b1fe9e9-93aa-4d24-807d-3455568b9ab1"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "NBA 2K24", 25, false, "A basketball simulation game with updated rosters and gameplay improvements.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5094) },
                    { new Guid("4b2cc218-6db3-41d4-9b15-c5d052d175a4"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Company of Heroes 2", 14, false, "A WWII real-time strategy game focusing on squad-based tactics.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5585) },
                    { new Guid("4cb8762a-2a4f-4b37-b2e1-4920d0b64709"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "FIFA 24", 30, false, "A football simulation game with realistic gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5087) },
                    { new Guid("4f902612-0cb4-48f7-91aa-532a5b9b7509"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Mortal Kombat 11", 20, false, "A brutal and action-packed fighting game with iconic characters.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5720) },
                    { new Guid("513224b6-f898-4d26-9bd7-89435b6eb82d"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Civilization VI", 18, false, "A turn-based strategy game where you build and expand an empire.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5050) },
                    { new Guid("51eaf502-d758-407d-bb7a-ea395084016e"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Dragon Ball FighterZ", 22, false, "An anime-style fighting game featuring characters from the Dragon Ball series.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5730) },
                    { new Guid("545390b2-f467-4e07-9012-a403c4dbf183"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Cities: Skylines", 18, false, "A city-building simulation game where you design and manage a city.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5018) },
                    { new Guid("54c79435-7685-43ec-aa30-761ac7f8e3b5"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Age of Empires II: Definitive Edition", 30, false, "A real-time strategy game that lets players build and battle in historical settings.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5580) },
                    { new Guid("58f232a3-07aa-428a-8d52-887b2a016497"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Far Cry 5", 15, false, "An action-adventure first-person shooter game set in an open world.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4911) },
                    { new Guid("591f91d4-517b-4d76-a179-d20bc026eac6"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "F1 2021", 20, false, "An official Formula 1 racing simulation game with realistic graphics.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5707) },
                    { new Guid("5b044b57-0c62-4f87-a7e7-1e357536cfd4"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "F1 2021", 20, false, "An official Formula 1 racing simulation game with realistic graphics.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5243) },
                    { new Guid("5ba0c796-1a2c-48ba-8cf4-cb2cf217e1cf"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Dragon Age: Inquisition", 14, false, "An RPG set in a rich fantasy world with strategic combat.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5512) },
                    { new Guid("5e7549ff-ed46-48c1-9fa6-8475bc8c76aa"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Need for Speed: Heat", 22, false, "A high-octane racing game with customizable cars.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5687) },
                    { new Guid("5ea3c124-987c-44b4-b25f-bc8911346816"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Injustice 2", 15, false, "A superhero fighting game featuring characters from the DC Universe.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5734) },
                    { new Guid("5ec7c493-9701-40f0-8261-a55803666cb0"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Company of Heroes 2", 14, false, "A WWII real-time strategy game focusing on squad-based tactics.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5081) },
                    { new Guid("6239300e-f419-4db8-b421-8c0b7800b0de"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "The Legend of Zelda: Breath of the Wild", 15, false, "An open-world adventure game set in the kingdom of Hyrule.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5455) },
                    { new Guid("62bc1b93-f9e3-4619-b3a7-ae27b3a283c9"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Dirt Rally 2.0", 17, false, "A rally racing game with challenging tracks and realistic driving physics.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5711) },
                    { new Guid("63b30d12-8a25-4e51-818d-5e09068d279c"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "The Elder Scrolls V: Skyrim", 20, false, "An open-world RPG set in the fantasy land of Tamriel.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4980) },
                    { new Guid("64596fd9-0612-4eae-b730-f8e539bd0328"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Cyberpunk 2077", 15, false, "An RPG set in a dystopian future with immersive open-world gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4986) },
                    { new Guid("64b3f6aa-d10b-4887-8396-8dfe252bed75"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "The Sims 4", 25, false, "A life simulation game where you can create and control people.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5523) },
                    { new Guid("668eeaa7-0a90-4de0-8ad1-7a68e2fc3b9c"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Microsoft Flight Simulator", 15, false, "A flight simulation game with realistic aircraft and world modeling.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5030) },
                    { new Guid("66da4d25-aa47-4a40-8e18-1a2ab9d49d5d"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Gran Turismo Sport", 18, false, "A racing simulator with realistic graphics and physics.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5226) },
                    { new Guid("68b6d473-c130-425b-bf19-d297fd30c1fc"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Gears 5", 12, false, "A third-person shooter game with a gripping storyline.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4925) },
                    { new Guid("6992cfec-a5f9-46e9-b0b9-0993a7bf0fce"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Far Cry 5", 15, false, "An action-adventure first-person shooter game set in an open world.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5429) },
                    { new Guid("69d1f929-846c-4710-a0ee-e0345237b7ab"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Alien: Isolation", 18, false, "A horror game where you evade an alien on a deserted space station.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5208) },
                    { new Guid("6ec7dc0f-cf6d-4e8d-aa8b-2ac45423c015"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Mass Effect 2", 22, false, "A sci-fi RPG with an engaging storyline and moral choices.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5006) },
                    { new Guid("7037d1c5-7322-4c1e-84a4-de70ac437e45"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "The Witcher 3: Wild Hunt", 10, false, "An open-world fantasy RPG with a rich storyline and complex characters.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5488) },
                    { new Guid("71ab1509-b7f2-4180-a55c-3cfd65b811a2"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Mario Kart 8 Deluxe", 25, false, "A fun and fast-paced kart racing game with iconic Nintendo characters.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5237) },
                    { new Guid("757565b9-f7f1-433c-bd80-de8970c3f19c"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Cyberpunk 2077", 15, false, "An RPG set in a dystopian future with immersive open-world gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5502) },
                    { new Guid("785078f4-ad86-4562-b129-7a3276441d81"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Mario Kart 8 Deluxe", 25, false, "A fun and fast-paced kart racing game with iconic Nintendo characters.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5702) },
                    { new Guid("795ee2fc-67d1-47a4-b996-2087baaabd9d"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Need for Speed: Heat", 22, false, "A high-octane racing game with customizable cars.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5214) },
                    { new Guid("795f6e05-06b0-4ce4-8429-d5569bcbe661"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Doom Eternal", 10, false, "A fast-paced first-person shooter with intense gameplay.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4905) },
                    { new Guid("7b627085-7377-43ec-841c-de072f243892"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Tetris Effect", 30, false, "A mesmerizing puzzle game with stunning visuals and music.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5624) },
                    { new Guid("7bfe8ea3-2a90-4244-8de2-a72d202f317b"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "The Sims 4", 25, false, "A life simulation game where you can create and control people.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5012) },
                    { new Guid("7d6cf03b-879f-4035-b0b0-eee8a3ad55b9"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "The Witcher 3: Wild Hunt", 10, false, "An open-world fantasy RPG with a rich storyline and complex characters.", 44.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4970) },
                    { new Guid("7fe87d9c-079c-493d-ba78-47fae43a420b"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "Tony Hawk's Pro Skater 1 + 2", 22, false, "A skateboarding game featuring iconic locations and tricks.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5112) },
                    { new Guid("817d21b3-957d-4585-ae75-599864a02a07"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Candy Crush Saga", 50, false, "A popular match-three puzzle game with hundreds of challenging levels.", 0.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5165) },
                    { new Guid("8ae9f0aa-baea-4053-af6c-acce1aad41b4"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Resident Evil Village", 10, false, "A survival horror game with a gripping storyline.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5654) },
                    { new Guid("8b72703b-a5f2-47b2-b3bc-04124f5925e8"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Red Dead Redemption 2", 20, false, "An epic tale of life in America’s unforgiving heartland.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4951) },
                    { new Guid("8e00735d-4bbd-464c-86c4-053c712a0958"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Starcraft II", 20, false, "A real-time strategy game with futuristic warfare and intense battles.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5561) },
                    { new Guid("8e90e289-15a9-4758-a368-043826348972"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Total War: Three Kingdoms", 12, false, "A grand strategy game set in ancient China during the Three Kingdoms period.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5574) },
                    { new Guid("93b32047-7b1f-402f-b7ee-356ed4dad66e"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "Total War: Three Kingdoms", 12, false, "A grand strategy game set in ancient China during the Three Kingdoms period.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5067) },
                    { new Guid("94d451bb-84b0-4d12-92c3-2b897fc2e448"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "The Witness", 15, false, "An open-world puzzle game with complex and visually engaging challenges.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5145) },
                    { new Guid("973372e4-c57c-476c-b18d-d9e30ed7ec49"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "FIFA 24", 30, false, "A football simulation game with realistic gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5591) },
                    { new Guid("98fde90e-d585-4a10-bf08-434e66ae612b"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Call of Duty: Modern Warfare", 20, false, "A first-person shooter game with intense multiplayer action.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4895) },
                    { new Guid("9cacec19-ec27-44b1-8098-00198b0c6b68"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Persona 5", 18, false, "A stylish RPG that follows high school students with secret supernatural abilities.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5507) },
                    { new Guid("9cce4f23-2e69-451b-86d4-f1170a603f82"), new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"), "Final Fantasy XV", 12, false, "An epic RPG with a rich storyline and immersive world.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4975) },
                    { new Guid("a4a4e58a-93fa-476f-8875-71ae9bd8eff3"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "The Legend of Zelda: Breath of the Wild", 15, false, "An open-world adventure game set in the kingdom of Hyrule.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4938) },
                    { new Guid("abbb226b-314e-437b-8e5e-fe31fafa8af9"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Gran Turismo Sport", 18, false, "A racing simulator with realistic graphics and physics.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5696) },
                    { new Guid("ac69fae5-0e77-4234-a997-f1c726a83e1d"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Tekken 7", 18, false, "A popular fighting game with deep combat mechanics and diverse characters.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5725) },
                    { new Guid("ad60aade-edcd-4a90-8f45-f26b23867b8c"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Portal 2", 20, false, "A physics-based puzzle game with mind-bending challenges.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5628) },
                    { new Guid("b2870beb-eecf-4412-a2f4-8d4dd77ca3f5"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Street Fighter V", 25, false, "A classic fighting game with a roster of diverse characters.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5254) },
                    { new Guid("b4925923-0ac5-479f-81a8-a549314aa2ed"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "WWE 2K23", 15, false, "A professional wrestling simulation game with realistic moves and characters.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5619) },
                    { new Guid("b89ba1b5-a3e2-46d6-9281-2287385d3bba"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Dirt Rally 2.0", 17, false, "A rally racing game with challenging tracks and realistic driving physics.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5248) },
                    { new Guid("bd791876-1f2e-43cb-a4e1-14044ea113ff"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Outlast", 20, false, "A first-person horror game where you explore an abandoned asylum.", 19.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5189) },
                    { new Guid("bf196fa7-52e0-49ae-912d-fb92ccc6198a"), new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"), "XCOM 2", 15, false, "A turn-based strategy game where players defend Earth from alien invasion.", 34.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5566) },
                    { new Guid("c65bd472-1b57-437f-a7fc-b75ee88dc496"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "The Witness", 15, false, "An open-world puzzle game with complex and visually engaging challenges.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5633) },
                    { new Guid("c94d3086-3035-407d-be4c-4b53e3ae5d32"), new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"), "Tekken 7", 18, false, "A popular fighting game with deep combat mechanics and diverse characters.", 24.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5268) },
                    { new Guid("ca6fc45b-19ef-4581-8e6c-0d178e94e6b9"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "Tony Hawk's Pro Skater 1 + 2", 22, false, "A skateboarding game featuring iconic locations and tricks.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5611) },
                    { new Guid("d0ea04d9-2d8c-48cb-8724-a8453fc56f2a"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Monument Valley", 20, false, "A visually stunning puzzle game with impossible architecture and optical illusions.", 9.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5649) },
                    { new Guid("d2eced70-da2f-4805-83a8-da837621b06e"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Horizon Zero Dawn", 25, false, "A post-apocalyptic adventure game where players battle robotic creatures.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4964) },
                    { new Guid("d5ea6982-3969-482b-bc6c-5c57f462471c"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Forza Horizon 4", 15, false, "An open-world racing game set in a dynamic environment.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5692) },
                    { new Guid("d6810720-89eb-4520-9cd3-73ceb28593f6"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Uncharted 4: A Thief's End", 12, false, "An action-adventure game following the treasure-hunting adventures of Nathan Drake.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5460) },
                    { new Guid("dac99302-9583-497d-9ba2-73aedd1fb812"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "Madden NFL 24", 20, false, "A football simulation game featuring the NFL teams and players.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5600) },
                    { new Guid("dc7aab85-014d-4bc3-b33f-b24f2b67ae26"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Tetris Effect", 30, false, "A mesmerizing puzzle game with stunning visuals and music.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5126) },
                    { new Guid("ddecd65e-1295-46de-b755-921753d00c71"), new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"), "Halo Infinite", 22, false, "The latest installment in the popular Halo series with intense action gameplay.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4931) },
                    { new Guid("e30b1976-0266-41b9-aac2-21a681f569bb"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "MLB The Show 23", 18, false, "A baseball simulation game with realistic graphics and gameplay.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5106) },
                    { new Guid("e49a5d89-3c05-4c50-866f-1b34f0ac92e8"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Horizon Zero Dawn", 25, false, "A post-apocalyptic adventure game where players battle robotic creatures.", 39.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5481) },
                    { new Guid("e681b9fe-6dd5-45c6-9085-a3e395315d7c"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "WWE 2K23", 15, false, "A professional wrestling simulation game with realistic moves and characters.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5119) },
                    { new Guid("e96838ec-cfdb-49ef-b4b9-346ce59fb8de"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Cities: Skylines", 18, false, "A city-building simulation game where you design and manage a city.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5531) },
                    { new Guid("f219603d-3751-4fd7-b2cc-5d1042fe9ec9"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "Madden NFL 24", 20, false, "A football simulation game featuring the NFL teams and players.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5100) },
                    { new Guid("f4afcfab-dcf0-4307-8a81-ccff3a12f665"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "The Evil Within", 12, false, "A horror game with intense combat and a chilling story.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5676) },
                    { new Guid("f5759484-02e8-4b94-915b-a4b01d6c05e1"), new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"), "Tomb Raider", 18, false, "The origin story of Lara Croft as she becomes the Tomb Raider.", 29.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(4958) },
                    { new Guid("f98a1692-1b16-4ea1-9788-02d40f09e6c2"), new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"), "NBA 2K24", 25, false, "A basketball simulation game with updated rosters and gameplay improvements.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5596) },
                    { new Guid("fb4578ee-25bd-4611-ac17-c4133f26bca3"), new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"), "Forza Horizon 4", 15, false, "An open-world racing game set in a dynamic environment.", 49.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5220) },
                    { new Guid("fc8384ae-69e3-4888-bba2-b687c65c08e0"), new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"), "Microsoft Flight Simulator", 15, false, "A flight simulation game with realistic aircraft and world modeling.", 59.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5540) },
                    { new Guid("fcc29afa-b77d-48ac-aa71-769ed8078802"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Baba Is You", 25, false, "A unique puzzle game where you manipulate rules to solve puzzles.", 14.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5638) },
                    { new Guid("fddbf5d5-07f8-43d7-96e6-82dc1a631d28"), new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"), "Monument Valley", 20, false, "A visually stunning puzzle game with impossible architecture and optical illusions.", 9.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5171) },
                    { new Guid("fe5e3927-b654-41ea-a3f8-629019a407ff"), new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"), "Amnesia: The Dark Descent", 25, false, "A survival horror game that emphasizes hiding over fighting.", 14.99m, null, new DateTime(2024, 11, 6, 20, 29, 51, 624, DateTimeKind.Local).AddTicks(5195) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MemberID",
                table: "Addresses",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegisters_EventId",
                table: "EventRegisters",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegisters_MemberId",
                table: "EventRegisters",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_GameReviews_GameID",
                table: "GameReviews",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_GameReviews_MemberID",
                table: "GameReviews",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameCategoryId",
                table: "Games",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPreference_FavoritePlatformId",
                table: "MemberPreference",
                column: "FavoritePlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPreference_GameCategoryId",
                table: "MemberPreference",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPreference_LanguageId",
                table: "MemberPreference",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_GameID",
                table: "OrderDetails",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MemberID",
                table: "Orders",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_MemberID_GameID",
                table: "WishLists",
                columns: new[] { "MemberID", "GameID" },
                unique: true,
                filter: "[MemberID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventRegisters");

            migrationBuilder.DropTable(
                name: "GameReviews");

            migrationBuilder.DropTable(
                name: "MemberPreference");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CvgsEvents");

            migrationBuilder.DropTable(
                name: "FavoritePlatform");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "GameCategories");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
