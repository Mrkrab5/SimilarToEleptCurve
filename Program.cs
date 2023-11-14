static int[] umnNaScolar(string p, int x, int y)
{
    int[] result = new int[2];
    int resultUmn = 0;

    for (int i = p.Length - 1; i >= 0; i--)
    {
        if (i == p.Length - 1)
            resultUmn++;
        else
        {
            if (p[i] == '1')
            {
                resultUmn *= 2;
                resultUmn++;
            }
            else
                resultUmn *= 2;
        }
    }

    //Не знаю что значит запись в примере 29P, где P точка
    //так что просто запишу произведение координат на число
    result[0] = resultUmn * x;
    result[1] = resultUmn * y;

    return result;
}

static string Bin(int k)
{
    string kBin = "";

    while (k > 0)
    {
        kBin += k % 2;
        k /= 2;
    }

    return kBin;
}

int a = 1, b = 0, p = 23, x = 9, y = 5, k1 = 10, k2 = 8;
int[] result11 = new int[2], result12 = new int[2], result21 = new int[2], result22 = new int[2];
string znachBin = "";

if ((4 * Math.Pow(a, 3) + 27 * Math.Pow(b, 2)) % p > 0)
{
    //Формирование двоичного представления секретного числа первого абонента,
    //а затем составление пары изменённых координат
    znachBin = Bin(k1);
    result11 = umnNaScolar(znachBin, x, y);

    //Формирование двоичного представления секретного числа второго абонента,
    //а затем составление пары изменённых координат
    znachBin = Bin(k2);
    result21 = umnNaScolar(znachBin, x, y);

    //Формирование двоичного представления секретного числа первого абонента,
    //а затем составление итоговых координат
    znachBin = Bin(k1);
    result12 = umnNaScolar(znachBin, result21[0], result21[1]);

    //Формирование двоичного представления секретного числа второго абонента,
    //а затем составление итоговых координат
    znachBin = Bin(k2);
    result22 = umnNaScolar(znachBin, result11[0], result11[1]);

    Console.WriteLine($"Координаты первого абонента: x = {result12[0]} y = {result12[1]}\n" +
                      $"Координаты второго абонента: x = {result22[0]} y = {result22[1]}");
}
else
    Console.WriteLine("Параметры A и B не удовлетворяют условию");