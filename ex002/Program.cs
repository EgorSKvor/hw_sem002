System.Console.WriteLine("Введите 3х значное число");
int num_user = int.Parse(Console.ReadLine());
string num_user_str = Convert.ToString(num_user);
if (num_user_str.Length < 2)
{
    System.Console.WriteLine("У вашего числа нет 3ей цифры ");
}
else
{
    System.Console.WriteLine("3-е число ->" + num_user_str[2]);
}