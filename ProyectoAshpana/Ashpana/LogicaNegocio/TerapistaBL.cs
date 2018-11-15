using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class TerapistaBL
    {
        private TerapistaDA terapistaDA;


        public TerapistaBL()
        {
            terapistaDA = new TerapistaDA();
        }

        public void registrarTerapista(Terapista t, string a, string b, string c, string d)
        {
            terapistaDA.registrarTerapista(t, a, b, c, d);
        }

        public BindingList<Terapista> listarTerapistas()
        {
            return terapistaDA.listarTerapistas();
        }

        public void modificarTerapista(Terapista t, string horaE, string horaS, string minutoE, string minutoS)
        {
            terapistaDA.modificarTerapista(t, horaE, horaS, minutoE, minutoS);
        }

        public bool registrarTratamiento_X_terapista(Terapista t)
        {
            try
            {
                foreach (Tratamiento trat in t.Tratamientos)
                {
                    terapistaDA.registrarTratamiento_X_terapista(t, trat);
                }
                return true;
            }
            catch
            {
                MessageBox.Show("No se ha registrar con exito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public BindingList<Tratamiento> listarTratamientos_x_Terapista(int IdTerapista)
        {
            return terapistaDA.listarTratamientos_X_Terapista(IdTerapista);
        }

        public BindingList<Terapista> listarTerapistas_X_Tratamiento(int idTratamiento)
        {
            return terapistaDA.listarTerapistas_X_Tratamiento(idTratamiento);
        }
    }
}
