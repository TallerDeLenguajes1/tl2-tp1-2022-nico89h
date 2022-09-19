using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
/*
Problema 1:
Realizar una aplicación de consola que cargue de un número entero por teclado e
imprimir su cuadrado
*/
// System.Console.WriteLine("Hola pibeeee, dame un numero para que lo eleve al cuadrado xfa");
// int x= Int32.Parse(Console.ReadLine());
// //aca la elevo al cuadrado a la piba
// System.Console.WriteLine("El numero ingresado elevado al cuadrado es:{0}", Math.Pow(x,2));

/*
Inicio de el problema 2
Realizar una aplicación de consola que cargue 2 números y haga la división entre ellos.
// */
// System.Console.WriteLine("Dame 2 numeros para dividir");
// System.Console.WriteLine("Numero 1");
// float X= float.Parse(Console.ReadLine());
// System.Console.WriteLine("Numero 2");
// float Y= float.Parse(Console.ReadLine());
// System.Console.WriteLine("La division entre ellos es: {0}", (X/Y));
/*
Problema 3:
Cree una aplicación que ingrese kilómetros conducidos y litros usados, y calcule
kilómetros por litro
*/

// System.Console.WriteLine("Dame el kilometro y los litros usados para calcular km por litro");
// System.Console.WriteLine("Kilometro");
// float X= float.Parse(Console.ReadLine());
// System.Console.WriteLine("Litro");
// float Y= float.Parse(Console.ReadLine());
// System.Console.WriteLine("Los litros utilizados por km son: {0}", (X/Y));
/*
Problema 4:
Realizar una aplicación de consola que consuma la siguiente api
https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre y que muestre el
listado de provincias y su correspondiente id.
*/
 //inicio de la api
    
var url="https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre"; //datos de los elixirs de harry potter
var request=(HttpWebRequest)WebRequest.Create(url);
request.Method="GET";
request.ContentType="application/json";
request.Accept="application/json";
try
{
    using (WebResponse response=request.GetResponse())
    {
        using (Stream strReader = response.GetResponseStream())
        {
            if (strReader==null) return;
            using (StreamReader objReader= new StreamReader(strReader))
            {
                string respondeBody = objReader.ReadToEnd();

                var provincias= JsonSerializer.Deserialize<List<Provincia>>(respondeBody);
                
                //inicio de el control de el elixir
                int l = 0;
                for (int p = 0; p < provincias.Count; p++) // recorro los datos de la lista recibida de la api
                {
                    //System.Console.WriteLine("Nombre : "+ provincias[p].Name);
                    //controla la cantidad de veces que aparecen los nombres y cuales son 
                    // for (l=0; l < 4; l++) //recorro los personajes
                    // {
                    //     if (provincias[p].Name==grupo1[l].Nombre || provincias[p].Name==grupo2[l].Nombre)
                    //     {
                    //         nombres.Add(provincias[p].Name);
                    //         cantidadElixir++;
                    //     }
                    // }
                    // l=0;
                    //inicio de provincias
                    System.Console.WriteLine("Las provincia es: "+ provincias[p].Nombre+ "Su id es: "+ provincias[p].Id);
                }
                //los nombres q apareceran son 3, en caso de que se use el json
                // if (cantidadElixir>0)
                // {
                //     System.Console.WriteLine("La cantidad de nombres que coinciden con los nombres de elixir son: "+ cantidadElixir);
                //     foreach (var item in nombres)
                //     {
                //         System.Console.WriteLine("Nombre: "+ item);
                //     }
                // }else
                // {
                //     System.Console.WriteLine("Ningun nombre coincide con la api");
                // }
            }
        }
    }
}
catch{
    System.Console.WriteLine("Se preodujo un error");
}


public class Provincia
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("nombre")]
    public string Nombre { get; set; }
}