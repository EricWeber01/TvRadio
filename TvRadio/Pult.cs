using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvRadio
{
    interface iPult
    {
        string Type { get; set; }
        int Chanels { get; set; }
        int Volume { get; set; }
        void ChangeVolume();
        void ChangeChanel();
    }
    class TVPult: iPult
    {
        public string Type { get; set; }
        public int Chanels { get; set; }
        public int Volume { get; set; }
        public TVPult()
        {
            Type = "TV Пульт";
            Chanels = 0;
            Volume = 0;
        }
        public void ChangeChanel()
        {
            Chanels++;
        }
        public void ChangeVolume()
        {
            Volume++;
        }
        public override string ToString()
        {
            return $"{Type}\nVolume: {Volume}\nChanel: {Chanels}";
        }
        ~TVPult()
        {
            Console.WriteLine("\nТелевизор был выключен\n");
        }
    }
    class RadioPult: iPult
    {
        public string Type { get; set; }
        public int Chanels { get; set; }
        public int Volume { get; set; }

        public RadioPult()
        {
            Type = "Radio Пульт";
            Chanels = 0;
            Volume = 0;
        }
        public void ChangeChanel()
        {
            Chanels++;
        }
        public void ChangeVolume()
        {
            Volume++;
        }
        public override string ToString()
        {
            return $"{Type}\nVolume: {Volume}\nChanel: {Chanels}";
        }
        ~RadioPult()
        {
            Console.WriteLine("\nРадио было выключено\n");
        }
    }
    class Pult
    {
        iPult pult;
        bool type;
        public Pult(bool _type)
        {
            type = _type;
            if (type)
                pult = new TVPult();
            else
                pult = new RadioPult();
        }
        public void ChangeChanel()
        {
            pult.ChangeChanel();
        }
        public void ChangeVolume()
        {
            pult.ChangeVolume();
        }
        public void ChangePult()
        {
            if (type)
            {
                type = false;
                pult = new RadioPult();
            }
            else
            {
                type = true;
                pult = new TVPult();
            }
        }
        public override string ToString()
        {
            return $"{pult}";
        }
    }
}