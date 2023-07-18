using System.Configuration;
using System.Reflection;
//using Test.Modelos;

public class Program
{

    public static void Main(string[] args)
    {
        //Type typeDeveloper = typeof(Developer);
        //Console.WriteLine(typeDeveloper.Name);
        //Console.WriteLine(typeDeveloper.IsClass);
        //Console.WriteLine(typeDeveloper.IsAbstract);
        //Console.WriteLine(typeDeveloper);

        //MethodInfo [] methods = typeDeveloper.GetMethods();
        //List<Attribute> list = typeDeveloper.GetCustomAttributes().ToList();

        string assemblyToLoad = ConfigurationManager.AppSettings["Assembly"];
        string privatePath = @"D:\Trabajo\Ejercicios\Reflection\ReflectionExample\ReflectionExample\bin\Debug\net6.0\dll";
        string assemblyPath = Path.Combine(privatePath, assemblyToLoad + ".dll");


        Assembly assemblyLoaded = Assembly.LoadFrom(assemblyPath);
        Type[] types = assemblyLoaded.GetTypes();

        Type developerType = types.FirstOrDefault(x => x.Name.Equals("Developer"));

        dynamic developerInstance = Activator.CreateInstance(developerType);

        MethodInfo methodInfo = developerType.GetMethod("GetCompleteName");

        Type pType = developerInstance.GetType();
        
        object result = pType.InvokeMember("GetGuid",
                           BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance,
                           null, developerInstance, null);



        Console.ReadLine();
    }
}