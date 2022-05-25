using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pawboi
{
    public partial class Form1 : Form
    {
        List<Imobil> listaImobil = new List<Imobil>();
        ErrorProvider errorProvider1;

        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DBAgentie.accdb";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1 = new ErrorProvider();
        }
        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text == "")
                errorProvider1.SetError(textBoxCod, "Introduceti codul!");
            else if (textBoxNume.Text == "")
                errorProvider1.SetError(textBoxNume, "Introduceti numele!");
            else if (textBoxPret.Text == "")
                errorProvider1.SetError(textBoxPret, "Introduceti pretul!");
            else if (textBoxNrCamere.Text == "")
                errorProvider1.SetError(textBoxNrCamere, "Introduceti Numarul de camere!");
            else if (textBoxMarime.Text == "")
                errorProvider1.SetError(textBoxMarime, "Introduceti marimea!");
            else if (textBoxLocatie.Text == "")
                errorProvider1.SetError(textBoxLocatie, "Introduceti locatia!");
            else
            {
                errorProvider1.Clear();

                OleDbConnection conexiune = new OleDbConnection(connectionString);
                OleDbCommand comanda = new OleDbCommand();
                try
                {
                    conexiune.Open();
                    comanda.Connection = conexiune;

                    int cod = Convert.ToInt32(textBoxCod.Text);
                    string nume = Convert.ToString(textBoxNume.Text);
                    float pret = float.Parse(textBoxPret.Text);
                    int nrCamere = Convert.ToInt32(textBoxNrCamere.Text);
                    int marime = Convert.ToInt32(textBoxMarime.Text);
                    string locatie = Convert.ToString(textBoxLocatie.Text);

                    comanda.CommandText = "INSERT INTO imobile VALUES (?,?,?,?,?,?)";
                    comanda.Parameters.Add("codImobil", OleDbType.Numeric).Value = cod;
                    comanda.Parameters.Add("numeImobil", OleDbType.VarChar).Value = nume;
                    comanda.Parameters.Add("pretImobil", OleDbType.Numeric).Value = pret;
                    comanda.Parameters.Add("nrCamereImobil", OleDbType.Numeric).Value = nrCamere;
                    comanda.Parameters.Add("marimeImobil", OleDbType.Numeric).Value = marime;
                    comanda.Parameters.Add("locatieImobil", OleDbType.VarChar).Value = locatie;

                    comanda.ExecuteNonQuery();
                    
                    Imobil i = new Imobil(cod, nume, pret, nrCamere, marime, locatie);
                    listaImobil.Add(i);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBoxCod.Clear();
                    textBoxNume.Clear();
                    textBoxPret.Clear();
                    textBoxNrCamere.Clear();
                    textBoxMarime.Clear();
                    textBoxLocatie.Clear();

                    conexiune.Close();
                }
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connectionString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM imobile";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["numeImobil"].ToString());
                    itm.SubItems.Add(reader["numeImobil"].ToString());
                    itm.SubItems.Add(reader["pretImobil"].ToString());
                    itm.SubItems.Add(reader["nrCamereImobil"].ToString());
                    itm.SubItems.Add(reader["marimeImobil"].ToString());
                    itm.SubItems.Add(reader["locatieImobil"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
