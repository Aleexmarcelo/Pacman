using System;

namespace Ghosts
{
    public class Ghosts
    {
        public string cor;
        public string velocidade;
        public string dano;

    }
    public static void Ghost1(String[] args) //Eu não lembro o que colocar nessa linha para não ter erros, ou se é outro código
    {
        Ghosts Ghost1 = new Ghosts();
        Ghost1.cor = "Azul";
        Ghost1.velocidade = "3.5";
        Ghost1.dano = "2";

        Ghosts Ghost2 = new Ghosts();
        Ghost2.cor = "Vermelho";
        Ghost2.velocidade = "4";
        Ghost2.dano = "3";
    }



}
}