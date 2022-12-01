int n=Int32.Parse(Console.ReadLine());      //n=rows
int m=Int32.Parse(Console.ReadLine());      //m=columns
for(int i=1;i<=n;i++){                   //outer loop for rows
    for(int j=1;j<=m;j++)                //inner loops for columns
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


//ex-
//n=4
//m=4
//=>  ****
//    ****
//    ****
//    ****