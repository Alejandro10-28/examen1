using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examencasa
{
    public class Principal
    {

      
      //A grandes rasgos solo ocupas este arreglo que lo hice de una clase persona para poder usar varios tipos de datos como
      //string, int y float en un mismo arreglo.
        persona[] personas = new persona[1];
        float Sumatotal ;
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido");

           
           Menu();
        }

        public void Menu()
        {

            Console.WriteLine("Elige una opcion:\n1-.Agregar tamales\n2-.Ver total");
            switch (Console.ReadLine())
            {
                case "1":
                    pedirdatos();
                    break;
                case "2":
                    VerTotal();
                    break;
            }

        }
        //Este metodo te lo imprime 
        private void VerTotal()
        {
            float total;
            int Sum=0;
            int SumP = 0;
            int SumR = 0;
            int SumE =0;
            Console.WriteLine("Personas y el total de tamales pedidos");
            for (int i = 0; i < personas.Length; i++)
            {

                Console.WriteLine("Persona:" + personas[i].Nombre );
                Console.WriteLine("Tamales Carne:{0}", personas[i].TamalC );
                Console.WriteLine("tamal pollo:{0}", personas[i].TamalP );
                Console.WriteLine( "tamal rajas:{0}", personas[i].TamalR );
                Console.WriteLine( "tamal elote:{0}", personas[i].TamalE);
                if (personas[i].Dinero > 0)
                {


                    Console.WriteLine("Saldo:{0}", personas[i].Dinero);
                    Sumatotal = Sumatotal - personas[i].Dinero;

                }
                else
                {
                    Console.WriteLine("Debes:{0}", personas[i].Dinero);

                }
                Sum =Sum + personas[i].TamalC;
                SumP = SumP + personas[i].TamalP;
                SumR = SumR + personas[i].TamalR;
                SumE = SumE + personas[i].TamalE;

            }
            Console.WriteLine("==========TOTAL===========");
            Console.WriteLine("Tamales de carne en total:" + Sum);
            Console.WriteLine("Tamales de pollo en total:" + SumP);
            Console.WriteLine("Tamales de rajas en total:" + SumR);
            Console.WriteLine("Tamales de elotes en total:" + SumE);
            Console.WriteLine("Total a pagar:"+Sumatotal);
            Console.ReadKey();
        }



        //Es metodo que te llena los datos al usuario 
        public void pedirdatos()
        {
            for (int x = 0; x < personas.Length; x++)
            {
                personas[x] = new persona();

                Console.WriteLine("Ingresa tu nombre");
                personas[x].Nombre =Console.ReadLine();
                Console.WriteLine("Con cuanto dinero cuentan:");              
                personas[x].Dinero = Convert.ToSingle(Console.ReadLine());
                //Haz de cuenta que hize una variable global sumatotal paraa que almacene todo el dinero de las personas 
                //y al final se le haga la resta total de todo lo que gastaron de tamales y vean cuanto fue por todo
                Sumatotal = Sumatotal + personas[x].Dinero;

                Console.WriteLine("Cuantos tamales de carne desean");
                personas[x].TamalC = Convert.ToInt32(Console.ReadLine());
                pedirC(x);
                Console.WriteLine("Cuantos tamales de pollo desean");
                personas[x].TamalP = Convert.ToInt32(Console.ReadLine());
                PedirP(x);
                Console.WriteLine("Cuantos tamales de Rajas desean");
                personas[x].TamalR = Convert.ToInt32(Console.ReadLine());
                PedirR(x);
                Console.WriteLine("Cuantos tamales de elote desean");
                personas[x].TamalE = Convert.ToInt32(Console.ReadLine());
                PedirE(x);
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Y haz de cuenta que estos metodos son para los precios es la misma condicion en todos solo varia el tipo de tamal es pedirC= tamal carne
        //PedirP=tamal pollo
        public void pedirC(int x)
        {
            if (personas[x].TamalC <= 10)
            {
                personas[x].Dinero = personas[x].Dinero - 15;
            }
            else if (personas[x].TamalC > 10 && personas[x].TamalC <= 20)
            {
                personas[x].Dinero = personas[x].Dinero - 13;

            }
            else if (personas[x].TamalC > 20)
            {
                personas[x].Dinero = personas[x].Dinero - 10;
            }
        }
        public void PedirP(int p)
        {
            if (personas[p].TamalP <= 10)
            {
                personas[p].Dinero = personas[p].Dinero - 15;
            }
            else if (personas[p].TamalP > 10 && personas[p].TamalP <= 20)
            {
                personas[p].Dinero = personas[p].Dinero - 13;

            }
            else if (personas[p].TamalP > 20)
            {
                personas[p].Dinero = personas[p].Dinero - 10;
            }
        }
        public void PedirR(int R)
        {
            if (personas[R].TamalR <= 10)
            {
                personas[R].Dinero = personas[R].Dinero - 15;
            }
            else if (personas[R].TamalR > 10 && personas[R].TamalR <= 20)
            {
                personas[R].Dinero = personas[R].Dinero - 13;

            }
            else if (personas[R].TamalR > 20)
            {
                personas[R].Dinero = personas[R].Dinero - 10;
            }
        }
        public void PedirE(int E)
        {
            if (personas[E].TamalE <= 10)
            {
                personas[E].Dinero = personas[E].Dinero - 15;
            }
            else if (personas[E].TamalE > 10 && personas[E].TamalE <= 20)
            {
                personas[E].Dinero = personas[E].Dinero - 13;

            }
            else if (personas[E].TamalE > 20)
            {
                personas[E].Dinero = personas[E].Dinero - 10;
            }
        }
    }
}
