// See https://aka.ms/new-console-template for more information

//Create a Loop that prints all values from 1-255
for(int i=1;i<=255;i++){
    Console.Write(i+" ");

}
Console.WriteLine();
Console.WriteLine("--------------");

//Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
for(int j=1;j<=100;j++){
    if((j%3==0)^(j%5==0)){
        Console.Write(j+" ");
        
    }
}

Console.WriteLine();
Console.WriteLine("--------------");

//Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
for(int j=1;j<=100;j++){
    if((j%3==0)||(j%5==0)){
        if((j%3==0)&&(j%5!=0)){
            Console.Write("Fizz ");
        }else if((j%5==0)&&(j%3!=0)){
            Console.Write("Buzz ");
        }else if((j%5==0)&&(j%3==0)){
            Console.Write("FizzBuzz ");
        }
        
    }
}