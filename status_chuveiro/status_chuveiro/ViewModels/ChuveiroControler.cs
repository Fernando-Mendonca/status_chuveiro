using System;
using System.Collections.Generic;
using System.Text;

namespace status_chuveiro.ViewModels
{
    class ChuveiroControler
    {
        //Criação de ATRIBUTOS da classe
        private int _IDStatus;
        private bool _Status;
        private TimeSpan _Time;

        //CONSTRUTOR da classe
        public ChuveiroControler(int iDStatus, bool status, TimeSpan time)
        {
            IDStatus = iDStatus;
            Status = status;
            Time = time;
        }

        //METODOS getters (pegar os valores das variaveis) e setters (setar os valores das variaveis)
        public int IDStatus { get => _IDStatus; set => _IDStatus = value; }
        public bool Status { get => _Status; set => _Status = value; }
        public TimeSpan Time { get => _Time; set => _Time = value; }

        public void IniciarBanho()
        {
            _Status = true;
        }
    }

}
