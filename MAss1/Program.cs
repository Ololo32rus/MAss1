// известно число жителей, проживающих в каждом доме улицы. Нумерация домов проведена подряд. Две стороны чет и нечет. На какой стороне больше живет людей

int[] House = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sumResidentsRight = 0;
int sumResidentsLeft = 0;

for (int i = 0; i < House.Length; i++) // число жителей приравнивали к нумерации дома 1=1 2=2 3=3 4=4 и т.д.
{
    if (House[i] % 2 == 0)
    {
        sumResidentsRight += House[i];
    }

    if (House[i] % 2 != 0)
    {
        sumResidentsLeft += House[i];
    }
}

if (sumResidentsRight > sumResidentsLeft)
{
    Console.WriteLine($"С правой стороны живет больше людей, всего = {sumResidentsRight}");
}
else
{
    Console.WriteLine($"С левой стороны живет больше людей, всег = {sumResidentsLeft}");
}