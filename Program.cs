using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica
{

    public class Empleados{
        public string Nombre { get; set; }
        public double Sueldo { get; set; }
        public double Venta { get; set; }
        public double Bono { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Empleados> nuevoEmpleadoList = new List<Empleados>();            
            //Empleados emple1 = new Empleados();
            
            //variables a utilizar
            int PromVentas = 0;
            string nombre;
            double bono = 0, sumarventas = 0, ventamayor = 0;
            double sueldo = 0, ventas = 0, CantVend = 0;

            //emplado con mayor venta
            string emplVentaMay = "";
            
            string opcion = "s";

            Console.WriteLine("¿Desea calcular el bono de un vendedor s/n?");
            opcion = Console.ReadLine();
            while(opcion != "n" ){
                //Console.Clear();

                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();
                //emple1.Nombre = nombre;

                Console.WriteLine("Ingrese su sueldo:");
                sueldo = double.Parse(Console.ReadLine());
                //emple1.Sueldo = sueldo;
                //nuevoEmpleadoList.Add(emple1);
                if (sueldo > 0){

                    Console.WriteLine("Ingrese el valor de la venta:");
                    ventas = double.Parse(Console.ReadLine());

                    if (ventas >= 0 && ventas <= 500)
                    {
                        Console.WriteLine("No tienes bonos sad :(");
                    }
                    else if (ventas > 500 && ventas <=700 )
                    {
                        bono = (sueldo * 0.05) + sueldo;
                        Console.WriteLine("Su bono es del 5% " + bono);
                    }
                    else if (ventas > 700 && ventas <= 900){
                        bono = (sueldo * 0.07) + sueldo;
                        Console.WriteLine("Su bono es de 7% " + bono);
                    }

                    else if (ventas > 900 && ventas <= 1100){
                        bono = (sueldo * 0.11) + sueldo;
                        Console.WriteLine("Su bono es de 11% " + bono);
                    }

                    else if (ventas > 1100){
                        bono = (sueldo * 0.15) + sueldo;
                        Console.WriteLine("Su bono es de 15% " + bono);
                    }

                    nuevoEmpleadoList.Add(new Empleados{Nombre = nombre, Sueldo = sueldo, Venta = ventas, Bono = bono});

                    Console.WriteLine("\nEmpleados registrados:");

                    foreach (Empleados item in nuevoEmpleadoList){
                        Console.WriteLine("Nombre vendedor: " + item.Nombre + "   ===> sueldo = " + item.Sueldo + 
                                          " y venta = " + item.Venta + " y su bono es = " + item.Bono);
                    }   
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sueldo no valido\n");
                    Console.WriteLine("Empleados registrados hasta el momento\n");
                    foreach (Empleados item in nuevoEmpleadoList){
                        Console.WriteLine("Nombre vendedor: " + item.Nombre + "   ===> sueldo = $" + item.Sueldo + 
                                          " y venta = " + item.Venta + " y su bono es = " + item.Bono);
                    }
                }
                
                //cantidad de vendedores 
                CantVend =+ 1;

                //sumartoria de las ventas
                sumarventas =+ ventas;

                //promedio de las ventas 
                PromVentas =+ 1;
                
                //sacando la venta mayor con el vendedro 
                foreach (Empleados itemx in nuevoEmpleadoList)
                {
                    if(itemx.Venta > ventamayor){
                        ventamayor = itemx.Venta;
                        emplVentaMay = itemx.Nombre;
                    }
                }
                if (ventas > ventamayor)
                {
                    ventamayor = ventas;
                }

                Console.WriteLine("\n¿Desea continuar con otro calculo? s/n");
                opcion = Console.ReadLine();
            }
            Console.WriteLine("Saliendo del sismtea");

            Console.WriteLine("La cantidad de vendedores evaluados en este rango son : " + CantVend);
            Console.WriteLine("La sumatoria de las ventas es : " + sumarventas);
            Console.WriteLine("El promedio de las ventas es : " + sumarventas / PromVentas);
            nombre = (Console.ReadLine());
            Console.WriteLine(" La Venta Maxima es : " + ventamayor + " del vendedor " + emplVentaMay);
            Console.ReadKey();        
        }
    }
}
