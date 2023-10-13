using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class seedjobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsibilities_Jobs_JobId",
                table: "Responsibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("46e2a2d7-3d96-4b16-82de-0cca0c51f624"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("62b5e7c2-bc88-49dc-b811-b362e38c51c9"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e5f68253-5aa0-4d68-8814-a32962d8da63"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("02add8d5-23d3-47dd-b09a-98821cdd638b"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("0797752d-78d6-44ae-bb81-7947b1de9213"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("35c57cb8-819e-45c7-8b3b-f50116bc5219"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7d69deba-fff5-4a29-9693-332d6b89eb86"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("8e4d37f6-6a80-49ee-8117-747802945223"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("c828d676-8a23-4618-91ec-d7eb318698a1"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"));

            migrationBuilder.AlterColumn<Guid>(
                name: "JobId",
                table: "Technologies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "JobId",
                table: "Responsibilities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AboutId", "Description", "Location", "Order" },
                values: new object[,]
                {
                    { new Guid("610df9e8-84bf-46ae-8bd7-90ac21779548"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2 },
                    { new Guid("88e748c8-b00d-4f5f-911f-99a8806a4ad7"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1 },
                    { new Guid("cbf7c311-cd4f-4171-899d-3251917dc769"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3 }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AboutId", "CompanyName", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer" },
                    { new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer" },
                    { new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("05ed22be-d769-492e-8b0b-54a86f04ace7"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("4576873d-2df0-4448-8fa9-e42082eb248d"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), true, "Github", "https://github.com/chrsolr/" },
                    { new Guid("652b60af-7656-45ca-b325-52f3f0088377"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("cf3260e0-983c-4b4f-8fda-53906b578368"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), false, "Twitch", "https://www.twitch.tv/7w3n7y" },
                    { new Guid("d6092f78-f49f-4c2a-b64f-67363de75e4c"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("da5f8acd-f662-4207-96ff-a351a93cdc64"), new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"), true, "Instagram", "https://www.instagram.com/7w3n7y/" }
                });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("134ee818-e8c0-486f-a8b5-746c590510f2"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("195a2321-22be-4dbf-9b81-c096bb4c8b0b"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("4c1335b8-3cd3-4086-abcf-32398d12243d"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." },
                    { new Guid("548e5a5d-fad1-41bb-96d2-c258b54eaaef"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." },
                    { new Guid("621d9cdd-2f6f-4565-8d70-af1d7fa57de3"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("7eab6faf-0ba2-4096-aa7d-7856c2e74d1f"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("b663b583-da56-43cd-b724-ce705d966dcb"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("ba6d662e-eecf-4b9d-8270-93fe1a605e2d"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." },
                    { new Guid("e1061345-799d-4993-8ce6-c57ec5bd5203"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "Managed and led a team of 5-7 interns on daily assignments." },
                    { new Guid("eb161960-71fb-4585-ad05-1488a75eda7b"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("f35a3e77-d18c-421a-a72e-32b26ef922e0"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("f498c717-fdf8-44ae-a202-426a768005bf"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("05036d2d-bc19-4d4e-89ea-fbdb781f60dc"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "ReactJs" },
                    { new Guid("057008b3-8968-404d-b464-48c81bfcf41f"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "AngularJs" },
                    { new Guid("0843c595-b5cc-4fec-9cb6-197acbb89a34"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "KnockoutJs" },
                    { new Guid("105ef487-a370-4a98-a5d8-ea8cfaf2781b"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "C#" },
                    { new Guid("19e2ee81-662b-4718-942d-514a4e670c99"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Typescript" },
                    { new Guid("1d961c2f-f9b3-41a3-8507-756412f4db2e"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "NodeJs" },
                    { new Guid("24c036f4-b203-4590-a8c0-183cda36e661"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "Entity Framework" },
                    { new Guid("27593b20-6955-4d00-9ea4-aea0f1d77832"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "MS SQL" },
                    { new Guid("32a8bc19-5bf4-4fc1-8746-0af34cc484c7"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "MeteorJs" },
                    { new Guid("79df4fb9-8aae-47f5-9d4c-fa4962de454b"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "AJAX" },
                    { new Guid("7b9994fe-348f-4f26-b7b3-cbdb24447a5d"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Kubernetes" },
                    { new Guid("8114a7de-6f3a-4f78-bd81-3e580a91ca33"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "AJAX" },
                    { new Guid("830d5314-d4b7-4512-acaa-61ce596b77c8"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "MongoDB" },
                    { new Guid("892f7cbe-836a-4080-a28f-80036082bdf4"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "style-components" },
                    { new Guid("9ae7990f-9eea-40f1-b173-ca5be284adfa"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "JavaScript" },
                    { new Guid("9d24f3a9-73e7-467b-a132-3b71bd7c5627"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "MS SQL" },
                    { new Guid("a4bb9293-e8c1-43f0-86d8-ecbf88f98cbc"), new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"), "Docker" },
                    { new Guid("ae231078-6d74-4071-ab91-b72ca705d2cc"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "LINQ" },
                    { new Guid("b7177f4a-b6c8-403e-9faa-988a721cf6c9"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "ASP.NET MVC" },
                    { new Guid("d0f80fa5-fc88-4344-ace3-1c7ab1af2017"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "AngularJs" },
                    { new Guid("d2031b20-6539-4a91-bc2a-7b471b5e55f2"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "RequireJs" },
                    { new Guid("e25dec1e-bcee-4900-bd52-13da4acd420e"), new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"), "C#" },
                    { new Guid("ffb1180d-ec04-4ded-b762-ad49f9c7d3d0"), new Guid("798d422f-0124-41fb-b1aa-a57b14570887"), "ASP.NET MVC" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsibilities_Jobs_JobId",
                table: "Responsibilities",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsibilities_Jobs_JobId",
                table: "Responsibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("610df9e8-84bf-46ae-8bd7-90ac21779548"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("88e748c8-b00d-4f5f-911f-99a8806a4ad7"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("cbf7c311-cd4f-4171-899d-3251917dc769"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("134ee818-e8c0-486f-a8b5-746c590510f2"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("195a2321-22be-4dbf-9b81-c096bb4c8b0b"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("4c1335b8-3cd3-4086-abcf-32398d12243d"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("548e5a5d-fad1-41bb-96d2-c258b54eaaef"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("621d9cdd-2f6f-4565-8d70-af1d7fa57de3"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("7eab6faf-0ba2-4096-aa7d-7856c2e74d1f"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("b663b583-da56-43cd-b724-ce705d966dcb"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("ba6d662e-eecf-4b9d-8270-93fe1a605e2d"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("e1061345-799d-4993-8ce6-c57ec5bd5203"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("eb161960-71fb-4585-ad05-1488a75eda7b"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("f35a3e77-d18c-421a-a72e-32b26ef922e0"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("f498c717-fdf8-44ae-a202-426a768005bf"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("05ed22be-d769-492e-8b0b-54a86f04ace7"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("4576873d-2df0-4448-8fa9-e42082eb248d"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("652b60af-7656-45ca-b325-52f3f0088377"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("cf3260e0-983c-4b4f-8fda-53906b578368"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("d6092f78-f49f-4c2a-b64f-67363de75e4c"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("da5f8acd-f662-4207-96ff-a351a93cdc64"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("05036d2d-bc19-4d4e-89ea-fbdb781f60dc"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("057008b3-8968-404d-b464-48c81bfcf41f"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("0843c595-b5cc-4fec-9cb6-197acbb89a34"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("105ef487-a370-4a98-a5d8-ea8cfaf2781b"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("19e2ee81-662b-4718-942d-514a4e670c99"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("1d961c2f-f9b3-41a3-8507-756412f4db2e"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("24c036f4-b203-4590-a8c0-183cda36e661"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("27593b20-6955-4d00-9ea4-aea0f1d77832"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("32a8bc19-5bf4-4fc1-8746-0af34cc484c7"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("79df4fb9-8aae-47f5-9d4c-fa4962de454b"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("7b9994fe-348f-4f26-b7b3-cbdb24447a5d"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("8114a7de-6f3a-4f78-bd81-3e580a91ca33"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("830d5314-d4b7-4512-acaa-61ce596b77c8"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("892f7cbe-836a-4080-a28f-80036082bdf4"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("9ae7990f-9eea-40f1-b173-ca5be284adfa"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("9d24f3a9-73e7-467b-a132-3b71bd7c5627"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("a4bb9293-e8c1-43f0-86d8-ecbf88f98cbc"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ae231078-6d74-4071-ab91-b72ca705d2cc"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("b7177f4a-b6c8-403e-9faa-988a721cf6c9"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("d0f80fa5-fc88-4344-ace3-1c7ab1af2017"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("d2031b20-6539-4a91-bc2a-7b471b5e55f2"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("e25dec1e-bcee-4900-bd52-13da4acd420e"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ffb1180d-ec04-4ded-b762-ad49f9c7d3d0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1058390b-b5d4-4356-9ff3-03cb085fad4c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("798d422f-0124-41fb-b1aa-a57b14570887"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ce71783f-fce5-47ee-af3b-97c16eed808e"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("a600cde4-e640-4904-9dca-23f09bcd8087"));

            migrationBuilder.AlterColumn<Guid>(
                name: "JobId",
                table: "Technologies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "JobId",
                table: "Responsibilities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Jobs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Jobs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "About",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "About",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AboutId", "Description", "Location", "Order" },
                values: new object[,]
                {
                    { new Guid("46e2a2d7-3d96-4b16-82de-0cca0c51f624"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3 },
                    { new Guid("62b5e7c2-bc88-49dc-b811-b362e38c51c9"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1 },
                    { new Guid("e5f68253-5aa0-4d68-8814-a32962d8da63"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2 }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("02add8d5-23d3-47dd-b09a-98821cdd638b"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("0797752d-78d6-44ae-bb81-7947b1de9213"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), false, "Twitch", "https://www.twitch.tv/7w3n7y" },
                    { new Guid("35c57cb8-819e-45c7-8b3b-f50116bc5219"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Github", "https://github.com/chrsolr/" },
                    { new Guid("7d69deba-fff5-4a29-9693-332d6b89eb86"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("8e4d37f6-6a80-49ee-8117-747802945223"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("c828d676-8a23-4618-91ec-d7eb318698a1"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Instagram", "https://www.instagram.com/7w3n7y/" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Responsibilities_Jobs_JobId",
                table: "Responsibilities",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");
        }
    }
}
