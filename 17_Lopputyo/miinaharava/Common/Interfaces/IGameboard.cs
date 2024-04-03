using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IGameboard
    {
        public int Width { get; set; }
        public void SetSize(int width, int height);
    }

}
