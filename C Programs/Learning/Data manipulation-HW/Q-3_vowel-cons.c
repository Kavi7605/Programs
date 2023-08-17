#include <stdio.h>

void main()
{
    //3nd
    char alp;
    printf("Enter a Alphabet: ");
    scanf("%c", &alp);
    if(alp>='a' && alp<='z' || alp>='A' && alp<='Z')
    {
        switch(alp)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                    printf("%c is a vowel", alp);
                    break;
            default:
                    printf("%c is a consonant", alp);
                    break;
        }
    }
    else
    {
        printf("ERROR: You didn't entered a alphabet.");
    }
}
