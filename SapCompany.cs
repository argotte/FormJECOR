using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPbobsCOM;

namespace FormJECOR
{

    public class SapCompany
    {
        public SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
        public int ret;
        public void CreateCompany()
        {

            try
            {

                string StatusConexion;
                
                oCompany = new SAPbobsCOM.Company();
                oCompany.Server = "DIEGUITO";
                oCompany.UserName = "manager";
                oCompany.Password = "B1Admin";
                oCompany.CompanyDB = "SBO_CULTIVAR";
                oCompany.DbUserName = "sa";
                oCompany.DbPassword = "B1Admin";
                oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2017;
                oCompany.language = SAPbobsCOM.BoSuppLangs.ln_Spanish;
                oCompany.UseTrusted = false;
                // soy lo maximo


                oCompany.LicenseServer = "DIEGUITO";


                ret = oCompany.Connect();
                if (ret != 0)
                {
                    String errormsj = oCompany.GetLastErrorDescription();
                    MessageBox.Show(errormsj);
                }
                else
                {
                    MessageBox.Show("Conexión satisfactoria!");
                }


                StatusConexion = ret.ToString();

            }

            catch (global::System.Exception)
            {
                MessageBox.Show("Error");


            }


        }

    }

    }

