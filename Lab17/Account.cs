using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    //Класс для моделирования счета в банке, закрытые поля для номера счета, баланса, ФИО владельца.
    class Account<T>
    {
        T NumAccount;
        float BalanceAccount;
        string HolderAccount;

        public void Input()
        {
            Console.Write("Введите номер счета: ");
            NumAccount = (T)(Convert.ChangeType(Console.ReadLine(), typeof(T)));
            Console.Write("Введите баланс: ");
            BalanceAccount = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите фамилию владельца: ");
            HolderAccount = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"Номер счета: {NumAccount}, баланс: {BalanceAccount:F2}, владелец: {HolderAccount}";
        }
    }
}
