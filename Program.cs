/*   
 _______________________________________________________________________
|[] Universidad Politecnica Internacional.                        |F]|!"|
|"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""|"|
|Programacion II                                                      | |
|Tarea 2 - Semana 3 v2                                                  | |
|																	  | |  
|Profesor: Ing. Alexander Curling                                     | |  
|                                                                     | |
|Creado por: Luis Angel Chaves Mora                                   |_|
|_____________________________________________________________________|/|
 
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea1_UPI_Progra2
{
    internal class Program
    {
        static int carnet = 0;
        static string nombre;
        static float quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;
        static float promedio_quices;
        static float promedio_tareas;
        static float promedio_examenes;
        static float porcentaje_quiz;
        static float porcentaje_tarea;
        static float porcentaje_examen;
        static float promedio_final;
        static string condicion_estudiante;
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {   
                
                Console.WriteLine("\t   Tarea 2 - Semana 2\n");
                Console.WriteLine("-------------Menu Principal-------------");
                Console.WriteLine("Opcion 1:  Ejercicio 1");
                Console.WriteLine("Opcion 2:  Ejercicio 2");
                Console.WriteLine("Opcion 3:  Ejercicio 3");
                Console.WriteLine("Opcion 4:  Salir");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Seleccione su opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);// si ingresa una letra no va a dejar continuar
                switch (opcion) 
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2: 
                        Ejercicio2();
                        break;
                    case 3: 
                        Ejercicio3();
                        break;        
                    default:
                        Console.WriteLine("¡Hasta Pronto! Gracias");
                        break; 
                
                }//fin del switch 
            } while (opcion != 4);

        }// fin del main
        public static void Ejercicio1() //metodo 1
        { 
            float precio = 0;
            int cantidad = 0;
            float total = 0;
            Console.Clear();
            Console.WriteLine("Programa para ventas de camisas\n");
            Console.WriteLine("Cual es el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad*precio}");
            }//fin if 1
            if (cantidad > 1 && cantidad <= 6)
            {
                total = (cantidad * precio) * 0.15f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: ${total} con descuento de 15%\n");
            }// fin if 2
            if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.2f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: ${total} con descuento de 20%\n");
            }//fin if 3
        }// fin metodo Ejercicio1
        
        public static void SolicitudDatos()
        {
            Console.WriteLine("Programa para calcular porcentajes y promedio final de un estudiante\n");
            Console.WriteLine("Ingrese su número de carnet: ");
            carnet = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la calificación del quiz 1 (0-100):");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del quiz 2 (0-100):");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del quiz 3 (0-100):");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación de la Tarea 1 (0-100):");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación de la Tarea 2 (0-100):");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación de la Tarea 3 (0-100):");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del Examen 1 (0-100):");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del Examen 2 (0-100):");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del Examen 3 (0-100):");
            examen3 = float.Parse(Console.ReadLine());
        }//fin metodo solicitud datos
        public static void Ejercicio2() // metodo 2
        {
            SolicitudDatos();
            CalculosPromPorc();
            ResultadosPantalla();
        }//Fin metodo 2
        public static void CalculosPromPorc()
        {
            //Calculo de Promedios
            promedio_quices = ((quiz1 + quiz2 + quiz3) / 3);
            promedio_tareas = ((tarea1 + tarea2 + tarea3) / 3);
            promedio_examenes = ((examen1 + examen2 + examen3) / 3);

            //Calculo Porcentajes
            porcentaje_quiz = (promedio_quices * 25 / 100);
            porcentaje_tarea = (promedio_tareas * 30 / 100);
            porcentaje_examen = (promedio_examenes * 45 / 100);

            //Calculo Promedio Final

            promedio_final = porcentaje_quiz + porcentaje_tarea + porcentaje_examen;

            //Condicion logica para determinar estado del estudiante
            
            if (promedio_final >= 70)
            {
                condicion_estudiante = "Aprobado";

            }//fin if
            else if (promedio_final >= 50)
            {
                condicion_estudiante = "Aplazado";

            }// fin else if
            else
            {
                condicion_estudiante = "Reprobado";
            }//fin else
        }//fin metodo calculos
        public static void ResultadosPantalla()
        {
            //Muestra de resultados por pantalla
            Console.Clear();
            Console.WriteLine("\nResumen de sus resultados\n");
            Console.WriteLine($"Carnet del estudiante: {carnet}");
            Console.WriteLine($"Nombre del estudiante: {nombre}");
            Console.WriteLine($"Porcentaje total de quices: {porcentaje_quiz}");
            Console.WriteLine($"Porcentaje total de tareas: {porcentaje_tarea}");
            Console.WriteLine($"Porcentaje total de examenes: {porcentaje_examen}");
            Console.WriteLine($"Promedio final del estudiante: {promedio_final}");
            Console.WriteLine($"Condicion del estudiante: {condicion_estudiante}");
            Console.WriteLine("\nPresione Enter para regresar al menu principal");
            Console.ReadLine(); // Espera que el usuario digite Enter para salir
            Console.Clear();
        }
        public static void Ejercicio3() // metodo 3
        {
            //Definicion e Inicializacion de variables
            int cant_articulos = 0;
            float precio_articulo = 0;
            float precio_total = 0;
            //Entrada de datos
            Console.WriteLine("Programa para ventas de productos\n");
            Console.WriteLine("Ingresa la cantidad de articulos a comprar: ");
            cant_articulos = int.Parse(Console.ReadLine());
            //Definir el precio por cant de articulos
            if (cant_articulos <= 10) 
            
            {
                precio_articulo = 20.0f;
                
            }//fin if
            else
            {
                precio_articulo = 15.0f;

            }//fin else
            // Calcular precio total por cant articulos
            precio_total = cant_articulos * precio_articulo;
            //Salida de resultados
            Console.WriteLine("\nResumen\n");
            Console.WriteLine($"Cantidad de articulos comprados: {cant_articulos}");
            Console.WriteLine($"Precio por articulo comprado: ${precio_articulo}");
            Console.WriteLine($"Precio total de la compra: ${precio_total}");
            Console.WriteLine("\nPresione Enter para regresar al menu principal");
            Console.ReadLine(); // Espera que el usuario digite Enter para salir
            Console.Clear();
        }//Fin metodo 3
    }// fin de la clase
}// fin del namespace
