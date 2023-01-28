//Código Modificado por Luiz Gustavo
//Assista as gravações destas modificações no canal L GUSTAVO - PROGRAMADOR PROFISSIONAL
// LINK DO CANAL - https://www.youtube.com/@lgustavo-programador
// LINK da PLAYLIST BOOTCAMP POTTENCIAL - https://www.youtube.com/watch?v=GHP6S3zKy7Y&list=PLNvQEEUeLujsHq1qF7Ze3C7FsE0ll3XyD

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria )
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}