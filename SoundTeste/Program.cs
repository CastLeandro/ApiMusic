using System;
void calcMedia(float n1, float n2)
{
 float media = (n1 + n2) / 2;
            if (media > 6)
            {
                Console.WriteLine($"Parabéns! voce foi aprovado com a media {media}");
            }
            else
            {
                Console.WriteLine($"Voce foi reprovado com a media {media}");
            }
}

        Console.WriteLine("Digite as duas notas do aluno: ");
        float n1 = float.Parse(Console.ReadLine()!);
        float n2 = float.Parse(Console.ReadLine()!);

        calcMedia(n1, n2);
