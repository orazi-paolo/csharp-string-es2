using System;
namespace csharp_string_es2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // I parametri verranno passati dal mio codice di verifica come argomenti del metodo Main


            string nome = args[0];
            string soprannome = args[1];

            // Converti il nome in maiuscolo e salvalo in una variabile
            string nomeUpper = nome.ToUpper();

            // Converti il nome in minuscolo e salvalo in una variabile
            string nomeLower = nome.ToLower();


            // Stampa i risultati
            Console.WriteLine($"Nome in maiuscolo: {nomeUpper}\nNome in minuscolo: {nomeLower}\nCiao, il mio nome è {nome} ma puoi chiamarmi {soprannome.Trim()}");

        }
    }
}
