using LibrairieConversionNote;
using System;
//Equipe 1 : Jonathan Amaral , Jonathan Larouche, Jean-Samuel Verret, Gabriel Laliberté
bool choixvalide = false;
List<string> listenotes = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
String reponse = "";
while (choixvalide == false)
{
    Console.Write("Conversion a faire (options disponible: NOTE ou QUITTER): ");
    reponse = Console.ReadLine().ToUpper();
    if (reponse == "NOTE")
    {
        bool notecorrect = false;
        while (notecorrect == false)
        {
            Console.Write("Conversion de Note: ");
            string notetotranslate = Console.ReadLine().ToUpper();
            ConversionAlphaToNote noteachanger = new ConversionAlphaToNote(notetotranslate);
            string final = noteachanger.transformer(notetotranslate);
            Console.WriteLine($"Note traduite: {final}");
        }
    }
    else if (reponse == "QUITTER")
    {
        choixvalide = true;
    }
    choixvalide = false;
}
return 0;
