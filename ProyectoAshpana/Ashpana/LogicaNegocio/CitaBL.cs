using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CitaBL
    {
        private CitaDA citaDA;
        private DetalleCitaDA detalleDA;
        private SesionDA sesionDA;
        public CitaBL()
        {
            citaDA = new CitaDA();
            detalleDA = new DetalleCitaDA();
            sesionDA = new SesionDA();
        }

        public int registrarCita (Cita c)
        {
            try
            {
                int idCita = citaDA.registrarCita(c);

                if (idCita != 0)
                {
                    foreach (DetalleCita dt in c.DetallesCitas)
                    {
                        int idDetalleCita = detalleDA.registrarDetalleCita(dt, idCita);
                        if (idDetalleCita != 0)
                        {
                            foreach (Sesion s in dt.Sesiones)
                            {
                                sesionDA.registrarSesion(s, idDetalleCita, idCita,c.Cliente.IdCliente);
                            }
                        }
                    }
                }
                return 1;
            }catch(Exception ex)
            {
                return 0; 
            }
            
        }

        public BindingList<Cita> listarCitas()
        {
            return citaDA.listarCitas();
        }
    }
}
