using Murder.Editor;

namespace PixelGameJam2024.Editor
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var editor = new Architect(new PixelGameJam2024Architect()))
            {
                editor.Run();
            }
        }
    }
}
