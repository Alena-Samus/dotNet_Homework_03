using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwLes3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.

            string user1, user2, nameWinner;
            byte userTry;
            bool correctNumber = true;
            char repeat = 'y';

            // При старте, игрокам предлагается ввести свои никнеймы.
                       
                       
            Console.WriteLine("Введите ник первого игрока");

            user1 = Console.ReadLine();

            Console.WriteLine("Введите ник второго игрока");

            user2 = Console.ReadLine();

            Console.Clear();


            // Никнеймы хранятся до конца игры.


            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            do
            {
                Random randomize = new Random();

            int randomIntResult = randomize.Next(12, 120);

            Console.WriteLine("Число: " + randomIntResult);
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш


                //Цикл выполняется пока randomIntResult больше 0
                do
                {
                    //ход первого игрока
                    nameWinner = user1;
                    do
                    {
                        Console.WriteLine($"Ход игрока {user1}:");
                        userTry = Convert.ToByte(Console.ReadLine());

                        //проверка введенного числа на удовлетворение условий
                        if (userTry != 1 && userTry != 2 && userTry != 3 && userTry != 4)
                        {
                            correctNumber = false;
                            Console.WriteLine("Вы ввели недопустимое число!\nВведите еще раз!");

                        }
                        else
                            break;
                    } while (!correctNumber);



                    randomIntResult -= userTry;
                    correctNumber = true;
                    Console.Clear();

                    Console.WriteLine("Число: " + randomIntResult);

                    //ход второго игрока, если первый еще не победил
                    if (randomIntResult > 0)
                    {
                        nameWinner = user2;

                        do
                        {
                            Console.WriteLine($"Ход игрока {user2}:");
                            userTry = Convert.ToByte(Console.ReadLine());

                            //проверка введенного числа на удовлетворение условий
                            if (userTry != 1 && userTry != 2 && userTry != 3 && userTry != 4)
                            {
                                correctNumber = false;
                                Console.WriteLine("Вы ввели недопустимое число!\nВведите еще раз!");

                            }
                            else
                                break;
                        } while (!correctNumber);


                        randomIntResult -= userTry;
                        correctNumber = true;

                        Console.Clear();
                        
                        Console.WriteLine("Число: " + randomIntResult);


                    }



                } while (randomIntResult > 0);
                //Вывод результата игры

                Console.WriteLine($"Победил: {nameWinner}");
                Console.WriteLine($"Хотите сыграть ещё раз (y/n)?");
                repeat = Convert.ToChar(Console.ReadLine());
            } while (repeat == 'y');


            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

                // *** Сложный бонус
                // Подумать над возможностью реализации однопользовательской игры
                // т е игрок должен играть с компьютером


                // Демонстрация
                // Число: 12,
                // Ход User1: 3
                //
                // Число: 9
                // Ход User2: 4
                //
                // Число: 5
                // Ход User1: 2
                //
                // Число: 3
                // Ход User2: 3
                //
                // User2 победил!
                //Console.ReadKey();
        }
    }
}
