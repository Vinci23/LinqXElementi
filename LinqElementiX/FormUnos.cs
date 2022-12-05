using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;

namespace LinqElementiX
{
    public partial class FormUnos : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        string dokument = "osobe.xml";
        public FormUnos()
        {
            InitializeComponent();
        }

        private void btnUnosPodataka_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtGodRod.Text));

            osobe.Add(osoba);

            DialogResult upit = MessageBox.Show("Želite li upisati još osoba?","Upit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if( upit == DialogResult.Yes)
            {
                txtGodRod.Clear();
                txtIme.Clear(); 
                txtPrezime.Clear();
            }

            else
            {

                if (File.Exists(dokument))
                {
                    var OsobeXML = XDocument.Load(dokument);
                   

                foreach(Osoba o in osobe)
                    {
                        var Osoba = new XElement("Osoba",                 
                        new XElement("Ime", osoba.Ime),
                        new XElement("Prezime", osoba.Prezime),
                        new XElement("GodinaRođenja", osoba.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(dokument);
                }

                else
                {
                    var OsobeXML = new XDocument();
                    OsobeXML.Add(new XElement("Osobe"));
                    foreach (Osoba o in osobe)
                    {
                        var Osoba = new XElement("Osoba",
                        new XElement("Ime", osoba.Ime),
                        new XElement("Prezime", osoba.Prezime),
                        new XElement("GodinaRođenja", osoba.GodRod));
                        OsobeXML.Root.Add(Osoba);
                    }
                    OsobeXML.Save(dokument);

                }

                
                
                /*
                if (File.Exists(dokument))
                {
                    /*DialogResult overwrite = MessageBox.Show("Dokument već postoji " + "\r\n Želite li prepisati stari dokument?", "Dokument postoji", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    
                    if (overwrite == DialogResult.Yes)
                    {

                    OsobeXML.Save(dokument);

                    }

                    else
                    {
                        SaveFileDialog noviDokument = new SaveFileDialog();
                        noviDokument.Title = "Spremi novi dokument";
                        noviDokument.InitialDirectory = @"C:\";
                        noviDokument.DefaultExt = "xml";
                        noviDokument.ShowDialog();

                        dokument = noviDokument.FileName;
                        OsobeXML.Save(dokument);


                    }
                    
                }
            */
            
                
                
                this.Close();
            }
        }
    }
}
