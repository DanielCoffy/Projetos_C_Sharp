using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets; //IMPORTAR 
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterNetwork INDICA QUE VAMOS USAR O IP V4
            //SocketType.Stream USADO PRA COMUNICAÇÃO DE DADOS
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //DEFINIMOS O PONTO DE COMUNICAÇÃO
            //IP=127.0.0.1
            //PORTA=1234
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            //ASSOCIA O SOCKET AO ENDPOINT
            socket.Bind(endPoint);

            //Para ESCUTAR AS REQUISIÇÕES DOS CLIENTES
            socket.Listen(5);

            Console.WriteLine("Escutando...");

            //VAI CRIAR UMA CONEXÃO COM QUEM FAZ UMA REQUISIÇÃO
            Socket escutar = socket.Accept();

            byte[] bytes = new byte[255];
            //A INFORMAÇÃO RECEBIDA ELE VAI COLOCAR DENTRO DO ARRAY DE BYTES
            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Cliente falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socket.Close();

            Console.WriteLine("Servidor Finalizado\nPressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
