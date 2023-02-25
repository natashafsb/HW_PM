Console.Write("Elements massive's number = ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] a = new string[n];
    string[] b = new string[n];
    for(int i = 0; i < n; i++)
    {
        a[i] = Console.ReadLine();
    }
    int t = 0;
    for(int i = 0; i < n; i++){
        int length = a[i].Length;
        if (length <= 3){
            b[t] = a[i];
            t = t + 1;
        }
    }
Console.WriteLine("New massive :");
    for(int i = 0; i < n; i++)
    {
        Console.Write(b[i]);
        Console.Write(' ');
    }
