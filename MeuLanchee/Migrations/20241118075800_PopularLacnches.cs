using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuLanchee.Migrations
{
    public partial class PopularLacnches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
                "Values(1,'Pão,Hamburger, ovo, presunto, queijo e batata palha', 'Delicios opão de hamburger com ovo frito; presunto e queijo de primeira qualidade acompanhado" +
                " com bata palha',1,'Hamburger.webp','Combo.webp',0," +
                "'Cheese Salada', 12.50  )");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
               "Values(1,'Pão,Hamburger, ovo, presunto, queijo e batata palha, ervilhas, azeitonas', 'Delicios pão de hamburger com linguiça e carne frita; presunto e queijo de primeira qualidade acompanhado" +
               " com bata palha',1,'Hamburger.webp','Combo.webp',1," +
               "'Cheese TUDO', 12.50  )");


            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
                "Values(2,'Pão,Hamburger, ovo, legumes', 'Delicioso pão de carioca; presunto e queijo de primeira qualidade acompanhado" +
                " com bata palha',1,'Hamburger.webp','Combo.webp',0," +
                "'Cheese Ftines', 15.00  )");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
                "Values(2,'Ovo, presunto, queijo e batata doce', 'Delicioso mexidão fitnes; presunto e queijo de primeira qualidade acompanhado" +
                " sem bata palha',1,'Hamburger.webp','Combo.webp',1," +
                "'Mexidão Fitnes', 8.75  )");
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
