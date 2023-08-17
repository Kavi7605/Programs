#include <stdio.h>

void main()
{
//Write a program in C to count the frequency of each element of an array.
    int a[10], b[10], c[10], size=0, i, j;

    printf("Enter 10 values:\n");
    for(i=0;i<10;i++)
    {
        scanf("%d", &a[i]);
    }
    for(i=0;i<10;i++)
    {
        for(j=0;j<size;j++)
        {
            if(b[j]==a[i])
            {
                c[j]++;
                break;
            }
        }

        if(j>=size)
        {
            b[j]=a[i];
            c[j]=1;
            size++;
        }
    }

    for(i=0;i<size;i++)
    {
        printf("%d, %d\n", b[i], c[i]);
    }
}
