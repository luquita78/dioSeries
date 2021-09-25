using dioSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace dioSeries
{
   public class Genero : EntidadeBase
    {
        private string nome;

        public Genero(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Genero() { }

        public Genero(string nome)
        {
            Nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }


        public bool Incluir()
        {
            Database db = new Database();

            try
            {
                db.Conectar();

                long Id = db.ExecutarComandoSQL("INSERT INTO genero VALUES(null,'" + this.Nome + "')", true);
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro no cadastro de Genero! -ERRO:" + er.Message);
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

                db.ExecutarComandoSQL("UPDATE genero SET nome = '" + this.Nome + "' WHERE idGenero = '"+this.Id+"'");



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

                db.ExecutarComandoSQL("DELETE FROM genero WHERE idGenero = '" + ID + "'");

                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao deletar genero!" + er.Message);
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
                return db.RetDataTable("CALL sp_ConsultaGeneros()");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }

        public Genero getGeneroPeloID(int ID)
        {
            Database db = new Database();
            try
            {
                db.Conectar();
                DataTable dados_genero = db.RetDataTable("SELECT *FROM Genero WHERE idGenero = '" + ID + "'");


                DataRow row = dados_genero.Rows[0];

                return new Genero(int.Parse(row["idGenero"].ToString()), row["nome"].ToString());

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }
        }
    }
}
