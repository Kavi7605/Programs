#include <stdio.h>

void main()
{
    int a, b, c;
    printf("Enter a value for A: ");
    scanf("%d", &a);

    for(b=1;b<11;b++)
    {
        c=a*b;
        printf("%d*%d=%d\n",a ,b, c);
    }
}
