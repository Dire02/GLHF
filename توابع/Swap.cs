private void func(ref int first, ref int sec)
        
{
            
int x;
            
x = first;
            
first = sec;
            
sec = x;
        
}
        
static void Main(string[] args)
       
{
            
int a = 10;
            
int b = 20;
            
Program p = new Program();
            
p.func(ref a, ref b);

            
Console.WriteLine(a + "  " + b);
        
}