int n=Int32.Parse(Console.ReadLine());    //n=rows
for(int i=1;i<=n;i++){                   //for rows
    for(int j=1;j<=n-i+1;j++){           //for columns
        Console.Write(j +" ");
    }
    Console.WriteLine();
}
