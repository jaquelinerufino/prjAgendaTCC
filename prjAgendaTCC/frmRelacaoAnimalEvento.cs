using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace prjAgendaTCC
{
    public partial class frmRelacaoAnimalEvento : Form
    {
        public frmRelacaoAnimalEvento()
        {
            InitializeComponent();
        }

        #region Conexão, Arrays Dinamicas, Instancias
        clsConexao.clsConexao Conexao = new clsConexao.clsConexao("mapan", "localhost", "root", "root");
        OdbcDataReader DR;

        List<int> lstCdAnimal = new List<int>();
        List<int> lstCdAnimaisExcluir = new List<int>();
        List<int> lstCdNovosAnimaisRelacionado = new List<int>();

        frmAgenda Relacao;
        frmNovoEvento Evento;

        public Boolean NovaRelação;
        #endregion

        #region FormLoad - Carrega a lista de animais, Lista de animais relacionados
        private void frmRelacaoAnimalEvento_Load(object sender, EventArgs e)
        {
            lstAnimaisAdicionados.Items.Clear();
            lstCdAnimaisExcluir.Clear();
            lstCdNovosAnimaisRelacionado.Clear();
            lstCdAnimal.Clear();
            cmbAnimais.Items.Clear();
            DR = null;

            #region Lista animais
            Conexao.IniciarStoredProcedure("ListaAnimal");
            DR = Conexao.ChamarStoredProcedureCR();

            while (DR.Read())
            {
                cmbAnimais.Items.Add(DR[0].ToString());
                lstCdAnimal.Add(DR.GetInt32(1));
            }

            DR.Close();
            DR.Dispose();
            Conexao.FecharConexao();
            #endregion

            #region Animais já relacionados
            if (NovaRelação == true)
            {
                Evento = (frmNovoEvento)this.Owner;

                if (Evento.lstAnimais.Items.Count > 0)
                {
                    for (int i = 0; i < Evento.lstAnimais.Items.Count; i++)
                    {
                        lstAnimaisAdicionados.Items.Add(Evento.lstAnimais.Items[i]);
                        Evento.lstNovosAnimais.Add(Evento.lstCodigosAnimais[i]);
                    }
                }
            }
            else
            {
                Relacao = (frmAgenda)this.Owner;

                if (Relacao.dgvAnimais.Columns[0].HeaderText != "Nenhum animal participou deste evento!")
                {
                    for (int i = 0; i < Relacao.dgvAnimais.Rows.Count; i++)
                    {

                        lstAnimaisAdicionados.Items.Add(Relacao.dgvAnimais.Rows[i].Cells[1].Value);
                        lstCdNovosAnimaisRelacionado.Add(Relacao.lstCdAnimais[i]);
                    }
                }
            }
            #endregion
        }
        #endregion

        #region btnCancelar - Fecha a tela, Recarrega a lista de animais relacionados da tela principal
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (lstCdAnimaisExcluir.Count != 0 && lstCdNovosAnimaisRelacionado.Count != 0)
            {
                if (MessageBox.Show("Atenção: Hávera perda de dados caso cancelada está operção! Tem certeza disto?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        #endregion

        #region btnAddAnimal - Adiciona um novo animal a lista de animais
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (cmbAnimais.SelectedIndex == -1)
            {
                MessageBox.Show("Atenção: Selecione um animal para poder adiciona-lo a lista!");
                return;
            }

            if (NovaRelação == false)
            {
                for (int i = 0; i < lstAnimaisAdicionados.Items.Count; i++)
                {
                    if (lstCdNovosAnimaisRelacionado[i] == lstCdAnimal[cmbAnimais.SelectedIndex])
                    {
                        lstAnimaisAdicionados.SelectedIndex = i;
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < lstAnimaisAdicionados.Items.Count; i++)
                {
                    if (Evento.lstNovosAnimais[i] == lstCdAnimal[cmbAnimais.SelectedIndex])
                    {
                        lstAnimaisAdicionados.SelectedIndex = i;
                        return;
                    }
                }
            }

            lstAnimaisAdicionados.Items.Add(cmbAnimais.Text);

            if (NovaRelação == false)
            {
                lstCdNovosAnimaisRelacionado.Add(lstCdAnimal[cmbAnimais.SelectedIndex]);
            }
            else
            {
                Evento.lstNovosAnimais.Add(lstCdAnimal[cmbAnimais.SelectedIndex]);
            }
        }
        #endregion

        #region txtCodigo-Keypress - Impede a digitação de caracteres não numéricos
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar > 47 && e.KeyChar < 58)
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region cmbAnimais - Mostra o codigo do animal na txtCodigo conforme o selecionado na lista de animais
        private void cmbAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnimais.SelectedIndex != -1)
            {
                txtCodigo.Text = lstCdAnimal[cmbAnimais.SelectedIndex].ToString();
            }
        }
        #endregion
       
        #region ltsAnimaisPossiveis - Seleciona o animal na combobox conforme o selecionado na lista de animais
        //Habilita/Desabilita btnTirar animal caso o animal já esteja adotado ou em um abrigo

        private void lstAnimaisPossiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i, NaoTem;

            NaoTem = 0;
            i = 0;

            if (lstAnimaisAdicionados.SelectedIndex > -1)
            {
                for (i = 0; i < cmbAnimais.Items.Count; i++)
                {
                    if (NovaRelação == false)
                    {
                        if (lstCdAnimal[i] == lstCdNovosAnimaisRelacionado[lstAnimaisAdicionados.SelectedIndex])
                        {
                            cmbAnimais.SelectedIndex = i;
                            btnExcluirAnimal.Enabled = true;
                        }
                        else
                        {
                            NaoTem = NaoTem + 1;
                        }
                    }
                    else
                    {
                        if (lstCdAnimal[i] == Evento.lstNovosAnimais[lstAnimaisAdicionados.SelectedIndex])
                        {
                            cmbAnimais.SelectedIndex = i;
                            btnExcluirAnimal.Enabled = true;
                        }
                        else
                        {
                            NaoTem = NaoTem + 1;
                        }
                    }
                }
            }

            if (NaoTem == i)
            {
                btnExcluirAnimal.Enabled = false;
                cmbAnimais.SelectedIndex = -1;
                txtCodigo.Text = "";
            }
        }
        #endregion

        #region btnTirarAnimal - Exclui o animal selecionado na lista de animais, Recarrega a lista de animais, Habilita/Desabilita btnExcluirAnimal
        private void btnTirarAnimal_Click(object sender, EventArgs e)
        {
            if (lstAnimaisAdicionados.SelectedIndex != -1)
            {
                if (MessageBox.Show("Você deseja retirar " + cmbAnimais.SelectedItem + " deste evento?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (NovaRelação == false)
                    {
                        lstCdAnimaisExcluir.Add(lstCdNovosAnimaisRelacionado[lstAnimaisAdicionados.SelectedIndex]);
                        lstCdNovosAnimaisRelacionado.RemoveAt(lstAnimaisAdicionados.SelectedIndex);
                        lstAnimaisAdicionados.Items.Remove(lstAnimaisAdicionados.SelectedItem);
                    }
                    else
                    {
                        Evento = (frmNovoEvento)this.Owner;

                        Evento.lstExcluirAnimais.Add(Evento.lstNovosAnimais[lstAnimaisAdicionados.SelectedIndex]);
                        Evento.lstNovosAnimais.RemoveAt(lstAnimaisAdicionados.SelectedIndex);
                        lstAnimaisAdicionados.Items.RemoveAt(lstAnimaisAdicionados.SelectedIndex);
                    }
                }
            }
        }
        #endregion

        #region Salva a lista de animas
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (NovaRelação == false)
            {

                #region Exclui os animais selecionados
                for (int i = 0; i < lstCdAnimaisExcluir.Count; i++)
                {
                    Conexao.IniciarStoredProcedure("ExcluirAnimal");
                    Conexao.AdicionarParametroInteiro(lstCdAnimaisExcluir[i]);
                    Conexao.AdicionarParametroTexto(DateTime.Parse(Relacao.lstData[Relacao.dgvListas.CurrentRow.Index]).Date.ToString("yyyy-MM-dd"));
                    Conexao.AdicionarParametroTexto(Relacao.lstHora[Relacao.dgvListas.CurrentRow.Index]);
                    Conexao.ChamarStoredProcedureSR();
                }
                #endregion

                #region Adiciona os animais selecionados
                for (int i = 0; i < lstCdNovosAnimaisRelacionado.Count; i++)
                {
                    Conexao.IniciarStoredProcedure("AddRelacaoAnimal");
                    Conexao.AdicionarParametroInteiro(lstCdNovosAnimaisRelacionado[i]);
                    Conexao.AdicionarParametroTexto(DateTime.Parse(Relacao.lstData[Relacao.dgvListas.CurrentRow.Index]).ToString("yyyy-MM-dd"));
                    Conexao.AdicionarParametroTexto(Relacao.lstHora[Relacao.dgvListas.CurrentRow.Index]);
                    Conexao.ChamarStoredProcedureSR();
                }
                #endregion

                DR = null;
                Relacao.lstCdAnimais.Clear();
                //Relacao.lstAnimaisRelacionados.Items.Clear();
                Relacao.dgvAnimais.Rows.Clear();

                #region Recarrega a lista de animais
                Conexao.IniciarStoredProcedure("ListaAnimaisEvento");
                Conexao.AdicionarParametroTexto(DateTime.Parse(Relacao.lstData[Relacao.dgvListas.CurrentRow.Index]).Date.ToString("yyyy-MM-dd"));
                Conexao.AdicionarParametroTexto(Relacao.lstHora[Relacao.dgvListas.CurrentRow.Index]);
                DR = Conexao.ChamarStoredProcedureCR();


                while (DR.Read())
                {
                    //Relacao.lstAnimaisRelacionados.Items.Add(DR[0].ToString());
                    Relacao.dgvAnimais.Rows.Add(DR[1].ToString(), DR[0].ToString());
                    Relacao.lstCdAnimais.Add(DR.GetInt32(1));
                }

                DR.Close();
                DR.Dispose();
                Conexao.FecharConexao();
                #endregion

                MessageBox.Show("Relações salvas com sucesso!");
            }
            else
            {
                Evento = (frmNovoEvento)this.Owner;

                Evento.lstAnimais.Items.Clear();

                for (int i = 0; i <  lstAnimaisAdicionados.Items.Count; i++)
                {
                    Evento.lstAnimais.Items.Add(lstAnimaisAdicionados.Items[i]);
                }
            }

            Close();
        }
        #endregion

        #region Pesquisa o animal pelo codigo
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            int NaoTem=0,i;

            for (i = 0; i < cmbAnimais.Items.Count; i++)
            {
                if (lstCdAnimal[i].ToString() == txtCodigo.Text)
                {
                    cmbAnimais.SelectedIndex = i;
                }
                else
                {
                    NaoTem += 1;
                }
            }

            if (NaoTem == i)
            {
                cmbAnimais.SelectedIndex = -1;
            }
        }
        #endregion
    }
}
