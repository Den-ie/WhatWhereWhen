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
            ("Вапрс 1 - Когда домой?", "1"),
            ("Вапрс 2 - Заебался я если честно", "2"),
            ("Вапрс 3 - Вопросы кончились", "3"),
            ("Вапрс 4 - Как дела?", "4"),
            ("Вапрс 5 - Что такое Бытие?", "5"),
            ("Вапрс 6 - Проверка", "6"),
            ("Вапрс 7 - РОУ РОУ РОУ ДАУБИ", "7"),
            ("Вапрс 8 - Ну ладна", "8"),
        };
        public static string Quest(int Award)
        {
            return Voprosi[Award].Item1;
        }
    }
}
