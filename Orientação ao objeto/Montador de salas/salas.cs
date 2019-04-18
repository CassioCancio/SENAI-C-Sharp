namespace SENAIzinho_Manha {
    public class Sala {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public string AlocarAluno (string nomeAluno) {

            capacidadeAtual--;

            if (capacidadeAtual >= 0) {

                alunos[capacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} alocado com sucesso!";

            } else {

                capacidadeAtual = 0;
                return $"Capacidade da sala {numeroSala} excedida!";

            }
        }

        public string ExibirAlunos(){
            string nomeAlunos = "";
            foreach (var item in alunos)
            {
                if(item != null){
                    nomeAlunos += item + " ";
                }
            }
            return nomeAlunos;
        }
    }
}