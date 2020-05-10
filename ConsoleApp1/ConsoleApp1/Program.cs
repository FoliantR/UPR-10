using System;
using System.Collections;
using System.Collections.Generic;

/*1 Есть набор команд, которые можно выполнять в любом порядке, и сколько угодно раз, например, арифметические команды. 
 * И нужно реализовать возможность отменять последние команды. 

2.	Если набор объектов - экземпляров одного класса, у которых есть числовое поле, например, 
id или номер, и другие поля, несущие информацию. 
Номер у разных объектов повторяться может. 
Реализовать поиск объектов по номеру с помощью List и с помощью Dictionary. 
*/

namespace OOP_UPR_10
{
    class Program
    {
        private static void Calcul_Print(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.Write("Какая программа: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {       
                case 1: // Первая программа
                    Console.Write("Изначальное число: ");
                    ArifmeticCalcul calcul = new ArifmeticCalcul(Convert.ToDouble(Console.ReadLine()));
                    //Добавление обработчика для события
                    calcul.Print += Calcul_Print;
                    // Создаем для каждого свой лог
                    Stack<double> log = new Stack<double>();
                    Stack<double> logAdd = new Stack<double>();
                    Stack<double> logMin = new Stack<double>();
                    Stack<double> logDiv = new Stack<double>();
                    Stack<double> logMult = new Stack<double>();

                    double tempAdd,tempMin,tempDiv,tempMult;
                    bool exit = true;
                    do
                    {
                        Console.Clear();
                        calcul.show();
                        Console.WriteLine("1 - Прибавить\n2 - Вычесть\n3 - Разделить\n4 - Умножить\n5 - Отменить предыдущее действие\n6 - Выйти\n");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                tempAdd = Convert.ToDouble(Console.ReadLine());
                                calcul.Add(tempAdd);
                                logAdd.Push(tempAdd);
                                log.Push(1);
                                break;
                            case 2:
                                tempMin = Convert.ToDouble(Console.ReadLine());
                                calcul.Min(tempMin);
                                logMin.Push(tempMin);
                                log.Push(2);
                                break;
                            case 3:
                                tempDiv = Convert.ToDouble(Console.ReadLine());
                                calcul.Div(tempDiv);
                                logDiv.Push(tempDiv);
                                log.Push(3);
                                break;
                            case 4:
                                tempMult = Convert.ToDouble(Console.ReadLine());
                                calcul.Mult(tempMult);
                                logMult.Push(tempMult);
                                log.Push(4);
                                break;
                            case 5:
                                if (log.Count != 0) 
                                {
                                    switch (log.Pop())
                                    {
                                        case 1:
                                            calcul.Min(logAdd.Pop());
                                            break;
                                        case 2:
                                            calcul.Add(logMin.Pop());
                                            break;
                                        case 3:
                                            calcul.Mult(logDiv.Pop());
                                            break;
                                        case 4:
                                            calcul.Div(logMult.Pop());
                                            break;
                                    }
                                }
                                break;
                            case 6:
                                exit = false;
                                break;
                            default:
                                break;
                        }
                    } while (exit);
                    break;
                case 2:  //Вторая программа
                    Console.Write("С помощью List - 1, Dictionary - 2 : ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        //С помощью List
                        case 1:
                            List<Worker> workers = new List<Worker>();
                            workers.Add(new Worker("Дима", new Id(2)));
                            workers.Add(new Worker("Вика", new Id(6)));
                            workers.Add(new Worker("Кирилл", new Id(2)));
                            foreach (Worker item in workers)
                            {
                                if (item.Id.ID == 2) Console.WriteLine($"{item.Name} {item.Id.ID}\n");
                            }
                            break;
                        //С помощью Dictionary
                        case 2:
                            Dictionary<Id, Trader> workersD = new Dictionary<Id, Trader>();
                            workersD.Add(new Id(7), new Trader("Игорь", 100000));
                            workersD.Add(new Id(3), new Trader("Мария", 5000000));
                            workersD.Add(new Id(3), new Trader("Виктория", 5255));
                            workersD.Add(new Id(5), new Trader("Зюзя", 40000));
                            foreach (KeyValuePair<Id,Trader> item in workersD)
                            {
                                if (item.Key.ID == 3) Console.WriteLine($"{item.Key.ID} {item.Value.Name} {item.Value.Balance}");
                            }
                            break;
                        default:
                            break; //степа лох объелся блох :)))))))))))))))))))) :^)
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
