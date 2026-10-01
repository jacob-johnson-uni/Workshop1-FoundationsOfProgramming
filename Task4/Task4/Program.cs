int balance = 1000;
string strBalance = Convert.ToString(balance);

Console.WriteLine($"Inital Balance: {strBalance}");

Console.Write("How much would you like to withdraw? ");
string withdraw = Console.ReadLine();

int intWithdraw = Convert.ToInt32(withdraw);
balance = balance - intWithdraw;

strBalance = Convert.ToString(balance);
Console.WriteLine($"Balance after withdrawal: {strBalance}");

Console.Write("How much would you like to deposit? ");
string strDeposit = Console.ReadLine();

int deposit =  Convert.ToInt32(strDeposit);
balance = balance + deposit;

strBalance = Convert.ToString(balance);
Console.WriteLine ($"Final balance after deposit: {strBalance}");