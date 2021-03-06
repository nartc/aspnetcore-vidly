﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace aspnetcorevidly.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("REMOVE FROM Features WHERE Name IN ('Feature 1', 'Feature 2', 'Feature 3')");
        }
    }
}
