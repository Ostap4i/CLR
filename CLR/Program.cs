using System.Reflection;

namespace MySpace
{
    //Task 4
    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello C#!");
        }
    }
    //    Imports System

    //Module Program
    //    Sub Main()
    //        Dim myObject As New MyClass()
    //        myObject.SayHello()
    //    End Sub
    //End Module

    // Task 5
    //public class CLS
    //{
    //    public void MyMethod(int number)
    //    {
    //        Console.WriteLine($"Number: {number}");
    //    }

    //    public void MyOtherMethod(string text)
    //    {
    //        Console.WriteLine($"Text: {text}");
    //    }
    //}
    //Task 7
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("Hello World");
            // Task 2

            string inputString = "Hello World";

            // Перевірка, чи містить рядок слово "Привіт"
            if (inputString.Contains("Hello"))
            {
                Console.WriteLine("Line woard 'Hi'.");
            }
            else
            {
                Console.WriteLine("Line no woard 'Hi'.");
            }

            // Виведення довжини рядка
            Console.WriteLine("Line lenght: " + inputString.Length);

            // Перетворення рядка у верхній регістр
            string upperCaseString = inputString.ToUpper();
            Console.WriteLine("Line in register: " + upperCaseString);

            // Розділення рядка на слова
            string[] words = inputString.Split(' ');
            Console.WriteLine("Woard in Line:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            // Task 3
            string message = "Hello World!";
            Console.WriteLine(message);
            //Task 5
            //    // Запросити користувача ввести шестизначне число
            //    Console.Write("Enter 6 number: ");
            //    string input = Console.ReadLine();

            //    // Перевірити, чи введено шестизначне число
            //    if (input.Length != 6 || !IsNumeric(input))
            //    {
            //        Console.WriteLine("Please, Enter the corect 6 number");
            //        return;
            //    }

            //    // Перевернути число
            //    char[] charArray = input.ToCharArray();
            //    Array.Reverse(charArray);
            //    string reversedNumber = new string(charArray);

            //    // Відобразити результат
            //    Console.WriteLine("Result: " + reversedNumber);
            //}

            //// Метод для перевірки, чи є рядок числом
            //static bool IsNumeric(string str)
            //{
            //    foreach (char c in str)
            //    {
            //        if (!char.IsDigit(c))
            //            return false;
            //    }
            //    return true;
            //}

            // Task 7
          
        
                // Створення екземпляру класу Person
                Person person = new Person();

                // Заповнення властивостей об'єкта
                person.Name = "John";
                person.Age = 30;

                // Виведення імені та віку створеного об'єкта на екран
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");

                // Зміна значення властивості Age
                person.Age = 35;

                // Виведення оновлених даних на екран
                Console.WriteLine($"osnovni data:");
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Age: {person.Age}");
            }
        }

    }
    

