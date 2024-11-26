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
                " com bata palha',1,'https://media.istockphoto.com/id/1184633031/pt/vetorial/cartoon-burger-vector-isolated-illustration.jpg?s=612x612&w=0&k=20&c=MG7UfuoShyrCcYbaPB-JSKXMVqrWhY64S-L7UBSkwmo=',0," +
                "'Cheese Salada', 12.50  )");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
               "Values(1,'Pão,Hamburger, ovo, presunto, queijo e batata palha, ervilhas, azeitonas', 'Delicios pão de hamburger com linguiça e carne frita; presunto e queijo de primeira qualidade acompanhado" +
               " com bata palha',1,'Hamburger.webp','https://www.estadao.com.br/resizer/v2/67M2WACSBBE6JC7WTDNSU2RGCE.jpg?quality=80&auth=0b60ded92c17521d31c4329774745805d13db42aab31ee77f5919fa85ace3bf6&width=1075&height=527&smart=true',1," +
               "'Cheese TUDO', 12.50  )");


            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
                "Values(2,'Pão,Hamburger, ovo, legumes', 'Delicioso pão de carioca; presunto e queijo de primeira qualidade acompanhado" +
                " com bata palha',1,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQt_lZPvtlSGiWgSyG2akuj4_W5-c0tbJ1GAQ&s',0," +
                "'Cheese Ftines', 15.00  )");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailrUrl,ImagemUrl,IsLanchePreferido,nome, Preco)" +
                "Values(2,'Ovo, presunto, queijo e batata doce', 'Delicioso mexidão fitnes; presunto e queijo de primeira qualidade acompanhado" +
                " sem bata palha',1,'https://img.freepik.com/fotos-gratis/hamburguer-vegetariano-de-vista-frontal-no-prato_23-2148784527.jpg',1," +
                "'Mexidão Fitnes', 8.75  )");
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
