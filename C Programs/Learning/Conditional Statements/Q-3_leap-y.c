#include <stdio.h>
#define NEWLINE '\n'

void main()
{
    //3rd
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
}
