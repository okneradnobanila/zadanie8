using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLib;

namespace CshGit8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВыберите действие:\n\n1) Показать информацию о студентах " +
                "\n2) Добавить студента " +
                "\n3) Удалить студента \n4) Изменить студента \n5) Поиск студента " +
                "\n6) Выход\n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("\nВыберите действие:\n\n1) Вся информация о студентах" +
                    "\n2) Список студентов с инициалами" +
                    "\n3) Список студентов старше 18\n4) Список студентов младше 18\n");
                int n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 == 1)
                {
                    Student.showlist();
                }
                if (n1 == 2)
                {
                    Student.initials();
                }
                if (n1 == 3)
                {
                    Student.starshe();
                }
                if (n1 == 4)
                {
                    Student.mladshe();
                }
                
            }

            if (n == 2)
            {
                Student.newstudent();
            }

            if (n == 3)
            {
                Student.deletestudent();
            }

            if (n == 4)
            {
                Student.correctinfo();
            }

            if (n == 5)
            {
                Student.poisk();
            }

            if (n == 6)
            {
                Student.close();
            }

           
            
        }
    }
}
