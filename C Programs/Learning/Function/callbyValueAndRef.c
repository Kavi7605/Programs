#include <stdio.h>

void main()
{
    int a, b, tmp;
    printf("Enter a value for A: ");
    scanf("%d", &a);
    printf("Enter a value for B: ");
    scanf("%d", &b);

    printf("A1: %d, B1: %d\n", a, b);

    swapbyvalue(a,b);

    printf("A2: %d, B2: %d\n", a, b);

    swapbyref(&a,&b);

    printf("A3: %d, B3: %d\n", a, b);

}

void swapbyvalue (int x, int y)
{
    int tmp;
    tmp=x;
    x=y;
    y=tmp;
    printf("X1: %d, Y1: %d\n", x, y);
}

void swapbyref (int *x, int *y)
{
    int tmp;
    tmp=*x;
    *x=*y;
    *y=tmp;
    printf("X2: %d, Y2: %d\n", *x, *y);
}
