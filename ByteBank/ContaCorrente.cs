using System;

namespace ByteBank
{
    public class ContaCorrente {
        public string Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo {get;set;}
        
        public ContaCorrente (int Agencia, int Numero, string Cliente) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0 ;
            
        }

        public double deposito(double valor){
            return this.Saldo += valor;
        }
        public bool saque(double valor){
            if(this.Saldo >= valor){
                this.Saldo -= valor;
                return true;
            } else {
                return false;
            }
        } 
        public bool Transferencia(ContaCorrente contaDestino, double valor){
            if(this.saque(valor)){
                contaDestino.deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}
