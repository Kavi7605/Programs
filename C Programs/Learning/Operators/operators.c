#include <stdio.h>

void main()
{
    /*
    int a, b, c;

    printf("Enter a value for a: ");
    scanf("%d", &a);
    printf("Enter a value for b: ");
    scanf("%d", &b);
    printf("Enter a value for c: ");
    scanf("%d", &c);

    //relational operators
    printf("%d == %d : %d\n", a, b, (a==b));
    printf("%d != %d : %d\n", a, b, (a!=b));
    printf("%d < %d : %d\n", a, b, (a<b));
    printf("%d > %d : %d\n", a, b, (a>b));
    printf("%d <= %d : %d\n", a, b, (a<=b));
    printf("%d >= %d : %d\n\n", a, b, (a>=b));

    //logical operator
    printf("%d && %d : %d\n", a, b, (a&&b));
    printf("%d || %d : %d\n", a, b, (a||b));
    printf("%d : NOT %d\n\n", a, (!a));

    printf("%d > %d and %d > %d : %d\n", a, b, a, c, (a>b && a>c));
    printf("%d > %d and %d > %d : NOT %d\n", a, b, a, c, !(a>b && a>c));
    printf("%d > %d || %d > %d : %d\n", a, b, a, c, (a>b || a>c));
    printf("%d > %d || %d > %d : NOT %d\n\n", a, b, a, c, !(a>b || a>c));

    //Assignment operators
    printf("%d = %d : %d\n", c, b, (c=b));
    printf("%d += %d : %d\n", a, 2, (a+=2));
    printf("%d -= %d : %d\n", a, 2, (a-=2));
    printf("%d *= %d : %d\n", a, 2, (a*=2));
    printf("%d /= %d : %d\n", a, 2, (a/=2));
    printf("%d %= %d : %d\n", a, 2, (a%=2));
*/
    int hp=10000, x;
    printf("Change HP: ");
    scanf("%d", &x);
    //hp=hp+x;
    hp+=x;
    printf("Current HP: %d",hp);


}
