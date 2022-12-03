using Calories;

public class Main
{
    public static int CalculateMostCaloriesForASingleElf()
    {
        var file = new Calories.Input.DataFile();
        if (!file.Load("elf-calories.txt"))
        {
            Console.Error.WriteLine("Failed to load data file");
            return -1;
        }
        
        var elfManager = new Calories.Elves.ElfManager();
        elfManager.ParseData(file.Data);

        var elf = elfManager.GetElfWithMostCalories();
        if (elf == null) 
        {
            Console.Error.WriteLine("No elves found");
            return -1;
        }

        Console.WriteLine("Highest calorie count is {0}", elf.CalculateTotalCalories());
        return 0;
    }
}
