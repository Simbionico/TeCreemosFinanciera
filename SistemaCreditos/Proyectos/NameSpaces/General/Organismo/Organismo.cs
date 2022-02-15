using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
using SistemaCreditos.Datos;
using System.Data;
using System.Windows.Forms;

namespace SistemaCreditos.General
{

    public class Organismo
    {

        #region Enums

        public enum TipoDatoValidacion
        {
            SinDefinir = 0,
            CorreoElectronico = 1,
            Contraseña = 2,
            Requerido = 3,
            EsNaturalNoCero = 4,
            EsNumeroPositivo = 5
        }

        #endregion

        #region Atributos

        #endregion

        #region Constructores

        public Organismo()
        {

        }

        #endregion

        #region Funciones

        public Dictionary<String, Object> ValidaDatos(String nombreCampo_, 
                                                        String valor_,
                                                        List<TipoDatoValidacion> listaValidaciones_)
        {

            Dictionary<String, Object> objetoValidacion_ = new Dictionary<String, Object>();

            List<String> listaErrores_ = new List<String>();

            Boolean tieneErrores_ = false;

            String expresion_ = null;

            objetoValidacion_["EsValido"] = tieneErrores_;

            foreach (var validacion_ in listaValidaciones_)
            {

                switch (validacion_)
                {

                    case TipoDatoValidacion.SinDefinir:
                        break;

                    case TipoDatoValidacion.CorreoElectronico:

                        expresion_ = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

                        if (!Regex.IsMatch(valor_, expresion_))
                        {

                            objetoValidacion_["EsValido"] = true;

                            listaErrores_.Add("El campo " + nombreCampo_ + " debe ser un correo electronico.");

                        }

                        break;

                    case TipoDatoValidacion.Contraseña:

                        //Una contraseña que contiene al menos 1 mayúscula, 1 minúscula, 1 dígito, 1 carácter especial y tiene una longitud de al menos 8

                        expresion_ = @"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$";

                        if (!Regex.IsMatch(valor_, expresion_))
                        {

                            objetoValidacion_["EsValido"] = true;

                            listaErrores_.Add("El campo " + nombreCampo_ + " no es una contraseña valida.");

                        }

                        break;

                    case TipoDatoValidacion.Requerido:

                        if(valor_ == "")
                        {

                            objetoValidacion_["EsValido"] = true;

                            listaErrores_.Add("El campo " + nombreCampo_ + " es requerido.");

                        }

                        break;

                    case TipoDatoValidacion.EsNumeroPositivo:

                        if (valor_ == "")

                            valor_ = "0";

                        float nuevoValor_ = float.Parse(valor_);

                        if (nuevoValor_ <= 0)
                        {

                            objetoValidacion_["EsValido"] = true;

                            listaErrores_.Add("El campo " + nombreCampo_ + " debser un número positivo.");

                        }

                        break;

                    default:
                        break;

                }

            }

            objetoValidacion_["ListaErrores"] = listaErrores_;

            return objetoValidacion_;

        }

        private bool EsFloatOrInt(string valor_)
        {
            int intValor_;

            float floatValor_;

            return Int32.TryParse(valor_, out intValor_) || float.TryParse(valor_, out floatValor_);

        }

        public static void CargaComboBox(ref ComboBox comboBox_,
                                        String campoValor_,
                                        String campoPresentacion_,
                                        ConexionesDB conexionDB_,
                                        List<String> select_,
                                        String from_,
                                        Dictionary<String, Object> condicional_ = null)
        {

            LineaBaseOperaciones operaciones_ = new LineaBaseOperaciones();

            operaciones_.ConexionDB = conexionDB_;

            //List<String> selec_ = new List<String> { "i_Cve_Persona AS Clave",
            //                                        "CONCAT(t_Nombre, ' ', t_ApellidoPaterno, ' ', t_ApellidoMaterno) AS Persona"};

            //Dictionary<String, Object> condicional_ = new Dictionary<string, Object> { { "i_Cve_Estado = ", 1 } };

            DataTable resultado_ = operaciones_.RealizaConsultaEstandar(select_, from_, condicional_);

            if (resultado_.Rows.Count > 0)
            {

                comboBox_.DataSource = resultado_;

                comboBox_.ValueMember = campoValor_;

                comboBox_.DisplayMember = campoPresentacion_;


            }

        }

        public static string CifrarCadena(string cadena_)
        {

            try
            {

                string llavePublica_ = "tecreemo";

                string llaveSecreta_ = "F1n@nc13";

                byte[] byteLlavePublica_ = System.Text.Encoding.UTF8.GetBytes(llavePublica_);

                byte[] byteLlaveSecreta_ = System.Text.Encoding.UTF8.GetBytes(llaveSecreta_);

                MemoryStream memoryStream_ = null;

                CryptoStream cscryptoStream_ = null;

                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(cadena_);

                using (DESCryptoServiceProvider cryptoServiceProvider_ = new DESCryptoServiceProvider())
                {

                    memoryStream_ = new MemoryStream();

                    cscryptoStream_ = new CryptoStream(memoryStream_, cryptoServiceProvider_.CreateEncryptor(byteLlavePublica_, byteLlaveSecreta_), CryptoStreamMode.Write);

                    cscryptoStream_.Write(inputbyteArray, 0, inputbyteArray.Length);

                    cscryptoStream_.FlushFinalBlock();

                    return Convert.ToBase64String(memoryStream_.ToArray());

                }

            }
            catch (Exception e_)
            {

                Console.WriteLine(e_.Message);

            }

            return null;

        }

        public static string DecifrarCadena(string cadena_)
        {

            try
            {

                string llavePublica_ = "tecreemo";

                string llaveSecreta_ = "F1n@nc13";

                byte[] byteLlavePublica_ = System.Text.Encoding.UTF8.GetBytes(llavePublica_);

                byte[] byteLlaveSecreta_ = System.Text.Encoding.UTF8.GetBytes(llaveSecreta_);

                MemoryStream memoryStream_ = null;

                CryptoStream cscryptoStream_ = null;

                byte[] byteCadena_ = new byte[cadena_.Replace(" ", "+").Length];

                byteCadena_ = Convert.FromBase64String(cadena_.Replace(" ", "+"));

                using (DESCryptoServiceProvider cryptoServiceProvider_ = new DESCryptoServiceProvider())
                {

                    memoryStream_ = new MemoryStream();

                    cscryptoStream_ = new CryptoStream(memoryStream_, cryptoServiceProvider_.CreateDecryptor(byteLlavePublica_, byteLlaveSecreta_), CryptoStreamMode.Write);

                    cscryptoStream_.Write(byteCadena_, 0, byteCadena_.Length);

                    cscryptoStream_.FlushFinalBlock();

                    Encoding encoding = Encoding.UTF8;

                    return encoding.GetString(memoryStream_.ToArray());

                }

            }
            catch (Exception e_)
            {

                Console.WriteLine(e_.Message);

            }

            return null;

        }

        #endregion

    }

}
