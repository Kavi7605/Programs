#include <stdio.h>

void main()
{
    //1st Minimum
    int min, n, b;

    printf("Enter value for N: ");
    scanf("%d", &n);
    printf("Enter %d values: ", n);

    int a[n];
    for(b=0;b<n;b++)
    {
        scanf("%d", &a[b]);
    }
    min=a[0];
    for(b=1;b<n;b++)
    {
        if(min>a[b])
        {
            min=a[b];
        }
    }
    printf("\nMinimum value is: %d", min);
}
