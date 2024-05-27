using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            //  firstCustomControl2.BringToFront();


        }
        internal List<Prodotti> ele_Prodotti = new List<Prodotti>();
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel_product.Visible = false;
            Panel_Carrello.Visible = false;
            panel_salati.Visible = false;
            panel_mappa.Visible = false;
            SidePanel.Height = btn_home.Height;
            SidePanel.Top = btn_home.Top;
            panel_home.Visible = true;

        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            
            Panel_Carrello.Visible = false;
            panel_salati.Visible = false;
            panel_home.Visible = false;
            panel_mappa.Visible = false;
            SidePanel.Height = btn_products.Height;
            SidePanel.Top = btn_products.Top;
            panel_product.Visible = true;
        }
        private void btn_salati_Click(object sender, EventArgs e)
        {
            panel_product.Visible = false;
            panel_home.Visible = false;
            panel_mappa.Visible = false;
            Panel_Carrello.Visible = false;
            SidePanel.Height = btn_salati.Height;
            SidePanel.Top = btn_salati.Top;
            panel_salati.Visible = true;
        }

        private void btn_carrello_Click(object sender, EventArgs e)
        {
            panel_product.Visible = false;
            panel_salati.Visible = false;
            panel_home.Visible = false;
            panel_mappa.Visible = false;

            Panel_Carrello.Visible = true;
            SidePanel.Height = btn_carrello.Height;
            SidePanel.Top = btn_carrello.Top;
            var ele = ele_Prodotti.Select(p =>
            {
                var isB = p is ProdottiB;
                if (isB)
                {
                    var prodB = (ProdottiB)p;
                    return new
                    {
                        p.nome,
                        p.prezzo,
                        p.quantità,
                        p.gusto,
                        persone = prodB.persone // Aggiungi le informazioni specifiche di ProdottiB
                    };
                }
                else
                {
                    return new
                    {
                        p.nome,
                        p.prezzo,
                        p.quantità,
                        p.gusto,
                        persone = 0 // Mostra un trattino al posto di 0 per Prodotti normali
                    };
                }
            });

            DGV_carrello.DataSource = ele.ToList();
        }
        private void btn_5_mappa_Click(object sender, EventArgs e)
        {
            panel_product.Visible = false;
            Panel_Carrello.Visible = false;
            panel_salati.Visible = false;
            panel_home.Visible = false;


            SidePanel.Height = btn_5_mappa.Height;
            SidePanel.Top = btn_5_mappa.Top;
            panel_mappa.Visible = true;
            //mappa_ThirdControl1.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //  SidePanel.Height = btn_products.Height;
            //  SidePanel.Top = btn_products.Top;
            //  mappa_ThirdControl1.BringToFront();
            panel_product.Visible = false;
            Panel_Carrello.Visible = false;
            panel_salati.Visible = false;
            panel_mappa.Visible = false;
            panel_home.Visible = true;

        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
            
        }
        private void btn_instagram_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pasticceriadacristian_/");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100049553242142");

        }

        private void btn_tiktok_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tiktok.com/@pasticceriadacristian?lang=it");

        }

        private void btn_panettone_Click(object sender, EventArgs e)
        {
            if(RB_classico.Checked == true)
            {
                id = id+1;
               Prodotti A = new Prodotti(id , "Panettone", 35, 1, "Classico");
                ele_Prodotti.Add(A);
            }
            if (RB_noci.Checked == true)
            {
                id = id + 1;
                Prodotti A = new Prodotti(id, "Panettone", 35, 1, "Noci e Cioccolato");
                ele_Prodotti.Add(A);
            }
            if (RB_veneziana.Checked == true)
            {
                id = id + 1;
                Prodotti A = new Prodotti(id, "Panettone", 35, 1, "Veneziana");
                ele_Prodotti.Add(A);
            }
            RB_veneziana.Checked = false;
            RB_noci.Checked = false;
            RB_classico.Checked = false;

        }

        private void btn_Torta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_torta_desc.Text) ||
                string.IsNullOrEmpty(tb_torta_perso.Text))
            { 
                MessageBox.Show("Inserire tutti i dati richiesto");
                return;
            }

            else
            {
                int quantità = int.Parse(tb_torta_perso.Text) * 200/1000;
                double quantità2 = Convert.ToDouble(tb_torta_perso.Text) * 2;
                id = id + 1;
                double prezzo = quantità2 * 3.5;

                ProdottiB A = new ProdottiB(id, "Torta", prezzo, quantità, tb_torta_desc.Text, int.Parse(tb_torta_perso.Text));
                ele_Prodotti.Add(A);
                tb_torta_desc.Clear();
                tb_torta_perso.Clear();
            }
        }

        private void btn_Brioches_Click(object sender, EventArgs e)
        {
            if (RB_crema.Checked == true)
            {
                if (string.IsNullOrEmpty(tb_quantità_crema.Text))
                {
                    MessageBox.Show("Inserire la quantità");
                    return;
                }
                double prezzo = Convert.ToDouble(tb_quantità_crema.Text) * 1.5;
                id = id + 1;
                Prodotti A = new Prodotti(id, "Brioches", prezzo, int.Parse(tb_quantità_crema.Text), "Crema");
                ele_Prodotti.Add(A);
                RB_crema.Checked = false;
                tb_quantità_crema.Clear();
            }
            if (RB_ciocco.Checked == true)
            {
                if(string.IsNullOrEmpty(tb_quantità_ciocco.Text))
                {
                    MessageBox.Show("Inserire la quantità");
                    return;
                }
                double prezzo = Convert.ToDouble(tb_quantità_ciocco.Text) * 1.50;
                id = id + 1;
                Prodotti A = new Prodotti(id, "Brioches", prezzo, int.Parse(tb_quantità_ciocco.Text), "Cioccolato");
                ele_Prodotti.Add(A);
                RB_ciocco.Checked = false;
                tb_quantità_ciocco.Clear();
            }
            if (RB_pistacchio.Checked == true)
            {
                if (string.IsNullOrEmpty(tb_quantità_pistacchio.Text))
                {
                    MessageBox.Show("Inserire la quantità");
                    return;
                }
                double prezzo = Convert.ToDouble(tb_quantità_pistacchio.Text) * 1.50;
                id = id + 1;
                Prodotti A = new Prodotti(id, "Brioches", prezzo, int.Parse(tb_quantità_pistacchio.Text), "Crema");
                ele_Prodotti.Add(A);
                tb_quantità_pistacchio.Clear();
                RB_pistacchio.Checked = false;
            }
        }

        private void btn_Pasticcini_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pastici_gusti.Text) ||
                          string.IsNullOrEmpty(tb_past_persone.Text))
            {
                MessageBox.Show("Inserire tutti i dati richiesto");
                return;
            }
            int persone = int.Parse(tb_past_persone.Text); //30 pasticcini 1kg 10 persone
            int quantità = persone * 3;
            id = id + 1;
            double prezzo = quantità * 1.167;
            ProdottiB A = new ProdottiB(id,"Pasticcini", prezzo, quantità, tb_pastici_gusti.Text, int.Parse(tb_past_persone.Text));
