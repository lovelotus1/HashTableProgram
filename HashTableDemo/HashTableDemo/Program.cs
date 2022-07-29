using HashTableDemo;

Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "Paranoid");
hash.Add("1", "are");
hash.Add("2", "not");
hash.Add("3", "paranoid");
hash.Add("4", "because");
hash.Add("5", "they");
hash.Add("6", "are");
hash.Add("7", "paranoid");
hash.Add("8", "but");
hash.Add("9", "because");
hash.Add("10", "they");
hash.Add("11", "keep");
hash.Add("12", "putting");
hash.Add("13", "themselves");
hash.Add("14", "deliberatly");
hash.Add("15", "into");
hash.Add("16", "paranoid");
hash.Add("17", "avoidable");
hash.Add("18", "situation");

string hash3 = hash.Get("3");
Console.WriteLine("3rd index value: " + hash3);
string hash0 = hash.Get("0");
Console.WriteLine("0 index value: " + hash0);
string hash7 = hash.Get("7");
Console.WriteLine("7th index value: " + hash7);
string hash16 = hash.Get("16");
Console.WriteLine("16th index value: " + hash16);
Console.ReadKey();