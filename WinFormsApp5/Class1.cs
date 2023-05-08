using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp5.Abstract;

namespace WinFormsApp5
{
    public class Class1 : Ataclass, Interface1
    {
        public void Mesaj()
        {
            MessageBox.Show("Listbox 1 Ad elave edildi");
        }

        public override void Mesajj()
        {
            MessageBox.Show("Listbox 1 Ad elave edildi");
        }
    }
}
