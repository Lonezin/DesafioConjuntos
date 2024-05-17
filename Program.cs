namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> a = new HashSet<int>();
        HashSet<int> b = new HashSet<int>();
        HashSet<int> c = new HashSet<int>();
        System.Console.Write("How many students for course A?");
        int n = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int sla = int.Parse(System.Console.ReadLine());
            a.Add(sla);
        }

        System.Console.Write("How many student for course B?");
        n = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int slb = int.Parse(System.Console.ReadLine());
            b.Add(slb);
        }
        System.Console.Write("How many student for course C?");
        n = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int slc = int.Parse(System.Console.ReadLine());
            c.Add(slc);
        }
        HashSet<int> result = new HashSet<int>(a);
        result.UnionWith(b);
        result.UnionWith(c);
        System.Console.WriteLine($"Total students: {result.Count}");
    }
}