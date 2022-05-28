using System;

namespace KIRILLOOP
{
    class Programm
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Positions
    {
        public int id_positions;
        public string name_positions;

        public void add_position()
        {
            if (id_positions > 0)
            {
                Console.WriteLine("Должность успешно добавлена");
            }
        }

        public void drop_position()
        {
            Console.WriteLine("Должность успешно удалена");
        }
    }

    public class Employer
    {
        public int id_employer;
        public string name_company;
        public string kind_activity;
        public string address;
        public string phone;

        public void create_employer()
        {
            if (id_employer > 0)
            {
                Console.WriteLine($"Профиль успешно создан c номером {id_employer}");
            }
            
        }

        public void drop_employer()
        {
            Console.WriteLine("Профиль успешно удален");
        }
    }

    public class Vacancy
    {
        public int id_vacancy;
        public Employer id_employer;
        public Positions id_positions;
        public string requirements;
        public string gender;
        public string education;
        public int age;
        public int work_experience;
        public int salary;

        public void watch_vacancy()
        {
            Console.WriteLine("Вакансия просмотрена");
        }

        public void create_vacancy()
        {
            if (id_vacancy > 0)
            {
                Console.WriteLine($"Вакансия успешно создана с номеров {id_vacancy}");
            }
            
        }

        public void place_vacancy()
        {
            if (id_vacancy > 0)
            {
                Console.WriteLine($"Вакансия с {id_vacancy}номером успешно размещена");
            }
            
        }

        public void update_salary()
        {
            if (salary != 0)
            {
                Console.WriteLine($"зарплата изменена на {salary}");
            }
            
        }

        public void drop_vacancy()
        {
            Console.WriteLine("Вакансия успешно удалена");
        }
    }

    public class Applicant
    {
        public int id_applicant;
        public int id_positions;
        public int work_experience;
        public string last_name;
        public string first_name;
        public string dad_name;
        public string gender;
        public string phone;
        public string education;
        public int age;
        public string competencies;
        public int salary;
        public DateTime Date_registration;

        public void create_resume()
        {
            if (id_applicant > 0)
            {
                Console.WriteLine($"Создано новое резюме с номером {id_applicant}");
            }
        }

        public void select_position()
        {
            if (id_positions > 0)
            {
                Console.WriteLine($"Должность выбрана {id_positions}");
            }
            
        }

        public void update_resume()
        {
            Console.WriteLine("Резюме успешно изменено");
        }

        public void drop_resume()
        {
            Console.WriteLine("Резюме успешно удалено");
        }
    }

    public class Managers
    {
        public int id_manager;
        public string last_name;
        public string first_name;
        public string dad_name;
        public int Earnings;
        public int Premium;
        public int Fine;

        public void salary()
        {
            Console.WriteLine($"Зарплат начислена в размере {Earnings}");
        }

        public void price()
        {
            Console.WriteLine($"Премия начислена в размере {Premium}");
        }

        public void rebuke()
        {
            Console.WriteLine($"{last_name} {first_name} {dad_name} Сделан выговор");
        }

        public void dismiss()
        {
            Console.WriteLine($"Сотрудник {last_name} {first_name} {dad_name}  уволен");
        }

        public void holiday()
        {
            Console.WriteLine($"Сотрудник {last_name} {first_name} {dad_name} отправлен в отпуск");
        }
    }

    public class Interview
    {
        public int id_interview;
        public Managers id_manager;
        public Vacancy id_vacancy;
        public Applicant id_applicant;
        public string interview_result;
        public DateTime date;

        public void conduct_an_interview()
        {
            if (id_interview > 0)
            {
                Console.WriteLine("Собеседование проведено");
            }
            
        }

        public void appoint_manager()
        {
            Console.WriteLine($"Менеджер с номером {id_manager} назначен");
        }

        public void evaluate_applicant()
        {
            Console.WriteLine($"Соискатель с номером {id_applicant} оценен");
        }

        public void pass_interview()
        {
            Console.WriteLine($"Соискатель с номером {id_applicant} прошел собеседование");
        }

        public void not_pass_interview()
        {
            Console.WriteLine($"Соискатель с номером {id_applicant} не прошел собеседование");
        }
    }
}