using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringsNullableTypesCastings
{
    public struct MyStruct
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct struct1;           //nulls are not allowed
            MyStruct? struct2 = null;   //nulls are allowed

            struct1.Name = "ala ma kota";
            struct2 = struct1;

            SimpleTypesCanBeNullable();

            StringsAreImmutable();
        }

        private static void SimpleTypesCanBeNullable()
        {
            int m2 = 10;    //we can't store null value here
            int? m = null;  //we can store null value in m variable

            //m ?? 20 - check if m equals null, if it is null return 20, otherwise return m
            m2 += m ?? 20;
            //statemenet belowe will not work as m2 is not null, and m can be null (we can't save null in not null variable)
            //m2 = m2 + m;

            bool check1 = false;    //only true or false
            bool? check2 = null;    //true, false or null

            check2 = check1;
            //operation below is not allowed becouse check1 cannot be null and check2 can
            //check1 = check2;
            //to save check2 inside check1 use value property
            check1 = check2.Value;
            //it is better to check first if there is value inside using HasValue property, otherwise it is possible app will crash (null exception will be thrown
            if (check2.HasValue)
                check1 = check2.Value;
        }

        private static void StringsAreImmutable()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Ala");
            builder.Append(" ");
            builder.Append("ma");
            builder.Append(" ");
            builder.Append("kota");
            string testString = builder.ToString();
        }
    }
}
