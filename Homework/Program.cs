﻿using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализовать класс Банковский клиент.
            //--Сделать класс Клиент, который может содержать множество счетов (из предыдущего ДЗ)
            //--Сделать свойство, отображающее общую сумму денег на всех счетах.
            //--Клиенты могут быть 2х типов: обычные и VIP.
            //--Обычные клиенты не могут иметь более 3х счетов, VIP - до 10 счетов.
            //--Реализовать методы:
            //--создания новых счетов для клиентов,
            //--закрытие счета по его номеру.
            //--Реализовать класс Банк, который производит операции по счетам: перевод денег с одного счета на другой
            //--Про счета:
            //--Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля
            //--Типы счетов:
            //--сберегательный - возможность пополнения и изъятия денег со счета
            //--расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание,
            //--Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции. 
            //--Счет не может быть закрыт, если он имеет положительный баланс
            Console.WriteLine("Hello World!");
        }
    }
}
