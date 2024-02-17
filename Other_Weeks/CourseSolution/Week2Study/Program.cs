

class Program
{
    static void Main(string[] args)
    {

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();

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
        Console.WriteLine("Length is " + StrPractice());
    }

    //String Metotlari
    static int StrPractice() 
    { 
    string sentence = "My name is Nazli Sahin";
    int result = sentence.Length;
    var result2 = sentence.Clone(); //cumleyi klonladi
        result2 = "My name is Clone";
    bool result3 = sentence.EndsWith("g"); //String g ile bitiyor mu check
    bool result4 =sentence.StartsWith("g"); //String g ile basliyor mu check
        var result5 = sentence.IndexOf("name"); // indexi verir istenenin bulamazsa -1 verir
        var result6 = sentence.IndexOf(" "); //buldugu ilk istenenin indexini veerir
        var result7 = sentence.LastIndexOf(" ");    //aramaya sondan baslar ama indexi bastan sayarak verir
        var result8 = sentence.Insert(0, "Hello, "); //istenen indexe ekleme yapar
        var result9 = sentence.Substring(3); //3. indexten baslar hepsini verir
        var result10 = sentence.Substring(4, 8); // 4 ten itibaren 8 tane indexi yaz
        var result11 = sentence.ToLower(); //hepsini kucuk yapar
        var result12 = sentence.ToUpper(); //hepsini buyuk yapar
        var result13 = sentence.Replace(" ", "-"); //bosluk yerine cizgi koymus olduk
        var result14 = sentence.Remove(0, 1); //0 dan itibaren 1 karakteri sil

        return result;
            
    }

    //Class
    class CustomerManager
    {
        public void Add()  //bu classlari mainde kullnamak icin bir ornegini olusturmaliyiz satir 8
        {
            Console.WriteLine("Added");
        }

        public void Update() 
        {
            Console.WriteLine("Updated");

         }
    }
}

//enum
enum Days
{
    Monday=0, Tuesday=2, Wednesday, Friday, Saturday, Sunday
};

//Other Notes https://handy-banana-950.notion.site/Week2-2e147b35d0d94156a4ffdd185e93685c?pvs=4