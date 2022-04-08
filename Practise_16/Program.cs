using System;
using ClassLibrary;
using System.Collections.Generic;
namespace Practise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            
            string answer = "";
            do
            {
                Console.WriteLine("1-Telebe elave et");
                Console.WriteLine("2-Telebeye imtahan elave et");
                Console.WriteLine("3-Telebenin bir imtahan balina bax");
                Console.WriteLine("4-telebenin butun imtahanlarini goster");
                Console.WriteLine("5-Telebenin imtahan ortalamasin goster");
                Console.WriteLine("6-Imtahan sil");
                Console.WriteLine("0-Proqrami bitir");
                answer = Console.ReadLine();
                
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Telebenin adi:");
                        string fullname = Console.ReadLine();
                        Student student = new Student();
                        student.Fullname = fullname;
                        studentList.Add(student);
                        break;
                    case "2":
                        
                        bool check = false;
                        while(!check)
                        {
                            Console.WriteLine("Telebenin nomresi");
                            int studentNo = int.Parse(Console.ReadLine());
                            foreach (var item in studentList)
                            {
                                if (item.No == studentNo)
                                {
                                    Console.WriteLine("imtahan adi:");
                                    string examName = Console.ReadLine();
                                    Console.WriteLine("Imtahan bali:");
                                    int examPoint = int.Parse(Console.ReadLine());
                                    item.AddExam(examName, examPoint);
                                    check = true;
                                }

                            }
                            if (!check)
                            {
                                Console.WriteLine("Bu nomrede telebe yoxdu");
                                break;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Telebenin No-su:");
                        int no = int.Parse(Console.ReadLine());
                        bool check1 = false;
                        foreach (var item in studentList)
                        {
                            if (item.No == no)
                            {
                                Console.WriteLine("neticesine baxmaq istediyiniz imtahanin adi:");
                                string exName = Console.ReadLine();
                                Console.WriteLine(item.GetExamResult(exName)); 
                                check1 = true;
                            }

                        }
                        if (!check1)
                        {
                            Console.WriteLine("Bu nomrede telebe yoxdu");
                            break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("imtahanlarina baxmaq istediyiniz telebenin No-su");
                        int no4 = int.Parse(Console.ReadLine());
                        bool check2 = false;
                        foreach (var item in studentList)
                        {
                            if (item.No == no4)
                            {
                                foreach (var ex in item.Exams)
                                {
                                    Console.WriteLine(ex);
                                }
                                check2 = true;
                            }

                        }
                        if (!check2)
                        {
                            Console.WriteLine("Bu nomrede telebe yoxdu");
                            break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("imtahanlarinin ortalama balina baxmaq istediyiniz telebenin No-su");
                        int no5 = int.Parse(Console.ReadLine());
                        bool check3 = false;
                        foreach (var item in studentList)
                        {
                            if (item.No == no5)
                            {
                                Console.WriteLine(item.GetExamAvg()); 
                                check2 = true;
                            }

                        }
                        if (!check3)
                        {
                            Console.WriteLine("Bu nomrede telebe yoxdu");
                            break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("imtahanini silmey istediyiniz telebennin No-su");
                        int no6 = int.Parse(Console.ReadLine());
                        bool check4 = false;
                        foreach (var item in studentList)
                        {
                            if (item.No == no6)
                            {
                                Console.WriteLine("silmey istediyiniz imtahanin adi:");
                                string exname = Console.ReadLine();
                                item.Exams.Remove(exname);
                                check2 = true;
                            }

                        }
                        if (!check4)
                        {
                            Console.WriteLine("Bu nomrede telebe yoxdu");
                            break;
                        }
                        
                        break;
                    default:
                        break;
                }
            } while (answer!="0");
        }
    }
}
