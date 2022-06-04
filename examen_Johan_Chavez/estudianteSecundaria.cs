class EstudianteSecundaria : IEstudiante
{ 
string _nombre = "";
string _apellido = "";
string _institucion = "";
int _id;
int _nivel; 
int matricula = 20;
int total;

string nombre
{
    get { return _nombre;}
    set { _nombre = value;}
}
string apellido
{
    get { return _apellido;}
    set { _apellido = value;}
}
string institucion
{
    get { return _institucion;}
    set { _institucion = value;}
}
int id
{
    get { return _id;}
    set { _id = value;}
}
int nivel
{
    get { return _nivel;}
    set { _nivel = value;}
}

    public void DatosExtra(int nivel)
    {
        this.nivel = nivel;
    }

    public void Datos(string nombre, string apellido, string institucion, int id)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.institucion = institucion;
        this.id = id;
    }
    public int CalculoPrecio()
    {
        total = matricula* nivel;
        return total ;
    }
    public void ImprimirDatos()
    {
         Console.WriteLine("  ");
        Console.WriteLine(" .....Estudiante de Secundaria.....");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Nombre de la Institución: "+this.institucion);
        Console.WriteLine("Cédula de identidad: "+this.id);
        Console.WriteLine("El valor de la matricula por "+this.nivel+" niveles es de: "+CalculoPrecio()+" $");
    }  
}
