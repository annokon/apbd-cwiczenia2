// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja1");
Console.WriteLine("Modyfikacja2");
Console.WriteLine("Modyfikacja3");
Console.WriteLine("Modyfikacja3.2");

static double GetAverage(int[] numbers) {
    int suma = 0;
    foreach (var number in numbers) {
        suma += number;
    }

    return (double)suma / numbers.Length;
}


static int GetMax(int[] numbers) {
    int max = 0;
    foreach (var number in numbers) {
        if (number > max) {
            max = number;
        }
    }

    return max;
}

int[] numbers = {1, 2, 3, 4, 5};
double average = GetAverage(numbers);
Console.WriteLine(average);

int max = GetMax(numbers);
Console.WriteLine(max);