 using hilo_game.Game;

namespace hilo_game
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            Director director = new Director();
            director.Test();
            director.StartGame();
        }
    }
}
