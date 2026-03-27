using ClinicaSalud.Models;

//var id = id;
//string name = name;

/*Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Name);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Id);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Edad);
Console.Write(new Pacientes(123,"szapatar",12, "diarrea").Sintoma);*/
bool system = true;

List <string> NombrePacientes = new List<string>()
{
   "Juan Sanchez","Camilo Cifuentes","Bad Bunny" 
};

while (system)
{
    string Options = "1.Register Patient\n"+
                     "2. List Patients\n" +
                     "3. Search Patients\n" +
                     "4.Exit\n" +
                     "Please Enter The First Letter Of The Option You Want to\n";
    Console.Write(Options);
//var User = Console.ReadLine();

    ConsoleKeyInfo choose = new ConsoleKeyInfo();

    choose = Console.ReadKey(true);
    system = false;

    switch (choose.Key)
    {
        case ConsoleKey.R:
        {
            Console.Write("Do You Want Register A Patient And\n");
            break;
        }

        case ConsoleKey.L:
        {
            Console.Write("Do You Want List Patients And\n");
            break;
        }

        case ConsoleKey.S:
        {
            Console.Write("Do You Want Search Any Patient And\n");
            break;
        }

        case ConsoleKey.E:
        {
            Console.Write("Do You Want Exit Of The System And\n");
            break;
        }
        default:
        {
            Console.Clear();
            Console.WriteLine("Please Select A Valid Option\n");
            system = true;
            break;

        }
    }
}



   















/*string Form = "Choose An Option";

Console.Write(Form);
Console.ReadLine();
*/
