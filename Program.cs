using System.Collections.Generic;
using System;

namespace ColeccionesII
{
    /*COLECCIONES 
     * buscar en .net library collections
     * ¿QUE SON?
     * Son clases que pertenecen al namespace System.Collection.Generic
     * Permiten almacenar elementos
     * Son clases genéricas
     * No tienen las limitacioens de los arrays (a cambio de ayor consumo de recuros).Permiten:
     * -Ordenar
     * -Añadir
     * -Eliminar
     * -Buscar
     * -Etc...
     * 
     * Colecciones más frecuentes
     * LIST<T> 
     * Parecido a los array pero con métodos adicionales para agregar, eliminar, ordenar,buscar etc
     * 
     * Queue<T>
     * Las "colas". Un elemento entra y uno sale. Primero en entrar- primero en salir
     * 
     * Stack<T>
     * Parecido a las Queue  pero con algunas diferencias. Primero en entrar-último en salir
     * 
     * LinkedList<T>
     * Comportamiento como Queue o Stack pero con acceso aleatorio
     * 
     * HashSet<T>
     * Lista de valores sin ordenar
     * 
     * Dictionary<Tkey, Tvalue> 
     * Almacenar elementos con estructura de clave-valor
     * 
     * SortedList<Tkey,Tvalue>
     * Igual que los Dictionary pero ordenados
     */
    /*
     */
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("---------------------------- DICTIONARY ------------------------------------------------ ");

            Dictionary<string,int> edades= new Dictionary<string,int>();

            //Rellenar el diccionario

            edades.Add("Aimhoa", 99);
            edades.Add("Germán", 14);
            edades["Alex"]= 89;
            edades.Add("Albert", 56);
            edades.Add("Celia", 9);

            foreach (KeyValuePair<string,int>persona in edades)
                Console.WriteLine("Nombre: {0} , Edad mental : {1}",persona.Key,persona.Value);



        }
    }


}
