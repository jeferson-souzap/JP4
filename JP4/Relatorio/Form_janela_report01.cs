using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace JP4
{
    public partial class Form_janela_report01 : Form
    {
        public Form_janela_report01()
        {
            InitializeComponent();
            // Carregar_grafico_pico();
            // Carregar_grafico_ext();

            
            

        }

        private void Carregar_total_produ()
        {
            
        }

        private void Carregar_grafico_pico()
        {
            try
            {

                string dat_movto = "01/11/2021"; //Convert.ToDateTime( DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"));
                string dat_movto2 = "02/11/2021"; //Convert.ToDateTime( DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"));

                string conecta_string = Properties.Settings.Default.db_aplicativo_kpiConnectionString;
                MySqlConnection conexao = new MySqlConnection(conecta_string);
                string comando_sql = "select * from estoque_trans where dat_movto >= '" + dat_movto + "' and dat_movto <= '" + dat_movto2 + "'  and cod_operacao = 'APON' and cod_empresa ='SAN MARINO'";
                MySqlDataReader myreader;

                // cod_operacao

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                conexao.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    //Maquina

                    chart_producao_pico.Series["Maquina"].Points.AddXY(myreader["secao_nome"].ToString(), myreader["qtd_movto"].ToString());


                }
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
                

    }
}
