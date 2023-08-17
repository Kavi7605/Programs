#include <stdio.h>

void main()
{
    char a;

    printf("Enter a character : ");
    scanf("%c", &a);
    if(a>=65 && a<=97 || a>=90 && a<=122)
    {
        printf("You entered a Alphabet.");
    }
    else if(a>=0 && a<=9)
    {
        printf("You entered a Digit.");
    }
    else
    {
        printf("You entered a Special character.");
    }
}
