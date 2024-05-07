using Murder;
using Murder.Diagnostics;

namespace PixelGameJam2024
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                using Game game = new(new PixelGameJam2024Game());
                game.Run();
            }
            catch (Exception ex) when (GameLogger.CaptureCrash(ex)) { }
        }
    }
}
