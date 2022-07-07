Console.WriteLine("Кто там? Тут совсем темно, представьтесь пожалуйста.");
string username = Console.ReadLine();
if (username.ToLower() == "марьям")
{
    Console.WriteLine("Ура ! Наконецто ты пришла, я так рад тебе!");
} else {
    Console.Write("Чтож, ");
    Console.Write(username);
    Console.WriteLine(" проходи.");
}