using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConestogaVirtualGameStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class addq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("06dc607a-a32a-4576-ba42-fc0501ba46c9"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("38c580f8-f43f-4d01-abde-00dc37baacc7"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("85d69f5b-68db-40ba-9f69-011572ab93bb"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("a7d33357-c975-4676-9470-8a17c3f145d8"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("d6fa8e2e-98c5-42e6-adb8-bbf5cb4c0b14"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("09b5cafe-d0bf-4ccf-b4a0-fdff5e4f570f"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("60e5e8d5-c9c6-4eeb-a701-427f51eb5c8a"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("b9052b74-0303-48d5-ab14-bfbf6d3e749a"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("c8c80c67-b340-4570-bac4-15f8d792982f"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("d354dfc6-6f69-4c57-b8d4-56dc6bb474a6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("01257f62-597d-4ec3-bc4d-fe6972579b45"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0146bfa6-f721-49b4-ba2e-aeff3ad13a78"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("085a941a-1e69-4784-9b3a-709e65637bf4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0ac4a728-b286-472f-814b-a58208bc4707"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0ddc8550-da25-4bf4-b948-b7f88612aa21"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0e20b1be-f5d0-4ec6-bea4-1a74f0570d36"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("10e59fd6-9dc7-40a1-a741-b346e82d1177"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("132167e7-68c5-4a1f-96cc-86ed8c7e5013"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("158433cf-38d8-493c-a1ce-270b6f5d5c86"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("174c7e26-7c1d-4073-a058-302fa6cd3599"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("17de9734-5d9b-409a-8f63-ff297409ca2d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("190f227a-3616-4cdf-bc33-ccfe6fa38d44"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("19316a84-a5f9-4c3e-bbd1-3e52ec9bccac"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("199a5484-917f-465f-982a-1f6837b4e9c3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1b7fe563-27b8-4c4d-b625-20965f9f27bb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1c5431f6-cff0-49f9-b323-c1625dc42d44"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1e70d134-d909-4053-8a37-7b594f463196"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("201a8c95-fc7a-4247-9614-5edf429315dc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("20f3a088-065c-4d73-bca5-9d4eb6fe18f9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("228f6c82-74e7-48a7-8ccd-b10f35211777"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("27acc786-f475-4d87-8cb6-790bb1b890cc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2846792e-48eb-4f1d-aae4-7994096606b5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("28f1f5ca-1871-4b1d-9029-bc85c6bfd7d1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2ac90553-66a6-4c96-bcc8-dc117e22ade8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2af84878-1272-4f25-9da7-bad66e8caa1f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2e9d2e7e-6734-4842-b378-687bd23251af"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2f85d694-0b45-48ee-94cd-db391bf2acd5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3031b64b-e42c-4772-9e79-ad8b7f2a4bd9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("332ffafa-9000-43bc-9b7a-66ab133e5e11"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("357c5865-b1e4-4d24-9a45-7c92f78b6c0b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("365efae8-b781-4a3f-8bba-35a1859fa9cd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("398560c8-1b54-49d2-8334-5d4b4ce3d548"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3a5820ac-6332-45cc-9861-2a08f0da2dd2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3acaaf3c-ae34-4a0a-96f0-5389f2bc2544"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3c5bf8ee-3993-4acd-b383-2558837c883a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3c65ac51-eb4e-42ed-ad1a-8d289ad84d67"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3e4c1229-94af-44b6-a3ce-9f904700a168"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3f1713ff-3703-4a40-8e8b-f7e87dd9c889"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3fb051d5-75a7-442b-8a7a-5886ed83a22f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("48975600-a93a-444e-9fcc-d4ea62efb48c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4aae2f73-62f4-43cf-9179-b1e5c9ec1234"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4b1fe9e9-93aa-4d24-807d-3455568b9ab1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4b2cc218-6db3-41d4-9b15-c5d052d175a4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4cb8762a-2a4f-4b37-b2e1-4920d0b64709"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4f902612-0cb4-48f7-91aa-532a5b9b7509"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("513224b6-f898-4d26-9bd7-89435b6eb82d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("51eaf502-d758-407d-bb7a-ea395084016e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("545390b2-f467-4e07-9012-a403c4dbf183"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("54c79435-7685-43ec-aa30-761ac7f8e3b5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("58f232a3-07aa-428a-8d52-887b2a016497"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("591f91d4-517b-4d76-a179-d20bc026eac6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5b044b57-0c62-4f87-a7e7-1e357536cfd4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5ba0c796-1a2c-48ba-8cf4-cb2cf217e1cf"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5e7549ff-ed46-48c1-9fa6-8475bc8c76aa"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5ea3c124-987c-44b4-b25f-bc8911346816"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5ec7c493-9701-40f0-8261-a55803666cb0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6239300e-f419-4db8-b421-8c0b7800b0de"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("62bc1b93-f9e3-4619-b3a7-ae27b3a283c9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("63b30d12-8a25-4e51-818d-5e09068d279c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("64596fd9-0612-4eae-b730-f8e539bd0328"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("64b3f6aa-d10b-4887-8396-8dfe252bed75"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("668eeaa7-0a90-4de0-8ad1-7a68e2fc3b9c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("66da4d25-aa47-4a40-8e18-1a2ab9d49d5d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("68b6d473-c130-425b-bf19-d297fd30c1fc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6992cfec-a5f9-46e9-b0b9-0993a7bf0fce"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("69d1f929-846c-4710-a0ee-e0345237b7ab"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6ec7dc0f-cf6d-4e8d-aa8b-2ac45423c015"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7037d1c5-7322-4c1e-84a4-de70ac437e45"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("71ab1509-b7f2-4180-a55c-3cfd65b811a2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("757565b9-f7f1-433c-bd80-de8970c3f19c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("785078f4-ad86-4562-b129-7a3276441d81"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("795ee2fc-67d1-47a4-b996-2087baaabd9d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("795f6e05-06b0-4ce4-8429-d5569bcbe661"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7b627085-7377-43ec-841c-de072f243892"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7bfe8ea3-2a90-4244-8de2-a72d202f317b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7d6cf03b-879f-4035-b0b0-eee8a3ad55b9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7fe87d9c-079c-493d-ba78-47fae43a420b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("817d21b3-957d-4585-ae75-599864a02a07"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8ae9f0aa-baea-4053-af6c-acce1aad41b4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8b72703b-a5f2-47b2-b3bc-04124f5925e8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e00735d-4bbd-464c-86c4-053c712a0958"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8e90e289-15a9-4758-a368-043826348972"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("93b32047-7b1f-402f-b7ee-356ed4dad66e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("94d451bb-84b0-4d12-92c3-2b897fc2e448"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("973372e4-c57c-476c-b18d-d9e30ed7ec49"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("98fde90e-d585-4a10-bf08-434e66ae612b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9cacec19-ec27-44b1-8098-00198b0c6b68"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9cce4f23-2e69-451b-86d4-f1170a603f82"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a4a4e58a-93fa-476f-8875-71ae9bd8eff3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("abbb226b-314e-437b-8e5e-fe31fafa8af9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ac69fae5-0e77-4234-a997-f1c726a83e1d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ad60aade-edcd-4a90-8f45-f26b23867b8c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b2870beb-eecf-4412-a2f4-8d4dd77ca3f5"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b4925923-0ac5-479f-81a8-a549314aa2ed"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b89ba1b5-a3e2-46d6-9281-2287385d3bba"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("bd791876-1f2e-43cb-a4e1-14044ea113ff"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("bf196fa7-52e0-49ae-912d-fb92ccc6198a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c65bd472-1b57-437f-a7fc-b75ee88dc496"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c94d3086-3035-407d-be4c-4b53e3ae5d32"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ca6fc45b-19ef-4581-8e6c-0d178e94e6b9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d0ea04d9-2d8c-48cb-8724-a8453fc56f2a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d2eced70-da2f-4805-83a8-da837621b06e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d5ea6982-3969-482b-bc6c-5c57f462471c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d6810720-89eb-4520-9cd3-73ceb28593f6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("dac99302-9583-497d-9ba2-73aedd1fb812"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("dc7aab85-014d-4bc3-b33f-b24f2b67ae26"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ddecd65e-1295-46de-b755-921753d00c71"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e30b1976-0266-41b9-aac2-21a681f569bb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e49a5d89-3c05-4c50-866f-1b34f0ac92e8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e681b9fe-6dd5-45c6-9085-a3e395315d7c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e96838ec-cfdb-49ef-b4b9-346ce59fb8de"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f219603d-3751-4fd7-b2cc-5d1042fe9ec9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f4afcfab-dcf0-4307-8a81-ccff3a12f665"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f5759484-02e8-4b94-915b-a4b01d6c05e1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f98a1692-1b16-4ea1-9788-02d40f09e6c2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fb4578ee-25bd-4611-ac17-c4133f26bca3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fc8384ae-69e3-4888-bba2-b687c65c08e0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fcc29afa-b77d-48ac-aa71-769ed8078802"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fddbf5d5-07f8-43d7-96e6-82dc1a631d28"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fe5e3927-b654-41ea-a3f8-629019a407ff"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("2acd6855-a685-4818-9073-32283d1089c0"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("6c358b17-83ce-4f28-825c-ea7f5f921b08"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("70d7bd8b-aa95-4d42-8e48-d958ef9c5b30"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("7d9561d2-133f-4c3f-a6b2-9b52d1228df6"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("c4350b26-3908-4030-84b4-2c187bac8412"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("13903a03-ea45-46c7-8cd3-91a5a38ac384"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("17bad3cd-14aa-4c21-85c5-b3eeccffef36"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ba0192d-226c-4bca-acb8-f7f2cc1f15ff"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("53702f92-4967-4924-9a9b-dc2a62e89e66"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("56279c2f-a08f-4afc-a166-7826c300ae6f"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a0edf7b-b244-4465-82f9-e9d608cd7928"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3b6fc79-06a6-43bf-b15c-4cc2e47a24c7"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("c58b047a-3e96-4498-9a2d-5581c8d03402"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc28a28a-13ce-49bb-8dad-f70649258637"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("fe82dbe3-93db-4b0c-8c0d-40c96e349f1c"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailID");

            migrationBuilder.InsertData(
                table: "CvgsEvents",
                columns: new[] { "Id", "EventDateTime", "EventDescription", "EventName", "IsDeleted", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("6a308c42-a617-4197-babf-b3fd91ae35c3"), new DateTime(2024, 12, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6759), "A workshop on artificial intelligence and machine learning.", "AI Workshop", false, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6760) },
                    { new Guid("982a5c23-0595-4205-911a-0b25366e0ebe"), new DateTime(2024, 12, 19, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6763), "A summit discussing the latest in cybersecurity.", "Cybersecurity Summit", false, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6765) },
                    { new Guid("b533c37e-5306-4834-8e8c-f39eb2a7b4ba"), new DateTime(2024, 12, 29, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6768), "A meetup for cloud computing enthusiasts.", "Cloud Computing Meetup", false, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6769) },
                    { new Guid("ef9da08c-a5d1-4e62-a4ae-52a5e60042b6"), new DateTime(2024, 11, 19, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6698), "A conference about the latest in technology.", "Tech Conference 2024", false, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6745) },
                    { new Guid("f5a758f6-46aa-480a-a06f-daf68b4eb849"), new DateTime(2024, 11, 29, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6753), "An expo showcasing the latest in gaming.", "Gaming Expo", false, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6755) }
                });

            migrationBuilder.InsertData(
                table: "FavoritePlatform",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bc2f067-cb86-43ad-93b1-9f0643152801"), "PC" },
                    { new Guid("14a92283-a79f-44e8-a6de-f1b10b25bb70"), "Mobile" },
                    { new Guid("4ba1af93-03ae-4ad4-b119-28a9de134de0"), "PlayStation" },
                    { new Guid("6fc57c8b-4156-4967-8e51-0071636e7f77"), "Xbox" },
                    { new Guid("f15843c6-a134-4bc3-a9e6-9f48e8f7732d"), "Nintendo Switch" }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Puzzle" },
                    { new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Racing" },
                    { new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Simulation" },
                    { new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Strategy" },
                    { new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Fighting" },
                    { new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Action" },
                    { new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Adventure" },
                    { new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "Sport" },
                    { new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "RPG" },
                    { new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a902f5cc-22de-484a-bc1f-21458667a4ab"), "Spanish" },
                    { new Guid("cabf1717-971e-49d2-b574-3032b3f25a1b"), "French" },
                    { new Guid("d0318056-098c-42fa-b35c-1b0736eaf793"), "Japanese" },
                    { new Guid("da6dfff3-bf92-4c33-8bbb-5bdc78ff0ad1"), "German" },
                    { new Guid("fc86e15d-dbf3-478e-b58a-141cb37eec90"), "English" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameCategoryId", "GameName", "GamesInStock", "IsDelete", "Overview", "Price", "ThumbnailPath", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("03b41f47-8e78-4646-8d4b-05d2acc8614d"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Uncharted 4: A Thief's End", 12, false, "An action-adventure game following the treasure-hunting adventures of Nathan Drake.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7562) },
                    { new Guid("03c5b3df-5955-4cf5-a2fc-3e3af4f4252d"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "NBA 2K24", 25, false, "A basketball simulation game with updated rosters and gameplay improvements.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7679) },
                    { new Guid("04244a47-fdd3-41dd-b691-4c32028be686"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Cyberpunk 2077", 15, false, "An RPG set in a dystopian future with immersive open-world gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7586) },
                    { new Guid("04632a75-2dca-4c7b-9e8e-8f42ed157d97"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Assassin’s Creed Valhalla", 18, false, "An open-world action RPG set in Viking-era Norway and England.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7009) },
                    { new Guid("05c4ab5d-f263-4f06-b4da-cc9903440bcd"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Street Fighter V", 25, false, "A classic fighting game with a roster of diverse characters.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7758) },
                    { new Guid("0b1f4879-7bd4-4f43-9e52-61f7ac496904"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Portal 2", 20, false, "A physics-based puzzle game with mind-bending challenges.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7270) },
                    { new Guid("0bd43f9d-da5d-47a7-b3fd-f7e0cfdc935e"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Amnesia: The Dark Descent", 25, false, "A survival horror game that emphasizes hiding over fighting.", 14.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7312) },
                    { new Guid("10ab55b9-3a86-4c9d-971b-38eed14bda7a"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "The Elder Scrolls V: Skyrim", 20, false, "An open-world RPG set in the fantasy land of Tamriel.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7069) },
                    { new Guid("12316c84-cac7-4ab4-a7e0-99d4bd16f6ce"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Cyberpunk 2077", 15, false, "An RPG set in a dystopian future with immersive open-world gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7075) },
                    { new Guid("12d88106-8157-4e64-9ae5-96fb288fe116"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Gran Turismo Sport", 18, false, "A racing simulator with realistic graphics and physics.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7336) },
                    { new Guid("13a33f83-cbf2-46d4-8ec4-513700a9099a"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "WWE 2K23", 15, false, "A professional wrestling simulation game with realistic moves and characters.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7260) },
                    { new Guid("147dabb7-4850-4fae-a31f-2f1bb45f1efa"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Dragon Ball FighterZ", 22, false, "An anime-style fighting game featuring characters from the Dragon Ball series.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7771) },
                    { new Guid("15238762-ff65-412a-a206-c66292175934"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Doom Eternal", 10, false, "A fast-paced first-person shooter with intense gameplay.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6947) },
                    { new Guid("158c0446-e8d6-4614-9606-f633738b9ef4"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Outlast", 20, false, "A first-person horror game where you explore an abandoned asylum.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7724) },
                    { new Guid("1604776b-0615-406d-abdd-83eb05d609a0"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Dragon Age: Inquisition", 14, false, "An RPG set in a rich fantasy world with strategic combat.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7123) },
                    { new Guid("1b128c42-8b25-47f3-b877-30fb4929e89c"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Microsoft Flight Simulator", 15, false, "A flight simulation game with realistic aircraft and world modeling.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7612) },
                    { new Guid("22342909-13ea-4b8c-9a02-44e0fa9f2779"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Horizon Zero Dawn", 25, false, "A post-apocalyptic adventure game where players battle robotic creatures.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7573) },
                    { new Guid("26aa8d49-1beb-4e26-a90b-fa8a1a7d2376"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Cities: Skylines", 18, false, "A city-building simulation game where you design and manage a city.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7149) },
                    { new Guid("2d57915f-d751-4ab2-b6f3-ed6738714f89"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Need for Speed: Heat", 22, false, "A high-octane racing game with customizable cars.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7739) },
                    { new Guid("3171e2a7-ff92-4208-b6e0-a43e506bdbb8"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Gran Turismo Sport", 18, false, "A racing simulator with realistic graphics and physics.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7745) },
                    { new Guid("3173c398-7535-4e9a-ad30-d88354e2c213"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "MLB The Show 23", 18, false, "A baseball simulation game with realistic graphics and gameplay.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7248) },
                    { new Guid("331cf5b8-85e8-427a-af47-c5636c2e9392"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Dirt Rally 2.0", 17, false, "A rally racing game with challenging tracks and realistic driving physics.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7394) },
                    { new Guid("35e867ce-82c7-4cd2-b176-7f00250026b7"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Resident Evil Village", 10, false, "A survival horror game with a gripping storyline.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7295) },
                    { new Guid("35ea6422-ee80-41ec-868a-3ae8f2347033"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Two Point Hospital", 16, false, "A hospital management simulation game with humor and strategic depth.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7650) },
                    { new Guid("36a563dd-ee77-4bbc-8514-9c860cc98db4"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "The Evil Within", 12, false, "A horror game with intense combat and a chilling story.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7731) },
                    { new Guid("36fe9221-000e-49e3-b3d9-7add5d69d000"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Monument Valley", 20, false, "A visually stunning puzzle game with impossible architecture and optical illusions.", 9.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7290) },
                    { new Guid("3765754a-8ea7-4f30-a6d5-ef5c5699a4b8"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Dragon Age: Inquisition", 14, false, "An RPG set in a rich fantasy world with strategic combat.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7594) },
                    { new Guid("382c4812-91ba-40a8-94a7-50205e824771"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Two Point Hospital", 16, false, "A hospital management simulation game with humor and strategic depth.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7176) },
                    { new Guid("383cf6eb-c3df-47cb-b6ba-1c508ff893cd"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "The Witness", 15, false, "An open-world puzzle game with complex and visually engaging challenges.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7275) },
                    { new Guid("39a68ca5-367d-4dbf-b589-db6cf882ad9b"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Silent Hill 2", 15, false, "A classic horror game known for its psychological elements and atmosphere.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7302) },
                    { new Guid("3e6867c3-2e63-4c31-9149-ad9b4a284a13"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Dragon Ball FighterZ", 22, false, "An anime-style fighting game featuring characters from the Dragon Ball series.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7414) },
                    { new Guid("3f6fded4-11c9-4587-a7af-4290ea4e21d9"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Tekken 7", 18, false, "A popular fighting game with deep combat mechanics and diverse characters.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7409) },
                    { new Guid("3fd9e068-4cb0-422d-b618-49cb9fa7bde8"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Planet Zoo", 20, false, "A zoo management simulation game where you build and run a zoo.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7156) },
                    { new Guid("40c09a0c-f8ea-4bb5-b496-276a435a1d53"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "The Elder Scrolls V: Skyrim", 20, false, "An open-world RPG set in the fantasy land of Tamriel.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7583) },
                    { new Guid("440c1ec1-89d8-4557-b073-80083eed8e9e"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "Madden NFL 24", 20, false, "A football simulation game featuring the NFL teams and players.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7682) },
                    { new Guid("49d2c14c-6d9c-4552-80b1-736c4f8b9e75"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Street Fighter V", 25, false, "A classic fighting game with a roster of diverse characters.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7399) },
                    { new Guid("49fa632d-c8ee-4d8e-ade5-ed4d9a597377"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Halo Infinite", 22, false, "The latest installment in the popular Halo series with intense action gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7553) },
                    { new Guid("4cd2d95e-1ad4-49d1-b5f6-8db942290800"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Far Cry 5", 15, false, "An action-adventure first-person shooter game set in an open world.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7540) },
                    { new Guid("4e0bf565-8cd7-4aba-bec4-777a4337270d"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Amnesia: The Dark Descent", 25, false, "A survival horror game that emphasizes hiding over fighting.", 14.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7728) },
                    { new Guid("50a6d444-32bf-4027-be1d-5894995dc768"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "The Witcher 3: Wild Hunt", 10, false, "An open-world fantasy RPG with a rich storyline and complex characters.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7059) },
                    { new Guid("514f7952-01bb-490b-9b66-898cf1c12822"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "F1 2021", 20, false, "An official Formula 1 racing simulation game with realistic graphics.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7752) },
                    { new Guid("519e62fd-7e06-4d9f-92ca-1226feb62588"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Horizon Zero Dawn", 25, false, "A post-apocalyptic adventure game where players battle robotic creatures.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7051) },
                    { new Guid("53393d79-8d66-4b11-94f3-be4d97654e66"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Far Cry 5", 15, false, "An action-adventure first-person shooter game set in an open world.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6952) },
                    { new Guid("5595c4b5-1722-46d5-9c12-2d38eeb92817"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Farming Simulator 22", 22, false, "A simulation game where you manage a farm with realistic machinery.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7169) },
                    { new Guid("5627597d-a241-44e9-b838-aa9e4ef17a8c"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Call of Duty: Modern Warfare", 20, false, "A first-person shooter game with intense multiplayer action.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7532) },
                    { new Guid("56da5b8e-e61f-476e-a596-ee86f4ed2818"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Company of Heroes 2", 14, false, "A WWII real-time strategy game focusing on squad-based tactics.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7221) },
                    { new Guid("5c1b94b1-806f-4435-ab46-a2caa7d3955b"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "The Witcher 3: Wild Hunt", 10, false, "An open-world fantasy RPG with a rich storyline and complex characters.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7576) },
                    { new Guid("5d348861-4869-4890-b9c3-e83b6c4b3999"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Assassin’s Creed Valhalla", 18, false, "An open-world action RPG set in Viking-era Norway and England.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7545) },
                    { new Guid("6515ae7a-8332-4166-84fa-095e5ac048a6"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Mario Kart 8 Deluxe", 25, false, "A fun and fast-paced kart racing game with iconic Nintendo characters.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7749) },
                    { new Guid("65160def-8f67-47a5-85f8-0dd689a2536f"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Baba Is You", 25, false, "A unique puzzle game where you manipulate rules to solve puzzles.", 14.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7708) },
                    { new Guid("66ae9796-1201-431a-b102-5425953bfe5f"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Civilization VI", 18, false, "A turn-based strategy game where you build and expand an empire.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7653) },
                    { new Guid("6929cec9-0973-45f3-9355-364d00d21e1c"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Cities: Skylines", 18, false, "A city-building simulation game where you design and manage a city.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7605) },
                    { new Guid("69b42d04-960b-4cf3-b6a1-3570c977d2be"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Injustice 2", 15, false, "A superhero fighting game featuring characters from the DC Universe.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7774) },
                    { new Guid("69d43e13-5c2f-4d2a-b0d2-374172dc3a1c"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Silent Hill 2", 15, false, "A classic horror game known for its psychological elements and atmosphere.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7721) },
                    { new Guid("6b8a02a4-53e4-4ed8-b2e8-9a99fff16a0c"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Resident Evil Village", 10, false, "A survival horror game with a gripping storyline.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7718) },
                    { new Guid("6b9d6242-e5d0-4ef3-91cd-5c15d49b4a0f"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Gears 5", 12, false, "A third-person shooter game with a gripping storyline.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7016) },
                    { new Guid("70cd26af-c81f-45ad-8ac9-233b5665402d"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Forza Horizon 4", 15, false, "An open-world racing game set in a dynamic environment.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7332) },
                    { new Guid("7484cdcc-1087-4c57-ac7e-3d4c3cdd0e04"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "XCOM 2", 15, false, "A turn-based strategy game where players defend Earth from alien invasion.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7199) },
                    { new Guid("762adfee-2512-4ae8-a6db-fa60fd3d5bb2"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Total War: Three Kingdoms", 12, false, "A grand strategy game set in ancient China during the Three Kingdoms period.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7664) },
                    { new Guid("7bcbfb5b-84bd-4de5-aac3-10ef291212c7"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Mortal Kombat 11", 20, false, "A brutal and action-packed fighting game with iconic characters.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7765) },
                    { new Guid("7c86b2c1-75f7-4b37-bfd7-a73c74046b0a"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Call of Duty: Modern Warfare", 20, false, "A first-person shooter game with intense multiplayer action.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(6939) },
                    { new Guid("815b2dfc-c44a-48e0-af1c-5160eee579b6"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Soulcalibur VI", 20, false, "A weapon-based fighting game with unique characters and combat styles.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7778) },
                    { new Guid("836a7cd9-c7c1-4933-b1a7-253e1a9162a7"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Mass Effect 2", 22, false, "A sci-fi RPG with an engaging storyline and moral choices.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7598) },
                    { new Guid("85988c66-a695-4188-9e9c-29f013acacbb"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Total War: Three Kingdoms", 12, false, "A grand strategy game set in ancient China during the Three Kingdoms period.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7209) },
                    { new Guid("85df5379-40d1-419f-a1b7-d5b7ac125b2c"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Tomb Raider", 18, false, "The origin story of Lara Croft as she becomes the Tomb Raider.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7046) },
                    { new Guid("8a45515e-038b-4e3d-aa6d-7ef5d67a6fe1"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Age of Empires II: Definitive Edition", 30, false, "A real-time strategy game that lets players build and battle in historical settings.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7667) },
                    { new Guid("8c2445c1-c76d-44ea-b92a-075fccf0bfb8"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Alien: Isolation", 18, false, "A horror game where you evade an alien on a deserted space station.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7322) },
                    { new Guid("91677f25-fabf-4f93-807b-91fb52c2da22"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Outlast", 20, false, "A first-person horror game where you explore an abandoned asylum.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7307) },
                    { new Guid("92a76f78-8b5e-47da-8659-eb7bed2b7b97"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Persona 5", 18, false, "A stylish RPG that follows high school students with secret supernatural abilities.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7082) },
                    { new Guid("934070cb-6b6a-4e77-84c2-0b428ec057b9"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "FIFA 24", 30, false, "A football simulation game with realistic gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7674) },
                    { new Guid("934fb0e3-9a44-436b-bce1-67cfc1ca610b"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "The Legend of Zelda: Breath of the Wild", 15, false, "An open-world adventure game set in the kingdom of Hyrule.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7557) },
                    { new Guid("9415b65c-c328-4fc1-91eb-20c9864f8647"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Starcraft II", 20, false, "A real-time strategy game with futuristic warfare and intense battles.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7657) },
                    { new Guid("95e504a6-b148-4308-84e5-70c89a778670"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Portal 2", 20, false, "A physics-based puzzle game with mind-bending challenges.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7700) },
                    { new Guid("97283e5b-3331-4c7b-ae1e-ce3a47ae719c"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Microsoft Flight Simulator", 15, false, "A flight simulation game with realistic aircraft and world modeling.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7162) },
                    { new Guid("98500ac2-ea27-4f43-9527-c9b6ea02456e"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "The Sims 4", 25, false, "A life simulation game where you can create and control people.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7139) },
                    { new Guid("9bce7132-ed81-4af6-9624-f537eb6b39ac"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Final Fantasy XV", 12, false, "An epic RPG with a rich storyline and immersive world.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7064) },
                    { new Guid("a024f552-aee8-498d-a569-692e54a881f4"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "FIFA 24", 30, false, "A football simulation game with realistic gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7231) },
                    { new Guid("a7212bbb-49f6-4581-9b9d-d9acae023a0a"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Red Dead Redemption 2", 20, false, "An epic tale of life in America’s unforgiving heartland.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7566) },
                    { new Guid("ac436cfc-4a72-41af-a223-8ea1ff0d0e8b"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Halo Infinite", 22, false, "The latest installment in the popular Halo series with intense action gameplay.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7023) },
                    { new Guid("b0101d9a-852a-463c-9829-0d066e1d577f"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Monument Valley", 20, false, "A visually stunning puzzle game with impossible architecture and optical illusions.", 9.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7715) },
                    { new Guid("b1c56bf4-2a14-49db-8866-c302e9a9517f"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Injustice 2", 15, false, "A superhero fighting game featuring characters from the DC Universe.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7419) },
                    { new Guid("b60d44e0-b545-4a02-a6ab-d25cf2413ae4"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "Madden NFL 24", 20, false, "A football simulation game featuring the NFL teams and players.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7241) },
                    { new Guid("b7b57c03-7a2a-4717-8e81-f1bc746dba8e"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Baba Is You", 25, false, "A unique puzzle game where you manipulate rules to solve puzzles.", 14.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7280) },
                    { new Guid("b9294a5c-a4a1-44ab-9a7b-bdc1191a331f"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Forza Horizon 4", 15, false, "An open-world racing game set in a dynamic environment.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7742) },
                    { new Guid("b99036d0-db6b-4a37-aac4-b00ca073c1ce"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Doom Eternal", 10, false, "A fast-paced first-person shooter with intense gameplay.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7537) },
                    { new Guid("c14e303d-3733-479a-8e13-4c224a42e24a"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Candy Crush Saga", 50, false, "A popular match-three puzzle game with hundreds of challenging levels.", 0.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7285) },
                    { new Guid("c1e5e9a5-be48-4589-9422-118109a0ac2f"), new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"), "Gears 5", 12, false, "A third-person shooter game with a gripping storyline.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7549) },
                    { new Guid("c32c1bb5-dfec-49cf-a03b-9a849ce081fd"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "Alien: Isolation", 18, false, "A horror game where you evade an alien on a deserted space station.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7736) },
                    { new Guid("c450c989-2b63-48e6-8a84-1074a7f33ef4"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Need for Speed: Heat", 22, false, "A high-octane racing game with customizable cars.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7327) },
                    { new Guid("cbc5c91e-3f57-421b-b0db-7fd9ee8c4934"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Final Fantasy XV", 12, false, "An epic RPG with a rich storyline and immersive world.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7579) },
                    { new Guid("cc1bef2f-d83f-4560-9570-bad1bc1129e2"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Tetris Effect", 30, false, "A mesmerizing puzzle game with stunning visuals and music.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7265) },
                    { new Guid("ccdc6225-1aa5-4573-99fe-070222961580"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Tetris Effect", 30, false, "A mesmerizing puzzle game with stunning visuals and music.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7696) },
                    { new Guid("cd6a3577-a757-4ee7-93b7-30f7e762ac3d"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "Tony Hawk's Pro Skater 1 + 2", 22, false, "A skateboarding game featuring iconic locations and tricks.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7689) },
                    { new Guid("cf3f48e7-f898-43a4-bf23-be6ade79068a"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Company of Heroes 2", 14, false, "A WWII real-time strategy game focusing on squad-based tactics.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7671) },
                    { new Guid("d066960d-8b1a-4cbd-b1b4-73ddb7994824"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "XCOM 2", 15, false, "A turn-based strategy game where players defend Earth from alien invasion.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7661) },
                    { new Guid("d2b56bd1-4f00-46bd-8e83-83bf5e6293df"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Planet Zoo", 20, false, "A zoo management simulation game where you build and run a zoo.", 44.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7609) },
                    { new Guid("d39a790d-296b-45cf-bdf7-b53d055cb474"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Civilization VI", 18, false, "A turn-based strategy game where you build and expand an empire.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7184) },
                    { new Guid("d3bb2333-a7fb-4a72-a909-23f4cbba9efa"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "F1 2021", 20, false, "An official Formula 1 racing simulation game with realistic graphics.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7389) },
                    { new Guid("d5cc36e9-1809-4536-be4f-6259fd6ef92b"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "The Witness", 15, false, "An open-world puzzle game with complex and visually engaging challenges.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7703) },
                    { new Guid("d86f381b-b156-43ec-8f03-3eca934e3590"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "WWE 2K23", 15, false, "A professional wrestling simulation game with realistic moves and characters.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7693) },
                    { new Guid("d8d2c26d-7d20-4363-8e7b-942f63b7035a"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "Tony Hawk's Pro Skater 1 + 2", 22, false, "A skateboarding game featuring iconic locations and tricks.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7253) },
                    { new Guid("db27a54f-4a27-408b-8bbd-29e6b4456819"), new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"), "Candy Crush Saga", 50, false, "A popular match-three puzzle game with hundreds of challenging levels.", 0.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7712) },
                    { new Guid("de57e946-ffef-4f56-ba4c-6dd5c1bf7735"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Soulcalibur VI", 20, false, "A weapon-based fighting game with unique characters and combat styles.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7426) },
                    { new Guid("de5847d0-5aa3-467b-8841-437bdf3f78e9"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "Farming Simulator 22", 22, false, "A simulation game where you manage a farm with realistic machinery.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7644) },
                    { new Guid("e001d368-59d1-43b1-9f71-e12b417e093a"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Mass Effect 2", 22, false, "A sci-fi RPG with an engaging storyline and moral choices.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7131) },
                    { new Guid("e2743961-55c3-4681-8a37-6a19d352b6bc"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "MLB The Show 23", 18, false, "A baseball simulation game with realistic graphics and gameplay.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7686) },
                    { new Guid("e27d33c3-6ac6-4a9c-938e-596328f90ecf"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Uncharted 4: A Thief's End", 12, false, "An action-adventure game following the treasure-hunting adventures of Nathan Drake.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7035) },
                    { new Guid("e361e5fc-7260-49d9-acbb-40fe404be06d"), new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"), "The Sims 4", 25, false, "A life simulation game where you can create and control people.", 39.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7602) },
                    { new Guid("eaf56d56-f7e9-493c-83aa-130bbece2ae1"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Tomb Raider", 18, false, "The origin story of Lara Croft as she becomes the Tomb Raider.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7570) },
                    { new Guid("ee6eb0fb-7c54-46cd-afa1-95ac5669a0f3"), new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"), "The Evil Within", 12, false, "A horror game with intense combat and a chilling story.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7317) },
                    { new Guid("eed80de2-2094-41f2-9a39-e8a168d536ca"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Starcraft II", 20, false, "A real-time strategy game with futuristic warfare and intense battles.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7192) },
                    { new Guid("f1eb88fa-8a8a-4481-a9b4-cbcb2068ac85"), new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"), "Persona 5", 18, false, "A stylish RPG that follows high school students with secret supernatural abilities.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7591) },
                    { new Guid("f413d2a0-755d-4340-8aeb-21b86ebbf75f"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Tekken 7", 18, false, "A popular fighting game with deep combat mechanics and diverse characters.", 24.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7768) },
                    { new Guid("f7248aaf-6fcd-445a-8615-b9e2488ffb04"), new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"), "Age of Empires II: Definitive Edition", 30, false, "A real-time strategy game that lets players build and battle in historical settings.", 19.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7215) },
                    { new Guid("f8238d89-f771-473e-a19a-07b70d0232d3"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Dirt Rally 2.0", 17, false, "A rally racing game with challenging tracks and realistic driving physics.", 34.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7755) },
                    { new Guid("fa110e6e-8b96-45c9-96ce-d9cf8d904efb"), new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"), "Mario Kart 8 Deluxe", 25, false, "A fun and fast-paced kart racing game with iconic Nintendo characters.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7343) },
                    { new Guid("fba7f26f-cfd1-41f9-8f9d-424194a69a42"), new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"), "NBA 2K24", 25, false, "A basketball simulation game with updated rosters and gameplay improvements.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7236) },
                    { new Guid("fc870211-5045-45ff-9c34-32473d246535"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "Red Dead Redemption 2", 20, false, "An epic tale of life in America’s unforgiving heartland.", 49.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7040) },
                    { new Guid("fcf82422-a63f-4b53-95c5-5b499285fb8f"), new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"), "The Legend of Zelda: Breath of the Wild", 15, false, "An open-world adventure game set in the kingdom of Hyrule.", 59.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7029) },
                    { new Guid("fec0fcde-9df6-4915-a5c4-33313818b301"), new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"), "Mortal Kombat 11", 20, false, "A brutal and action-packed fighting game with iconic characters.", 29.99m, null, new DateTime(2024, 11, 9, 21, 12, 34, 341, DateTimeKind.Local).AddTicks(7404) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID_GameID",
                table: "OrderDetails",
                columns: new[] { "OrderID", "GameID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderID_GameID",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("6a308c42-a617-4197-babf-b3fd91ae35c3"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("982a5c23-0595-4205-911a-0b25366e0ebe"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("b533c37e-5306-4834-8e8c-f39eb2a7b4ba"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("ef9da08c-a5d1-4e62-a4ae-52a5e60042b6"));

            migrationBuilder.DeleteData(
                table: "CvgsEvents",
                keyColumn: "Id",
                keyValue: new Guid("f5a758f6-46aa-480a-a06f-daf68b4eb849"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("0bc2f067-cb86-43ad-93b1-9f0643152801"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("14a92283-a79f-44e8-a6de-f1b10b25bb70"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("4ba1af93-03ae-4ad4-b119-28a9de134de0"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("6fc57c8b-4156-4967-8e51-0071636e7f77"));

            migrationBuilder.DeleteData(
                table: "FavoritePlatform",
                keyColumn: "Id",
                keyValue: new Guid("f15843c6-a134-4bc3-a9e6-9f48e8f7732d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("03b41f47-8e78-4646-8d4b-05d2acc8614d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("03c5b3df-5955-4cf5-a2fc-3e3af4f4252d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("04244a47-fdd3-41dd-b691-4c32028be686"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("04632a75-2dca-4c7b-9e8e-8f42ed157d97"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("05c4ab5d-f263-4f06-b4da-cc9903440bcd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0b1f4879-7bd4-4f43-9e52-61f7ac496904"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0bd43f9d-da5d-47a7-b3fd-f7e0cfdc935e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("10ab55b9-3a86-4c9d-971b-38eed14bda7a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("12316c84-cac7-4ab4-a7e0-99d4bd16f6ce"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("12d88106-8157-4e64-9ae5-96fb288fe116"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("13a33f83-cbf2-46d4-8ec4-513700a9099a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("147dabb7-4850-4fae-a31f-2f1bb45f1efa"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("15238762-ff65-412a-a206-c66292175934"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("158c0446-e8d6-4614-9606-f633738b9ef4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1604776b-0615-406d-abdd-83eb05d609a0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1b128c42-8b25-47f3-b877-30fb4929e89c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("22342909-13ea-4b8c-9a02-44e0fa9f2779"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("26aa8d49-1beb-4e26-a90b-fa8a1a7d2376"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2d57915f-d751-4ab2-b6f3-ed6738714f89"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3171e2a7-ff92-4208-b6e0-a43e506bdbb8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3173c398-7535-4e9a-ad30-d88354e2c213"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("331cf5b8-85e8-427a-af47-c5636c2e9392"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("35e867ce-82c7-4cd2-b176-7f00250026b7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("35ea6422-ee80-41ec-868a-3ae8f2347033"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("36a563dd-ee77-4bbc-8514-9c860cc98db4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("36fe9221-000e-49e3-b3d9-7add5d69d000"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3765754a-8ea7-4f30-a6d5-ef5c5699a4b8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("382c4812-91ba-40a8-94a7-50205e824771"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("383cf6eb-c3df-47cb-b6ba-1c508ff893cd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("39a68ca5-367d-4dbf-b589-db6cf882ad9b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3e6867c3-2e63-4c31-9149-ad9b4a284a13"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3f6fded4-11c9-4587-a7af-4290ea4e21d9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3fd9e068-4cb0-422d-b618-49cb9fa7bde8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("40c09a0c-f8ea-4bb5-b496-276a435a1d53"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("440c1ec1-89d8-4557-b073-80083eed8e9e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("49d2c14c-6d9c-4552-80b1-736c4f8b9e75"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("49fa632d-c8ee-4d8e-ade5-ed4d9a597377"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4cd2d95e-1ad4-49d1-b5f6-8db942290800"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4e0bf565-8cd7-4aba-bec4-777a4337270d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("50a6d444-32bf-4027-be1d-5894995dc768"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("514f7952-01bb-490b-9b66-898cf1c12822"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("519e62fd-7e06-4d9f-92ca-1226feb62588"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("53393d79-8d66-4b11-94f3-be4d97654e66"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5595c4b5-1722-46d5-9c12-2d38eeb92817"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5627597d-a241-44e9-b838-aa9e4ef17a8c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("56da5b8e-e61f-476e-a596-ee86f4ed2818"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5c1b94b1-806f-4435-ab46-a2caa7d3955b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5d348861-4869-4890-b9c3-e83b6c4b3999"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6515ae7a-8332-4166-84fa-095e5ac048a6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("65160def-8f67-47a5-85f8-0dd689a2536f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("66ae9796-1201-431a-b102-5425953bfe5f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6929cec9-0973-45f3-9355-364d00d21e1c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("69b42d04-960b-4cf3-b6a1-3570c977d2be"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("69d43e13-5c2f-4d2a-b0d2-374172dc3a1c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6b8a02a4-53e4-4ed8-b2e8-9a99fff16a0c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6b9d6242-e5d0-4ef3-91cd-5c15d49b4a0f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("70cd26af-c81f-45ad-8ac9-233b5665402d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7484cdcc-1087-4c57-ac7e-3d4c3cdd0e04"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("762adfee-2512-4ae8-a6db-fa60fd3d5bb2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7bcbfb5b-84bd-4de5-aac3-10ef291212c7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7c86b2c1-75f7-4b37-bfd7-a73c74046b0a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("815b2dfc-c44a-48e0-af1c-5160eee579b6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("836a7cd9-c7c1-4933-b1a7-253e1a9162a7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85988c66-a695-4188-9e9c-29f013acacbb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("85df5379-40d1-419f-a1b7-d5b7ac125b2c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8a45515e-038b-4e3d-aa6d-7ef5d67a6fe1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8c2445c1-c76d-44ea-b92a-075fccf0bfb8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("91677f25-fabf-4f93-807b-91fb52c2da22"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("92a76f78-8b5e-47da-8659-eb7bed2b7b97"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("934070cb-6b6a-4e77-84c2-0b428ec057b9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("934fb0e3-9a44-436b-bce1-67cfc1ca610b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9415b65c-c328-4fc1-91eb-20c9864f8647"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("95e504a6-b148-4308-84e5-70c89a778670"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("97283e5b-3331-4c7b-ae1e-ce3a47ae719c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("98500ac2-ea27-4f43-9527-c9b6ea02456e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("9bce7132-ed81-4af6-9624-f537eb6b39ac"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a024f552-aee8-498d-a569-692e54a881f4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a7212bbb-49f6-4581-9b9d-d9acae023a0a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ac436cfc-4a72-41af-a223-8ea1ff0d0e8b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b0101d9a-852a-463c-9829-0d066e1d577f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b1c56bf4-2a14-49db-8866-c302e9a9517f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b60d44e0-b545-4a02-a6ab-d25cf2413ae4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b7b57c03-7a2a-4717-8e81-f1bc746dba8e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b9294a5c-a4a1-44ab-9a7b-bdc1191a331f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b99036d0-db6b-4a37-aac4-b00ca073c1ce"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c14e303d-3733-479a-8e13-4c224a42e24a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c1e5e9a5-be48-4589-9422-118109a0ac2f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c32c1bb5-dfec-49cf-a03b-9a849ce081fd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c450c989-2b63-48e6-8a84-1074a7f33ef4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cbc5c91e-3f57-421b-b0db-7fd9ee8c4934"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cc1bef2f-d83f-4560-9570-bad1bc1129e2"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ccdc6225-1aa5-4573-99fe-070222961580"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cd6a3577-a757-4ee7-93b7-30f7e762ac3d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("cf3f48e7-f898-43a4-bf23-be6ade79068a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d066960d-8b1a-4cbd-b1b4-73ddb7994824"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d2b56bd1-4f00-46bd-8e83-83bf5e6293df"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d39a790d-296b-45cf-bdf7-b53d055cb474"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d3bb2333-a7fb-4a72-a909-23f4cbba9efa"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d5cc36e9-1809-4536-be4f-6259fd6ef92b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d86f381b-b156-43ec-8f03-3eca934e3590"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d8d2c26d-7d20-4363-8e7b-942f63b7035a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("db27a54f-4a27-408b-8bbd-29e6b4456819"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("de57e946-ffef-4f56-ba4c-6dd5c1bf7735"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("de5847d0-5aa3-467b-8841-437bdf3f78e9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e001d368-59d1-43b1-9f71-e12b417e093a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e2743961-55c3-4681-8a37-6a19d352b6bc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e27d33c3-6ac6-4a9c-938e-596328f90ecf"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e361e5fc-7260-49d9-acbb-40fe404be06d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("eaf56d56-f7e9-493c-83aa-130bbece2ae1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ee6eb0fb-7c54-46cd-afa1-95ac5669a0f3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("eed80de2-2094-41f2-9a39-e8a168d536ca"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f1eb88fa-8a8a-4481-a9b4-cbcb2068ac85"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f413d2a0-755d-4340-8aeb-21b86ebbf75f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f7248aaf-6fcd-445a-8615-b9e2488ffb04"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f8238d89-f771-473e-a19a-07b70d0232d3"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fa110e6e-8b96-45c9-96ce-d9cf8d904efb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fba7f26f-cfd1-41f9-8f9d-424194a69a42"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fc870211-5045-45ff-9c34-32473d246535"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fcf82422-a63f-4b53-95c5-5b499285fb8f"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fec0fcde-9df6-4915-a5c4-33313818b301"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("a902f5cc-22de-484a-bc1f-21458667a4ab"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("cabf1717-971e-49d2-b574-3032b3f25a1b"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("d0318056-098c-42fa-b35c-1b0736eaf793"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("da6dfff3-bf92-4c33-8bbb-5bdc78ff0ad1"));

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: new Guid("fc86e15d-dbf3-478e-b58a-141cb37eec90"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ce424cf-6c4b-4dc0-945f-a492bb9cf80e"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b909b26-ed36-42c3-a001-43f080e544b6"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("6545a3c5-026a-4edc-8eb1-b1ac29bf7de0"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c1911df-7efa-4975-b1d9-84a46d6081e6"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("966216e9-22b6-4a47-acaa-66f0d23a0919"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("97e26390-59ff-4ce9-a2e4-67e0ffa9ca21"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5744862-10ed-41e1-b2a4-bac9b89b55a7"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("e341d0fd-73bb-4301-82cf-6f8c66182909"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("f41cdd32-d0a9-4eb6-9473-4a728dc03cec"));

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9a78f93-2260-40ca-baa3-6d0cb71ef52a"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderID", "GameID" });

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
        }
    }
}
