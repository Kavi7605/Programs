#include <stdio.h>

void main()
{
    int a, b, c;

    printf("Enter a value for a: ");
    scanf("%d", &a);
    printf("Enter a value for b: ");
    scanf("%d", &b);
    printf("Enter a value for c: ");
    scanf("%d", &c);

 /*
    if(a < b )
    {
        printf("%d < %d\n", a, b);
    }
    else
    {
        printf("%d > %d\n", a, b);
    }
*/
    //nested if else
    if(a > b)
    {
        if(a > c)
        {
            printf("A is max");
        }
        else
        {
            printf("C is max");
        }
    }
    else
    {
        if(b > c)
        {
            printf("B is max");
        }
        else
        {
            printf("C is max");
        }
    }
 /*
    //if else if ladder
    if(a < b)
    {
        printf("A is less");
    }
    else if(a > b)
    {
        printf("A is greater");
    }
    else
    {
        printf("A = B");
    }
*/
/*
    printf("%d == %d : %d\n", a, b, (a==b));
    printf("%d != %d : %d\n", a, b, (a!=b));
    printf("%d < %d : %d\n", a, b, (a<b));
    printf("%d > %d : %d\n", a, b, (a>b));
    printf("%d <= %d : %d\n", a, b, (a<=b));
    printf("%d >= %d : %d", a, b, (a>=b));
*/

}
