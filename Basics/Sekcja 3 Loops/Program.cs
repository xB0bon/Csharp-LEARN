// See https://aka.ms/new-console-template for more information

string space = "\n";

string rakieta = 
    "          _\n" +
    "         /^\\\n" +
    "         |-|\n" +
    "         | |\n" +
    "         | |\n" +
    "        /| |\\\n" +
    "       / | | \\\n" +
    "      |  | |  |\n" +
    "      |  | |  |\n" +
    "      |  | |  |\n" +
    "      |  | |  |\n" +
    "      |  | |  |\n" +
    "     /  | | |  \\\n" +
    "    /   | | |   \\\n" +
    "   /    | | |    \\\n" +
    "  |     | | |     |\n" +
    "  |     | | |     |\n" +
    "  |_____|_|_|_____|";

for (int i = 10; i >= 0; i--)
{
    Console.Clear();
    Console.WriteLine(space);
    Console.WriteLine(rakieta);
    Thread.Sleep(1000);
    space += "\n";


}

Console.WriteLine("----------------------------------------------------------------------");