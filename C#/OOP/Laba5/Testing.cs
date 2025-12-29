namespace Laba5

{
    /// <summary>
    /// Методы класса позволяют тестировать
    /// перечисления - создавать и обрабатывать
    /// объекты перечислений, определенных в проекте
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Создание объектов перечислений,
        /// присваивание значений и вывод на печать
        /// </summary>
        public void TestEnum()
        {
            const string COLOR_EQUAL =
                "Цвета совпадают!";
            const string COLOR_DIFFERENT =
                "Цвета не совпадают!";
            const string ENUM_RAINBOW =
                "Цвета перечисления Rainbow:";

            Rainbow color = new Rainbow();
            //MyColors color1 = MyColors(MyColors.blue);
            MyColors color1 = MyColors.white;
            TwoColors color2;
            color2 = TwoColors.white;
            Console.WriteLine("цвет1 = {0}, цвет2 = {1}",
                color1, color2);

            //if(color1 != color2) color2 = color1;
            if (color1.ToString() == color2.ToString())
                Console.WriteLine(COLOR_EQUAL);
            else Console.WriteLine(COLOR_DIFFERENT);

            Rainbow color3;
            color3 = (Rainbow)4;
            color1 = MyColors.blue;
            Console.WriteLine("цвет1 = {0}, цвет2 = {1}",
                color1, color3);
            if (color3 == Rainbow.голубой)
                Console.WriteLine(COLOR_EQUAL);
            else Console.WriteLine(COLOR_DIFFERENT);

            Console.WriteLine(ENUM_RAINBOW);
            for (int num = 0; num < 10; num++)
            {
                color = (Rainbow)num;
                Console.WriteLine(color.ToString());
            }

            Sex who = Sex.man;
            Days first_work_day = (Days)(long)1;

            Console.WriteLine("who={0}, first_work_day={1}",
                who, first_work_day);
        }

        public enum Profesion
        {
            teacher,
            engineer,
            businesswoman
        };

        public enum MyColors
        {
            red,
            blue,
            yellow,
            black,
            white
        }

        public enum TwoColors
        {
            black,
            white
        }

        public enum Rainbow
        {
            красный,
            оранжевый,
            желтый,
            зеленый,
            голубой,
            синий,
            фиолетовый
        }

        public enum Sex : byte
        {
            man = 1,
            woman
        }

        public enum Days : long
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }

    }
}
