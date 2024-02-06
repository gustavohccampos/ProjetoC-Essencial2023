Console.WriteLine("Precedencia e Associatividade");
Console.WriteLine("--------------- ");


int x = 10 - 2 * 3;
Console.WriteLine( x);

int y = (10 - 2) * 3;
Console.WriteLine(y);



bool p = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(p);

bool q = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(q);



int a = 5, b= 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);