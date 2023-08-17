#include <stdio.h>

int main()
{
    //1st
    char a,b,c,d;
    a = 'W';
    b = a + 24;
    c = b + 8;
    d = 'n';
    printf("%c%c%c%c",a,b,c,d);
    //2nd
    char ch = 'A';
    printf("\n\nch = %c\n",ch);
    printf("ch = %d, hence an integer\n\n",ch);
    //3rd
    char greeting[6] = {'H', 'e', 'l', 'l', 'o', '\0'};
    printf("Greeting message: %s\n", greeting );
    char Alexa[13] = {'G', 'o', 'o', 'd', ' ', 'M', 'o', 'r', 'n', 'i', 'n', 'g', '\0'};
    printf("Alexa says: %s\n\n\n", Alexa );
    //4th
    char str1[12] = "Hello";
    char str2[12] = "World";
    char str3[12];
    int  len ;
    /* copy str1 into str3 */
    strcpy(str3, str1);
    printf("strcpy( str3, str1) :  %s\n", str3 );
    /* concatenates str1 and str2 */
    strcat( str1, str2);
    printf("strcat( str1, str2):   %s\n", str1 );
    /* total lenghth of str1 after concatenation */
    len = strlen(str1);
    printf("strlen(str1) :  %d\n\n\n", len );

}
