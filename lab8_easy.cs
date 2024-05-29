using System;
using System.Collections.Generic;
using System.Linq;
abstract class Task
{
    protected string text;
    public Task(string text)
    {
        this.text = text;
        ParseText();
    }
    protected abstract void ParseText();
    protected virtual int Count()
    {
        return -1;
    }
    private double CountPersent(int number, int total)
    {
        return (double)number / (double)total * 100;
    }
}

class Task_2 : Task
{
    public Task_2(string text) : base(text) { }
    public override string ToString()
    {
        return text;
    }
    protected override void ParseText()
    {
        text = "Закодированный текст:\n" + Code(text) + "\nРаскодированный текст:\n" + Code(Code(text));
    }
    protected string Code(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            string word = "";
            while (i < text.Length && char.IsLetter(text[i]))
            {
                word += text[i];
                i++;
            }
            text = text.Remove(i - word.Length, word.Length);
            text = text.Insert(i - word.Length, Reverse(word));
        }
        return text;
    }
    protected string Reverse(string word)
    {
        string reversed_word = "";
        for(int i = word.Length - 1; i > -1; i--)
        {
            reversed_word += word[i];
        }
        return reversed_word;
    }
}

class Task_4 : Task
{
    protected int count = 0;
    public Task_4(string text) : base(text) { }
    public override string ToString()
    {
        return "Сложность текста - " + count;
    }
    protected override void ParseText()
    {
        string puncts = ".?!,:;–()«»";
        for(int i = 0; i < text.Length; i++)
        {
            if (puncts.Contains(text[i])) count++;
        }
        string[] words = text.Split(new char[] {' ', '–'}, StringSplitOptions.RemoveEmptyEntries);
        count += words.Length;
    }
}

class Task_5 : Task
{
    private string letters = "";
    public Task_5(string text) : base(text){ }
    public override string ToString()
    {
        return letters;
    }
    protected override void ParseText()
    {
        text = text.ToLower();
        string[] words = text.Split(new char[] { ' ', '–', ',', '.', ':', '!', '?', ';', '(', ')', '«', '»' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<char, int> count = new Dictionary<char, int>();
        for(int i = 0; i < words.Length; i++)
        {
            char c = words[i][0];
            if (char.IsLetter(c))
            {
                if(!count.ContainsKey(c))
                {
                    count[c] = 0;
                }
                count[c]++;
            }
        }
        var sorted_count = count.OrderByDescending(pair => pair.Value);
        foreach(var pair in sorted_count)
        {
            letters += pair.Key + " " + pair.Value + "\n";
        }
    }
}

class Task_7 : Task
{
    protected string substr;
    protected string words_list;
    public Task_7(string text) : base(text) { }
    public override string ToString()
    {
        return words_list;
    }
    protected override void ParseText()
    {
        Console.WriteLine("Введите подстроку для поиска: ");
        substr = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '–', ',', '.', ':', '!', '?', ';', '(', ')', '«', '»' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            if (word.Contains(substr))
            {
                words_list += word + "\n";
            }
        }
    }
}

class Task_11 : Task
{
    string surnames = "";
    public Task_11(string text) : base(text) { }
    public override string ToString()
    {
        return surnames;
    }
    protected override void ParseText()
    {
        string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                int minLength = Math.Min(words[i].Length, words[j].Length);
                bool swapNeeded = false;
                for (int k = 0; k < minLength; k++)
                {
                    if (char.ToLower(words[j][k]) < char.ToLower(words[i][k]))
                    {
                        swapNeeded = true;
                        break;
                    }
                    else if (char.ToLower(words[j][k]) > char.ToLower(words[i][k]))
                    {
                        break;
                    }
                }
                if (swapNeeded)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }
        foreach(string word in words)
        {
            surnames += word + "\n";
        }
    }
}

class Task_14 : Task
{
    protected int sum = 0;
    public Task_14(string text) : base(text) { }
    public override string ToString()
    {
        return sum.ToString();
    }
    protected override void ParseText()
    {
        for (int i = 0; i < text.Length; i++)
        {
            string num = "";
            while (i < text.Length && char.IsDigit(text[i]))
            {
                num += text[i];
                i++;
            }
            if (num != "")
            {
                sum += int.Parse(num);
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        string text = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. ";
        string list = "Ivanov, Petrov, Smirnov, Sokolov, Kuznetsov, Popov, Lebedev, Volkov, Kozlov, Novikov, Ivanova, Petrova, Smirnova";
        Task_2 task2 = new Task_2(text);
        //Task_4 task4 = new Task_4(text);
        //Task_5 task5 = new Task_5(text);
        //Task_7 task7 = new Task_7(text);
        //Task_11 task11 = new Task_11(list);
        //Task_14 task14 = new Task_14(text);

        Console.WriteLine(task2);
        Console.WriteLine();
        Console.ReadKey();
    }
}
