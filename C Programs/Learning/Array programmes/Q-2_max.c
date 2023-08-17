#include <stdio.h>

void main()
{
    //2st Maximum
    int b, n, max;

    printf("Enter value for N: ");
    scanf("%d", &n);
    int a[n];

    printf("Enter %d values: ", n);
    for(b=0;b<n;b++)
    {
        scanf("%d", &a[b]);
    }
    max=a[0];
    for(b=1;b<n;b++)
    {
        if(max<a[b])
        {
            max=a[b];
        }
    }
    printf("\nMaximum value is: %d", max);
}
