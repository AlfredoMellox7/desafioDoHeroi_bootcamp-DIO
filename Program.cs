using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.Write("Olá Jogador(a) !\nSeja bem-vindo(a) ao Hall dos guerreiros(as) !\nQual o nome do(a) seu/sua herói/heroína ? ");
        string nomeHeroi = Convert.ToString(Console.ReadLine())!;
        Console.WriteLine($"Ótimo, quantos pontos de expêrienca {nomeHeroi} acumulou na sua longa jornada pelas Terras Distantes ?");
        float pontosExperiencia = float.Parse(Console.ReadLine()!);
        if (pontosExperiencia < 1000)
        {
            Console.WriteLine($"O brasão de {nomeHeroi} será de FERRO .\nParabéns pela sua jornada jovem guerreiro(a).");
        }
        else if (pontosExperiencia >= 1001 && pontosExperiencia <= 2000)
        {
            Console.WriteLine($"O brasão de {nomeHeroi} será de BRONZE .\nParabéns pela sua jornada jovem guerreiro(a).");
        }
        else if (pontosExperiencia >= 2001 && pontosExperiencia <= 3000)
        {
            Console.Write($"O brasão de {nomeHeroi} será de PRATA .\nParabéns pela sua jornada jovem guerreiro(a).");
        }
        else if (pontosExperiencia >= 3001 && pontosExperiencia <= 4000)
        {
            Console.WriteLine($"O brasão de {nomeHeroi} será de OURO .\nParabéns pela sua jornada jovem guerreiro(a).");
        }
        else
        {
            Console.WriteLine($"Wow, {nomeHeroi} é LENDÁRIO(A) !\nSeu brasão será de DIAMANTE !\nParabéns pela sua jornada jovem guerreiro(a).");
        }
        Console.WriteLine("Até a próxima aventura quando o mal precisar ser combatido novamente!\nVocê será convocado !\nAguarde ...");
    }
}