#include <stdio.h>

void main()
{
    int a, b, c;

    while(1)
    {
        printf("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        printf("\nSelect an option:");
        scanf("%d", &c);

        system("cls");
        switch(c)
        {
            case 1:
                getinput(&a,&b);
                printf("%d+%d=%d\n", a, b, add(a, b));
                break;
            case 2:
                getinput(&a,&b);
                printf("%d-%d=%d\n", a, b, sub(a, b));
                break;
            case 3:
                getinput(&a,&b);
                printf("%d*%d=%d\n", a, b, mul(a, b));
                break;
            case 4:
                getinput(&a,&b);
                printf("%d/%d=%d\n", a, b, div(a, b));
                break;
            case 5:
                exit(0);
            default:
                    printf("Error: Invalid Option Selected.\n");
        }
    }
}

void getinput(int *a, int *b)
{
    printf("Enter a value for A: ");
    scanf("%d", a);
    printf("Enter a value for B: ");
    scanf("%d", b);
}

int add( int a, int b)
{
    return a+b;
}
int sub( int a, int b)
{
    return a-b;
}
int mul( int a, int b)
{
    return a*b;
}
int div( int a, int b)
{
    return a/b;
}
