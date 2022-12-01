int n=4;                    //n=rows
int m=5;                    //m=columns
for(int i=1;i<=n;i++){                   //outer loop for rows
    for(int j=1;j<=m;j++){                //inner loop for columns
        if(i==1 ||j==1 ||i==n ||j==m){
            Console.Write("*");
        }
            else{
           Console.Write(" ");
            }

            }

Console.WriteLine();
        
    
}