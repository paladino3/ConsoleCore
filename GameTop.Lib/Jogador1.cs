

using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} está Chutando ";
        }
            //corre
        public string Corre()
        {
            return $"{_Nome} está Correndo ";
        }
        //passe
        public string Passe()
        {
            return $"{_Nome} está Passando ";
        }
    }
} 