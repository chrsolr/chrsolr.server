using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class updatemodelblog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "BlogPosts",
                newName: "IsActive");

            migrationBuilder.AddColumn<Guid>(
                name: "AboutId",
                table: "About",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "AboutId", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), null, "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AboutId", "Description", "Location", "Order" },
                values: new object[,]
                {
                    { new Guid("9035894d-79ee-4a06-ae94-c946de6e5d5b"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1 },
                    { new Guid("cf3097b5-04f6-4592-a9e2-94fa2253b8fd"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3 },
                    { new Guid("fdc6e30f-b94a-4bd1-a556-7a340a474d55"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2 }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AboutId", "CompanyName", "EndDate", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("4056004b-f63f-4367-a979-dfd709084b92"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants" },
                    { new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer" },
                    { new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("30ebe14e-a526-4e14-9eaa-3eafaa38c5fb"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), false, "Twitch", "https://www.twitch.tv/7w3n7y" },
                    { new Guid("6260d5c7-fbf4-475e-930f-283df8050cd2"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("98704d67-b9c6-482f-a07b-239afb82dfc9"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), true, "Instagram", "https://www.instagram.com/7w3n7y/" },
                    { new Guid("abfab7f2-302b-4e44-870e-4b6e2ba36b92"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("aca545e4-6ae5-44bf-a8ef-10346e414147"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("fbb49925-2b20-47e4-a8ef-58945d869ae7"), new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"), true, "Github", "https://github.com/chrsolr/" }
                });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("0613668e-8ff6-4d96-8b9f-3ee9f3b69b00"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("1a4ea392-73a4-44ad-9d4e-eca418e2f49b"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("505df7f4-256a-4653-9966-696c010b0b83"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("5346255d-13c2-47b7-a76b-c18d477e08ae"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("68a81a48-f960-492a-bdfe-bf127407957a"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." },
                    { new Guid("82cf9ed3-aa70-4e42-a6a1-4b7a3a26e1d3"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." },
                    { new Guid("92f77ca3-645c-4382-9586-a37078744526"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "Managed and led a team of 5-7 interns on daily assignments." },
                    { new Guid("a1990bd7-41f0-4b93-acbf-a2ae54e3ab1b"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("b2a15d15-2ba6-427a-a9f5-c9f7e7d82625"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("e54d77e7-bcc8-4419-b39b-b9977dc81de9"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("e8c303a1-9e48-4d70-8e72-918f7a4b3875"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." },
                    { new Guid("f7fd48a6-6282-44ac-af08-56f4ec2356bb"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("162e029d-1cfb-4b38-adc3-4d66e8d97041"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "ReactJs" },
                    { new Guid("188d64a1-fab0-4fcf-8a7d-4ef13af1d4ad"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "ASP.NET MVC" },
                    { new Guid("19a81f1e-3c20-40ed-86bc-ecfd6c330ed2"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "MongoDB" },
                    { new Guid("23907a29-22a7-4feb-ae5b-724751af3626"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "MS SQL" },
                    { new Guid("23dbe259-1c50-4536-96c5-1441e846d3fd"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "NodeJs" },
                    { new Guid("472a06ac-31dc-477e-8752-fd3d2fa01e13"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "C#" },
                    { new Guid("492d10a9-4e0f-4b87-ae91-472695f01f68"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "JavaScript" },
                    { new Guid("4a857958-511c-43f9-8ee7-7210e52ef92c"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "RequireJs" },
                    { new Guid("5075af85-7bcf-41e6-8d0b-21ce57a876de"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Styled Components" },
                    { new Guid("5c7c0f66-5b7b-4ac1-8102-17d1ecda43de"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "MS SQL" },
                    { new Guid("5fcd6db3-24e9-4e61-8386-f9061261225d"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "C#" },
                    { new Guid("87bebf78-cd0e-45e5-b2a7-b5377e148b73"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Typescript" },
                    { new Guid("93644cd6-eb36-4206-b9a1-ab5064a6cb3f"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "AngularJs" },
                    { new Guid("961bdb88-49e4-40c8-87bd-1703ab1f44ab"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "Entity Framework" },
                    { new Guid("bf8ecedb-2568-49e6-8190-c620283891d9"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "ASP.NET MVC" },
                    { new Guid("c2ce192a-5a70-4798-8d1a-52a688992410"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "AJAX" },
                    { new Guid("c947a6a1-ae13-45c6-bc00-d5d2eb79aa07"), new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"), "KnockoutJs" },
                    { new Guid("cd8410a0-895a-42b5-8d40-fbe13bc61b61"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "MeteorJs" },
                    { new Guid("d9bb43ec-6a91-442b-9cae-4eb6683c8201"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "AngularJs" },
                    { new Guid("db377a53-2f5b-47dd-9ed0-9b637f1be4e0"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "LINQ" },
                    { new Guid("edb849fa-8163-4fea-90b1-f8255dfa47cd"), new Guid("4056004b-f63f-4367-a979-dfd709084b92"), "AJAX" },
                    { new Guid("ee51a38f-fed0-4a50-bf98-042f4c1083cd"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Docker" },
                    { new Guid("ffbdb110-e77e-44a9-acea-9e37f937ad02"), new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"), "Kubernetes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_About_AboutId",
                table: "About",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_About_About_AboutId",
                table: "About",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_About_About_AboutId",
                table: "About");

            migrationBuilder.DropIndex(
                name: "IX_About_AboutId",
                table: "About");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("9035894d-79ee-4a06-ae94-c946de6e5d5b"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("cf3097b5-04f6-4592-a9e2-94fa2253b8fd"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("fdc6e30f-b94a-4bd1-a556-7a340a474d55"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("0613668e-8ff6-4d96-8b9f-3ee9f3b69b00"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("1a4ea392-73a4-44ad-9d4e-eca418e2f49b"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("505df7f4-256a-4653-9966-696c010b0b83"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("5346255d-13c2-47b7-a76b-c18d477e08ae"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("68a81a48-f960-492a-bdfe-bf127407957a"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("82cf9ed3-aa70-4e42-a6a1-4b7a3a26e1d3"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("92f77ca3-645c-4382-9586-a37078744526"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("a1990bd7-41f0-4b93-acbf-a2ae54e3ab1b"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("b2a15d15-2ba6-427a-a9f5-c9f7e7d82625"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("e54d77e7-bcc8-4419-b39b-b9977dc81de9"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("e8c303a1-9e48-4d70-8e72-918f7a4b3875"));

            migrationBuilder.DeleteData(
                table: "Responsibilities",
                keyColumn: "Id",
                keyValue: new Guid("f7fd48a6-6282-44ac-af08-56f4ec2356bb"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("30ebe14e-a526-4e14-9eaa-3eafaa38c5fb"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("6260d5c7-fbf4-475e-930f-283df8050cd2"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("98704d67-b9c6-482f-a07b-239afb82dfc9"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("abfab7f2-302b-4e44-870e-4b6e2ba36b92"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("aca545e4-6ae5-44bf-a8ef-10346e414147"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("fbb49925-2b20-47e4-a8ef-58945d869ae7"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("162e029d-1cfb-4b38-adc3-4d66e8d97041"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("188d64a1-fab0-4fcf-8a7d-4ef13af1d4ad"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("19a81f1e-3c20-40ed-86bc-ecfd6c330ed2"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("23907a29-22a7-4feb-ae5b-724751af3626"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("23dbe259-1c50-4536-96c5-1441e846d3fd"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("472a06ac-31dc-477e-8752-fd3d2fa01e13"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("492d10a9-4e0f-4b87-ae91-472695f01f68"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("4a857958-511c-43f9-8ee7-7210e52ef92c"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("5075af85-7bcf-41e6-8d0b-21ce57a876de"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("5c7c0f66-5b7b-4ac1-8102-17d1ecda43de"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("5fcd6db3-24e9-4e61-8386-f9061261225d"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("87bebf78-cd0e-45e5-b2a7-b5377e148b73"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("93644cd6-eb36-4206-b9a1-ab5064a6cb3f"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("961bdb88-49e4-40c8-87bd-1703ab1f44ab"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("bf8ecedb-2568-49e6-8190-c620283891d9"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("c2ce192a-5a70-4798-8d1a-52a688992410"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("c947a6a1-ae13-45c6-bc00-d5d2eb79aa07"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("cd8410a0-895a-42b5-8d40-fbe13bc61b61"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("d9bb43ec-6a91-442b-9cae-4eb6683c8201"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("db377a53-2f5b-47dd-9ed0-9b637f1be4e0"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("edb849fa-8163-4fea-90b1-f8255dfa47cd"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ee51a38f-fed0-4a50-bf98-042f4c1083cd"));

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "Id",
                keyValue: new Guid("ffbdb110-e77e-44a9-acea-9e37f937ad02"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4056004b-f63f-4367-a979-dfd709084b92"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"));

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "About");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "BlogPosts",
                newName: "Active");

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
        }
    }
}
