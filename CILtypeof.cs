using System;
// using TypeOf operator
class CILtypeof
{
static void Main()
{
//Print All Those Data Type CIL Type
// we have two ways to print CIL type 
Console.WriteLine(typeof(byte));
//OR
Console.WriteLine(typeof(byte).FullName);
Console.WriteLine(typeof(short));
Console.WriteLine(typeof(long));
Console.WriteLine(typeof(int));
Console.WriteLine(typeof(sbyte));
Console.WriteLine(typeof(uint));
Console.WriteLine(typeof(ushort));
Console.WriteLine(typeof(ulong));
Console.WriteLine(typeof(float));
Console.WriteLine(typeof(double));
Console.WriteLine(typeof(decimal));
Console.WriteLine(typeof(bool));
Console.WriteLine(typeof(char));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(Guid));
Console.WriteLine(typeof(DateTime));
Console.WriteLine(typeof(object));
}
}
