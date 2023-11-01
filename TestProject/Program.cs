Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
bool validEntry = false;

readResult = Console.ReadLine();

if (animalSpecies != "dog" && animalSpecies != "cat")
{
    validEntry = false;
}
else
{
    validEntry = true;
}
do
{
    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        animalSpecies = readResult.ToLower();
        if (animalSpecies != "dog" && animalSpecies != "cat")
        {
            //Console.WriteLine($"You entered: {animalSpecies}.");
            validEntry = false;
        }
        else
        {
            validEntry = true;
        }
    }
} while (validEntry == false);