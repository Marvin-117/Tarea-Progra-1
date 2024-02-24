using System;

class Program
{
    //primer ejercicio
    static void Main(string[] args)
  {
   Console.WriteLine("Ingrese el primer número:");
   double primernumero = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Ingrese el segundo número:");
   double segundonumero = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Ingrese el tercer número:");
   double tercernumero = Convert.ToDouble(Console.ReadLine());

   double mayor = primernumero;

     if (segundonumero > mayor)
      {
         mayor = segundonumero;
      }

     if (tercernumero > mayor)
     {
        mayor = tercernumero;
     }

             Console.WriteLine("El mayor es: " + mayor);

        Console.WriteLine("--------------------------------------------------------------------------" +
            "                                                                                       ");
        //segundo ejercicio
            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("¡Bienvenido, Puede seleccionar su Cariñosa!");
            }
            else
            {
                Console.WriteLine("Lo siento debe tener al menos 18 años.");
            }



        Console.WriteLine("--------------------------------------------------------------------------" +
            "                                                                                       ");

          //tercer ejercicio 
                           Console.WriteLine("Ingrese el precio del producto:");
                           double SinDescuento = Convert.ToDouble(Console.ReadLine());

                           if (SinDescuento > 100)
                           {
                           double descuento = SinDescuento * 0.10;
                           double precioFinal = SinDescuento - descuento;
                           Console.WriteLine("+ Cupon del 10%.");
                           Console.WriteLine("   Gastado: Q " + SinDescuento);
                           Console.WriteLine("-10% TOTAL: Q " + precioFinal);
                           }
                          else
                          {
                          Console.WriteLine("Cupon no valido.");
                          Console.WriteLine("TOTAL: Q " + SinDescuento);  
                          }



        Console.WriteLine("--------------------------------------------------------------------------" +
"                                                                                       ");

        //cuarto
                                 string usuario = "Marvin007";
                                 string contraseña = "123";

       
                                Console.WriteLine("Usuario:");
                                string UsuarioIngresado = Console.ReadLine();


                               Console.WriteLine("Contraseña:");
                               string contrasenaIngresada = Console.ReadLine();

                               if (UsuarioIngresado == usuario && contrasenaIngresada == contraseña)
                               {
                                Console.WriteLine("Soy el Mark, Bienvenido a facebook. " + usuario + "!");
                               }
                               else
                               {
                               Console.WriteLine("usuario o contraseña son incorrectos");
                               }


        Console.WriteLine("--------------------------------------------------------------------------" +
"                                                                                       ");
        //quinto


        Console.WriteLine("Ingrese un número:");
        int cantidad = Convert.ToInt32(Console.ReadLine());

       
        if (cantidad % 2 == 0)
        {
            Console.WriteLine(cantidad + " es un número par.");
        }
        else
        {
            Console.WriteLine(cantidad + " es un número impar.");
        }





        Console.WriteLine("--------------------------------------------------------------------------" +
"                                                                                       ");

        //sexto
        Console.WriteLine("Ingrese el monto del préstamo:");
                                           double credito = Convert.ToDouble(Console.ReadLine());

                                           Console.WriteLine("Ingrese su edad:");
                                           int Edad = Convert.ToInt32(Console.ReadLine());

       
                                           if (credito<5000 || Edad>60)
                                           {
                                            Console.WriteLine("Credito aprobado.");
                                           }
                                           else
                                           {
                                            Console.WriteLine("Credito denegado.");
                                           }

        Console.WriteLine("--------------------------------------------------------------------------" +
"                                                                                       ");

        //septimo
        Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
        string tipoFigura = Console.ReadLine().ToLower(); 

        double area = 0;

        switch (tipoFigura)
        {
            case "triangulo":
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del triángulo:");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                area = (baseTriangulo * alturaTriangulo) / 2;
                break;

            case "cuadrado":
                Console.WriteLine("Ingrese el lado del cuadrado:");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                area = ladoCuadrado * ladoCuadrado;
                break;

            case "circulo":
                Console.WriteLine("Ingrese el radio del círculo:");
                double radioCirculo = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * Math.Pow(radioCirculo, 2);
                break;

            default:
                Console.WriteLine("Tipo de figura geométrica no válido.");
                return;
        }

        Console.WriteLine("El área de la figura geométrica es: " + area);
    }







}
    