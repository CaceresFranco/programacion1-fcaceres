// See https://aka.ms/new-console-template for more information

//
/* este  es un ejemplo con While, donde pido valores hasta que me ponen un 0
Console.WriteLine("Flaco, poneme las ventas y cuando no tengas mas, poneme un 0");
int sumita = 0;

Console.WriteLine("ingresar valor:");
string valor = Console.ReadLine();
int valorInt = int.Parse(valor);

while (valorInt > 0)
{
    sumita = sumita + valorInt;

    Console.WriteLine("ingresar valor:");
    valor = Console.ReadLine();
    valorInt = int.Parse(valor);

}
Console.WriteLine("al final de todo vendiste: " + sumita);

/* // aca hay un ejemplo del For para leer 12 valores
Console.WriteLine("Hola, te voy a ir pidiendo los valores de laos 12 meses? ");
// me voy a crear una variable para poder ir llevando la suma de los montos de cada mes
int sumita = 0 ;

for (int mes = 1; mes <= 12; mes++)
{
    Console.WriteLine("Poneme el valor del mes: " + mes);
    string valor = Console.ReadLine();
    sumita = sumita + int.Parse(valor);

    //Console.WriteLine(valor);
   
}
Console.WriteLine(sumita);
*/



/* // Esto es para probar el IF
string loQueElFlacoPone;

Console.WriteLine("Hola, me das alguna cadena? ");
loQueElFlacoPone = Console.ReadLine();

if (loQueElFlacoPone.Length > 15)
{
    Console.WriteLine("Mucho texto!!");
} else
{
    Console.WriteLine("bien!! tiene poco");
}
*/



/* // Esto es para ver el año de nacimiento
Console.WriteLine("Hola, me das tu año de nacimiento? ");
string LoQueElTipoPuso =  Console.ReadLine();
// si voy a calcular mas o menos la edad que tiene tomando su año de nac.
// tendía que calcular así:
int ElAnioDelPibeEnInt = int.Parse(LoQueElTipoPuso);
int ElAnioDondeEstoyAhora = DateTime.Today.Year;

int laEdadDelFlaco = ElAnioDondeEstoyAhora - ElAnioDelPibeEnInt;

Console.WriteLine("Vos tenes o vas a cumplir este año: " + laEdadDelFlaco);

*/


// cacho se fue al campo.

/*

Console.WriteLine("hola me das tu año de nacimiento?");
string? ElInput = Console.ReadLine();
// calcular edad aprox en base a fecha de nacimiento de la siguiente manera
int AnioInt = int.Parse(ElInput);
int EdadDeUser = 2023 - AnioInt;
Console.WriteLine("vos tenes o vas a cumplir este año:" + EdadDeUser);
*/

/*
Practicar IF

string? elInputQueEntra;
Console.WriteLine("hola, me das una cadena?");
elInputQueEntra = Console.ReadLine();
if (elInputQueEntra.Length > 15)
{
    Console.WriteLine("mucho texto");
}else
{
    Console.WriteLine("corta la bocha");
}
*/

// ejercicios practica do while


// ejercicio 1

/* 

Console.WriteLine("pasame la nota de las 9 materias:");

int NotasAlumno = 0;
string Nota = "";

for (int i = 1; i <= 9; i++)
{
    Console.WriteLine("ingresame la nota: " + i);
    Nota = Console.ReadLine();
    int NotaInt = int.Parse(Nota);
    NotasAlumno = NotasAlumno + NotaInt;


}

Console.WriteLine("tu promedio es: " + (NotasAlumno / 9));
*/

// ejercicio 2:

/*Console.WriteLine("ingresa un numero");
string? num;
int? numint;
do
{
    num = Console.ReadLine();
    numint = int.Parse(num);
} while (numint < 0);

Console.WriteLine(" ingresaste un numero positivo"); */

// ejercicio 3:

/*Console.WriteLine("ingresa un numero");
float? num;
//float? numfloat;
float? suma = 0;
float? cont = 0;
//float? promedioNegativos;
do
{
    num = float.Parse(Console.ReadLine());
    

    if (num < 0)
    {
        suma += num;
        cont++;
    }
    } while (num < 0);


float? promedioNegativos = suma / cont;
Console.WriteLine(" ingresaste un numero positivo, el promedio de los numeros negativos ingresados es: " + promedioNegativos); */


// ejercicio 4:

/*Console.WriteLine("ingresa un numero");
int? num = 0;
do
{
    num =int.Parse(Console.ReadLine());
} while (num < 999);

Console.WriteLine("ingresaste un numero mayor a 3 cifras");*/


// ejercicio 5:

/*Console.WriteLine("ingresa un numero");
float? num = 0;
float? suma = 0;
float? cont = 0;


do
{
    num = float.Parse(Console.ReadLine());
    
    suma += num;
    cont++;

} while (num < 999.99);

float? promedio= suma / cont;
Console.WriteLine("ingresaste un numero mayor a 3 cifras el promedio de numeros ingresados es: " + promedio);*/

// Practica while

// ejercicio 1 y 2

/*Console.WriteLine("ingresa un numero positivo");
float? num = 0;
float? suma = 0;
float? cont = 0;

num = float.Parse(Console.ReadLine());

while (num > 0)
{

    suma += num;
    cont++;
    Console.WriteLine("ingresa un numero positivo:");
    num = float.Parse(Console.ReadLine());

} 

float? promedio = suma / cont;
Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);*/

// ejercicio 3


/*Console.WriteLine("ingresa los nombres de la lista");
string? nom;
int? cont = 0;
nom = Console.ReadLine();

while (nom != "")

{
    cont++;
    Console.WriteLine("ingresa los nombres de la lista");
    nom = Console.ReadLine();
}

Console.WriteLine("La cantidad de nombres ingresados en la lista son: " + cont);*/

//ejercicio 4 y 5 (preguntar consigna)

// practica for

// ejercicio 1


/*Console.WriteLine("vas ingresar 5 valores enteros");
int? val;
int? sum = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("ingresa un valor entero: ");
    val = int.Parse(Console.ReadLine());
    sum += val;
}

Console.WriteLine(" la suma de los valores enteros ingresados es: " + sum); */

// ejercicio 2

/*Console.WriteLine("vas ingresar 8 numeros");
float? val;
float? suma = 0;
float? cont = 0;
float? prom = 0;

for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("ingresa un numero: ");
    val = float.Parse(Console.ReadLine());
    suma += val;
    cont++;
}

prom = suma / cont;
Console.WriteLine(" el promedio de los valores ingresados es: " + prom); */

// ejercicio 4


/*Console.WriteLine("vas ingresar 8 numeros");
float? val;
float? mayor = 0;


for (int i = 1; i <= 8; i++)
{
    Console.WriteLine("ingresa un numero: ");
    val = float.Parse(Console.ReadLine());
    
    if (val > mayor)
    {
        mayor = val;
    }
}
Console.WriteLine("el numero mayor es: " + mayor); */

// ejercicio 5

/*Console.WriteLine("vas ingresar 5 clientes y sus respectivos gastos");
string? cliente;
string? clientemayor;
float? gasto;
float? mayor = 0;


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("ingresa un cliente: ");
    cliente = Console.ReadLine();
    Console.WriteLine("ingresa su gasto: ");
    gasto = float.Parse(Console.ReadLine());

    if (gasto > mayor)
    {
        mayor = gasto;
        clientemayor = cliente;
    }
}
Console.WriteLine("el numero mayor es: " + mayor); /*