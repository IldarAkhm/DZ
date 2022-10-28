using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class House
    {
        public int Root { private set; get; }
        public void Rt(int root) => Root = root;

        public int Height { private set; get; }
        public void Hg(int heicght) => Height = heicght;

        public int Flor { private set; get; }
        public void Fl(int flor) => Flor = flor;

        public int Flat { private set; get; }
        public void Ft(int flat) => Flat = flat;

        public int Entrance { private set; get; }
        public void En(int entrance) => Entrance = entrance;
    }
}
