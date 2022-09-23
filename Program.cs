//inicio de la creacion de N trabajadores
Empleado jose=new Empleado("Nicolas", "Leal", "Lamadrid 1190", 44747829, DateTime.Parse("2020/07/89"), 213214412, Cargos.Universitario, EstadoCivil.Soltero);
jose.mostrarDatos();

//Inicio d eel cargo
enum Cargos
{
    Universitario,
    Secundario
}
//inicio de  ek estado civil
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

    public void mostrarDatos(){
        System.Console.WriteLine("Los datos de el empleado son: ");
        System.Console.WriteLine("Nombre "+ this.nombre);
        System.Console.WriteLine("Apellido: "+ this.apellido);
        System.Console.WriteLine("El sueldo es: "+ this.sueldo);
        System.Console.WriteLine("Fecha de ingreso: "+ this.fechaIngreso);
        System.Console.WriteLine("La antiguedad es: "+ this.antiguedad);
        System.Console.WriteLine("El estado civil es: "+ this.estadoCivil);
        System.Console.WriteLine("La educacion de el empleado es de nivel: "+ this.tipoEducacion);
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