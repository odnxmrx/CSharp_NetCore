// See https://aka.ms/new-console-template for more information
int operand1, operand2;
int result = 0; //initialized (final log purpose)
char operatorSymbol;

Console.WriteLine("Basic Calculator");
Console.WriteLine("-----------------");

Console.WriteLine("Please, enter a whole number (first operand):");
operand1 = int.Parse(Console.ReadLine()); //parse to Integer 

Console.WriteLine("Please, enter a whole number (second operand):");
operand2 = int.Parse(Console.ReadLine()); //parse to Integer 

Console.WriteLine("Please, enter a valid operator symbol:");
Console.WriteLine("'+', '-', '*', '/'");
operatorSymbol = char.Parse(Console.ReadLine()); //convert to str to char

//operator case:
switch (operatorSymbol)
{
    case '+':
        result = operand1 + operand2;
        break;
    case '-':
        result = operand1 - operand2;
        break;
    case '*':
        result = operand1 * operand2;
        break;
    case '/':
        result = operand1 / operand2;
        break;
    default:
        break;
}

Console.WriteLine();
Console.WriteLine($"{operand1} {operatorSymbol} {operand2} = {result} ");
Console.WriteLine();