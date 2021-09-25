using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dioSeries
{
    public class GeneroSerie 
    {
        private int idSerie;
        private int idGenero;

        public GeneroSerie(int idSerie, int idGenero)
        {
            IdSerie = idSerie;
            IdGenero = idGenero;
        }
        public GeneroSerie() { }

        public int IdSerie { get => idSerie; set => idSerie = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }


        public bool VincularGeneroSerie()
        {
            Database db = new Database();
            try
            {
                db.Conectar();

                long Id = db.ExecutarComandoSQL("INSERT INTO GeneroSerie VALUES('"+this.idGenero+"','" + this.idSerie + "')", true);
                return true;
            }
            catch (Exception er)
            {
                throw new Exception("Erro no Registro! -ERRO:" + er.Message);
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
                return db.RetDataTable("CALL sp_ExibeSerieGenero()");

            }


            catch (Exception er)
            {
                throw new Exception("Erro ao listar! - ERRO:" + er.Message);
            }


        }
    }
}
