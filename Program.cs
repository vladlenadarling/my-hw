string[] mass1 = new string[] { "hello", "2", ";-)" };
string[] mass2 = new string[mass1.Length];
int j = 0;

void CheckMass(string[] mass1, string[] mass2)
{
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length <= 3)
        {
            mass2[j] = mass1[i];
            j++;
        }
    }
}
CheckMass(mass1, mass2);

void PrintMass(string[] mass)
{
    for (int i = 0; i < mass2.Length; i++)
    {
        Console.Write($"{mass2[i]} ");
    }
}

PrintMass(mass2);