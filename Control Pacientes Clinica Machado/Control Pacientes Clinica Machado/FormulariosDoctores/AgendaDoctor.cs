using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;

namespace Control_Pacientes_Clinica_Machado.FormulariosDoctores
{
    public partial class AgendaDoctor : Form
    {
        DataTable dt = new DataTable();
        object[,] listeMois;
        int pos = 0;
        string[] liste_jours;
        int _jour;
        int _mois;
        int _annee;
        //maBaseDataContext data = new maBaseDataContext();

        public AgendaDoctor()
        {
            InitializeComponent();
            dateEvent.Format = DateTimePickerFormat.Custom;
            dateEvent.CustomFormat = "dd/MM/yyyy";
            _jour = DateTime.Today.Day;
            _mois = DateTime.Today.Month;
            _annee = DateTime.Today.Year;
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("dateEve", typeof(DateTime));
            dt.Columns.Add("event", typeof(string));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            liste_jours = new string[7] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            listeMois = new object[12, 2] { { 1, "Enero" }, { 2, "Febrero" }, { 3, "Marzo" }, { 4, "Abril" }, { 5, "Mayo" }, { 6, "Junio" }, { 7, "Julio" }, { 8, "Agosto" }, { 9, "Septiembre" }, { 10, "Octubre" }, { 11, "Noviembre" }, { 12, "Diciembre" } };

            lundi.Text = "Lunes";
            mardi.Text = "Martes";
            mercredi.Text = "Miercoles";
            jeudi.Text = "Jueves";
            vendredi.Text = "Viernes";
            samedi.Text = "Sabado";
            dimanche.Text = "Domingo";

            for (int i = 0; i < listeMois.Length / 2; i++)
                mois.Items.Add(listeMois[i, 1]);
            if (DateTime.Today.Month > 1)
                pos = DateTime.Today.Month - 1;
            else
                pos = 0;

            for (int i = 0; i < 12; i++)
            {
                if ((int)listeMois[i, 0] == DateTime.Today.Month)
                {
                    mois.SelectedText = (string)listeMois[i, 1];
                }
            }

            for (int i = 0; i < 5; i++)
                annee.Items.Add(DateTime.Today.Year + i - 2);



            annee.SelectedText = DateTime.Today.Year.ToString();

            Afficher(mois.Text, annee.Text);

            if (pos == 0)
            {
                label1.Visible = false;
                label2.Visible = false;
            }
            if (pos == 11)
            {
                label4.Visible = false;
                label5.Visible = false;
            }

            this.getDataFromDatabase();

            for (int i = 0; i < 12; i++)
            {
                if ((int)listeMois[i, 0] == DateTime.Today.Month)
                {
                    CalendrierlisteMois((int)listeMois[i, 0], int.Parse(annee.Text));
                }
            }
        }

        private void getDataFromDatabase()
        {
            //Recupération de données,
            //var taches = from m in data.ListeTache select m;
            //Remplissement du datatable 
            dt.Clear();
            //foreach (var item in taches)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["id"] = item.IdEve;
            //    dr["dateEve"] = item.DateEve;
            //    dr["event"] = item.Evenement;
            //    dt.Rows.Add(dr);
            //}
        }

        private void Afficher(int m, int a)
        {
            for (int i = 0; i < 12; i++)
            {
                if ((int)listeMois[i, 0] == m)
                {
                    maDate.Text = listeMois[i, 1].ToString() + " " + a.ToString();
                    CalendrierlisteMois(m, a);
                }
            }

        }

        private void Afficher(string m, string a)
        {
            maDate.Text = m + " " + a.ToString();
        }

        private void mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Afficher(mois.SelectedItem.ToString(), annee.Text);
            for (int i = 0; i < 12; i++)
            {
                if (listeMois[i, 1] == mois.SelectedItem)
                {
                    this.CalendrierlisteMois((int)listeMois[i, 0] , int.Parse(annee.Text));
                    pos = i;
                    _mois = (int)listeMois[i, 0];
                    if (pos == 0) firstMonth();
                    if (pos == 11) lastMonth();
                }
            }
            this.majdateTimePicker();
        }

