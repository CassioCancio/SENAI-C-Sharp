using System;

namespace tsukair
{
    class Passageiro
    {
        string nome;
        int numeroPassagem;
        DateTime data;
        public void setNome(string nome){
            this.nome = nome;
        }
        public string getNome(){
            return this.nome;
        }
        public void setNumero(int numeroPassagem){
            this.numeroPassagem = numeroPassagem;
        }
        public int getNumero(){
            return this.numeroPassagem;
        }
        public void setData(DateTime data){
            this.data = data;
        }
        public DateTime getData(){
            return this.data;
        }
    }
}

