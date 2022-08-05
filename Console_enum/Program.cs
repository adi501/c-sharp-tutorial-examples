using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_enum
{
    // ref : https://www.codeproject.com/Articles/18809/Enums-in-C

    //#region with out enum
    //class Demo
    //{
    //    public static void Main()
    //    {
    //        int Sunday = 0;
    //        int Monday = 1;
    //        int Tuesday = 2;
    //        int Wednesday = 3;
    //        int Thursday = 4;
    //        int Friday = 5;
    //        int Saturday = 6;
    //        System.Console.WriteLine(Sunday);
    //        System.Console.WriteLine(Monday);
    //        System.Console.WriteLine(Tuesday);
    //        System.Console.WriteLine(Wednesday);
    //        System.Console.WriteLine(Thursday);
    //        System.Console.WriteLine(Friday);
    //        System.Console.WriteLine(Saturday);
    //    }
    //}
    //#endregion

    //#region with enum
    //enum WeekDays
    //{
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    //class Demo
    //{
    //    public static void Main()
    //    {
    //        System.Console.WriteLine(WeekDays.Sunday);
    //        System.Console.WriteLine(WeekDays.Monday);
    //        System.Console.WriteLine(WeekDays.Tuesday);
    //        System.Console.WriteLine(WeekDays.Wednesday);
    //        System.Console.WriteLine(WeekDays.Thursday);
    //        System.Console.WriteLine(WeekDays.Friday);
    //        System.Console.WriteLine(WeekDays.Saturday);
    //    }
    //}
    //#endregion

    //#region enum and integer out put
    //enum WeekDays
    //{
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    //class Demo
    //{
    //    public static void Main()
    //    {
    //        System.Console.WriteLine((int)WeekDays.Sunday);
    //        System.Console.WriteLine((int)WeekDays.Monday);
    //        System.Console.WriteLine((int)WeekDays.Tuesday);
    //        System.Console.WriteLine((int)WeekDays.Wednesday);
    //        System.Console.WriteLine((int)WeekDays.Thursday);
    //        System.Console.WriteLine((int)WeekDays.Friday);
    //        System.Console.WriteLine((int)WeekDays.Saturday);
    //    }
    //}
    //#endregion
    //#region enum with specify constant values for the members of the enum
    //enum WeekDays
    //{
    //    Sunday = 10,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    //class Demo
    //{
    //    public static void Main()
    //    {
    //        System.Console.WriteLine((int)WeekDays.Sunday);
    //        System.Console.WriteLine((int)WeekDays.Monday);
    //        System.Console.WriteLine((int)WeekDays.Tuesday);
    //        System.Console.WriteLine((int)WeekDays.Wednesday);
    //        System.Console.WriteLine((int)WeekDays.Thursday);
    //        System.Console.WriteLine((int)WeekDays.Friday);
    //        System.Console.WriteLine((int)WeekDays.Saturday);
    //    }
    //}
    //#endregion

    //#region enum with we are allowed to specify constant values for the members of the enum
    //enum WeekDays
    //{
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday = 10,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    //class Demo
    //{
    //    public static void Main()
    //    {
    //        System.Console.WriteLine((int)WeekDays.Sunday);
    //        System.Console.WriteLine((int)WeekDays.Monday);
    //        System.Console.WriteLine((int)WeekDays.Tuesday);
    //        System.Console.WriteLine((int)WeekDays.Wednesday);
    //        System.Console.WriteLine((int)WeekDays.Thursday);
    //        System.Console.WriteLine((int)WeekDays.Friday);
    //        System.Console.WriteLine((int)WeekDays.Saturday);
    //    }
    //}
    //#endregion

    #region enum with Explicitly assigning the same values to members of enum is allowed
    enum WeekDays
    {
        Sunday = 10,
        Monday = 10,
        Tuesday = 10,
        Wednesday = 10,
        Thursday = 10,
        Friday = 10,
        Saturday = 10
    }

    class Demo
    {
        public static void Main()
        {
            System.Console.WriteLine((int)WeekDays.Sunday);
            System.Console.WriteLine((int)WeekDays.Monday);
            System.Console.WriteLine((int)WeekDays.Tuesday);
            System.Console.WriteLine((int)WeekDays.Wednesday);
            System.Console.WriteLine((int)WeekDays.Thursday);
            System.Console.WriteLine((int)WeekDays.Friday);
            System.Console.WriteLine((int)WeekDays.Saturday);
        }
    }
    #endregion
}
