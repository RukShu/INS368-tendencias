import math;

def main():
    print("Resolución de ecuación cuadrática");
    a = int(input("Introduzca el coeficiente A: "));
    b = int(input("Introduzca el coeficiente B: "));
    c = int(input("Introduzca el coeficiente C: "));
    try:
        x1 = (-b + math.sqrt(b*b - 4*a*c))/(2*a);
        x2 = (-b - math.sqrt(b*b - 4*a*c))/(2*a);    
        print("Valor X1: ", end = "");
        print(x1);
        print("Valor X2: ", end = "");
        print(x2);
    except:
         print("Esta ecuación cuadrática no posee soluciones reales.");

main();