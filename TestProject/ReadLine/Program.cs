Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string[] role = new string[3] { "Administrator", "Manager", "User" };

string? userRole = Console.ReadLine();

Console.WriteLine($"Role1{role[0]}");
Console.WriteLine($"Role2{role[1]}");
Console.WriteLine($"Role3{role[2]}");
switch(userRole){
    case "Administrator":
        Console.WriteLine($"Your input value ({role[0]}) has been accepted.");
        break;
    case "Manager":
        Console.WriteLine($"Your input value ({role[1]}) has been accepted.");
        break;
    case "User":
        Console.WriteLine($"Your input value ({role[2]}) has been accepted.");
        break;
    default:
        Console.WriteLine($"Your input value ({userRole}) is not valid. Enter you Role again");
        break;
}
