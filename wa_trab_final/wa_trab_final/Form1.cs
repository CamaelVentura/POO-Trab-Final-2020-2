using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wa_trab_final
{
    public partial class Form1 : Form
    {
        private string stringConn = String.Format("Server={0};Port={1};User Id={2}; Password={3};Database={4};",
                                                    "localhost", 5433, "POO", "trabalhodepoo", "Trabalho_Final");

        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand command;

        private int rowIndexClient = -1;
        private int rowIndexPackage = -1;
        private int rowIndexPurchased = -1;

        private DataTable dataClient;
        private DataTable dataPackage;
        private DataTable dataPurchased;

        private List<Client> clients = new List<Client>();
        private List<Package> packages = new List<Package>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(stringConn);
            Select_Client();
            Select_Package();
            Select_Purchased_Package();
        }

        private  void Select_Client()
        {
            try
            {
                conn.Open();

                NpgsqlDataAdapter dataSelectClient;
                sql = @"SELECT * FROM select_client()";
                command = new NpgsqlCommand(sql, conn);
                dataClient = new DataTable();
                dataSelectClient = new NpgsqlDataAdapter(command);
                conn.Close();
                dataSelectClient.Fill(dataClient);
                dgv_clients.DataSource = null;
                dgv_clients.DataSource = dataClient;
                
                clients.Clear();
                cbox_client.Items.Clear();
                foreach(DataRow dtRow in dataClient.Rows)
                {
                    Client client = new Client(int.Parse(dtRow["cliente"].ToString()), dtRow["nome"].ToString(), dtRow["email"].ToString(), dtRow["cpf"].ToString());
                    clients.Add(client);
                    cbox_client.Items.Add(client.getName());
                }
            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            }
        }
        private void Select_Package()
        {
            try
            {
                conn.Open();

                NpgsqlDataAdapter dataSelectPackage;
                sql = @"SELECT * FROM select_package()";
                command = new NpgsqlCommand(sql, conn);
                dataPackage = new DataTable();
                dataSelectPackage = new NpgsqlDataAdapter(command);
                conn.Close();
                dataSelectPackage.Fill(dataPackage);
                dgv_packages.DataSource = null;
                dgv_packages.DataSource = dataPackage;

                packages.Clear();
                cbox_package.Items.Clear();
                foreach (DataRow dtRow in dataPackage.Rows)
                {
                    Package package = new Package(int.Parse(dtRow["pacote"].ToString()), dtRow["nome"].ToString(), int.Parse(dtRow["dias"].ToString()), double.Parse(dtRow["preco_adulto"].ToString()), double.Parse(dtRow["preco_infantil"].ToString()));
                    packages.Add(package);
                    cbox_package.Items.Add(package.getName());
                }
            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            }
        }
        private void Select_Purchased_Package()
        {
            try
            {
                conn.Open();

                NpgsqlDataAdapter dataSelectPurchased;
                sql = @"SELECT * FROM select_purchased_package()";
                command = new NpgsqlCommand(sql, conn);
                dataPurchased = new DataTable();
                dataSelectPurchased = new NpgsqlDataAdapter(command);
                conn.Close();
                dataSelectPurchased.Fill(dataPurchased);
                dgv_purchased_packages.DataSource = null;
                dgv_purchased_packages.DataSource = dataPurchased;

            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            }
        }

        private void btn_insert_client_Click(object sender, EventArgs e)
        {
            rowIndexClient = -1;
            txt_name_client.Text = txt_mail_client.Text = txt_doc_client.Text = null;
            txt_name_client.Enabled = txt_mail_client.Enabled = txt_doc_client.Enabled = true;
            btn_insert_client.Enabled = btn_update_client.Enabled = btn_delete_client.Enabled = false;
            btn_save_client.Enabled = true;
            txt_name_client.Select();
        }

        private void btn_update_client_Click(object sender, EventArgs e)
        {
            if(rowIndexClient < 0)
            {
                MessageBox.Show("Você precisa escolher o cliente que deseja alterar.");
                return;
            }
            txt_name_client.Enabled = txt_mail_client.Enabled = txt_doc_client.Enabled = true;
            btn_insert_client.Enabled = btn_update_client.Enabled = btn_delete_client.Enabled = false;
            btn_save_client.Enabled = true;
            txt_name_client.Select();
        }

        private void btn_delete_client_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if (rowIndexClient < 0)
            {
                MessageBox.Show("Você precisa escolher o cliente que deseja apagar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from delete_client(:_id)";
                command = new NpgsqlCommand(sql, conn);
                command.Parameters.AddWithValue("_id", int.Parse(dgv_clients.Rows[rowIndexClient].Cells["cliente"].Value.ToString()));
                retorno = (int)command.ExecuteScalar();
                conn.Close();
                if(retorno == 1)
                {
                    MessageBox.Show("Cliente deletado com sucesso!");
                    txt_name_client.Text = txt_mail_client.Text = txt_doc_client.Text = null;
                    Select_Client();
                    Select_Purchased_Package();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o cliente.");
                }
            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            } 
        }

        private void btn_save_client_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if(rowIndexClient < 0)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from insert_client(:_name, :_mail, :_doc)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_name", txt_name_client.Text);
                    command.Parameters.AddWithValue("_mail", txt_mail_client.Text);
                    command.Parameters.AddWithValue("_doc", txt_doc_client.Text);
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Cliente inserido com sucesso!");
                        Select_Client();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar cliente.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = @"select * from update_client(:_id, :_name, :_mail, :_doc)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_id", int.Parse(dgv_clients.Rows[rowIndexClient].Cells["cliente"].Value.ToString()));
                    command.Parameters.AddWithValue("_name", txt_name_client.Text);
                    command.Parameters.AddWithValue("_mail", txt_mail_client.Text);
                    command.Parameters.AddWithValue("_doc", txt_doc_client.Text);
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Cliente atualizado com sucesso!");
                        Select_Client();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar dados do cliente.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }
            rowIndexClient = -1;
            txt_name_client.Text = txt_mail_client.Text = txt_doc_client.Text = null;
            txt_name_client.Enabled = txt_mail_client.Enabled = txt_doc_client.Enabled = false;
            btn_insert_client.Enabled = btn_update_client.Enabled = btn_delete_client.Enabled = true;
            btn_save_client.Enabled = false;
        }
            
        private void dgv_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                rowIndexClient = e.RowIndex;
                txt_name_client.Text = dgv_clients.Rows[rowIndexClient].Cells["nome"].Value.ToString();
                txt_mail_client.Text = dgv_clients.Rows[rowIndexClient].Cells["email"].Value.ToString();
                txt_doc_client.Text = dgv_clients.Rows[rowIndexClient].Cells["cpf"].Value.ToString();
            }
        }

        private void btn_insert_package_Click(object sender, EventArgs e)
        {
            rowIndexPackage = -1;
            txt_name_package.Text = txt_duration_package.Text = txt_adult_price.Text = txt_kids_price.Text = null;
            txt_name_package.Enabled = txt_duration_package.Enabled = txt_adult_price.Enabled = txt_kids_price.Enabled = true;
            btn_insert_package.Enabled = btn_update_package.Enabled = btn_delete_package.Enabled = false;
            btn_save_package.Enabled = true;
            txt_name_package.Select();
        }

        private void btn_update_package_Click(object sender, EventArgs e)
        {
            if (rowIndexPackage < 0)
            {
                MessageBox.Show("Você precisa escolher o pacote que deseja alterar.");
                return;
            }
            txt_name_package.Enabled = txt_duration_package.Enabled = txt_adult_price.Enabled = txt_kids_price.Enabled = true;
            btn_insert_package.Enabled = btn_update_package.Enabled = btn_delete_package.Enabled = false;
            btn_save_package.Enabled = true;
            txt_name_package.Select();
        }

        private void btn_delete_package_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if (rowIndexClient < 0)
            {
                MessageBox.Show("Você precisa escolher o pacote que deseja apagar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from delete_package(:_id)";
                command = new NpgsqlCommand(sql, conn);
                command.Parameters.AddWithValue("_id", int.Parse(dgv_packages.Rows[rowIndexPackage].Cells["pacote"].Value.ToString()));
                retorno = (int)command.ExecuteScalar();
                conn.Close();
                if (retorno == 1)
                {
                    MessageBox.Show("Pacote deletado com sucesso!");
                    txt_name_package.Text = txt_duration_package.Text = txt_adult_price.Text = txt_kids_price.Text = null;
                    Select_Package();
                    Select_Purchased_Package();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o pacote.");
                }
            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            }
        }

        private void btn_save_package_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if (rowIndexPackage < 0)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from insert_package(:_name, :_duration, :_adult_price, :_kids_price)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_name", txt_name_package.Text);
                    command.Parameters.AddWithValue("_duration", int.Parse(txt_duration_package.Text));
                    command.Parameters.AddWithValue("_adult_price", double.Parse(txt_adult_price.Text));
                    command.Parameters.AddWithValue("_kids_price", double.Parse(txt_kids_price.Text));
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Pacote adicionado com sucesso!");
                        Select_Package();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar pacote.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = @"select * from update_package(:_id, :_name, :_duration, :_adult_price, :_kids_price)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_id", int.Parse(dgv_packages.Rows[rowIndexPackage].Cells["pacote"].Value.ToString()));
                    command.Parameters.AddWithValue("_name", txt_name_package.Text);
                    command.Parameters.AddWithValue("_duration", int.Parse(txt_duration_package.Text));
                    command.Parameters.AddWithValue("_adult_price", double.Parse(txt_adult_price.Text));
                    command.Parameters.AddWithValue("_kids_price", double.Parse(txt_kids_price.Text));
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Pacote atualizado com sucesso!");
                        Select_Package();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar dados do pacote.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }

            rowIndexPackage = -1;
            txt_name_package.Text = txt_duration_package.Text = txt_adult_price.Text = txt_kids_price.Text = null;
            txt_name_package.Enabled = txt_duration_package.Enabled = txt_adult_price.Enabled = txt_kids_price.Enabled = false;
            btn_insert_package.Enabled = btn_update_package.Enabled = btn_delete_package.Enabled = true;
            btn_save_package.Enabled = false;
        }

        private void dgv_packages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexPackage = e.RowIndex;
                txt_name_package.Text = dgv_packages.Rows[rowIndexPackage].Cells["nome"].Value.ToString();
                txt_duration_package.Text = dgv_packages.Rows[rowIndexPackage].Cells["dias"].Value.ToString();
                txt_adult_price.Text = dgv_packages.Rows[rowIndexPackage].Cells["preco_adulto"].Value.ToString();
                txt_kids_price.Text = dgv_packages.Rows[rowIndexPackage].Cells["preco_infantil"].Value.ToString();
            }
        }

        private void btn_insert_purchased_Click(object sender, EventArgs e)
        {
            rowIndexPurchased = -1;
            cbox_client.SelectedIndex = cbox_package.SelectedIndex = -1;
            txt_qtd_adults.Text = txt_qtd_kids.Text = null;
            cbox_client.Enabled = cbox_package.Enabled = txt_qtd_adults.Enabled = txt_qtd_kids.Enabled = true;
            btn_insert_purchased.Enabled = btn_update_purchased.Enabled = btn_delete_purchased.Enabled = false;
            btn_save_purchased.Enabled = true;
            cbox_client.Select();
        }

        private void btn_update_purchased_Click(object sender, EventArgs e)
        {
            if (rowIndexPurchased < 0)
            {
                MessageBox.Show("Você precisa escolher a venda que deseja alterar.");
                return;
            }
            cbox_client.Enabled = cbox_package.Enabled = txt_qtd_adults.Enabled = txt_qtd_kids.Enabled = true;
            btn_insert_purchased.Enabled = btn_update_purchased.Enabled = btn_delete_purchased.Enabled = false;
            btn_save_purchased.Enabled = true;
            cbox_client.Select();
        }

        private void btn_delete_purchased_Click(object sender, EventArgs e)
        {
            int retorno = 0;
            if (rowIndexPurchased < 0)
            {
                MessageBox.Show("Você precisa escolher a venda que deseja apagar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from delete_purchased_package(:_id)";
                command = new NpgsqlCommand(sql, conn);
                command.Parameters.AddWithValue("_id", int.Parse(dgv_purchased_packages.Rows[rowIndexPurchased].Cells["pacote_fechado"].Value.ToString()));
                retorno = (int)command.ExecuteScalar();
                conn.Close();
                if (retorno == 1)
                {
                    MessageBox.Show("Venda deletada com sucesso!");
                    cbox_client.SelectedIndex = cbox_package.SelectedIndex = -1;
                    txt_qtd_adults.Text = txt_qtd_kids.Text = null;
                    Select_Purchased_Package();
                }
                else
                {
                    MessageBox.Show("Não foi possível deletar o pacote.");
                }
            }
            catch (Exception excpt)
            {
                conn.Close();
                MessageBox.Show("Erro: " + excpt.Message);
                throw;
            }
        }

        private void btn_save_purchased_Click(object sender, EventArgs e)
        {
            int selectedClient = clients[cbox_client.SelectedIndex].getId();
            int selectedPackage = packages[cbox_package.SelectedIndex].getId();
            int retorno = 0;
            if (rowIndexPackage < 0)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from insert_purchased_package(:_id_client, :_id_package, :_adults, :_kids)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_id_client", selectedClient);
                    command.Parameters.AddWithValue("_id_package", selectedPackage);
                    command.Parameters.AddWithValue("_adults", int.Parse(txt_qtd_adults.Text));
                    command.Parameters.AddWithValue("_kids", int.Parse(txt_qtd_kids.Text));
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Venda adicionada com sucesso!");
                        Select_Purchased_Package();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao adicionar venda.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = @"select * from update_purchased_package(:_id, :_id_client, :_id_package, :_adults, :_kids)";
                    command = new NpgsqlCommand(sql, conn);
                    command.Parameters.AddWithValue("_id", int.Parse(dgv_purchased_packages.Rows[rowIndexPurchased].Cells["pacote_fechado"].Value.ToString()));
                    command.Parameters.AddWithValue("_id_client", selectedClient);
                    command.Parameters.AddWithValue("_id_package", selectedPackage);
                    command.Parameters.AddWithValue("_adults", int.Parse(txt_qtd_adults.Text));
                    command.Parameters.AddWithValue("_kids", int.Parse(txt_qtd_kids.Text));
                    retorno = (int)command.ExecuteScalar();
                    conn.Close();
                    if (retorno == 1)
                    {
                        MessageBox.Show("Venda atualizada com sucesso!");
                        Select_Purchased_Package();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao alterar dados da venda.");
                    }
                }
                catch (Exception excpt)
                {
                    MessageBox.Show("Erro: " + excpt.Message);
                    throw;
                }
            }

            rowIndexPurchased = -1;
            cbox_client.SelectedIndex = cbox_package.SelectedIndex = -1;
            txt_qtd_adults.Text = txt_qtd_kids.Text = null;
            cbox_client.Enabled = cbox_package.Enabled = txt_qtd_adults.Enabled = txt_qtd_kids.Enabled = false;
            btn_insert_purchased.Enabled = btn_update_purchased.Enabled = btn_delete_purchased.Enabled = true;
            btn_save_purchased.Enabled = false;
        }

        private void dgv_purchased_packages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexPurchased = e.RowIndex;
                for (int i = 0; i < clients.Count(); i++)
                {
                    if (clients[i].getId() == int.Parse(dgv_purchased_packages.Rows[rowIndexPurchased].Cells["cliente"].Value.ToString()))
                    {
                        cbox_client.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < packages.Count(); i++)
                {
                    if (packages[i].getId() == int.Parse(dgv_purchased_packages.Rows[rowIndexPurchased].Cells["pacote"].Value.ToString()))
                    {
                        cbox_package.SelectedIndex = i;
                    }
                }

                txt_qtd_adults.Text = dgv_purchased_packages.Rows[rowIndexPurchased].Cells["adultos"].Value.ToString();
                txt_qtd_kids.Text = dgv_purchased_packages.Rows[rowIndexPurchased].Cells["criancas"].Value.ToString();
            }
        }
    }
}
