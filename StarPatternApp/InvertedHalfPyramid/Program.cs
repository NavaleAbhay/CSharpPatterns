
int n=Int32.Parse(Console.ReadLine());      //n=rows
for(int rows=n;rows>=1;rows--){                     //outer loop for rows
    for(int cols=1;cols<=rows;cols++){                //inner loop for columns
        Console.Write("*");
    }
    Console.WriteLine();
}


//o/p=>
//n=5
//  *****
//  ****
//  ***
//  **
//  *
