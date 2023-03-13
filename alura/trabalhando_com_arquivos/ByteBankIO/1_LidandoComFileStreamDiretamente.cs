using System.Text;


partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecodoArquivo = "contas.txt";

        var numeroDeBytesLidos = -1;
        var buffer = new byte[1024]; //1KB

        using (var fluxodoArquivo = new FileStream(enderecodoArquivo, FileMode.Open))
        {
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxodoArquivo.Read(buffer, 0, 1024); //array, primeira posição e ultima posição
                EscreveBuffer(buffer, numeroDeBytesLidos);
            }

            fluxodoArquivo.Close();

            void EscreveBuffer(byte[] buffer, int bytesLidos)
            {
                var utf8 = new UTF8Encoding();

                var texto = utf8.GetString(buffer, 0, bytesLidos);
                Console.Write(texto);


                //foreach (var meuByte in buffer)
                //{
                //    Console.Write(meuByte);
                //    Console.Write(" ");
                //}
            }
        }
    }
}
