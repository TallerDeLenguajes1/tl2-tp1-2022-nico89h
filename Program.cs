/*
) Implementar la solución del siguiente programa usando Try Catch para capturar los posibles
errores.
Escribir la declaración de una clase que almacene información de un empleado: Datos
personales, Dirección, fecha de ingreso la empresa, datos profesionales.
a) La clase empleado deberá calcular la antigüedad en la empresa, la edad del
empleado y el salario. Este se calcula de acuerdo a la fórmula: Salario = Sueldo
Básico + Adicional – Descuento
Descuento = 15 % del Sueldo Básico.
Adicional = 1 % del sueldo básico por cada año de antigüedad
2 años_________________________ 2%
15 años_________________________ 1 5%
> 20 años________________________ 25% (a partir de 20 años se fija en 25%)
b) Modifica luego la clase de tal manera que puedas suministrar la información:
i) Si es casado, la cantidad de hijos.
ii) Si es divorciado, la fecha de su divorcio.
iii) Si tiene título universitario, el título y la universidad que impartió el título.
c) Permite el ingreso de N trabajadores
d) Muestra en una lista los datos: Apellido y Nombre, Edad, Antigüedad y Salario de los
trabajadores ingresados
*/

//Inicio d eel cargo
enum Cargos
{
    Universitario,
    Secundario
}
enum EstadoCivil
{
    Casado,
    Divorciado,
    Soltero
}
//Inicio de la clase
class Empleado{
    //inicio de la declaracion de los atributos
    private string universidad;
    private string titulo;
    private string nombre, apellido, direccion;
    private long  Dni;
    private DateTime fechaIngreso;
    private float sueldo, sueldoBasico;
    private Cargos tipoEducacion;
    private int antiguedad;
    private EstadoCivil estadoCivil;
    private float adicional, descuento;
    public Empleado(string Nombre, string Apellido, string Direccion, long DNI, DateTime FechaIngreso, float SueldoBasico, Cargos tipoEducacion, EstadoCivil Estadocivil){
        this.nombre=Nombre;
        this.apellido=Apellido;
        this.Dni=DNI;
        this.direccion=Direccion;
        this.fechaIngreso=FechaIngreso;
        this.sueldoBasico=SueldoBasico;
        this.tipoEducacion=tipoEducacion;
        if (tipoEducacion==Cargos.Universitario)
        {
            this.tieneTitulo();
        }
        this.antiguedad=  DateTime.Now.Year-this.fechaIngreso.Year; //obtengo la antiguedad
        this.estadoCivil=Estadocivil;
         //inicio de los calculos de adicional

        var v = (this.sueldoBasico * this.antiguedad) / 100;
        
        this.adicional= this.antiguedad>=20? (float)(0.25*this.sueldoBasico ): v;

        //inicio de los calculos de descuento
        this.descuento=this.antiguedad*this.sueldoBasico/100;
        
        this.sueldo= this.sueldoBasico+ this.adicional-this.descuento;//hacer la cuenta
    }
    private int hijos;
     private void tieneTitulo(){
        System.Console.WriteLine("Cual es tu titulo?");
        this.titulo=Console.ReadLine();
        System.Console.WriteLine("Cual es la universidad que te dio el titulo?");
        this.universidad=Console.ReadLine();      
    }
    private DateTime divorcioFecha;
    private void esDivorciado(){
        System.Console.WriteLine("Cual fue la fecha de tu divorcio?");
        this.divorcioFecha= DateTime.Parse(Console.ReadLine());
    }
    private void CantidadHijos(){
        System.Console.WriteLine("Cuantos hijos tenes?");
        this.hijos= Int32.Parse(Console.ReadLine());
    }
    public void CantidadHijosImprimir(){
        System.Console.WriteLine("La cantidad de hijos es: "+ this.hijos);
    }
    public void datosUniversidad(){
        System.Console.WriteLine("Los datos de la universidad y el titulo son: ");
        System.Console.WriteLine("Titulo "+ this.titulo);
        System.Console.WriteLine("Universidad "+ this.universidad);
    }
    public void FechaDivorcioImprimir(){
        System.Console.WriteLine("La fecha del divorcio fue en :"+ this.divorcioFecha.ToString("yyyyMMdd"));
    }

//     i) Si es casado, la cantidad de hijos.
// ii) Si es divorciado, la fecha de su divorcio.
// iii) Si tiene título universitario, el título y la universidad que impartió el título.

}
/*
Este se calcula de acuerdo a la fórmula: Salario = Sueldo
Básico + Adicional – Descuento
Descuento = 15 % del Sueldo Básico.
Adicional = 1 % del sueldo básico por cada año de antigüedad
2 años_________________________ 2%
15 años_________________________ 1 5%
> 20 años________________________ 25% (a partir de 20 años se fija en 25%)
*/