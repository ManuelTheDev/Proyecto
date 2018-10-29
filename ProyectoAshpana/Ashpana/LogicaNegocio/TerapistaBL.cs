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

        public void registrarTerapista(Terapista t)
        {
            terapistaDA.registrarTerapista(t);
        }

        public BindingList<Terapista> listarTerapistas()
        {
            return terapistaDA.listarTerapistas();
        }

        public void modificarTerapista(Terapista t)
        {
            terapistaDA.modificarTerapista(t);
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
    }
}
