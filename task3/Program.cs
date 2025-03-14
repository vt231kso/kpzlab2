using task3;

var auth1 = Authenticator.Instance;
var auth2 = Authenticator.Instance;

Console.WriteLine($"Are both instances the same? {auth1 == auth2}");
