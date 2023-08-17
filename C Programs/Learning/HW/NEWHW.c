#include <stdio.h>

void main()
{
/*
    char a,b;
    printf("Enter a character: ");
    scanf("%c", &a);

    if(a<=90)
    {
        b=a+32;
        printf("Lower case: %c\n", b);
    }
    else
    {
        b=a-32;
        printf("Upper case: %c\n", b);
    }
*/

    char arr1[10], arr2[10];
    int i;
    printf("Enter string: ");
    scanf("%s", arr1);
    for(i=0;arr1[i]!='\0';i++)
    {
        if(arr1[i]<=90)
        {
            arr2[i]=arr1[i]+32;
        }
        else
        {
            arr2[i]=arr1[i]-32;
        }
    }
    arr2[i]='\0';
    printf("%s", arr2);

}
