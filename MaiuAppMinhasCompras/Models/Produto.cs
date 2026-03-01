using SQLite;

namespace MaiuAppMinhasCompras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public int Preço { get; set; }

    }
    /*Esta é a primeira pasta que foi alterada, coloquei o usingSQlite, depois criei a classe Produto, 
         * e dentro dela coloquei as propriedades, a primeira é o Id, que é a chave primária e auto-incrementável, 
         * depois tem a descrição, quantidade e preço.
        Por fim cliquei com o botao direito no campo dos usings, depois em remover e classificar usos, para remover os usings que nao utilizei
         */
}
