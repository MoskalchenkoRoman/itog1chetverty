using System.Linq;

string[] AS; 
int count; 
string x;
string[] AS2; 
Console.WriteLine("Введите строки:");
count = 0;
AS = new string[count]; 
do
{
x = Console.ReadLine();
    if (x!="")
    {
    count++;
    AS2 = new string[count];
    for (int i = 0; i < AS2.Length - 1; i++)
        AS2[i] = AS[i];
        AS2[count - 1] = x;
        AS = AS2;
    }
} while (x != "");   
for (int i = 0; i < AS.Length; i++)
    Console.Write(AS[i]+";");
Console.WriteLine();
// List<string> result = new List<string>();
// foreach(string s in AS)
// {
//     if(s.Length <= 3)
//     {
//         result.Add(s);
//     }
// }
// foreach (string s in result)
//     Console.Write(s+",");
var res = from s in AS
          where s.Length <=3
          select s;
 foreach (string s in res)
     Console.Write(s+",");  