namespace Fajlkezelo3
{
    internal class Program
    {
        static void Main()
        {
            string fajl = "binaris.dat";

            // Írás
            using (FileStream fs = new FileStream(fajl, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(42);       // int
                bw.Write("Hello");  // string
                bw.Write(true);     // bool
            }


            // Olvasás
            using (FileStream fs = new FileStream(fajl, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int szam = br.ReadInt32();
                string szoveg = br.ReadString(); 
                bool logikailag = br.ReadBoolean();

                Console.WriteLine($"{szam}, {szoveg}, {logikailag}");
            }
        }
    }
}
