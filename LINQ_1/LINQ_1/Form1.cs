using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {

        //Declara uma lista de strings chamada lista_nomes
        //Essa lista será usada para armazenar nomes de pessoas.
        //A classe List<T> é uma coleção genérica que fornece métodos
        //para adicionar, remover e acessar elementos de maneira eficiente.
        List<string> lista_nomes;

        //Declara uma lista de inteiros chamada lista_numeros
        //Essa lista será usada para armazenar números inteiros.
        //Assim como List<string>, a List<int> fornece métodos
        //para manipular os números armazenados.
        List<int> lista_numeros;

        //Declara um dicionário que mapeia strings para valores
        //do tipo double, chamado lista_produtos.
        //Esse dicionário será usado para armazenar produtos
        //e seus respectivos preços.
        //A classe Dictionary<TKey, TValue> é uma coleção genérica
        //que armazena pares de chave-valor, permitindo acesso rápido
        //aos valores baseados na chave.
        Dictionary<string, double> lista_produtos;

        //Declara um dicionário que mapeia strings para outras strings,
        //chamado lista_estados.
        //Esse dicionário será usado para armazenar estados(ou cidades) e
        //seus respectivos países.
        //Como no caso anterior, Dictionary<TKey, TValue> permite
        //a associação de duas strings, possibilitando buscar o país
        //de um estado/cidade rapidamente.
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            InitializeComponent();

            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Danny");
            lista_nomes.Add("Arthur");
            lista_nomes.Add("Danielle");
            lista_nomes.Add("Thuxs");
            lista_nomes.Add("Logan");
            lista_nomes.Add("Artigas");
            lista_nomes.Add("Flávio");
            lista_nomes.Add("Beatriz");
            lista_nomes.Add("Glória");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Bia");
            lista_nomes.Add("Eduardo");
            lista_nomes.Add("Márcio");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Sarah");
            lista_nomes.Add("Saray");
            lista_nomes.Add("Larissa");
            lista_nomes.Add("Lucas");
            lista_nomes.Add("Guilherme");
            lista_nomes.Add("Maciel");
            #endregion

            #region Lista Números
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(5);
            lista_numeros.Add(8);
            lista_numeros.Add(54);
            lista_numeros.Add(57);
            lista_numeros.Add(2);
            lista_numeros.Add(3);
            lista_numeros.Add(15);
            lista_numeros.Add(12);
            lista_numeros.Add(7);
            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 358.99);
            lista_produtos.Add("Mouse", 29.5);
            lista_produtos.Add("Monitor", 780.85);
            lista_produtos.Add("Memória 16Gb", 700.00);
            lista_produtos.Add("Memória 8Gb", 375.65);
            lista_produtos.Add("Processador", 1250);
            lista_produtos.Add("Placa Mãe", 623.75);
            lista_produtos.Add("Gabinete mATX", 150);
            lista_produtos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Washington", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");
            #endregion

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            #region INTRODUÇÃO DO LINQ EX
            // Metodo Comum SEM USAR O LINK
            //foreach (int num in lista_numeros)
            //{
            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }
            //}

            ////Utilizando LINQ
            // Obter a fonte dos dados.
            // Criar a consulta.
            // Executar a consulta.

            //Interface IEnumerable<T>:
            //IEnumerable<T> é uma interface genérica definida no
            //namespace System.Collections.Generic.
            //T é um parâmetro de tipo genérico que pode ser qualquer
            //tipo de dado. No caso de IEnumerable<int>,
            //T é substituído por int, indicando que a coleção contém
            //elementos do tipo int.
            //AQUI FAÇO A CONSULTA
            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //AQUI EXECUTAMOS A CONSULTA
            //foreach (int n in res)
            //{
            //    lista.Items.Add(n);
            //}
            #endregion

            #region LINQ CONSULTA NOME
            //FAZENDO PESQUISA NA LISTA DE NOMES
            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes 
                                       where nome.StartsWith(txt) 
                                       select nome;
            //AQUI USO UM ARRAY
            lista.Items.AddRange(res2.ToArray());
            //POSSO USAR UM FOREACH
            //foreach (string n in res2)
            //{
            //    lista.Items.Add(n);
            //}
            #endregion
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Operador de Filtragem, a clausula where

            string txt = txtConsulta.Text.ToLower();

            var res = from nome in lista_nomes 
                      where nome.ToLower().Contains(txt) 
                      select nome;

            foreach (var n in res)
            {
                lista.Items.Add(n);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            // Operador de ordenação
            lista.Items.Clear();
            string txt = txtConsulta.Text;

            //var res = from num in lista_numeros 
            //          orderby num descending 
            //          where num <= 10 
            //          select num;

            //var res = from nome in lista_nomes orderby nome select nome;

            //foreach (var n in res)
            //{
            //    lista.Items.Add(n);
            //}

            var res = from produto in lista_produtos
                      orderby produto.Key
                      select produto;

            foreach (KeyValuePair<string, double> item in res)
            {
                lista.Items.Add(item.Key + " R$ " + item.Value);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            // Operadores de Agrupamento
            lista.Items.Clear();
            txtConsulta.Text = "";

            var res = from estado in lista_estados 
                      group estado by estado.Value;
            
            foreach (var grupo in res)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add("     " + estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            //contar
            //conto o número de elementos na lista com o count
            //int cont1 = lista_nomes.Count();

            //conto o número de elementos que começam com D
            //int cont2 = (from nome in lista_nomes where nome.StartsWith("D") select nome).Count();
            //lista.Items.Add(cont1 + " nomes.");
            //lista.Items.Add(cont2 + " nomes começandos com letra D.");

            //média
            //average é usado pra calcular a média
            //double media1 = lista_numeros.Average();
            //lista.Items.Add(media1 + " média dos valores na lista números.");

            //aqui calculo a média dos menores que 10
            //var res1 = from num in lista_numeros where num < 10 select num;
            //double media2 = res1.Average();
            //lista.Items.Add(media2 + " média menores que 10.");

            //soma
            //com o sum faço a soma dos valores
            //int soma1 = lista_numeros.Sum();
            //lista.Items.Add(soma1 + " soma dos valores.");
            //faço a soma dos menores que 10
            //var res2 = from num in lista_numeros where num < 10 select num;
            //int soma2 = res2.Sum();
            //lista.Items.Add(soma2 + " soma dos valores < 10.");

            // Tambem aplicados nas consultas.
            //min busca o mínimo
            //lista.Items.Add(lista_numeros.Min() + " valor minimo em lista numeros");
            //max busca o máximo
            //lista.Items.Add(lista_numeros.Max() + " valor máximo em lista numeros");

            // Tambem aplicados nas consultas.
            //long contagem = lista_numeros.LongCount();

            // Tambem aplicado nas consoltas.
            //aggregate vou procurar o maior nome da lista
            //usando lambda
            //No aggregate passamos um valor inicial e uma função
            //posso retirar o lista_nomes[0]
            string maiorNome = lista_nomes.Aggregate(lista_nomes[0],(maior, proximo) => {
                if (maior.Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });

            lista.Items.Add(maiorNome + " é o maior nome da lista");
        }

        private void btnOperadoresDeElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Tambem aplicados nas consultas.
            //pode ser usado o .first, mas se alista estiver vazia dará uma excessão
            //uso FirstOrDefault para retornar 0 
            int primeiro = lista_numeros.FirstOrDefault();
            lista.Items.Add(primeiro);

            int ultimo = lista_numeros.LastOrDefault();
            lista.Items.Add(ultimo);

            int elementoEm = lista_numeros.ElementAtOrDefault(3);
            lista.Items.Add(elementoEm);

            var consulta = from num in lista_numeros where num > 1000 select num;
            int numero = consulta.FirstOrDefault();
            lista.Items.Add(numero);   
        }

        private void btnLINQLambda_Click(object sender, EventArgs e)
        {
            //vai retornar todos os nomes
            //var cons1 = from nome in lista_nomes select nome; // Comum
            //usando operador de seleção
            //var cons1L = lista_nomes.Select(nome => nome); 
            //lista.Items.AddRange(cons1.ToArray());

            //fazendo uma consulta usando a cláusula where
            //var cons2 = from nome in lista_nomes where nome.StartsWith("G") select nome;
            //usando O método where no lambda "=>" indica o retorno
            //var cons2L = lista_nomes.Where((nome) => nome.StartsWith("G"));
            //lista.Items.AddRange(cons2L.ToArray());

            //consulta usando o orderby
            //var cons3 = from nome in lista_nomes orderby nome select nome;
            //var cons3L = lista_nomes.OrderBy(nome => nome);
            //fazendo consulta order by Descending ordem DECRESCENTE
            //var cons3L2 = lista_nomes.OrderByDescending(nome => nome);
            //lista.Items.AddRange(cons3L2.ToArray());

            //GROUPBY USANDO O LAMBDA
            //var cons4 = from estado in lista_estados group estado by estado.Value;
            var cons4L = lista_estados.GroupBy(estado => estado.Value);

            foreach (var grupo in cons4L)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add("     " + estado.Key);
                }
            }
        }
    }
}
