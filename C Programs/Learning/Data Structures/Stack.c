#include <stdio.h>
#define MAX 10

struct Stack{
 int a[MAX];
 int top;
} ;

void main()
{
    struct Stack s1;
    createstack(&s1);

    printstack(&s1);

    push(&s1,2);
    push(&s1,5);
    push(&s1,6);
    push(&s1,8);
    push(&s1,4);
    push(&s1,1);
    push(&s1,0);
    push(&s1,7);
    push(&s1,5);
    push(&s1,3);
    push(&s1,89);

    printstack(&s1);
    printf("Value at top: %d.\n", peek(&s1));
    pop(&s1);
    pop(&s1);

    printstack(&s1);
    printf("Value at top: %d.\n", peek(&s1));
}

void createstack(struct Stack *x)
{
    x->top=-1;
}

void push(struct Stack *x, int y)
{
    if(x->top >= MAX-1)
    {
        printf("Stack is Full.\n");
    }
    else
    {
        x->top++;
        x->a[x->top] = y;
    }
}

void pop(struct Stack *x)
{
    if(x->top<0)
    {
        printf("Stack is empty.\n");
    }
    else
    {
        printf("Deleted element %d.\n", x->a[x->top]);
        x->top--;
    }
}

int peek(struct Stack *x)
{
    if(x->top<0)
    {
        printf("Stack is Empty.\n");
        return NULL;
    }
    else
    {
        return x->a[x->top];
    }

}

void printstack(struct Stack *x)
{
    int i;
    if(x->top<0)
    {
        printf("Stack is empty.\n");
    }
    else
    {
        for(i=0; i <= x->top; i++)
        {
            printf("%d\n",x->a[i]);
        }
    }
}
