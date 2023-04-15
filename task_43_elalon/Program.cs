// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// --------- формула  ---------
// x = (-b2 + b1)/(-k1 + k2);
// y = k2 * x + b2;
// Эталонное решение

const int coefficinet = 0; //
const int constant = 1;    //
const int x_coord = 0;     //
const int y_coord = 1;     //
const int line1 = 1;       // номер линии 1
const int line2 = 2;       // номер линии 2

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений у={lineData1[coefficinet]} * x+{lineData1[constant]} и у={lineData2[coefficinet]}*х + {lineData2[constant]} ");
    Console.WriteLine($" имеет координаты ({coord[x_coord]}, {coord[y_coord]})");
}

// Вывод сообщение и считывание данных
double Prompt(string message)
{
    System.Console.Write(message); // вывести сообщение
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

// Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficinet] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[constant] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}


// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) / 
    (lineData2[coefficinet] - lineData1[coefficinet]);
    coord[y_coord] = (lineData1[constant] * coord[x_coord]) + 
    lineData1[constant];
    return coord;
}

// проверка введенных данных
bool ValidateLines (double[] lineData1, double[] lineData2) 
{
    if (lineData1[coefficinet] == lineData2[coefficinet])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}


