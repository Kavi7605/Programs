#include <stdio.h>

void main()
{
    int i, j, size;

    //4A
    printf("Enter number of rows: ");
    scanf("%d", &size);

    for(i=size-1;i>=0;i--)
    {
        for(j=0;j<i;j++)
        {
            printf(" ");
        }
        for(j=0;j<size-i;j++)
        {
            printf("*");
        }
        printf("\n");
    }

    //4B
    printf("Enter number of rows: ");
    scanf("%d", &size);

    for(i=size-1;i>=0;i--)
    {
        for(j=0;j<i;j++)
        {
            printf(" ");
        }
        for(j=0;j<size-i-1;j++)
        {
            printf("**");
        }
        printf("*");
        printf("\n");
    }

    //4C
    printf("Enter number of rows: ");
    scanf("%d", &size);

    for(i=size-1;i>-1;i--)
    {
        for(j=0;j<i;j++)
        {
            printf(" ");
        }
        for(j=0;j<size-i-1;j++)
        {
            printf("**");
        }
        printf("*");
        printf("\n");
    }
    for(i=1;i<=size-1;i++)
    {
        for(j=0;j<i;j++)
        {
            printf(" ");
        }
        for(j=0;j<size-i-1;j++)
        {
            printf("**");
        }
        printf("*");
        printf("\n");
    }
}
