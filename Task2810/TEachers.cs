using DZ1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{
    class Mathem : Learn
    {
        public int lecture { get; } = 162;
        public int practice { get; set; } = 0;
        public int laboratory { get; set; } = 162;
        public int independent { get; set; } = 270;
        public int general { get; set; } = 720;
        public Mathem()
        {
        }       
        public Mathem(int lectur, int gener, int practic, int laba, int independ)
        {
            this.lecture = lectur;
            this.general = gener;
            this.practice = practic;
            this.independent = independ;
            this.laboratory = laba;

            Console.WriteLine("По вашему желанию составлен новый план:");
        }
        public override void Teach()
        {
            Console.WriteLine("Математический анализ\nПреподователь: Сидоров" +
                " Анатолий Михайлович");
        }
        
        public override void Geninfo()
        {
            Console.WriteLine($"Всего {general} часов\n" +
                $"{lecture} часа лекций\n{practice} часов практики\n" +
                $"{laboratory} часа лабораторных\n" +
                $"{independent} часов самостоятельного изучения\n");
        }
        public override void Help()
        {
            Console.WriteLine("Информация об классе Mathem\n" +
                "Вы можете посмотреть название предмета и имя преподователя" +
                " через Teach\nМожете посмотреть учебный план через Geninfo\n" +
                "можете написать свой учебныц план через Mathem\n" +
                "через GlassInfo можно узнать о том, как проводятся различные занятия");
        }
        public override void ClassInfo()
        {
            Console.WriteLine("Введите вид занятий, о которых хотите узнать");
            string TypeClass = Console.ReadLine();
            try
            {
                string clas = TypeClass.ToLower();
                switch (clas)
                {
                    case "лекции":
                        Console.WriteLine("Лекции проходят в очном формате" +
                            " в большом зале в котором находится 50-70 студентов");
                        break;
                    case "семинары":
                        Console.WriteLine("Семинары проходят в очном формате" +
                            " на которых сидит подгруппа из 10 человек");
                        break;
                    case "лабораторные":
                        Console.WriteLine("Лабораторные проходят в очном формате");
                        break;
                    default:
                        Console.WriteLine("Повторите попытку, если хотите выйти напишите exit");
                        string ex = Console.ReadLine();
                        if (ex == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            ClassInfo();
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("повторите попытку, если хотите выйти напишите exit");
                string ex = Console.ReadLine();
                if (ex == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    ClassInfo();
                }
            }
        }
        public override void Pay()
        {
            Console.WriteLine("Введите количество занятий в месяц и ставку за час");
            double cnt = Convert.ToDouble(Console.ReadLine());
            double zp = Convert.ToDouble(Console.ReadLine());
            double cnthours = cnt * 1.5;
            Console.WriteLine($"Зарплата за {cnt} занятий будет составлять {cnthours * zp} рублей");
        }
    }
    class Algem : Learn
    {
        public Algem()
        {
        }
        public Algem(int lectur, int gener, int practic, int laba, int independ)
        {
            this.lecture = lectur;
            this.general = gener;
            this.practice = practic;
            this.independent = independ;
            this.laboratory = laba;

            Console.WriteLine("По вашему желанию составлен новый план:");
        }
        public override void Teach()
        {
            Console.WriteLine("Алгебра и геометрия\nПреподователь: Карчевский Евгений Михайлович");
        }
        public override void Geninfo()
        {
            Console.WriteLine($"Всего {general} часов\n" +
                $"{lecture} часа лекций\n{practice} часов практики\n" +
                $"{laboratory} часа лабораторных\n" +
                $"{independent} часов самостоятельного изучения\n");
        }
        public override void Help()
        {
            Console.WriteLine("Информация об классе Algem\n" +
                "Вы можете посмотреть название предмета и имя преподователя" +
                " через Teach\nМожете посмотреть учебный план через Geninfo\n" +
                "можете написать свой учебныц план через Mathem\n" +
                "через GlassInfo можно узнать о том, как проводятся различные занятия");
        }
        public override void ClassInfo() 
        {
            Console.WriteLine("Введите вид занятий, о которых хотите узнать");
            string TypeClass = Console.ReadLine();
            try
            {
                string clas = TypeClass.ToLower();
                switch (clas)
                {
                    case "лекции":
                        Console.WriteLine("Лекции проходят в заочном/очном формате" +
                            " переписывание теориии по онлайн лекциям");
                        break;
                    case "семинары":
                        Console.WriteLine("Семинары проходят в заочном/очном формате" +
                            " даются задания по онлайн решебнику");
                        break;
                    case "лабораторные":
                        Console.WriteLine("Лабораторные проходят в заочном формате");
                        break;
                    default:
                        Console.WriteLine("Повторите попытку, если хотите выйти напишите exit");
                        string ex = Console.ReadLine();
                        if (ex == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            ClassInfo();
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("повторите попытку, если хотите выйти напишите exit");
                string ex = Console.ReadLine();
                if (ex == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    ClassInfo();
                }
            }
        }
        public override void Pay()
        {
            Console.WriteLine("Введите количество занятий в месяц и ставку за час");
            double cnt = Convert.ToDouble(Console.ReadLine());
            double zp = Convert.ToDouble(Console.ReadLine());
            double cnthours = cnt * 1.5;
            Console.WriteLine($"Зарплата за {cnt} занятий будет составлять {cnthours * zp} рублей");
        }
        public int lecture { get; } = 108;
        public int practice { get; } = 0;
        public int laboratory { get; } = 108;
        public int independent { get; } = 216;
        public int general { get; } = 520;
    }
}
