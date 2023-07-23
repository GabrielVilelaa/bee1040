using System;
using System.Globalization;
class bee1040
{

    static void Main(string[] args)
    {

        float Note_1, Note_2, Note_3, Note_4, media;


        string [] Notas = (Console.ReadLine ().Split(' '));
         Note_1= float.Parse(Notas[0],CultureInfo.InvariantCulture);
         Note_2= float.Parse(Notas[1], CultureInfo.InvariantCulture);
         Note_3= float.Parse(Notas[2], CultureInfo.InvariantCulture);
         Note_4= float.Parse(Notas[3], CultureInfo.InvariantCulture);

        media = (Note_1*2) + (Note_2 * 3) + (Note_3*4) + (Note_4*1);
        media = media / 10;

        if (media >= 7.0 && media <= 10)
        {
            Console.WriteLine("Media:" + media.ToString("F1", CultureInfo.InvariantCulture)); ;
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media <= 4.9 )
        {
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5.0 && media <= 6.9 )
        {
         
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");

            float novoexame = float.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            media = (media + novoexame) / 2;
            if (media >= 5.0) {
                Console.WriteLine("Nota do exame: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final:" + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if (media < 4.9){
                Console.WriteLine("Nota do exame: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else { }
        }
        Console.ReadLine();
    }

}