        private void annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            _annee = int.Parse(annee.SelectedItem.ToString());
            this.CalendrierlisteMois(_mois, _annee);
            this.Afficher(mois.Text, annee.Text);
            this.majdateTimePicker();
        }

        private void dateEvent_ValueChanged(object sender, EventArgs e)
        {
            _jour = dateEvent.Value.Day;
            _mois = dateEvent.Value.Month;
            _annee = dateEvent.Value.Year;
            this.Afficher(listeMois[_mois-1, 1].ToString(), _annee.ToString());
            mois.Text = listeMois[_mois - 1, 1].ToString();
            annee.Text = _annee.ToString();
        }

        //Premier de l'année
        private void label1_Click(object sender, EventArgs e)
        {
            pos = 0;
            mois.Text = listeMois[pos, 1].ToString();
            firstMonth();
        }

        private void firstMonth() {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void betweenFistandLastMonth()
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void lastMonth()
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
        }
        //Précédente
        private void label2_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos > 0)
            {
                Afficher(listeMois[pos, 1].ToString(), annee.Text);
                mois.Text = listeMois[pos, 1].ToString();
                betweenFistandLastMonth();
            }
            else
            {
                pos = 0;
                Afficher(listeMois[pos, 1].ToString(), annee.Text);
                mois.Text = listeMois[pos, 1].ToString();
                firstMonth();
            }
        }
        //Suivant
        private void label4_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < 11)
            {
                Afficher(listeMois[pos, 1].ToString(), annee.Text);
                mois.Text = listeMois[pos, 1].ToString();
                betweenFistandLastMonth();
            }
            else
            {
                pos = 11;
                Afficher(listeMois[pos, 1].ToString(), annee.Text);
                mois.Text = listeMois[pos, 1].ToString();
                lastMonth();
            }
        }
        //Dernier de l'année
        private void label5_Click(object sender, EventArgs e)
        {
            pos = 11;
            mois.Text = listeMois[pos, 1].ToString();
            lastMonth();
        }
        

        private void CalendrierlisteMois(int m, int a)
        {
            int nbliste_jours = DateTime.DaysInMonth(a, m);
            DateTime date = DateTime.Parse(1 + "/" + m.ToString() + "/" + a.ToString());
            int index = 0;
            int nSemaine = 0;
            bool trouve = false;
            string [,] agenda = new string [6,8];

            while (index < nbliste_jours)
            {
                
                agenda[nSemaine, 0] = (nSemaine + 1).ToString();
                
                for (int i = 1; i < 8 ; i++)
                {
                    if (date.ToString("dddd", new CultureInfo("fr-Fr")).ToLower() == liste_jours[i - 1].ToLower() && trouve == false)
                    {
                        index++;
                        agenda[nSemaine, i] = index.ToString() + recupererEvenement(DateTime.Parse(index + "/" + m.ToString() + "/" + a.ToString()));
                        trouve = true;
                        continue;
                    }
                    else if(trouve == false)
                    {
                        agenda[nSemaine, i] = "";
                        continue;
                    }

                  
                    if(index < nbliste_jours)
                    {
                        index++;
                        agenda[nSemaine, i] = index.ToString() + recupererEvenement(DateTime.Parse(index + "/" + m.ToString() + "/" + a.ToString()));
                    }
                    else
                        agenda[nSemaine, i] = "";

                }
                nSemaine++;
            }

            chargerDataGrid(agenda, nSemaine);
        }

        private string recupererEvenement(DateTime date)
        {
            string str = "";
            bool first = true;
            this.getDataFromDatabase();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                if(String.Format("{0:d}", date) == String.Format("{0:d}",(DateTime)dt.Rows[i][1]))
                {
                    if(first){
                        first = false;
                        str += "        " + String.Format("{0:t}", (DateTime)dt.Rows[i][1]) + ((char)13) + dt.Rows[i][2] + "\r\n";
                    }else
                        str += ((char)13) + "-----------------------" + "\r\n" + "          " + String.Format("{0:t}", (DateTime)dt.Rows[i][1]) + "\r\n" + dt.Rows[i][2] + "\r\n";
                    
                }
            }
            return str;
        }

        private void chargerDataGrid(string [,] data, int nbLigne)
        {
            DataTable tab = new DataTable();
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn()); 
            tab.Columns.Add(new DataColumn());
            tab.Columns.Add(new DataColumn());


            maDataGrid.Rows.Clear();
            
            for (int i = 0; i < nbLigne; i++)
            {  
                maDataGrid.Rows.Add(data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6], data[i, 7]);
            }

            maDataGrid.Rows[0].Cells[0].Selected = false;

            for (int i = 0; i < maDataGrid.Rows.Count; i++)
            {
                for (int j = 1; j < maDataGrid.Columns.Count ; j++)
                {
                    string[] t = data[i, j].Split(' ');
                    DateTime date = new DateTime();

                    if (t[0] != "")
                    {
                        for (int m = 0; m < 12; m++)
                        {
                            
                            if (mois.Text.Equals(listeMois[m, 1]))
                            {
                                date = DateTime.Parse(t[0].Trim() + "/" + listeMois[m, 0] + "/" + annee.Text);
                                continue;
                            }
                        }

                    }

                    if (DateTime.Compare(date, new DateTime(_annee, _mois, _jour)) == 0)
                        maDataGrid.Rows[i].Cells[j].Selected = true;

                    if (!data[i, j].Equals(""))
                        maDataGrid.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;

                    if (data[i, j].Length > 2)
                        maDataGrid.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                    
                }
            }
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            if (txtEvent.Text != "" & txtEvent.Text != "Event : ")
            {

                try
                {
                    //ListeTache tache = new ListeTache();
                    string[] time = timeEvent.Text.Split(':');
                    int hour = 0;
                    int minute = 0;
                    if (time[0] != "  " && time[1] != "  ")
                    {
                        hour = int.Parse(time[0]);
                        minute = int.Parse(time[1]);
                    }
                    DateTime date = new DateTime(dateEvent.Value.Year, dateEvent.Value.Month, dateEvent.Value.Day, hour, minute, 0);
                    //tache.IdEve = 9;
                    //tache.DateEve = date;
                    //tache.Evenement = txtEvent.Text;

                    //// Ajouter la nouvelle tache dans la table listeTache.
                    //data.ListeTache.InsertOnSubmit(tache);
                    //data.SubmitChanges();
                    //this.CalendrierlisteMois(_mois, _annee);
                    //txtEvent.Text = "Event : ";
                    //timeEvent.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void majdateTimePicker() {
            dateEvent.Value = new DateTime(_annee, _mois, _jour);
        }

        private void maDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] value = maDataGrid.CurrentCell.Value.ToString().Split();
            _jour = int.Parse(value[0]);
            displayEvent.Text = "Event(s) : \r\n" + this.recupererEvenement(new DateTime(_annee, _mois, _jour));
            this.majdateTimePicker();
            this.CalendrierlisteMois(_mois, _annee);
        }

    }
}