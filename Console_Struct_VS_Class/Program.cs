using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Struct_VS_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Str_Discounts saleDiscounts = new Str_Discounts();
            saleDiscounts.Cloths = 10;
            saleDiscounts.HomeDecor = 5;
            saleDiscounts.Grocery = 2;

            Str_Discounts saleDiscounts1 = new  Str_Discounts();
             saleDiscounts1 = saleDiscounts;
            saleDiscounts1.Cloths = 20;
            saleDiscounts1.HomeDecor = 10;
            saleDiscounts1.Grocery = 4;

            Str_Discounts saleDiscounts2 =new  Str_Discounts();
             saleDiscounts2 = saleDiscounts;
            saleDiscounts2.Cloths = 40;
            saleDiscounts2.HomeDecor = 20;
            saleDiscounts2.Grocery = 8;


            CLS_Discounts objCLS_Discounts = new CLS_Discounts();
            objCLS_Discounts.Cloths = 10;
            objCLS_Discounts.HomeDecor = 5;
            objCLS_Discounts.Grocery = 2;

            CLS_Discounts objCLS_Discounts1 = new CLS_Discounts();

            objCLS_Discounts1 = objCLS_Discounts;

            objCLS_Discounts1.Cloths = 20;
            objCLS_Discounts1.HomeDecor = 10;
            objCLS_Discounts1.Grocery = 4;

            CLS_Discounts objCLS_Discounts2 = new CLS_Discounts();

            //objCLS_Discounts2 = objCLS_Discounts;

            objCLS_Discounts2.Cloths = 40;
            objCLS_Discounts2.HomeDecor = 20;
            objCLS_Discounts2.Grocery = 8;
        }
    }

    public struct Str_Discounts
    {
        public int Cloths { get; set; }
        public int HomeDecor { get; set; }
        public int Grocery { get; set; }
    }

    public class CLS_Discounts
    {
        public int Cloths { get; set; }
        public int HomeDecor { get; set; }
        public int Grocery { get; set; }
    }
}
