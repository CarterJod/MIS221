int num1 = 5;
int num2 = 10;

System.Console.WriteLine(Add(num1, num2));

System.Console.WriteLine(num1 + num2);

static int Add(int num1, int num2){
    num1 = 22;
    int temp = num1 + num2;
    return temp;
}