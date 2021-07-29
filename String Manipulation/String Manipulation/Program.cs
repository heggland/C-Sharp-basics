using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 111;
            string name = "Bilbo";
            string job = "Adventurer";

            Console.WriteLine("Hello World!");


            // 1. String concatenation
            Console.WriteLine("string Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am" + age + " years old");

            // 2. String formatting.
            // string formatting uses index
            Console.WriteLine("String Fromatting");
            Console.WriteLine("Hello \n my name is {0}, I am {1} years old. I'm a {2}", name, age, job);


            // 3. String interplation
            // uses $ at the start which will allow us to write our variables like this ${variableName}
            Console.WriteLine("string interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            // 4. Verbatim strings
            // start with @ and tells the compiler to take the string literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Pellentesque massa ipsum, cursus sed accumsan nec, pretium sed nunc. Vivamus consequat nisl
lectus, ac pellentesque nisi hendrerit sit amet. In eu lacus quis felis finibus feugiat ac quis mi

. Curabitur commodo felis erat, nec faucibus lacus commodo eu. Proin felis metus, sodales sed er


os 1vitae, euismod sollicitudin erat. Pellentesque scelerisque sit amet risus eu consequat. Nulla ex tortor, consectetur ac vestibulum at, tincidunt quis sapien.");

            // with verbatim strings backslash doesnt work 
            Console.WriteLine(@"D:\Programfiler\Steam");
        
        }
    }
}
