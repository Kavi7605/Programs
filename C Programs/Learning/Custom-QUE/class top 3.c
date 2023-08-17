#include <stdio.h>
#include <string.h>

struct top{
    char name[10];
    int roll;
    int sub[5];
    float avg;
};

void avg(struct top *proc);

void main()
{
    struct top s[5];
    int i, j;
    float rank[5], tmp;

    for(i=0;i<5;i++)
    {
        printf("Enter your name: ");
        scanf("%s", &s[i].name);
        printf("Enter your roll no: ");
        scanf("%d", &s[i].roll);
        printf("Enter your Maths marks: ");
        scanf("%d", &s[i].sub[0]);
        printf("Enter your Social marks: ");
        scanf("%d", &s[i].sub[1]);
        printf("Enter your Science marks: ");
        scanf("%d", &s[i].sub[2]);
        printf("Enter your Hindi marks: ");
        scanf("%d", &s[i].sub[3]);
        printf("Enter your English marks: ");
        scanf("%d", &s[i].sub[4]);
        avg(&s[i]);
    }
    for(i=0;i<5;i++)
    {
        rank[i]=s[i].avg;
    }
    for(i=0;i<5;i++)
    {
        for(j=i+1;j<5;j++)
        {
            if(rank[i]>rank[j]) continue;
            tmp=rank[i];
            rank[i]=rank[j];
            rank[j]=tmp;
        }
    }

    printf("Top 3 Students:\n");

    for(i=0,j=1;i<5;i++)
    {
        printf("%d. %.2f\n", j, rank[i]);
        j++;
    }
}

void avg(struct top *st){
    int i, sum=0;

    for(i=0;i<5;i++)
    {
        sum += st->sub[i];
    }
    st->avg = sum/5;
    printf("%.2f\n\n", st->avg);
}
