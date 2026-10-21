using System;

string especieMascota = "perro";   // "perro", "gato", "conejo", "reptil"
int edadMascota = 7;               // edad en años
double peso = 28.5;                // peso en kilogramos
bool tieneVacunasAlDia = false;
bool esSocio = true;
string motivoConsulta = "cirugia"; // "vacuna", "revision", "cirugia", "urgencia"

Console.WriteLine("=== Reporte de Atención Veterinaria ===");

// Parte 1 — Rango de edad (Switch expression)
string rangoDeEdad = edadMascota switch
{
    < 1 => "Cachorro",
    >= 1 and <= 3 => "Joven",
    >= 4 and <= 8 => "Adulto",
    > 8 => "Senior"
};

Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} | Etapa: {rangoDeEdad}");  

// Parte 2 — Alerta de vacunación
string alertaDeVacunacion;

if (especieMascota == "gato" || especieMascota == "perro")
{
    if (tieneVacunasAlDia)
    {
        alertaDeVacunacion = "Estado de vacunación: Vacunación al día";
    }
    else
    {
        alertaDeVacunacion = "Estado de vacunación: ALERTA: vacunación urgente requerida";
    }
}
else
{
    alertaDeVacunacion = "Estado de vacunación: Esquema de vacunación no aplica";
}

Console.WriteLine(alertaDeVacunacion);

// Parte 3 — Costo base de la consulta
decimal costoBase = 0;

switch (motivoConsulta)
{
    case "vacuna":
        costoBase = 35000;
        break;

    case "revision":
        costoBase = 50000;
        break;
    
    case "cirugia":
        costoBase = 280000;
        break;

    case "urgencia":
        costoBase = 150000;
        break;
    
    default:
        costoBase = 0;
        break;
}
Console.WriteLine($"Motivo: {motivoConsulta} | costo base: ${costoBase} ");

// Parte 4 — Descuento por membresía y peso

double porsentajeDescuento = esSocio ? (peso > 25 ? 0.15 : 0.10) : 0;

decimal descuento = costoBase * (decimal)porsentajeDescuento;
decimal costoFinal = costoBase - descuento;

Console.WriteLine($"Descuento: ${descuento} | Costo final: ${costoFinal}");


// Parte 5 — Recomendación post-consulta

string recomendacion = "";

if (motivoConsulta == "cirugia" )
{
    if (rangoDeEdad == "Senior")
    {
        recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
    }
    else
    {
        recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
    }

}
else if (motivoConsulta == "urgencia")
{
     if (tieneVacunasAlDia == false)
    {
        recomendacion = "Atender urgencia y programar vacunación inmediata";
    }
    else
    {
        recomendacion = "Seguimiento en 48 horas";
    }
}
else
{
    recomendacion = "Seguimiento en próxima consulta de rutina";
}
Console.WriteLine($"Recomendación: {recomendacion}");

