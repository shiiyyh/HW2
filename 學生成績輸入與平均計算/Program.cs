using System;

class Program
{
    static void Main()
    {
        int id;
        double chinese, english, math;
        double sumC = 0, sumE = 0, sumM = 0;
        int count = 0;

        Console.WriteLine("請輸入學號、國文、英文、數學成績（輸入學號0結束）：");

        while (true)
        {
            Console.Write("學號：");
            id = int.Parse(Console.ReadLine());

            if (id == 0)
                break;

            Console.Write("國文 英文 數學：");
            string[] scores = Console.ReadLine().Split(' ');
            chinese = double.Parse(scores[0]);
            english = double.Parse(scores[1]);
            math = double.Parse(scores[2]);

            double avg = (chinese + english + math) / 3.0;
            Console.WriteLine($"學號 {id} 的平均成績：{avg:F2}\n");

            sumC += chinese;
            sumE += english;
            sumM += math;
            count++;
        }

        if (count > 0)
        {
            Console.WriteLine("\n===== 班級平均成績 =====");
            Console.WriteLine($"國文平均：{sumC / count:F2}");
            Console.WriteLine($"英文平均：{sumE / count:F2}");
            Console.WriteLine($"數學平均：{sumM / count:F2}");
        }
        else
        {
            Console.WriteLine("未輸入任何學生資料！");
        }

        Console.WriteLine("\n按任意鍵結束程式...");
        Console.ReadKey();
    }
}
