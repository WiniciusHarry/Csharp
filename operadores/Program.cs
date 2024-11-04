// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Operadores aritimedicos

double resultado = 10 + 8 + 12 / 3;
Console.WriteLine(resultado);

double resultado = (10 + 8 + 12) / 3;
Console.WriteLine(resultado);

double resultado = (2 + 8) * 2 / 4;
Console.WriteLine(resultado);

// Operadores de comparacao
// And logico && (E)
bool a = true;
bool b = false;
Console.WriteLine(a && b);
// Or logico || (ou)
bool a1 = true;
bool b1 = false;
Console.WriteLine(a1 || b1);
// Not logico ! (nao)
bool a2 = true;
Console.WriteLine(!a2);
// Xor logico ^ (ou exclusivo)
bool a3 = true;
bool b3 = false;
Console.WriteLine(a3 ^ b3);

// Pecedencia:
// Not logico ! (nao)
// And logico && (E)
// Or logico || (ou)
// Xor logico ^ (ou exclusivo)
// Exemplos 1:
bool x = true;
bool y = false;
bool z = false;
bool resultado = !x || (y && z);
Console.WriteLine(resultado);
// Exemplos 2:
bool x = false;
bool y = false;
bool z = false;
bool resultado = !x || y && z;
Console.WriteLine(resultado);