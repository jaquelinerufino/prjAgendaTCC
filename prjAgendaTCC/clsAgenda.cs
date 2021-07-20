using System;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace prjAgendaTCC
{
    class clsAgenda
    {
        #region Conexão e Variaveis

        clsConexao.clsConexaoSQL Conexao = new clsConexao.clsConexaoSQL("MAPAN", "FREAKANOTE", "root", "root");
        SqlDataReader DataReader;

        List<int> CodigosTipoEvento1 = new List<int>();
        List<string> Nome = new List<string>();
        List<DateTime> DataEventoInicio = new List<DateTime>();
        List<DateTime> DataEventoTermino = new List<DateTime>();

        int tem;

        public int TEM
        {
            get { return tem; }
            set { tem = value; }
        }
        #endregion

        #region Retorno codigo do tipo evento
        public int CodigosTE(int cdTE)
        {
            DataReader = null;
            CodigosTipoEvento1.Clear();

            Conexao.IniciarStoredProcedure("ListaEvento");
            DataReader = Conexao.ChamarStoredProcedureCR();

            while (DataReader.Read())
            {
                CodigosTipoEvento1.Add(DataReader.GetInt32(8));
            }

            DataReader.Close();
            DataReader.Dispose();
            Conexao.FecharConexao();

            return CodigosTipoEvento1[cdTE];
        }
        #endregion

        #region Retorna a quantidade de tipo evento
        public int QtdCodigos1()
        {
            DataReader = null;
            CodigosTipoEvento1.Clear();

            Conexao.IniciarStoredProcedure("ListaEvento");
            DataReader = Conexao.ChamarStoredProcedureCR();

            while (DataReader.Read())
            {
                CodigosTipoEvento1.Add(DataReader.GetInt32(8));
            }

            DataReader.Close();
            DataReader.Dispose();
            Conexao.FecharConexao();

            return CodigosTipoEvento1.Count;
        }
        #endregion

        //DateTime DataIHoraI, DateTime DataIHoraF, DateTime DataFHoraI, DateTime DataFHoraF

        #region Verificação da data para novo evento
        public string DataExiste(DateTime DataI, DateTime DataF)
        {
            string Data;
            tem = 0;

            DataEventoInicio.Clear();
            DataEventoTermino.Clear();
            DataReader = null;

            Conexao.IniciarStoredProcedure("ListaEvento");
            DataReader = Conexao.ChamarStoredProcedureCR();

            while (DataReader.Read())
            {
                Data = DataReader.GetString(0) + " " + DataReader.GetString(1);
                DataEventoInicio.Add(DateTime.Parse(Data));

                Data = DataReader.GetString(2) + " " + DataReader.GetString(3);
                DataEventoTermino.Add(DateTime.Parse(Data));

                Nome.Add(DataReader.GetString(4));
            }

            DataReader.Close();
            DataReader.Dispose();
            Conexao.FecharConexao();

            if (DataI.Date != DataF.Date)
            {
                for (int i = 0; i < DataEventoInicio.Count; i++)
                {
                    if (DataI.Date <= DataEventoInicio[i].Date && DataF.Date >= DataEventoTermino[i].Date || DataI.Date >= DataEventoInicio[i].Date && DataF.Date <= DataEventoTermino[i].Date)
                    {
                        if (DataI.Hour >= DataEventoInicio[i].Hour && DataF.Hour <= DataEventoTermino[i].Hour || DataI.Hour <= DataEventoInicio[i].Hour && DataF.Hour >= DataEventoTermino[i].Hour || DataI.Hour > DataEventoInicio[i].Hour && DataI.Hour < DataEventoTermino[i].Hour || DataF.Hour > DataEventoInicio[i].Hour && DataF.Hour < DataEventoTermino[i].Hour)
                        {
                            return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                        }

                        if (DataI.Hour == DataEventoInicio[i].Hour || DataI.Hour == DataEventoTermino[i].Hour || DataF.Hour == DataEventoInicio[i].Hour || DataF.Hour == DataEventoTermino[i].Hour)
                        {
                            if (DataI.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataI.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataI.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataI.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataF.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataF.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < DataEventoInicio.Count; i++)
                {
                    if (DataI.Date >= DataEventoInicio[i].Date && DataI.Date <= DataEventoTermino[i].Date)
                    {
                        if (DataI.Hour >= DataEventoInicio[i].Hour && DataF.Hour <= DataEventoTermino[i].Hour || DataI.Hour <= DataEventoInicio[i].Hour && DataF.Hour >= DataEventoTermino[i].Hour || DataI.Hour > DataEventoInicio[i].Hour && DataI.Hour < DataEventoTermino[i].Hour || DataF.Hour > DataEventoInicio[i].Hour && DataF.Hour < DataEventoTermino[i].Hour)
                        {
                            return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                        }

                        if (DataI.Hour == DataEventoInicio[i].Hour || DataI.Hour == DataEventoTermino[i].Hour || DataF.Hour == DataEventoInicio[i].Hour || DataF.Hour == DataEventoTermino[i].Hour)
                        {
                            if (DataI.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataI.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataI.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataI.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataF.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataF.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }
                        }
                    }
                }
            }

            return "";
        }
        #endregion

        #region Verificação da data para edição do evento
        public string DataExisteEdicao(DateTime DataI, DateTime DataF, DateTime DataInOr, DateTime DataFnOr)
        {
            string Data;
            DataEventoInicio.Clear();
            DataEventoTermino.Clear();
            DataReader = null;

            Conexao.IniciarStoredProcedure("ListaEvento");
            DataReader = Conexao.ChamarStoredProcedureCR();

            while (DataReader.Read())
            {
                Data = DataReader.GetString(0) + " " + DataReader.GetString(1);
                DataEventoInicio.Add(DateTime.Parse(Data));

                Data = DataReader.GetString(2) + " " + DataReader.GetString(3);
                DataEventoTermino.Add(DateTime.Parse(Data));

                Nome.Add(DataReader.GetString(4));
            }

            DataReader.Close();
            DataReader.Dispose();
            Conexao.FecharConexao();

            for (int i = 0; i < DataEventoInicio.Count; i++)
            {
                if (DataEventoInicio[i] != DataInOr && DataEventoTermino[i] != DataFnOr)
                {
                    if (DataI.Date <= DataEventoInicio[i].Date && DataF.Date >= DataEventoTermino[i].Date || DataI.Date >= DataEventoInicio[i].Date && DataF.Date <= DataEventoTermino[i].Date)
                    {
                        if (DataI.Hour >= DataEventoInicio[i].Hour && DataF.Hour <= DataEventoTermino[i].Hour || DataI.Hour <= DataEventoInicio[i].Hour && DataF.Hour >= DataEventoTermino[i].Hour || DataI.Hour > DataEventoInicio[i].Hour && DataI.Hour < DataEventoTermino[i].Hour || DataF.Hour > DataEventoInicio[i].Hour && DataF.Hour < DataEventoTermino[i].Hour)
                        {
                            return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                        }

                        if (DataI.Hour == DataEventoInicio[i].Hour || DataI.Hour == DataEventoTermino[i].Hour || DataF.Hour == DataEventoInicio[i].Hour || DataF.Hour == DataEventoTermino[i].Hour)
                        {
                            if (DataI.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataI.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataI.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataI.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoInicio[i].Hour)
                            {
                                if (DataF.Minute >= DataEventoInicio[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }

                            if (DataF.Hour == DataEventoTermino[i].Hour)
                            {
                                if (DataF.Minute <= DataEventoTermino[i].Minute)
                                {
                                    return "Esta data já esta cadastrada no evento: " + Nome[i] + " - " + DataEventoInicio[i].ToString() + " - " + DataEventoTermino[i].ToString();
                                }
                            }
                        }
                    }
                }
            }

            return "";
        }
        #endregion



        #region Valida a data digitada pelo usuario na tela de vistoria
        public Boolean ValidaDataVistoria(int Dia, int Mes, int Ano)
        {
            if (Mes > 55)
            {
                return false;
            }

            if (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
            {
                if (Dia > 31)
                {
                    return false;
                }
            }

            if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
            {
                if (Dia > 30)
                {
                    return false;
                }
            }

            if (Mes == 2)
            {
                if (Ano % 400 == 0 || Ano % 4 == 0 && Ano % 100 != 0)
                {
                    if (Dia > 29)
                    {
                        return false;
                    }
                }
                
                if (Dia > 28)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region Verifica se há uma vistoria cadastrada com os mesmos termos
        public string ExisteVistoria(string Data, string hora, int pessoa)
        {
            Conexao.IniciarStoredProcedure("ListaVistoria");
            DataReader = Conexao.ChamarStoredProcedureCR();

            while (DataReader.Read())
            {
               if (Data == DataReader.GetString(0) && pessoa == DataReader.GetInt32(3))
               {
                   return "Atenção: Há um evento cadastrado com estas condições: " + DataReader[0].ToString() + " - " + DataReader[2].ToString() + " - " + DataReader[1].ToString();
               }
            }

            DataReader.Close();
            DataReader.Dispose();
            Conexao.FecharConexao();

            return "";
        }
        #endregion
    }
}