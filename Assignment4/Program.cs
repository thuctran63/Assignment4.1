using Exercise1.Exercise1;
using Exercise2;
using Exercise3;
using Exercise4;
using System.Collections;

void TestExercise1()
{
    ArrayList myArrayList = new ArrayList();
    myArrayList.Add("Hung");
    myArrayList.Add("Vu");
    myArrayList.Add(1);
    myArrayList.Add(2);
    myArrayList.Add("Van");
    myArrayList.Add(3.9d);

    Console.WriteLine("Number of integers in the ArrayList: " + myArrayList.CountInt());
    Console.WriteLine("Number of strings in the ArrayList: " + myArrayList.CountOf(typeof(string)));
    Console.WriteLine("Number of doubles in the ArrayList: " + myArrayList.CountOf<double>());
    Console.WriteLine("Max value of integers in the ArrayList: " + myArrayList.MaxOf<int>());

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

void TestExercise2()
{
    int[] arrInt = new int[] { 1, 2, 3, 3, 5, 6, 5, 2 };
    string[] arrString = new string[] { "Hung", "Vu", "Van", "Hung", "Quang", "Huy", "Vu" };

    int[] arrIntNoDup = arrInt.RemoveDuplicates();
    string[] arrStringNoDup = arrString.RemoveDuplicates();

    foreach (var item in arrIntNoDup)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine();

    foreach (var item in arrStringNoDup)
    {
        Console.Write(item + " ");
    }

    Console.ReadKey();
    Console.WriteLine("Enter any key to continue...");
}

void TestExercise3()
{
    int[] arr = new int[] { 1, 2, 3, 5, 7, 3, 2 };
    int element = 3;

    Console.WriteLine("Index of element " + element + " in the array: " + arr.ListIndexOf(element));

    Console.WriteLine("Enter any key to continue...");

    Console.ReadKey();
}

void TestExercise4()
{
    Console.WriteLine((new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 }).ElementOfOrder2());
    Console.WriteLine((new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 }).ElementOfOrder(2));
    Console.WriteLine((new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 }).ElementOfOrder(3));
    try
    {
        Console.WriteLine((new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 }).ElementOfOrder(20));
    }
    catch
    {
           Console.WriteLine("Error: Order is greater than the length of the array");
    }
    Console.WriteLine("Enter any key to continue...");
    Console.ReadKey();
}


int choice = 0;
while (true)
{
    Console.Clear();
    Console.WriteLine("1. Exercise 1");
    Console.WriteLine("2. Exercise 2");
    Console.WriteLine("3. Exercise 3");
    Console.WriteLine("4. Exercise 4");
    Console.WriteLine("5. Exit");

    try
    {
        choice = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        choice = 5;
    }

    Console.Clear();
    switch (choice)
    {
        
        case 1:
            TestExercise1();
            break;
        case 2:
            TestExercise2();
            break;
        case 3:
            TestExercise3();
            break;
        case 4:
            TestExercise4();
            break;
        case 5:
            return;
    }
}