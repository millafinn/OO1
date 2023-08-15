namespace OO1
{
    internal class Program
    {
        static void Main(string[] args)  {
            Conta conta1 = new Conta();
            Conta conta2 = new Conta(); 

            conta1.setNum(1);
            conta1.setNome("LP"); //SET
            conta1.setSaldo(1000);
            Console.WriteLine(conta1.getNum());  //GET
            Console.WriteLine(conta1.getNome());
            Console.WriteLine(conta1.getSaldo());

            conta2.setNum(2);
            conta2.setNome("FM");
            conta2.setSaldo(2000);
            Console.WriteLine(conta2.getNum()); //GET
            Console.WriteLine(conta2.getNome());
            Console.WriteLine(conta2.getSaldo());
        }
    }
}