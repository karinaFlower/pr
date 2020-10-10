using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika301
{
    class Class1
    {
        double vozrast;
        double login;
        string Fio;
        double parol;
        string Avatar;
        public Class1(double vozrast, double login, string fio, double parol, string avatar)
        {
            this.vozrast = vozrast;
            this.login = login;
            Fio = fio;
            Avatar = avatar;
            this.parol = parol;
        }
        public double ReturnVozrast()
        {
            return vozrast;
        }
        public string ReturnFio()
        {
            return Fio;
        }
        public void SetFio(string fio)
        {
            Fio =fio;
        }
        public string ReturnAvatar()
        {
            return Avatar;
        }
        public void SetFAvatar(string avatar)
        {
            Avatar = avatar;
        }
        public double Returnlogin()
        {
            return login;
        }
        public double  ReturnParol()
        {
            return parol;
        }
    }
}
