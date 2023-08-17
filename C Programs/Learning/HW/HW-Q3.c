#include <stdio.h>

void main()
{
    int a, b, c;
    printf("Enter a number: ");
    scanf("%d", &a);

    for(b=1;b<=a;b++)
    {
        c=b*b*b;
        printf("%d*%d*%d=%d\n", b, b, b, c);
    }
}

