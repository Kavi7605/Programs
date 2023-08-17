#include <stdio.h>

void main()
{
    int a, b, c;
    printf("A:");
    scanf("%d", &a);
    printf("B:");
    scanf("%d", &b);
    c=a;
    a=b;
    b=c;
    printf("\nAfter swap\nA:%d B:%d\n\n\n", a, b);
}
