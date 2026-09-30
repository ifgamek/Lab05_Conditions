// // // // // // // // Console.Write(":");

// // // // // // // // int number = int.Parse(Console.ReadLine());
// // // // // // // // if (number > 0)
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Число положительное.");
// // // // // // // // }
// // // // // // // // else if (number < 0)
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Число отрицательное.");
// // // // // // // // }
// // // // // // // // else
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Число равно нулю.");
// // // // // // // // }


// // // // // // // Console.Write("Введите балл (0-100): ");
// // // // // // // int score = int.Parse(Console.ReadLine());

// // // // // // // if (score >= 91)
// // // // // // // {
// // // // // // //     Console.WriteLine("Оценка: Отлично (5)");
// // // // // // // }
// // // // // // // else if (score >= 71)
// // // // // // // {
// // // // // // //     Console.WriteLine("Оценка: Хорошо(4)");
// // // // // // // }
// // // // // // // else if (score >= 51)
// // // // // // // {
// // // // // // //     Console.WriteLine("Оценка: Удовлетворительно(3)");
// // // // // // // }
// // // // // // // else
// // // // // // // {
// // // // // // //     Console.WriteLine("Оценка Неудовлетворительно(2)");
// // // // // // // }

// // // // // // using System.Reflection.Metadata;

// // // // // // Console.WriteLine("Ввидите кол-во посещений(из 19): ");
// // // // // // int attendance = int.Parse(Console.ReadLine());
// // // // // // Console.Write("Введите среднйи балл по практике: ");
// // // // // // double practiceGpa = double.Parse(Console.ReadLine());
// // // // // // bool goodAttendance = attendance >= 14;
// // // // // // bool goodGrades = practiceGpa >= 3.0;

// // // // // // if (goodAttendance && goodGrades)
// // // // // // {
// // // // // //     Console.WriteLine("+ Допуск к экзамену разрешен.");
// // // // // // }
// // // // // // else if (!goodAttendance && goodGrades)
// // // // // // {
// // // // // //     Console.WriteLine("- Недостаточно посещений. Нужно отработать");
// // // // // // }
// // // // // // else if (goodAttendance && !goodGrades)
// // // // // // {
// // // // // //     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// // // // // // }
// // // // // // else
// // // // // // {
// // // // // //     Console.WriteLine("-Проблемы и с посещением, и с оценками. Срочно к преподавателю");
// // // // // // }

// // // // // Console.Write("введите свой возраст");
// // // // // int age = int.Parse(Console.ReadLine());
// // // // // string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// // // // // Console.WriteLine($"Вы {ageGroup}.");
// // // // // Console.Write("\nВведите температуру за окном (C):");
// // // // // double temp = double.Parse(Console.ReadLine());
// // // // // string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладео" : "мороз");
// // // // // Console.WriteLine($"за окном{weather}");

// // // // // Console.Write("\nВведите число:");
// // // // // int n = int.Parse(Console.ReadLine());
// // // // // string parity = n % 2 == 0 ? "Четное" : "нечетное";
// // // // // Console.WriteLine($"Число {n} - {parity}");

// // // // switch (day)
// // // // {
// // // //     case 1:Console.WriteLine("понедельник");break;
// // // //     case 2:Console.WriteLine("втроник");break;
// // // //     case 3:Console.WriteLine("среда");break;
// // // //     default:Console.WriteLine("неизвестный день");break;
// // // // }

// // // using System.Collections;

// // // Console.WriteLine("меню");
// // // Console.WriteLine("1. Посмотреть расписание");
// // // Console.WriteLine("2. Посмотреть оценки");
// // // Console.WriteLine("3. Связаться с преподавателем");
// // // Console.WriteLine("4. Выйти");
// // // Console.Write("Выберите пункт (1-4): ");

// // // switch (choice)
// // // {
// // //     case "1": Console.WriteLine("Расписание : ИСП -244, каб 102 , 08:30"); break;
// // //     case "2": Console.WriteLine("Ваши оценки: ИРСПО - 20, РПМ -35"); break;
// // //     case "3": Console.WriteLine("Email : ifgamek@outlook.com"); break;
// // //     case "4": Console.WriteLine("До свидания"); break;
// // //     default: Console.WriteLine($"ошибка:пункт <<{choice}>> не существует . ВВедите число от 1 до 4."); break;
// // // }

// // // Console.Write("\nВВедите номер дня недели (1-7)");
// // // int dayNumber = int.Parse(Console.ReadLine());
// // // switch (dayNumber)
// // // {
// // //     case 1:
// // //     case 2:
// // //     case 3:
// // //     case 4:
// // //     case 5:
// // //         Console.WriteLine("Рабочий день - пора учиться!");
// // //         break;
// // //     case 6:
// // //     case 7:
// // //         Console.WriteLine("Выходной - заслуженный отдых");
// // //         break;
// // //     default:
// // //         Console.WriteLine("такого дня не существует");
// // //         break;
// // // }


// // Random random = new Random();
// // int secret = random.Next(1, 101);

// // int attempts = 0;
// // bool guessed = false;

// // Console.WriteLine("");
// // Console.WriteLine("");

// // string result = attempts <= 7
// //     ? $"отличный результат! всего {attempts} попыток"
// //     : $"число найдено за {attempts} попыток. можно лучше!";

// // Console.WriteLine($"правильно! Загаданное число :{secret}");
// // Console.WriteLine($"{result}");

// // string GetHint(int difference)
// // {
// //     switch (difference)
// //     {
// //         case <= 3:
// //             return "горячо";
// //         case <= 10:
// //             return "тепло";
// //         case <= 25:
// //             return "прохладно";
// //         default:
// //             return "холодно";

// //     }
// // }

// // while (!guessed)
// // {
// //     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
// //     string input = Console.ReadLine();
// //     if (!int.TryParse(input, out int guess))
// //     {
// //         Console.WriteLine("!!! введите целое число, а не текст!");
// //         continue;
// //     }
// //     if (guess < 1 || guess > 100)
// //     {
// //         Console.WriteLine("!!! Число должно быть от 1 до 100!");
// //         continue;
// //     }
// //     attempts++;
// //     if (guess < secret)
// //     {
// //         int diff = secret - guess;
// //         string hint = GetHint(diff);
// //         Console.WriteLine($"Больше !{hint}\n");

// //     }
// //     else if (guess > secret)
// //     {
// //         int diff = guess - secret;
// //         string hint = GetHint(diff);
// //         Console.WriteLine($"меньше! {hint}\n");
// //     }
// //     else
// //     {
// //         guessed = true;
// //     }
// // }















// задание 1

// using System.ComponentModel;

// Console.WriteLine("Введите пароль: ");
// string password_1 = Console.ReadLine();

// Console.WriteLine("Ведите повторно пароль");
// string password_2 = Console.ReadLine();

// if (password_1 != password_2)
// {
//     Console.WriteLine("Пароль не правильный");
// }

// else
// {
//     Console.WriteLine("Пароль правильный");
// }

