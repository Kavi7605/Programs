#include <stdio.h>
#define NEWLINE '\n'

void main()
{
/*  //1st
    int a;
    printf("Enter any number: ");
    scanf("%d", &a);
    if(a % 2 == 0)
    {
        printf("%d is even number.", a);
    }
    else
    {
        printf("%d is odd number.", a);
    }
*/
/* //2nd
    int a, b;
    printf("Enter any number: ");
    scanf("%d", &a);
    if(a>=0)
    {
        printf("You Entered Positive number.");
    }
    else
    {
        printf("You Entered Negetive number.");
    }
*/
/* 3rd
    int y;
    printf("Enter a year: ");
    scanf("%d", &y);
    if (y % 400 == 0)
    {
        printf("%d is a leap year.", y);
    }
    else if (y % 100 == 0)
    {
        printf("%d is not a leap year.", y);
    }
    else if (y % 4 == 0)
    {
        printf("%d is a leap year.", y);
    }
    else
    {
        printf("%d is not a leap year.", y);
    }
*/

    //pointer example
   /* int a=10, *b;
    b=&a;

    printf("org: %d, add: %d, value %d\n", a, b,*b);

    *b = 20;
    printf("org: %d, add: %d, value %d\n", a, b,*b);
*/


    //ternary operator
    int a, b=20, c;

    printf("enter a value: ");
    scanf("%d", &a);

    c = (a<b) ? (a+b) : (a-b);
    printf("C: %d\n",c);

}