//            ProdottiB A = new ProdottiB(id, "Torta", prezzo, quantità, tb_torta_desc.Text, int.Parse(tb_torta_perso.Text));
            ele_Prodotti.Add(A);
            tb_pastici_gusti.Clear();
            tb_past_persone.Clear();


        }
    
        private void AddLocationByName(string locationName)
        {
            var geocodingProvider = GMapProviders.OpenStreetMap;
            var geo = geocodingProvider.GetPoint(locationName, out GeoCoderStatusCode statusCode);
            if (statusCode == GeoCoderStatusCode.OK && geo != null)
            {

                var marker = new GMarkerGoogle(geo.Value, GMarkerGoogleType.blue_dot);
                var markersOverlay = new GMapOverlay("markers");

                markersOverlay.Markers.Add(marker);
                Mappa.Overlays.Add(markersOverlay);


                Mappa.Position = geo.Value;
            }
            else
            {
                MessageBox.Show("Non è stato possibile trovare il luogo specificato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_pizza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pizza_gusti.Text) || string.IsNullOrEmpty(tb_pizza_teglie.Text))
            {
                MessageBox.Show("Inserire tutti i campi");
            }
            else
            {
                int prezzo = int.Parse(tb_pizza_teglie.Text) * 35;

                id++;
                Prodotti p = new Prodotti(id, "Pizza", prezzo, int.Parse(tb_pizza_teglie.Text), tb_pizza_gusti.Text);
                ele_Prodotti.Add(p);
                tb_pizza_gusti.Clear();
                tb_pizza_teglie.Clear();

            }
        }

        private void btn_pizzetta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_salatini_gusti.Text) || string.IsNullOrEmpty(tb_salatini_persone.Text))
            {
                MessageBox.Show("Inserire tutti i campi");
            }
            else
            {
                int persone = int.Parse(tb_salatini_persone.Text);
                double prezzo = persone * 35 / 10;
                int quantità = int.Parse(tb_salatini_persone.Text) * 5; // 50 pizzette 1KG 10 persone
                id++;
                ProdottiB p = new ProdottiB(id, "Pizzetta", prezzo, quantità, tb_salatini_gusti.Text, int.Parse(tb_salatini_persone.Text));
                ele_Prodotti.Add(p);
                tb_salatini_gusti.Clear();
                tb_salatini_persone.Clear();

            }
        }

        private void btn_sormontè_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_sormontè_gusti.Text) || string.IsNullOrEmpty(tb_sormontè_quantità.Text))
            {
                MessageBox.Show("Inserire tutti i campi");
            }
            else
            {
                id++;
                double prezzo = Convert.ToDouble(tb_sormontè_quantità.Text) * 55;
                Prodotti p = new Prodotti(id, "Sormontè", prezzo, int.Parse(tb_sormontè_quantità.Text), tb_sormontè_gusti.Text);
                ele_Prodotti.Add(p);
                tb_sormontè_gusti.Clear();
                tb_sormontè_quantità.Clear();
            }
        }

        private void btn_sestanghen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_sestanghen_quantità.Text) || string.IsNullOrEmpty(tb_sestanghen_gusti.Text))
            {
                MessageBox.Show("Inserire tutti i campi");
            }
            else
            {
                id++;
                double prezzo = Convert.ToDouble(tb_sestanghen_quantità.Text) * 2.80;
                Prodotti p = new Prodotti(id, "Sestanghen", prezzo, int.Parse(tb_sestanghen_quantità.Text), tb_sestanghen_gusti.Text);
                ele_Prodotti.Add(p);
                tb_sestanghen_quantità.Clear();
                tb_sestanghen_gusti.Clear();
            }
        }

        private void Mappa_Load_1(object sender, EventArgs e)
        {
            Mappa.MapProvider = GMapProviders.OpenStreetMap;
            Mappa.MinZoom = 5;
            Mappa.MaxZoom = 100;
            Mappa.Zoom = 19;
            Mappa.ShowCenter = false;
            AddLocationByName("1034, Bergamo");
        }


    }
}
