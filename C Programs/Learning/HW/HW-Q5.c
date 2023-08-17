#include <stdio.h>

void main()
{
    int i, j, count=1, size;

    printf("Enter number of rows: ");
    scanf("%d", &size);
    for(i=1;i<size;i++)
    {
        for(j=0;j<i;j++)
        {
            printf("%d ", count++);
        }
        printf("\n");
    }
    for(i=size-1;i>1;i--)
    {
        count=count-(i+(i-2))-1;
        for(j=0;j<i-1;j++)
        {
            printf("%d ", count++);
        }
        printf("\n");
    }
}
