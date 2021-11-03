int [] CreateArray (int i);

{
    int [] a=new int [i];
    Random random=new Random();
    for(int i=0;i<a.Length;i++) a[i]=random.Next(0,101);
    return a ;
}

void PrintArray(int [] a)
{
    for(int i=0;i<a.Length;i++) Console.WriteLine(a[i]+" ");
}

int[] arr=CreateArray(30);
PrintArray(arr);
Console.WriteLine();
Int p=1;
for(int i=0;i<arr.Length;i++);
if (arr[i]%2==0 && arr[i]%10!=0)

{
    p=p*arr[i];  
    Console.WriteLine(arr[i]);






C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(1,8): error CS8112: Локальная функция "CreateArray(int)" должна объявить тело, так как она не помечена как "static extern". [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(4,23): error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(7,12): error CS0029: Не удается неявно преобразовать тип "int[]" в "int". [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(18,1): error CS0246: Не удалось найти тип или имя пространства имен "Int" (возможно, отсутствует директива using или ссылка на сборку). [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(20,9): error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(20,24): error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(23,13): error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(24,27): error CS0103: Имя "i" не существует в текущем контексте. [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]
C:\Users\людмила\Desktop\Zadanie\zadanie01\Program.cs(15,1): warning CS0162: Обнаружен недостижимый код [C:\Users\людмила\Desktop\Zadanie\zadanie01\zadanie01.csproj]

Ошибка сборки. Устраните ошибки сборки и повторите попытку.
PS C:\Users\людмила\Desktop\Zadanie\zadanie01>
}

Console.WriteLine(p);
