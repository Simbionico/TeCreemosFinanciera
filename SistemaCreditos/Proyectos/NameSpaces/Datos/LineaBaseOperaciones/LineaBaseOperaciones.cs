using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System;

namespace SistemaCreditos.Datos
{

    public class LineaBaseOperaciones
    {

        #region Enums

        public enum TipoOperacion{
            SinFefinir = 0,
            Agregar = 1,
            Editar = 2
        }

        #endregion

        #region Atributos

        ConexionesDB _conexionDB;

        Int64 _claveFilaSeleccionada;

        #endregion

        #region Propiedades

        public ConexionesDB ConexionDB { get => _conexionDB; set => _conexionDB = value; }

        public Int64 ClaveFilaSeleccionada { get => _claveFilaSeleccionada; set => _claveFilaSeleccionada = value; }

        #endregion

        #region Constructores

        public LineaBaseOperaciones()
        {

            _claveFilaSeleccionada = 0;

        }

        #endregion

        #region Metodos

        public bool RealizaActualizacion(String table_,
                                        String llaveTabla_,
                                        Int64 valorLlave_,
                                        Dictionary<String, object> campos_)
        {
            try
            {

                List<String> listaCamposValor_ = new List<String>();

                foreach (var campo_ in campos_)
                {

                    String tipoValor_ = campo_.Value.GetType().FullName;

                    switch (tipoValor_)
                    {

                        case "System.Int32": 
                        case "System.Single":

                            listaCamposValor_.Add(campo_.Key + " = " + campo_.Value);

                            break;

                        case "System.String":

                            listaCamposValor_.Add(campo_.Key + " = '" + campo_.Value + "'");

                            break;

                        default:

                            // No implementado

                            break;

                    }

                }

                //String sentencia_ = @"UPDATE " + table_ + " SET " + String.Join(", ", listaCamposValor_) + " WHERE " + llaveTabla_ + " = " + _claveFilaSeleccionada;
                String sentencia_ = @"UPDATE " + table_ + " SET " + String.Join(", ", listaCamposValor_) + " WHERE " + llaveTabla_ + " = " + valorLlave_;

                using (MySqlCommand comandoDB_ = new MySqlCommand(sentencia_, _conexionDB.Conexion))
                {

                    using (MySqlDataReader reader_ = comandoDB_.ExecuteReader())
                    {

                        return true;

                    }

                }

            }
            catch (Exception ex_)
            {

                Console.WriteLine(ex_.Message);

            }

            return false;

        }

        public Int64 RealizaInsercion(String table_,
                                        List<String> campos_,
                                        List<List<Object>> listaValores_)
        {
            try
            {

                String valoresArmados_ = "";

                foreach (var fila_ in listaValores_.Select((FilaValor, FilaIndice) => new { FilaIndice, FilaValor }))
                {

                    String filaValor_ = "";

                    String campoValor_ = "";

                    if (fila_.FilaIndice == 0)
                    {

                        filaValor_ = "(";

                    }
                    else
                    {

                        filaValor_ = ", (";

                    }

                    foreach (var campo_ in fila_.FilaValor.Select((CampoValor, CampoIndice) => new { CampoIndice, CampoValor }))
                    {

                        String tipoValor_ = campo_.CampoValor.GetType().FullName;

                        switch (tipoValor_)
                        {

                            case "System.Int32":

                                if (campo_.CampoIndice == 0)
                                {

                                    campoValor_ += "" + campo_.CampoValor;

                                }
                                else
                                {

                                    campoValor_ += ", " + campo_.CampoValor;

                                }

                                break;

                            case "System.Single":

                                if (campo_.CampoIndice == 0)
                                {

                                    campoValor_ += "" + campo_.CampoValor;

                                }
                                else
                                {

                                    campoValor_ += ", " + campo_.CampoValor;

                                }

                                break;

                            case "System.String":

                                if (campo_.CampoIndice == 0)
                                {

                                    campoValor_ += "'" + campo_.CampoValor + "'";

                                }
                                else
                                {

                                    campoValor_ += ", '" + campo_.CampoValor + "'";

                                }

                                break;

                            default:

                                // No implementado

                                break;

                        }

                    }

                    filaValor_ += campoValor_;

                    filaValor_ += ")";

                    valoresArmados_ += filaValor_;

                }

                String sentencia_ = @"INSERT INTO " + table_ + "(" + String.Join(", ", campos_) + ") VALUES " + valoresArmados_ + "; SELECT LAST_INSERT_ID();";

                using (MySqlCommand comandoDB_ = new MySqlCommand(sentencia_, _conexionDB.Conexion))
                {

                    comandoDB_.CommandTimeout = 60;

                    Int64 claveInsertada_ = Convert.ToInt64(comandoDB_.ExecuteScalar());

                    return claveInsertada_;

                }

            }
            catch (Exception ex_)
            {

                Console.WriteLine(ex_.Message);

            }

            return 0;

        }

        public DataTable RealizaConsultaEstandar(List<String> campos_,
                                                String repositorio_,
                                                Dictionary<String, Object> condicional_ = null)
        {

            DataTable resultadoDataTable_ = new DataTable();

            try
            {

                if (campos_.Count == 0 || repositorio_ == "")
                {

                    return resultadoDataTable_;

                }

                String sentencia_ = null;

                String select_ = " SELECT " + string.Join(", ", campos_);

                String from_ = " FROM " + repositorio_;

                String where_ = "";

                if (condicional_ != null)
                {

                    where_ = " WHERE " + string.Join("", condicional_.Select(fila_ => fila_.Key + fila_.Value).ToArray());

                }

                sentencia_ = select_ + from_ + where_;

                using (MySqlCommand comandoDB_ = new MySqlCommand(sentencia_, _conexionDB.Conexion))
                {

                    using (MySqlDataReader reader_ = comandoDB_.ExecuteReader())
                    {

                        resultadoDataTable_.Load(reader_);

                    }

                }

            }
            catch (Exception e_)
            {

                Console.WriteLine(e_.Message);

            }

            return resultadoDataTable_;

        }

        public DataTable RealizaConsultaLibre(String sentencia_)
        {

            DataTable resultadoDataTable_ = new DataTable();

            return resultadoDataTable_;

        }

        #endregion

    }

}
