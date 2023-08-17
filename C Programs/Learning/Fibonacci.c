//0 1 1 2 3 5 8

#include <stdio.h>

void main()
{
    int a=0, b=1, c, n, i;
    printf("Enter a value for n: ");
    scanf("%d", &n);

    printf("Fibonacci Series with %d elements\n%d", n , a);
    for(i=0;i<n;i++)
    {
        printf(" %d", b);
        c=a+b;
        a=b;
        b=c;
    }
}
