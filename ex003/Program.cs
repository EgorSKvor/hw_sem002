System.Console.WriteLine("Введите день недели и мы определим можно ли идти ту ту ту");
int num_user = int.Parse(Console.ReadLine());
if (num_user == 6 || num_user == 7)
{
    System.Console.WriteLine("Сегодня можно тутуту! ");
}
else if (num_user < 1 || num_user > 7)
{
    System.Console.WriteLine("Это не день недели, вы живете в матрице");
}
else 
{
    System.Console.WriteLine("Нельзя туту (");
}