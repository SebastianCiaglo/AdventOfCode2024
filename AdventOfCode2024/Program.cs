using AdventOfCode2024;
using static System.Net.Mime.MediaTypeNames;

string inputFile = "Input_1a.txt";

var listsday1 = new Lists();

Console.WriteLine("AdventOfCode2024_task1a");

DataInputFromFile(inputFile);

//DataSaveToFile("Input_1a.txt");

void DataInputFromFile(string fileName)
{
    int i = 0;

    if (File.Exists(fileName))
    {
        using (var reader = File.OpenText(fileName))
        {
            var line = reader.ReadLine();

            while (line != null)
            {
                string inputLine = Convert.ToString(line);

                listsday1.AddToRawData(inputLine);

                line = reader.ReadLine();

                i++;
            }
        }
    }
    else
    {
        Console.WriteLine("File missing");
    }
}

void DataSaveToFile(string fileName)
{
    if (File.Exists(fileName))
    {
        DeleteFile(fileName);
    }

    using (var writer = File.AppendText(fileName))
    {
        writer.WriteLine("Test");
        Console.WriteLine("File created");
    }


}

void DeleteFile(string fileName)
{
    if (File.Exists(fileName))
    {
        File.Delete(fileName);
    }
}


foreach (var item in listsday1.rawData)
{
    Console.WriteLine(item);

    string[] parts = item.Split(" ");

    listsday1.AddToList1(int.Parse(parts[0]));

    listsday1.AddToList2(int.Parse(parts[parts.Length-1]));

}


//var DataDay1a = new InputProcessing();

    //InputProcessing.DataInput(fileName);


    /*
    listsday1.AddToList1(3);
    listsday1.AddToList1(4);
    listsday1.AddToList1(2);
    listsday1.AddToList1(1);
    listsday1.AddToList1(3);
    listsday1.AddToList1(3);

    listsday1.AddToList2(4);
    listsday1.AddToList2(3);
    listsday1.AddToList2(5);
    listsday1.AddToList2(3);
    listsday1.AddToList2(9);
    listsday1.AddToList2(3);
*/
    Console.WriteLine("location team 1 before sorting");

    foreach (var item in listsday1.locationsTeam1)
    {
        Console.WriteLine(item.ToString());
    }

    Console.WriteLine("location team 2 before sorting");

    foreach (var item in listsday1.locationsTeam2)
    {
        Console.WriteLine(item.ToString());
    }


    listsday1.locationsTeam1.Sort();
    listsday1.locationsTeam2.Sort();

    Console.WriteLine("location team 1 after sorting");

    foreach (var item in listsday1.locationsTeam1)
    {
        Console.WriteLine(item.ToString());
    }

    Console.WriteLine("location team 2 after sorting");

    foreach (var item in listsday1.locationsTeam2)
    {
        Console.WriteLine(item.ToString());
    }

    int i4 = 0;
    int i3 = 0;

    for (int i1 = 0; i1 < listsday1.locationsTeam1.Count; i1++)
    {
        for (i1 = 0; i1 < listsday1.locationsTeam2.Count; i1++)
        {
            i3 = Math.Abs(listsday1.locationsTeam1[i1] - listsday1.locationsTeam2[i1]);

            i4 = i4 + i3;

            Console.WriteLine("Current Length is:");
            Console.WriteLine(i4);
        }
    }

    Console.WriteLine(" ");
    Console.WriteLine("Final Length is:");
    Console.WriteLine(i4);
    //*/
namespace AdventOfCode2024
{

    public class Lists
    {
        public List<string> rawData = new List<string>();

        public List<int> locationsTeam1 = new List<int>();

        public List<int> locationsTeam2 = new List<int>();

        public Lists()
        {
        }

        public void AddToRawData(string line)
        {
            this.rawData.Add(line);

        }

        public void AddToList1(int i)
        {
            this.locationsTeam1.Add(i);

        }

        public void AddToList2(int i)
        {
            this.locationsTeam2.Add(i);
        }



    }
    /*
        public class Program
        {
            static void Main()
            {

            }
        }
    */
    /*    public class InputProcessing
        {
            public InputProcessing()
                {
                }

            //private const string fileName = "Input_1a.txt";

            public void DataInput(string fileName)
            {
                int i = 0;

                if (File.Exists(fileName))
                {
                    using (var reader = File.OpenText(fileName))
                    {
                        var line = reader.ReadLine();

                        while (line != null)
                        {
                            string inputLine = Convert.ToString(line);

                            ShowInput(inputLine);

                            line = reader.ReadLine();

                            i++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File missing");
                }
            }

            public void ShowInput(string showInput)
            {
                Console.WriteLine(showInput);
            }

        }
    */
}






