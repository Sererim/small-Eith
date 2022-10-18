int Main()
{
    string key;
    Console.WriteLine("Enter the dimensions of a matrix m x m x m.");
    key = Console.ReadLine();
    int m;
    m = System.Int32.Parse(key);
    int[,,] arr = new int[m,m,m];
    arr = homework.Make(arr,m);
    homework.Show(arr,m);

    int[,] mat = new int[4,4];
    mat = homework.Snek(mat);
    homework.Show(mat,4);
    return 0;
}
Main();

class homework
{
    static public int[,,] Make(int[,,] arr, int m)
    {
        Random rand = new Random();
        for(int i = 0; i < m; i++)
            for(int j = 0; j < m; j++)
                for(int k = 0; k < m; k++)
                    arr[i,j,k] = rand.Next(-20,20);
        return arr;
    }
    static public void Show(int[,,] arr, int m)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < m; j++)
            {
                for(int k = 0; k < m; k++)
                    Console.Write($"{arr[i,j,k]} ({i},{j},{k}) ");
                Console.WriteLine();
            }
        }
    }

    static public int[,] Snek(int[,] arr)
    {
        int foo = 1, m = 4;

        for(int i = 0; i < m; i++)
        {
            arr[0,i] = foo;
            foo++;
        }
        for(int i = 1; i < m; i++)
        {
            arr[i,m-1] = foo;
            foo++;
        }
        for(int i = m-2; i >= 0; i--)
        {
            arr[m-1,i] = foo;
            foo++;
        }
        for(int i = m-2; i > 0; i--)
        {
            arr[i,0] = foo;
            foo++;
        }
        for(int i = 1; i < m -1 ; i++)
        {
            arr[1,i] = foo;
            foo++;
        }
        arr[2,2] = foo;
        foo++;
        arr[2,1] = foo;
        foo++;

        return arr;
    }

    static public void Show(int[,] arr, int m)
    {
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < m; j++)
                Console.Write($" {arr[i,j]} ");
            Console.WriteLine();
        }
    }
} 