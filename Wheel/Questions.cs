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
            ("Вопрос под №1 - Чему равна сумма -5 и 120?", "115"),
            ("Вопрос под №2 - В каком году крестили Русь?", "988"),
            ("Вопрос под №3 - Имя первого человека в космосе.", "Юрий"),
            ("Вопрос под №4 - Сколько иммортал предметов у Тинкера?", "3"),
            ("Вопрос под №5 - Висит груша нельзя скушать. Что это?", "Лампочка"),
            ("Вопрос под №6 - Как называется единица измерения силы тока?", "Ампер"),
            ("Вопрос под №7 - Какой элемент из химической таблицы Д.И.Менделеева обозначается Au?", "Золото"),
            ("Вопрос под №8 - В какой таверне находится Тит Ривендер?", "5"),
        };
        public static string Quest(int Award)
        {
            return Voprosi[Award].Item1;
        }

        public static int ViewerPoints = 0;
        public static int ExpertPoints = 0;
    }
}
