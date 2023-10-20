
int n = int.Parse(Console.ReadLine());

int rows = n;
int cols = n;

char[,] battlefield = new char[rows, cols];
int startRow = 0;
int startCol = 0;


for (int i = 0; i < rows; i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < cols; j++)
    {
        battlefield[i, j] = row[j];
        if (battlefield[i, j] == 'S')
        {
            startRow = i;
            startCol = j;
        }
    }
}
battlefield[startRow, startCol] = '-';

int takenHits = 0;
int foundBases = 0;
while (true)
{
    string command = Console.ReadLine();
    if (command == "left")
    {

        //if (startCol == 0)
        //{
        //    isOutSideMatrix = true;
        //    Console.WriteLine("The delivery is late. Order is canceled.");
        //    break;
        //}
        //if (neighbourHood[startRow, startCol - 1] == '*')
        //{
        //    continue;
        //}
        startCol--;
    }
    else if (command == "right")
    {

        //if (startCol == cols - 1)
        //{
        //    isOutSideMatrix = true;
        //    Console.WriteLine("The delivery is late. Order is canceled.");
        //    break;
        //}
        //if (neighbourHood[startRow, startCol + 1] == '*')
        //{
        //    continue;
        //}

        startCol++;
    }
    else if (command == "up")
    {

        //if (startRow == 0)
        //{
        //    isOutSideMatrix = true;
        //    Console.WriteLine("The delivery is late. Order is canceled.");
        //    break;
        //}
        //if (neighbourHood[startRow - 1, startCol] == '*')
        //{
        //    continue;
        //}
        startRow--;
    }
    else if (command == "down")
    {

        //if (startRow == rows - 1)
        //{
        //    isOutSideMatrix = true;
        //    Console.WriteLine("The delivery is late. Order is canceled.");
        //    break;
        //}
        //if (neighbourHood[startRow + 1, startCol] == '*')
        //{
        //    continue;
        //}
        startRow++;
    }
    if (battlefield[startRow, startCol] == '-')
    {
        
        continue;
    }
    else if (battlefield[startRow, startCol] == '*')
    {
        takenHits++;
        battlefield[startRow, startCol] = '-';
        if (takenHits == 3)
        {
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{startRow}, {startCol}]!");
            break;
        }
        else
        {
            
            
            continue;
        }
    }
    else if (battlefield[startRow, startCol] == 'C')
    {
        foundBases++;
        battlefield[startRow, startCol] = '-';
        if (foundBases == 3)
        {
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;
        }
        else 
        { 
            
            continue; 
        }
    }
}
battlefield[startRow, startCol] = 'S';
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(battlefield[i, j]);
    }
    Console.WriteLine();
}