using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class BasePerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public BasePerson(string name, string lastname, string position)
        {
            Name = name;
            LastName = lastname;
            Position = position;
        }

        public abstract void Gorev();
    }
public class ProjeYoneticisi : BasePerson
{
    public ProjeYoneticisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman)
    {
    }

    public override void Gorev()
    {
        Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
    }
}
public class YazılımGeliştirici : BasePerson
{
    public YazılımGeliştirici(string ad, string soyad, string departman)
        : base(ad, soyad, departman)
    {
    }
    public override void Gorev()
    {
        Console.WriteLine("Yazılım geliştiricisi olarak çalışıyorum.");
    }
}
public class VeriAnalisti : BasePerson
{
    public VeriAnalisti(string ad, string soyad, string departman)
        : base(ad, soyad, departman)
    {
    }
    public override void Gorev()
    {
        Console.WriteLine("Veri analisti olarak çalışıyorum.");
    }
}


