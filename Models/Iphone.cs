//Código Modificado por Luiz Gustavo
//Assista as gravações destas modificações no canal L GUSTAVO - PROGRAMADOR PROFISSIONAL
// LINK DO CANAL - https://www.youtube.com/@lgustavo-programador
// LINK da PLAYLIST BOOTCAMP POTTENCIAL - https://www.youtube.com/watch?v=GHP6S3zKy7Y&list=PLNvQEEUeLujsHq1qF7Ze3C7FsE0ll3XyD

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
           public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no IPHONE");
        }
    }
}