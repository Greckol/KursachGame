namespace Fightgame
{
    internal static class Program
    {
        public static bool ShouldOpenForm1 { get; set; } = false;
        public static string Difficulty { get; set; }
        public static int PanelSizeWidth { get; set; }
        public static int PanelSizeHeight { get; set; }
        public static string PlayerName { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());

            if (ShouldOpenForm1)
            {
                Form1 form1 = new Form1(
                    Difficulty,
                    PanelSizeWidth,
                    PanelSizeHeight,
                    PlayerName);
                Application.Run(form1);
            }
        }
    }
}