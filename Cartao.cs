using System;

namespace Aula23Listas
{
    public class Cartao
    {
        
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public string Vencimento { get; set; }
        public int Cvv { get; set; }

        public Cartao(){

        }

        public Cartao(string _titular, int _numero, string _bandeira, string _vencimento, int _cvv){

            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.Cvv = _cvv;

        }

    }
}