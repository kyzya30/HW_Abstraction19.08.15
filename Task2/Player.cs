using System;


namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public void Play() { Console.WriteLine("Воспроизвидение музыки"); }
        public void Record() { Console.WriteLine("Запись звука"); }
        void IRecodable.Pause() { Console.WriteLine("Запись звука в состоянии паузы"); }
        void IRecodable.Stop() { Console.WriteLine("Запись звука остановлена"); }
        void IPlayable.Pause() { Console.WriteLine("Воспроизвидение музыки в состоянии паузы"); }
        void IPlayable.Stop() { Console.WriteLine("Воспроизвидение музыки остановлено"); }
    }
}
