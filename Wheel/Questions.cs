using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel
{
    class Questions
    {
        public static List<(string,string)> Voprosi = new()
        {
            ("Чему равна сумма -5 и 120?", "115"),
            ("В каком году крестили Русь?", "988"),
            ("Имя первого человека в космосе.", "Юрий"),
            ("Сколько иммортал предметов у Тинкера?", "3"),
            ("Висит груша нельзя скушать. \nЧто это?", "Лампочка"),
            ("Как называется единица \nизмерения силы тока?", "Ампер"),
            ("Какой из элементов химической таблицы Д.И.Менделеева \nобозначается буквами Au?", "Золото"),
            ("В какой таверне находится Тит Ривендер?", "5"),
        };
        public static string Quest(int Award)
        {
            return Voprosi[Award].Item1;
        }

        public static int ViewerPoints = 0;
        public static int ExpertPoints = 0;
    }
}
