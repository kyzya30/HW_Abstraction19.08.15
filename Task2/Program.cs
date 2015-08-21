using System;

namespace Task2
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            ActionsInPlayer();   
        }
        static void ActionsInPlayer()
        {
            Player player = new Player();
            Console.WriteLine("Выберите действие: 1 - воспроизвидение муз. 2 - запись звука");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    player.Play();

                    Console.WriteLine("Следующее действие муз.устройства: 1 - Пауза; 2 - Остановить; 3 - Выход;");
                    int newAction = int.Parse(Console.ReadLine());
                    IPlayable iPlayable = (IPlayable)player;
                    switch (newAction)
                    {
                        case 1:
                            iPlayable.Pause();
                            break;
                        case 2:
                            iPlayable.Stop();
                            break;
                        case 3:
                            break;
                    }
                    break;
                case 2:
                    player.Record();
                    Console.WriteLine("Следующее действие записывающего устройства: 1 - Пауза; 2 - Остановить; 3 - Выход;");
                    int nextAction = int.Parse(Console.ReadLine());
                    IRecodable iRecodable = (IRecodable)player;
                    switch (nextAction)
                    {
                        case 1:
                            iRecodable.Pause();
                            break;
                        case 2:
                            iRecodable.Stop();
                            break;
                        case 3:
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка выбора");
                    break;
            }
        }     
        
        
        
    }
}
