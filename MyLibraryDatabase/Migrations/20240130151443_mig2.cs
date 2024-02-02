using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryDatabase.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Presses_PressId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Faculties_FacultyId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_TeacherId",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_StudentId",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PressId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ThemeId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "LibId",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "LibId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PressId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Teachers",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_DepartmentId",
                table: "Teachers",
                newName: "IX_Teachers_BookId");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Id_Dep",
                table: "Teachers",
                column: "Id_Dep");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Book",
                table: "T_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id_Group",
                table: "Students",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Book",
                table: "S_Cards",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Student",
                table: "S_Cards",
                column: "Id_Student");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_Id_Faculty",
                table: "Groups",
                column: "Id_Faculty");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Author",
                table: "Books",
                column: "Id_Author");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Category",
                table: "Books",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Theme",
                table: "Books",
                column: "Id_Theme");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Id_Author",
                table: "Books",
                column: "Id_Author",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_Id_Category",
                table: "Books",
                column: "Id_Category",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Presses_Id_Press",
                table: "Books",
                column: "Id_Press",
                principalTable: "Presses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Themes_Id_Theme",
                table: "Books",
                column: "Id_Theme",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Faculties_Id_Faculty",
                table: "Groups",
                column: "Id_Faculty",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Books_Id_Book",
                table: "S_Cards",
                column: "Id_Book",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Libs_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_Id_Student",
                table: "S_Cards",
                column: "Id_Student",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Books_BookId",
                table: "Students",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_Id_Group",
                table: "Students",
                column: "Id_Group",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Books_Id_Book",
                table: "T_Cards",
                column: "Id_Book",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Libs_Id_Lib",
                table: "T_Cards",
                column: "Id_Lib",
                principalTable: "Libs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Teachers_Id_Teacher",
                table: "T_Cards",
                column: "Id_Teacher",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Books_BookId",
                table: "Teachers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_Id_Dep",
                table: "Teachers",
                column: "Id_Dep",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Id_Author",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_Id_Category",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Presses_Id_Press",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Themes_Id_Theme",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Faculties_Id_Faculty",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Books_Id_Book",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Libs_Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Students_Id_Student",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Books_BookId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_Id_Group",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Books_Id_Book",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Libs_Id_Lib",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cards_Teachers_Id_Teacher",
                table: "T_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Books_BookId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Departments_Id_Dep",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_Id_Dep",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_Id_Book",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_Id_Lib",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_T_Cards_Id_Teacher",
                table: "T_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Students_Id_Group",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_Id_Book",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_Id_Student",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Groups_Id_Faculty",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Author",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Category",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Press",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Theme",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Teachers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_BookId",
                table: "Teachers",
                newName: "IX_Teachers_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_BookId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "T_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibId",
                table: "T_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "T_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "S_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibId",
                table: "S_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "S_Cards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PressId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_BookId",
                table: "T_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_LibId",
                table: "T_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_TeacherId",
                table: "T_Cards",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_BookId",
                table: "S_Cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_LibId",
                table: "S_Cards",
                column: "LibId");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_StudentId",
                table: "S_Cards",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PressId",
                table: "Books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ThemeId",
                table: "Books",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Presses_PressId",
                table: "Books",
                column: "PressId",
                principalTable: "Presses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Themes_ThemeId",
                table: "Books",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Faculties_FacultyId",
                table: "Groups",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Books_BookId",
                table: "S_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Libs_LibId",
                table: "S_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Students_StudentId",
                table: "S_Cards",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Books_BookId",
                table: "T_Cards",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Libs_LibId",
                table: "T_Cards",
                column: "LibId",
                principalTable: "Libs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cards_Teachers_TeacherId",
                table: "T_Cards",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Departments_DepartmentId",
                table: "Teachers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
