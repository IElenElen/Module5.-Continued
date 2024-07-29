namespace Module5.__Continued
{
    public class Program
    {
        public const string FILE_NAME = @"C:\Users\Ilka\Desktop\.net\zakupy.csv";
        static void Main(string[] args)
        {
            using (StreamWriter sw = File.AppendText(FILE_NAME))
            {
                sw.WriteLine("biały seler, 4");
            }
            var lines = File.ReadLines(FILE_NAME);
        }
    }
}
