
bool stop = true;



List<string> nombrePacientes = new List<string>();



    string Options =
                      "1.Register Patient\n"+
                     "2. List Patients\n" +
                     "3. Search Patients\n" +
                     "4.Exit\n";
    Console.WriteLine(Options);
     


     while (stop)
     {
         
         Console.WriteLine("Please Enter The Number Do You Want\n"); 
         Console.WriteLine(Options);
         string choose = Console.ReadLine();
         
         Console.Clear();

         switch (choose)
         {
             case "1":
             {
                 Console.WriteLine("Enter Data Of Patient");
                 string paciente = Console.ReadLine();
                 nombrePacientes.Add(paciente);
                 //Console.Clear();
                 //Console.WriteLine(Options);
                 break;
             }

             case "2":
             {
                 foreach (var pacientes in nombrePacientes)
                 {
                     Console.WriteLine($"El paciente {pacientes} Esta Registrado");
                 }

                 Console.ReadLine();
                 break;
             }

             case "3":
             {
                 Console.Write("Search It \n");
                 string s = Console.ReadLine();

                 
                 string Name = nombrePacientes.FirstOrDefault(p =>p == s);
                 if (Name == null)
                 {
                     Console.WriteLine($"The {Name}Is Not In System");
                     Console.ReadLine();
                 }
                 else
                 {
                     Console.WriteLine($"The {Name} Is In The System");
                     Console.ReadLine();
                 }
                 
                 break;
             }

             case "4":
             {
                 stop = false;
                 break;
             }

         }
     }





















/*string Form = "Choose An Option";

Console.Write(Form);
Console.ReadLine();
*/
