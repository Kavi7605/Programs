#include <stdio.h>
#define NEWLINE '\n'

void main()
{
    //ternary operator
    int a, b=20, c;

    printf("enter a value: ");
    scanf("%d", &a);

    c = (a<b) ? (a+b) : (a-b);
    printf("C: %d\n",c);
}
