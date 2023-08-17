# A and B comparission
a=int(input("A= "))
b=int(input("B= "))

if a>b:
    print("A great")
elif a==b:
    print("A=B")
else:
    print("B great")

# X, Y and Z comparission
def fun1(x, y, z):
    if x < z and z > y:
        return print("Yes")
    elif y < z and z > x:
        return print("Yes")
    else:
        return print("No")

def main():
   c = input("mid: ")
   a = input("num1 ")
   b = input("num2 ")
   fun1(c,a,b,)
   print("result:",fun1)

fun1(5, 6, 2)