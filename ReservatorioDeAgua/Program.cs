using System;

class Program
{
    static void Main()
    {
        bool boiaB = false; // Boia B acionada (indicando que o nível está alto)
        bool boiaC = false; // Boia C acionada (indicando que o nível está baixo)
        bool bombaLigada = false; // Estado da bomba
        bool eletrovalvulaLigada = false; // Estado da eletroválvula

        while (true)
        {
            Console.WriteLine("Digite o nível de água (0 a 100): ");
            int nivelAgua = Convert.ToInt32(Console.ReadLine());

            // Verifica se o nível é válido
            if (nivelAgua < 0 || nivelAgua > 100)
            {
                Console.WriteLine("Erro: Nível de água inválido.");
                continue;
            }

            // Atualiza o estado das boias
            boiaB = nivelAgua >= 70; // Nível alto
            boiaC = nivelAgua < 30;  // Nível baixo

            // Controle da eletroválvula
            if (!boiaB)
            {
                eletrovalvulaLigada = true;
                Console.WriteLine("Eletroválvula acionada. Entrada de água permitida.");
            }
            else
            {
                eletrovalvulaLigada = false;
                Console.WriteLine("Eletroválvula desligada.");
            }

            // Controle da bomba
            if (nivelAgua > 0 && boiaC)
            {
                bombaLigada = true;
                Console.WriteLine("Bomba ligada. Reabastecendo o reservatório.");
            }
            else if (nivelAgua == 0)
            {
                bombaLigada = false;
                Console.WriteLine("Erro: Reservatório vazio. Bomba desligada.");
            }
            else
            {
                bombaLigada = false;
                Console.WriteLine("Bomba desligada.");
            }

            // Estado atual do sistema
            Console.WriteLine($"Estado do sistema: Bomba: {(bombaLigada ? "Ligada" : "Desligada")}, Eletroválvula: {(eletrovalvulaLigada ? "Ligada" : "Desligada")}");
            Console.WriteLine();
        }
    }
}
