int number = 10; // Puedes cambiar este valor para probar diferentes casos

string CheckNumber(int number)
{
    if (number > 0)
    {
        return "El número es positivo.";
    }
    else if (number < 0)
    {
        return "El número es negativo.";
    }
    else
    {
        return "El número es cero.";
    }
}

// Llamamos a la función e imprimimos lo que nos devuelve
string resultado = CheckNumber(number);
Console.WriteLine(resultado);