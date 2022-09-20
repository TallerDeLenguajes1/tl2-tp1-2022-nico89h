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
    Ingeniero, 
    Medico,
    Programador,
    Psicologo
}
//Inicio de la clase
class Empleado{
    //inicio de la declaracion de los atributos
    private string nombre, apellido, direccion;
    private long  Dni;
    private DateTime fechaIngreso;
    private float sueldo, sueldoBasico;
    private Cargos tipoEmpleo;
    private int antiguedad;
    public Empleado(string Nombre, string Apellido, string Direccion, long DNI, DateTime FechaIngreso, float SueldoBasico, Cargos TipoEmpleo){
        this.nombre=Nombre;
        this.apellido=Apellido;
        this.Dni=DNI;
        this.direccion=Direccion;
        this.fechaIngreso=FechaIngreso;
        this.sueldoBasico=SueldoBasico;
        this.tipoEmpleo=TipoEmpleo;
        this.antiguedad=  DateTime.Now.Year-this.fechaIngreso.Year; //obtengo la antiguedad
        this.sueldo= this.sueldoBasico;//hacer la cuenta
    }    
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