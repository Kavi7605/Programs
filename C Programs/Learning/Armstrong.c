#include <stdio.h>

void main()
{
    int a, b, r=0, tmp;
    printf("Enter a number: ");
    scanf("%d", &a);
    tmp=a;
    while(tmp!=0)
    {
        b=tmp % 10;
        printf("%d^3 ", b);
        r=r+b*b*b;
        tmp=tmp/10;
        if(tmp!=0)
        {
            printf("+ ");
        }
    }
    if(a==r)
    {
        printf("= %d\n%d is an armstrong number.", r, a);
    }
    else
    {
        printf("= %d\n%d is not an armstrong number.", r, a);
    }
}
