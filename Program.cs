// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string firstFriend = "            Sado";
string secondFriend = "                 Mustafa        ";
firstFriend = firstFriend.TrimStart();
secondFriend = secondFriend.TrimEnd();


Console.WriteLine($"My first friend is {firstFriend} second one is {secondFriend.TrimStart()} dir");
