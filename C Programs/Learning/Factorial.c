#include <stdio.h>

void main()
{
    int n, i, c=1;
    printf("Enter a value of n: ");
    scanf("%d", &n);
    for(i=1;i<=n;i++)
    {
        c=i*c;
    }
    printf("Factoruial of %d is %d", n, c);
}
