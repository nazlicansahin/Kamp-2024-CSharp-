

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Monday);
        int number1 = 0; //integer 32 'bit
        long number2 = 0; //long integer 64 bit
        short number3 = 0; //short integer  16 bit 
        byte number4 = 0; //0-255 between numbers 8bit
        bool trueorfalse = false;
        char character = 'a';
        double double1 = 0.4; // 0 without .4 is also okey. 64 bít
        decimal double2 = 0.732648734m; //more sensitive calculations. Imagine Biger double

        //var 
        var whatIsType = 22; // its 22 anymore

        //arrays 
        string[] students = new string[3];
        students[0] = "Éngin";
        students[1] = "Derin";

        string[] students2 = new string[] { "Ëngin", "Derin" };
        string[] students3 = { "Ëngin", "Derin" };
        foreach (var student in students)
        {
            Console.Write(student);
        }

        //Multidimensional Arrays
        string[,] regions = new string[7, 3] //7 row 3 column
        {
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"},
            { "Istanbul ","Ankara "," Balikesir"}

        };
    for (int i = 0 ; i<= regions.GetUpperBound(0); i++)
        {
            for (int j = 0 ; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i,j]);
            }
        }
    }

}

//enum
enum Days
{
    Monday=0, Tuesday=2, Wednesday, Friday, Saturday, Sunday
};

//Other Notes https://handy-banana-950.notion.site/Week2-2e147b35d0d94156a4ffdd185e93685c?pvs=4