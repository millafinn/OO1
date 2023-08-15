using System.Runtime.CompilerServices;

namespace OO1
{
    internal class Conta {
        private int num;
        private string nome;
        private double saldo;


        public void setNum(int num) {
            this.num = num;
        }

        public int getNum() {
            return num;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getNome() {
            return nome;
        }

        public void setSaldo(double saldo)  {
            this.saldo = saldo;
        }

        public double getSaldo()  {
            return saldo;
        }

    }
}
