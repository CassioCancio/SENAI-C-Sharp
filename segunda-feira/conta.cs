namespace segunda_feira
{
    public class conta
    {
        public string titular;

        public int agencia;

        public int numeroConta;

        public double saldo {get; set;}
    
        public void Depositar(double valor){
            saldo += valor;
        }
        public bool Sacar(double valor){
            
            if(saldo < valor){
                return false;
            }else{
                saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor,){

        }
    }
}