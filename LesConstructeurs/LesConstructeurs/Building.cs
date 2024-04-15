using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesConstructeurs
{
    internal class Building
    {
      private int _nbetages;
      private double _tailleBatiment;
      private double _hauteurEtage=3;

        public Building(int nbetages, double taille):this(nbetages)
        {
                    
            _tailleBatiment = taille;
            _hauteurEtage = GetFloorMaxSize();
        }
        public Building(int nbetages)
        {
            _nbetages = nbetages;
            _tailleBatiment = Getsize();
        }

        public double GetFloorMaxSize()
        {
            return _tailleBatiment / _nbetages;
        }
        public int GetFloorCount()
        {
            return _nbetages;
        }
        public double Getsize()
        {
            return _hauteurEtage * _nbetages;
        }
    }
}
