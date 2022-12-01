int n=Int32.Parse(Console.ReadLine());    //n=no. of rows
for(int i=1;i<=n;i++){                    //logic for rows
    for(int j=1;j<=n-i;j++){              //logic for spaces  
        Console.Write(" ");
    }
    for(int j=1;j<=i;j++){                //logic for columns
        Console.Write("*");
    }
    Console.WriteLine();
    }

//0/p=>n=5
//      *
//     **
//    ***
//   ****
//  *****