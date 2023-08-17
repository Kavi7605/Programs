#include <stdio.h>
#define NEWLINE '\n'

void main()
{
    //pointer example
    int a=10, *b;
    b=&a;

    printf("org: %d, add: %d, value %d\n", a, b,*b);

    *b = 20;
    printf("org: %d, add: %d, value %d\n", a, b,*b);
}
