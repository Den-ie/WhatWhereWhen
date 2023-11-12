using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wheel
{
    class Questions
    {
        public static List<string> Voprosi = new()
        {
            "Вапрс 1 - Когда домой?",
            "Вапрс 2 - Заебался я если честно",
            "Вапрс 3 - Вопросы кончились",
            "Вапрс 4 - Как дела?",
            "Вапрс 5 - Что такое Бытие?",
            "Вапрс 6 - Проверка",
            "Вапрс 7 - РОУ РОУ РОУ ДАУБИ",
            "Вапрс 8 - Ну ладна",
        };
        public static string Quest(int Award)
        {
            return Voprosi[Award];
        }
    }
}
