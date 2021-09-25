using dioSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace dioSeries
{
    public class Serie : EntidadeBase
    {
        private string nome;
        private string descricao;
        private int anoLancamento;

        #region Construtores 

        public Serie(string nome, string descricao, int anoLancamento)
        {
            Nome = nome;
            Descricao = descricao;
            AnoLancamento = anoLancamento;
        }

        public Serie(int id, string nome, string descricao, int anoLancamento)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            AnoLancamento = anoLancamento;
        }

        public Serie()
        {
            
        }
        #endregion

        
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int AnoLancamento { get => anoLancamento; set => anoLancamento = value; }


        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
           
            retorno += "Titulo: " + this.Nome + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.AnoLancamento + Environment.NewLine;
            
            return retorno;
        }

        public bool Incluir()
        {
            Database db = new Database();

            try
            {
                db.Conectar();

                long Id = db.ExecutarComandoSQL("INSERT INTO Serie VALUES(null,'" + this.Nome + "','" + this.Descricao + "','" + this.AnoLancamento + "')", true);
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro no cadastro de Série! -ERRO:" + er.Message);
            }
            finally
            {
                db = null;
            }

        }
        public bool Alterar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                db.ExecutarComandoSQL("UPDATE Serie SET nome = '" + this.Nome + "', descricao = '" + this.Descricao + "', anoSerie = '" + this.AnoLancamento + "' WHERE idSerie = '" + this.Id + "'");



                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao alterar Registro! - Erro:" + er.Message);
            }
            finally
            {
                db = null;
            }
        }
        public bool Excluir(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                db.ExecutarComandoSQL("DELETE FROM Serie WHERE idSerie = '" + ID + "'");

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar Serie!" + er.Message);
            }
            finally
            {
                db = null;
            }

        }
        public DataTable Listar()
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                return db.RetDataTable("CALL sp_ConsultaSerie()");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }

        public Serie getSeriePeloID(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dados_series = db.RetDataTable("SELECT *FROM Serie WHERE idSerie = '" + ID + "'");


                DataRow row = dados_series.Rows[0];

                return new Serie (int.Parse(row["idSerie"].ToString()), row["nome"].ToString(), row["descricao"].ToString(), int.Parse(row["anoSerie"].ToString()));

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }
        }
    }

  
}
