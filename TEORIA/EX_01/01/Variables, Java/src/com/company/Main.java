package com.company;

public class Main {

    public static void main(String[] args) {

        // Variables enteras 

        // 1- Definir variable
        int entero;

        // 2- Guardar cosas en la variable
        entero = 1;

        // 3- Usar el valor que está guardado (System.out.println = cw tab tab)
        System.out.println(entero);

        // 4- Modificar una variable 
        entero = entero + 1;
        System.out.println(entero);


        // Variables reales

        // 1- Definir variable 
        double real;

        // 2- Guardar cosas en la variable 
        real = 3.1415926535;

        // 3- Usar el valor que está guardado
        System.out.println(real);

        // 4- Modificar el valor 
        real = real * 2;
        System.out.println(real);


        // Caracteres

        // 1- Def (derech 0, 'el caracter entre estas comillas')
        char caracter;

        // 2- Guardar 
        caracter = 'A';

        // 3- Usar
        System.out.println(caracter);

        // 4- Operacion
        caracter = (char)(caracter + 1);
        System.out.println(caracter);

        // cuidado con el orden de las los caracteres
        char caracter2;
        caracter2 = 'ñ';
        System.out.println(caracter2);
        caracter2 = (char)(caracter2 + 1);
        System.out.println(caracter2);


        // Cadenas 

        // 1- Def (+ de 1 char y se usan las comillas del 2 "hola")
        String cadena;

        // 2- Guardar
        cadena = "hola";

        // 3- Uso
        System.out.println(cadena);

        // 4- Operaciones (para separar, espacio delante de la 2a cadena)
        cadena = cadena + " banana";
        System.out.println(cadena);


        // Variables booleanas (solo 1 valor, 0 o 1, pero se escribe true o false)
        boolean valor;
        valor = true;
        System.out.println(valor);
        boolean valor2;
        valor2 = false;
        System.out.println(valor2);
        
        
    }
}
