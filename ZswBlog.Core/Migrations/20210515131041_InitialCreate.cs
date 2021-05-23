using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZswBlog.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    like = table.Column<int>(type: "int", nullable: false),
                    visits = table.Column<int>(type: "int", nullable: false),
                    lastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isTop = table.Column<bool>(type: "bit", nullable: false),
                    topSort = table.Column<int>(type: "int", nullable: false),
                    readTime = table.Column<int>(type: "int", nullable: false),
                    textCount = table.Column<int>(type: "int", nullable: false),
                    coverImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CommentDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    articleId = table.Column<int>(type: "int", nullable: false),
                    targetUserId = table.Column<int>(type: "int", nullable: false),
                    targetId = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetUserPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MessageDTO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetUserPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageDTO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_actionlog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moduleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actionDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ipAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_actionlog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_announcement",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isTop = table.Column<bool>(type: "bit", nullable: false),
                    sort = table.Column<int>(type: "int", nullable: false),
                    endPushDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isShow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_announcement", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_file_attachment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileExt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_file_attachment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_friendlink",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    portrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_friendlink", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_sitetag",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    like = table.Column<int>(type: "int", nullable: false),
                    isShow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_sitetag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_tag",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_tag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_timeline",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_timeline", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_travel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShow = table.Column<bool>(type: "bit", nullable: false),
                    createBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_travel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    portrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    loginCount = table.Column<int>(type: "int", nullable: false),
                    disabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tab_article",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    like = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    visits = table.Column<int>(type: "int", nullable: false),
                    isShow = table.Column<bool>(type: "bit", nullable: false),
                    lastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    coverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isTop = table.Column<bool>(type: "bit", nullable: false),
                    topSort = table.Column<int>(type: "int", nullable: true),
                    readTime = table.Column<int>(type: "int", nullable: false),
                    textCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_article", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_article_tab_category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "tab_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab_middle_travel_file_attachment",
                columns: table => new
                {
                    travelId = table.Column<int>(type: "int", nullable: false),
                    fileAttachmentId = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_middle_travel_file_attachment", x => new { x.travelId, x.fileAttachmentId });
                    table.ForeignKey(
                        name: "FK_tab_middle_travel_file_attachment_tab_file_attachment_fileAttachmentId",
                        column: x => x.fileAttachmentId,
                        principalTable: "tab_file_attachment",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tab_middle_travel_file_attachment_tab_travel_travelId",
                        column: x => x.travelId,
                        principalTable: "tab_travel",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tab_comment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    articleId = table.Column<int>(type: "int", nullable: false),
                    targetUserId = table.Column<int>(type: "int", nullable: true),
                    targetId = table.Column<int>(type: "int", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShow = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_comment", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_comment_tab_user_targetUserId",
                        column: x => x.targetUserId,
                        principalTable: "tab_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tab_comment_tab_user_userId",
                        column: x => x.userId,
                        principalTable: "tab_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab_message",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    targetUserId = table.Column<int>(type: "int", nullable: true),
                    targetId = table.Column<int>(type: "int", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShow = table.Column<bool>(type: "bit", nullable: true),
                    ip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_message", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_message_tab_user_targetUserId",
                        column: x => x.targetUserId,
                        principalTable: "tab_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tab_message_tab_user_userId",
                        column: x => x.userId,
                        principalTable: "tab_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab_qq_userinfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    openId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accessToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    figureurl_qq_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_qq_userinfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_qq_userinfo_tab_user_userId",
                        column: x => x.userId,
                        principalTable: "tab_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tab_middle_article_tag",
                columns: table => new
                {
                    articleId = table.Column<int>(type: "int", nullable: false),
                    tagId = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    operatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_middle_article_tag", x => new { x.articleId, x.tagId });
                    table.ForeignKey(
                        name: "FK_tab_middle_article_tag_tab_article_articleId",
                        column: x => x.articleId,
                        principalTable: "tab_article",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tab_middle_article_tag_tab_tag_tagId",
                        column: x => x.tagId,
                        principalTable: "tab_tag",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tab_article_categoryId",
                table: "tab_article",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_comment_targetUserId",
                table: "tab_comment",
                column: "targetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_comment_userId",
                table: "tab_comment",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_message_targetUserId",
                table: "tab_message",
                column: "targetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_message_userId",
                table: "tab_message",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_middle_article_tag_tagId",
                table: "tab_middle_article_tag",
                column: "tagId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_middle_travel_file_attachment_fileAttachmentId",
                table: "tab_middle_travel_file_attachment",
                column: "fileAttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tab_qq_userinfo_userId",
                table: "tab_qq_userinfo",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleDTO");

            migrationBuilder.DropTable(
                name: "CommentDTO");

            migrationBuilder.DropTable(
                name: "MessageDTO");

            migrationBuilder.DropTable(
                name: "tab_actionlog");

            migrationBuilder.DropTable(
                name: "tab_announcement");

            migrationBuilder.DropTable(
                name: "tab_comment");

            migrationBuilder.DropTable(
                name: "tab_friendlink");

            migrationBuilder.DropTable(
                name: "tab_message");

            migrationBuilder.DropTable(
                name: "tab_middle_article_tag");

            migrationBuilder.DropTable(
                name: "tab_middle_travel_file_attachment");

            migrationBuilder.DropTable(
                name: "tab_qq_userinfo");

            migrationBuilder.DropTable(
                name: "tab_sitetag");

            migrationBuilder.DropTable(
                name: "tab_timeline");

            migrationBuilder.DropTable(
                name: "tab_article");

            migrationBuilder.DropTable(
                name: "tab_tag");

            migrationBuilder.DropTable(
                name: "tab_file_attachment");

            migrationBuilder.DropTable(
                name: "tab_travel");

            migrationBuilder.DropTable(
                name: "tab_user");

            migrationBuilder.DropTable(
                name: "tab_category");
        }
    }
}
