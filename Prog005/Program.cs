// сумма всех четных чисел

int s,i;
s=0;
i=1;
while(i<=15)
{
    if (i%2==0) 
    {
        s=s+i;
    }
    i++;
}
Console.WriteLine(s);
