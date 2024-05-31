using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp
{
    abstract class Task
    {
        protected string text;
        protected string Text
        {
            get { return text; }
            private set { text = value; }
        }
        public Task(string text)
        {
            this.text = text;
        }
        protected virtual void ParseText() { }
    }
    class Task1 : Task
    {
        private string minsentence;
        public string Minsentence
        {
            get { return minsentence; }
            set { minsentence = value; }
        }
        [JsonConstructor]
        public Task1(string text) : base(text)
        {
            ParseText();
        }
        protected override void ParseText()
        {
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            minsentence = sentences[0];
            foreach (var sentence in sentences)
            {
                if (sentence.Length <= minsentence.Length) minsentence = sentence;
            }
        }
        public override string ToString()
        {
            return minsentence;
        }
    }
    class Task2 : Task
    {
        [JsonConstructor]
        public Task2(string text) : base(text)
        {
            ParseText();
        }
        protected override void ParseText()
        {
            string currentWord = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    currentWord += text[i];
                }
                else if (text[i] != ' ')
                {
                    text = text.Remove(i - currentWord.Length, currentWord.Length);
                }
                else currentWord = "";
            }
        }
        public override string ToString()
        {
            return text;
        }
    }
    class JsonIO
    {
        public static void Write<T>(T obj, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, obj);
            }
        }
        public static T Read<T>(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<T>(fs);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            string text = "Some text";
            Task[] tasks = {
            new Task1(text),
            new Task2(text)
            };
            Console.WriteLine(tasks[0]);
            Console.WriteLine(tasks[1]);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = "fourth task";
            path = Path.Combine(path, folderName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName1 = "string_1.json";
            string fileName2 = "string_2.json";

            fileName1 = Path.Combine(path, fileName1);
            fileName2 = Path.Combine(path, fileName2);
            if (!File.Exists(fileName1))
            {
                JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
            }
            else
            {
                var t1 = JsonIO.Read<Task2>(fileName1);
                Console.WriteLine(t1);
            }
            if (!File.Exists(fileName2))
            {
                JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
            }
            else
            {
                var t2 = JsonIO.Read<Task2>(fileName2);
                Console.WriteLine(t2);
            }
        }
    }
}
