using System;

namespace Challenge___Datatypes_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteValue = 255; // 0 to 255
            sbyte sbyteValue = 127; // -128 to 127
            int intValue = 2147483647; // -2,147,483,648 to 2,147,483,647 unsigned integer
            uint uintValue = 4294967295; // 0 to 4294967295  signed integer
            short shortValue = 32767; // -32,768 to 32,767
            ushort ushortValue = 65535; // 0 to 65535
            long longValue = 9223372036854775807; // -9223372036854775808 to 9223372036854775807
            ulong ulongValue = 18446744073709551615; // 0 to 18446744073709551615
            float floatValue = 340282300000000f; // 	-3.402823e38 to 3.402823e38
            double doubleValue = 179769313486232000; // -179769313486232e308 to 179769313486232e308
            char charValue = 'b'; //Unicode symbols used in text
            bool boolValue = true; // True or false
            object objectValue; // Base type of all other types
            string stringValue = "This is a string"; // A sequence of characters
            decimal decimalValue = 10.5m; // ±1.0 × 10e−28 to ±7.9 × 10e28. Precise fractional or integral type that can represent decimal numbers with 29 significant digits

            string numText = "15";
            int numFromText = int.Parse(numText);


            Console.WriteLine(numText);

            Console.ReadKey();
        }
    }
}
