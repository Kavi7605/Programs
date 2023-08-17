#include <stdio.h>

void main()
{
    int A, B, C;
    printf("Value for A: ");
    scanf("%d",&A);
    printf("Value for B: ");
    scanf("%d",&B);
    printf("Value for C: ");
    scanf("%d",&C);

    if (A > B)
    {
        if (B > C)
            printf("A>B>C");
        else if (B < C)
        {
            if (C < A)
                printf("B<C<A");
            else if (C > A)
                printf("B<A<C");
            else
                printf("B<C=A");
        }
        else
            printf("A>B=C");
    }
    else if (A < B)
    {
        if (B > C)
        {
            if (C < A)
                printf("C<A<B");
            else if (C > A)
                printf("A<C<B");
            else
                printf("A=C<B");
        }
        else if (B < C)
            printf("A<B<C");
        else
            printf("A<B=C");
    }
    else
    {
        if (B > C)
            printf("A=B>C");
        else if (B < C)
            printf("A=B<C");
        else
            printf("A=B=C");
    }
}
