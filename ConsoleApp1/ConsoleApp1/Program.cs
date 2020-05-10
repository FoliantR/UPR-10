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
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:

                    Console.Write("Изначальное число: ");
                    ArifmeticCalcul calcul = new ArifmeticCalcul(Convert.ToDouble(Console.ReadLine()));
                    calcul.Print += Calcul_Print;
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
                case 2:
                    //Вторая программа
                    break;
                default:
                    break;
            }
        }
    }
}
