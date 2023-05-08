using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public abstract class Ataclass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual void Mesajj()
        {
           MessageBox.Show( "LIs1 yazildi");
        }

    }
}
