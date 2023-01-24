int N;

Console.Write("Введите пятизначное число: ");
N = Convert.ToInt32(Console.ReadLine());

if (N / 10000 == N % 10 && N % 10000 / 1000 == N % 100 / 10)
	{
		Console.WriteLine("Да");
    }
else
			
	{
		Console.WriteLine("Нет");
	}	

	
        Console.ReadLine();
        
		
	

