from dataclasses import dataclass

@dataclass
class vector:
    x: float
    y: float

def scalar_multiplication(vector, scalar):
    vector.x *= scalar;
    vector.y *= scalar;
    return vector;

def main():
    vectx = float(input("Introduzca la coordenada en x del vector: "));
    vecty = float(input("Introduzca la coordenada en y del vector: "));
    scal = float(input("Introduzca el escalar a multiplicar: "));
    vect = vector(vectx, vecty);
    vect_result = scalar_multiplication(vect, scal);
    print("El vector resultante es: ", end="");
    print(vect_result);
    
main();