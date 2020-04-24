using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class otra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Recipes_IngredientID",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Ingredients_RecipeID",
                table: "RecipeIngredient");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Ingredients_IngredientID",
                table: "RecipeIngredient",
                column: "IngredientID",
                principalTable: "Ingredients",
                principalColumn: "IngredientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeID",
                table: "RecipeIngredient",
                column: "RecipeID",
                principalTable: "Recipes",
                principalColumn: "RecipeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Ingredients_IngredientID",
                table: "RecipeIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredient_Recipes_RecipeID",
                table: "RecipeIngredient");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Recipes_IngredientID",
                table: "RecipeIngredient",
                column: "IngredientID",
                principalTable: "Recipes",
                principalColumn: "RecipeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredient_Ingredients_RecipeID",
                table: "RecipeIngredient",
                column: "RecipeID",
                principalTable: "Ingredients",
                principalColumn: "IngredientID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
