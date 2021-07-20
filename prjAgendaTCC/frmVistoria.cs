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
    public partial class frmVistoria : Form
    {
        public frmVistoria()
        {
            InitializeComponent();
        }

        clsConexao.clsConexao Conexao = new clsConexao.clsConexao("mapan", "localhost", "root", "root");

        OdbcDataReader DR;
        frmAgenda vistoria;
        clsAgenda Agenda;

        List<int> lstCdPessoa = new List<int>();

        public int Caminho = 0;
        int modificado = 0;

        #region FomLoad - Carrega as pessoas - Carrega vistoria para edição

        DateTime DataVisOr, HoraEve, HoraNow;
        int CdPessoaOr;
        private void frmVistoria_Load(object sender, EventArgs e)
        {
            vistoria = (frmAgenda)this.Owner;
            DR = null;

            Conexao.IniciarStoredProcedure("ListaPessoa");
            DR = Conexao.ChamarStoredProcedureCR();

            while (DR.Read())
            {
                cmbPessoa.Items.Add(DR[0].ToString());
                lstCdPessoa.Add(DR.GetInt32(1));
            }

            DR.Close();
            DR.Dispose();
            Conexao.FecharConexao();

            if (btnSalvar.Text == "Salvar")
            {
                btnSalvar.Location = new Point(16, 153);
                btnCancelar.Location = new Point(195, 153);
                this.Size = new Size(348, 228);

                rdbSim.Checked = true;
            }
            else
            {
                Conexao.IniciarStoredProcedure("ListaVistoria");
                DR = Conexao.ChamarStoredProcedureCR();

                while (DR.Read())
                {
                    //MessageBox.Show(vistoria.lstDataVis[vistoria.lstEventos.SelectedIndex] + " " + DR.GetString(0) + " - " + vistoria.lstHoraVis[vistoria.lstEventos.SelectedIndex] + " " + DR[2].ToString() + " - " + vistoria.lstCdPessoa[vistoria.lstEventos.SelectedIndex] + " " + DR.GetInt32(3));

                    if (DateTime.Parse(vistoria.lstDataVis[vistoria.dgvListas.CurrentRow.Index]).Date.ToString("yyyy-MM-dd") == DR.GetString(0) && vistoria.lstHoraVis[vistoria.dgvListas.CurrentRow.Index] == DR[2].ToString() && vistoria.lstCdPessoa[vistoria.dgvListas.CurrentRow.Index] == DR.GetInt32(3))
                    {
                        mtxtDataVis.Text = DateTime.Parse(DR.GetString(0)).Date.ToString("dd/MM/yyyy");
                        mtxtHora.Text = DR[2].ToString();
                        txtDescricao.Text = DR[5].ToString();

                        if (DR[6].ToString() != "")
                        {
                            mtxtDataVencimento.Text = DR.GetDate(6).ToString("dd/MM/yyyy");
                            mtxtDataVencimento.ReadOnly = true;
                        }
                        else
                        {
                            mtxtDataVencimento.ReadOnly = false;
                        }

                        if (DR[4].ToString() == "1")
                        {
                            rdbSim.Checked = true;
                        }
                        else
                        {
                            rdbNao.Checked = true;
                        }
                    }
                }

                DR.Close();
                DR.Dispose();
                Conexao.FecharConexao();

                DataVisOr = DateTime.Parse(mtxtDataVis.Text + " " + mtxtHora.Text.Substring(0,2) + ":" + mtxtHora.Text.Substring(2,2));
                HoraEve = DateTime.Parse("01/01/0001" + " " + mtxtHora.Text.Substring(0,2) + ":" + mtxtHora.Text.Substring(2,2));
                HoraNow = DateTime.Parse("01/01/0001" + " " + System.DateTime.Today.Hour + ":" + System.DateTime.Today.Minute);

                if (DataVisOr.Date > System.DateTime.Today.Date || DataVisOr.Date == System.DateTime.Today.Date && HoraEve < HoraNow )
                {
                    btnSalvar.Location = new Point(16, 153);
                    btnCancelar.Location = new Point(195, 153);
                    this.Size = new Size(348, 228);

                    mtxtDataVis.ReadOnly = false;
                    mtxtHora.ReadOnly = false;
                }
                else
                {
                    btnSalvar.Location = new Point(12, 414);
                    btnCancelar.Location = new Point(195, 414);
                    this.Size = new Size(348, 485);
                    
                    mtxtDataVis.ReadOnly = true;
                    mtxtHora.ReadOnly = true;

                    txtDescricao.Visible = true;
                    lblDescricao.Visible = true;
                    lblPassou.Visible = true;
                    rdbSim.Visible = true;
                    rdbNao.Visible = true;

                    lblDataVistoria.Visible = true;
                    mtxtDataVencimento.Visible = true;
                }

                for (int i = 0; i < cmbPessoa.Items.Count; i++)
                {
                    if (lstCdPessoa[i] == vistoria.lstCdPessoa[vistoria.dgvListas.CurrentRow.Index])
                    {
                        cmbPessoa.SelectedIndex = i;
                        CdPessoaOr = lstCdPessoa[i];
                    }
                }

                cmbPessoa.DropDownStyle = ComboBoxStyle.Simple;
            }
        }
        #endregion

        #region Cancela a Vistoria ou as Edições feitas
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "Cancelar")
            {
                if (mtxtDataVis.MaskCompleted && mtxtHora.MaskCompleted && mtxtDataVencimento.MaskCompleted)
                {
                    if (MessageBox.Show("Atenção: Hávera perda de dados caso cancelada está operação! Tem certeza disto?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("Você deseja cancelar está vistoria?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Close();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Você deseja cancelar a edição destá vistoria?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        #endregion

        #region Valida a data digitada pelo usuario do vencimento vistoria

        Boolean DataVisVen = true;
        private void mtxtDataVistoria_TextChanged(object sender, EventArgs e)
        {
            vistoria = (frmAgenda)this.Owner;
            Agenda = new clsAgenda();

            if (btnSalvar.Text != "Salvar" && modificado == 1)
            {
                if (mtxtDataVencimento.MaskCompleted == true)
                {
                    if (int.Parse(mtxtDataVencimento.Text.Substring(3, 2)) > 12)
                    {
                        MessageBox.Show("Atenção: O mês deve ser menor que '12'!");
                        mtxtDataVencimento.Focus();
                        mtxtDataVis.Select();
                        DataVisVen = false;
                        return;
                    }

                    if (Agenda.ValidaDataVistoria(int.Parse(mtxtDataVencimento.Text.Substring(0, 2)), int.Parse(mtxtDataVencimento.Text.Substring(3, 2)), int.Parse(mtxtDataVencimento.Text.Substring(6, 4))) == false)
                    {
                        MessageBox.Show("Atenção: A data ultrapassou o numero total de dias deste mês!");
                        mtxtDataVencimento.Focus();
                        mtxtDataVis.Select();
                        DataVisVen = false;
                        return;
                    }

                    if (DateTime.Parse(mtxtDataVencimento.Text) < vistoria.monthCalendar1.TodayDate)
                    {
                        MessageBox.Show("Atenção: A data " + mtxtDataVencimento.Text + " já passou!", this.Text);
                        mtxtDataVencimento.Focus();
                        mtxtDataVis.Select();
                        DataVisVen = false;
                        return;
                    }

                    if (DateTime.Parse(mtxtDataVencimento.Text) < DateTime.Parse(mtxtDataVis.Text))
                    {
                        MessageBox.Show("Atenção: A data de vencimento deve ser depois que a data da vistoria!");
                        mtxtDataVencimento.Focus();
                        mtxtDataVis.Select();
                        DataVisVen = false;
                        return;
                    }

                    DataVisVen = true;
                }
            }
        }
        #endregion

        #region Salva a vistoria
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DataVis == false || mtxtDataVis.MaskCompleted == false)
            {
                MessageBox.Show("Atenção: Data da vistoria inválida!");
                return;
            }

            if (DataVisVen == false && btnSalvar.Text == "Salvar Edição" || mtxtDataVencimento.MaskCompleted == false && btnSalvar.Text == "Salvar Edição" && modificado == 1)
            {
                MessageBox.Show("Atenção: Data de vencimento da vistoria inválida!");
                return;
            }

            if (HoraVis == false || mtxtHora.MaskCompleted == false)
            {
                MessageBox.Show("Atenção: A hora da vistoria está inválida!");
            }

            if (mtxtHora.MaskCompleted == false || int.Parse(mtxtHora.Text.Substring(0,2)) > 23 || int.Parse(mtxtHora.Text.Substring(2,2)) > 59)
            {
                MessageBox.Show("Atenção: A hora não está escrita corretamente!");
                return;
            }

            if (cmbPessoa.Text == "")
            {
                MessageBox.Show("Atenção: Selecione uma pessoa para vistoria!");
                return;
            }

            if (Agenda.ExisteVistoria(mtxtDataVis.Text, mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2), lstCdPessoa[cmbPessoa.SelectedIndex]) == "")
            {

                if (btnSalvar.Text == "Salvar")
                {
                    Conexao.IniciarStoredProcedure("AddVistoria");
                    Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVis.Text).Date.ToString("yyyy-MM-dd"));
                    Conexao.AdicionarParametroTexto(mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2));
                    Conexao.AdicionarParametroInteiro(lstCdPessoa[cmbPessoa.SelectedIndex]);
                    Conexao.AdicionarParametroTexto("");
                    Conexao.AdicionarParametroInteiro(-1);
                    Conexao.AdicionarParametroTexto("");
                    Conexao.ChamarStoredProcedureSR();

                    MessageBox.Show("Vistoria cadastrada com sucesso!");
                }
                else
                {
                    if (mtxtDataVencimento.Visible == true)
                    {
                        if (rdbSim.Checked)
                        {
                            Conexao.IniciarStoredProcedure("EditaVistoria");

                            Conexao.AdicionarParametroTexto(DataVisOr.Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroTexto((HoraEve.Hour + ":" + HoraEve.Minute).ToString());
                            Conexao.AdicionarParametroInteiro(CdPessoaOr);

                            Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVis.Text).Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroTexto(mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2));
                            Conexao.AdicionarParametroInteiro(lstCdPessoa[cmbPessoa.SelectedIndex]);
                            Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVencimento.Text).Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroInteiro(1);
                            Conexao.AdicionarParametroTexto(txtDescricao.Text);
                            Conexao.ChamarStoredProcedureSR();

                            MessageBox.Show("Vistoria editada com sucesso!");
                        }
                        else
                        {
                            Conexao.IniciarStoredProcedure("EditaVistoria");

                            Conexao.AdicionarParametroTexto(DataVisOr.Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroTexto((HoraEve.Hour + ":" + HoraEve.Minute).ToString());
                            Conexao.AdicionarParametroInteiro(CdPessoaOr);

                            Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVis.Text).Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroTexto(mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2));
                            Conexao.AdicionarParametroInteiro(lstCdPessoa[cmbPessoa.SelectedIndex]);
                            Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVencimento.Text).Date.ToString("yyyy-MM-dd"));
                            Conexao.AdicionarParametroInteiro(0);
                            Conexao.AdicionarParametroTexto(txtDescricao.Text);
                            Conexao.ChamarStoredProcedureSR();

                            MessageBox.Show("Vistoria editada com sucesso!");
                        }
                    }
                    else
                    {
                        Conexao.IniciarStoredProcedure("EditaVistoria");

                        Conexao.AdicionarParametroTexto(DataVisOr.Date.ToString("yyyy-MM-dd"));
                        Conexao.AdicionarParametroTexto((HoraEve.Hour + ":" + HoraEve.Minute).ToString());
                        Conexao.AdicionarParametroInteiro(CdPessoaOr);

                        Conexao.AdicionarParametroTexto(DateTime.Parse(mtxtDataVis.Text).Date.ToString("yyyy-MM-dd"));
                        Conexao.AdicionarParametroTexto(mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2));
                        Conexao.AdicionarParametroInteiro(lstCdPessoa[cmbPessoa.SelectedIndex]);
                        Conexao.AdicionarParametroTexto("");
                        Conexao.AdicionarParametroInteiro(-1);
                        Conexao.AdicionarParametroTexto("");
                        Conexao.ChamarStoredProcedureSR();

                        MessageBox.Show("Vistoria editada com sucesso!");
                    }
                }

                if (Caminho == 1)
                {
                    #region Recarrega a lista
                    vistoria = (frmAgenda)this.Owner;

                    vistoria.lstDataVis.Clear();
                    vistoria.lstHoraVis.Clear();
                    vistoria.lstCdPessoa.Clear();
                    vistoria.dgvListas.Rows.Clear();

                    DR = null;
                    int index = 0;

                    Conexao.IniciarStoredProcedure("ListaVistoria");
                    DR = Conexao.ChamarStoredProcedureCR();

                    while (DR.Read())
                    {
                        vistoria.lstDataVis.Add(DR[0].ToString());
                        vistoria.lstHoraVis.Add(DR[2].ToString());
                        vistoria.lstCdPessoa.Add(DR.GetInt32(3));

                        string hora = (System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute).ToString();

                        if (DR.GetDate(0) == vistoria.monthCalendar1.TodayDate && DR.GetTime(2) < TimeSpan.Parse(hora) || DR.GetDate(0) < vistoria.monthCalendar1.TodayDate)
                        {
                            if (DR[4].ToString() == "" && DR[5].ToString() == "")
                            {
                                if (DR[7].ToString() != "")
                                {
                                    if (DR[7].ToString() != "1")
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo inativo");
                                    }
                                    else
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo Ativo");
                                    }
                                }
                                else
                                {
                                    if (DR[8].ToString() != "")
                                    {
                                        if (DR[7].ToString() != "1")
                                        {
                                            vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante desbloqueado");
                                        }
                                        else
                                        {
                                            vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante bloqueado");
                                        }
                                    }
                                    else
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "");
                                    }
                                }

                                vistoria.dgvListas.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                                index += 1;
                            }
                            else
                            {
                                if (DR[7].ToString() != "")
                                {
                                    if (DR[7].ToString() != "1")
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo inativo");
                                    }
                                    else
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo Ativo");
                                    }
                                }
                                else
                                {
                                    if (DR[8].ToString() != "")
                                    {
                                        if (DR[7].ToString() != "1")
                                        {
                                            vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante desbloqueado");
                                        }
                                        else
                                        {
                                            vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante bloqueado");
                                        }
                                    }
                                    else
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "");
                                    }
                                }
                                index += 1;
                            }
                        }
                        else
                        {
                            if (DR[7].ToString() != "")
                            {
                                if (DR[7].ToString() != "1")
                                {
                                    vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo inativo");
                                }
                                else
                                {
                                    vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Dono de um abrigo Ativo");
                                }
                            }
                            else
                            {
                                if (DR[8].ToString() != "")
                                {
                                    if (DR[7].ToString() != "1")
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante desbloqueado");
                                    }
                                    else
                                    {
                                        vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "Adotante bloqueado");
                                    }
                                }
                                else
                                {
                                    vistoria.dgvListas.Rows.Add(DR.GetDate(0).ToString("dd/MM/yyyy"), DR[1].ToString(), "");
                                }
                            }
                            index += 1;
                        }
                    }

                    DR.Close();
                    DR.Dispose();
                    Conexao.FecharConexao();
                    #endregion
                }

                Close();
            }
            else
            {
                MessageBox.Show(Agenda.ExisteVistoria(mtxtDataVis.Text, mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2), lstCdPessoa[cmbPessoa.SelectedIndex]));
            }
        }
        #endregion

        #region Fecha a tela e Recarrega a lista de vistoria
        private void frmVistoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Reinicia a tela
            mtxtHora.Clear();
            mtxtDataVencimento.Clear();
            mtxtDataVis.Clear();
            txtDescricao.Clear();
            cmbPessoa.Text = "";
            btnSalvar.Text = "Salvar";
            btnCancelar.Text = "Cancelar";

            lstCdPessoa.Clear();
            cmbPessoa.Items.Clear();

            cmbPessoa.DropDownStyle = ComboBoxStyle.DropDownList;

            txtDescricao.Visible = false;
            lblDescricao.Visible = false;
            lblPassou.Visible = false;
            rdbSim.Visible = false;
            rdbNao.Visible = false;
            mtxtHora.ReadOnly = false;
            mtxtDataVencimento.Visible = false;
            lblDataVistoria.Visible = false;
            #endregion
        }
        #endregion

        #region Valida a data da vistoria digitada pelo usuario

        Boolean DataVis = true;
        private void mtxtDataVis_TextChanged(object sender, EventArgs e)
        {
            vistoria = (frmAgenda)this.Owner;
            Agenda = new clsAgenda();

            if (btnSalvar.Text == "Salvar")
            {
                if (mtxtDataVis.MaskCompleted == true)
                {
                    if (int.Parse(mtxtDataVis.Text.Substring(3, 2)) > 12)
                    {
                        MessageBox.Show("Atenção: O mês deve ser menor que '12'!");
                        mtxtDataVis.Focus();
                        mtxtDataVis.Select();
                        DataVis = false;
                        //btnSalvar.Enabled = false;
                        return;
                    }

                    if (Agenda.ValidaDataVistoria(int.Parse(mtxtDataVis.Text.Substring(0, 2)), int.Parse(mtxtDataVis.Text.Substring(3, 2)), int.Parse(mtxtDataVis.Text.Substring(6, 4))) == false)
                    {
                        MessageBox.Show("Atenção: A data ultrapassou o numero total de dias deste mês!");
                        mtxtDataVis.Focus();
                        mtxtDataVis.Select();
                        DataVis = false;
                        //btnSalvar.Enabled = false;
                        return;
                    }

                    if (DateTime.Parse(mtxtDataVis.Text) < System.DateTime.Today.Date)
                    {
                        MessageBox.Show("Atenção: A data " + mtxtDataVis.Text + " já passou!", this.Text);
                        mtxtDataVis.Focus();
                        mtxtDataVis.Select();
                        DataVis = false;
                        //btnSalvar.Enabled = false;
                        return;
                    }

                    DataVis = true;
                    //btnSalvar.Enabled = true;
                }
            }
        }
        #endregion

        #region Impede a digitação na combobox quando edição
        private void cmbPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnSalvar.Text == "Salvar Edição")
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Valida a hora caso seja uma vistoria no dia de hoje

        Boolean HoraVis = true;
        private void mtxtHora_TextChanged(object sender, EventArgs e)
        {
            if (mtxtHora.MaskCompleted && btnSalvar.Text == "Salvar" && mtxtDataVis.MaskCompleted)
            {
                if (DateTime.Parse(mtxtDataVis.Text).Date == System.DateTime.Today)
                {
                    DateTime HoraDig = (DateTime.Parse("01/01/0001 " + mtxtHora.Text.Substring(0, 2) + ":" + mtxtHora.Text.Substring(2, 2)));
                    DateTime HoraAgora = DateTime.Parse("01/01/0001 " + System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute);

                    if (DateTime.Parse(mtxtDataVis.Text).Date == System.DateTime.Today && HoraDig < HoraAgora)
                    {
                        MessageBox.Show("Atenção: A hora digitada já passou!");
                        HoraVis = false;
                        //btnSalvar.Enabled = false;
                    }
                    else
                    {
                        HoraVis = true;
                        //btnSalvar.Enabled = true;
                    }
                }
            }
        }
        #endregion

        #region mtxtDataVencimento
        private void mtxtDataVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            modificado = 1;
        }
        #endregion
    }
}
