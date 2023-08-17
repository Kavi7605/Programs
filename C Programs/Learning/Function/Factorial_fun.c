//1*2*3*4*5 = 120

#include <stdio.h>

void main()
{
    int n, i, c=1;
    printf("Enter a value of n: ");
    scanf("%d", &n);
    printf("Factorial of %d is %d", n, fact(n));
}

int fact(int n)
{
    if(n>1)
        return n * fact(n-1);
    else
        return 1;
}
