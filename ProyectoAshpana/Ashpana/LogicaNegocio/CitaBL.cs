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

        public BindingList<DetalleCita> listarDetallesCitas_X_Cita(int id)
        {
            BindingList<DetalleCita> detallesCita =  citaDA.listarDetalleCitas_Cita(id);
            foreach(DetalleCita dc in detallesCita)
            {
                dc.Sesiones = citaDA.listarSesiones_DetalleCita(dc.IdDetalleCita);
            }
            return detallesCita;
        }

        public BindingList<Sesion> listarSesiones_X_Detalle_Cita(int id)
        {
            return citaDA.listarSesiones_DetalleCita(id);
        }

        public void actualizarCita(Cita citaAnt,Cita citaMod)
        {
            if (citaMod.Estado_pago==1 && citaAnt.Estado_pago==0)
            {
                citaDA.actualizarCita(citaAnt.IdCita, 1);
            }
            int cont = 0;
            foreach(DetalleCita dc in citaAnt.DetallesCitas)
            {
                foreach(Sesion s in dc.Sesiones)
                {
                    if (!citaMod.DetallesCitas[cont].Sesiones.Contains(s)){
                        sesionDA.eliminarSesion(s.IdSesion);
                    }
                }
                cont++;
            }
            int cont2 = 0;
            foreach(DetalleCita dc in citaMod.DetallesCitas)
            {
                foreach(Sesion s in dc.Sesiones)
                {
                    if (!citaAnt.DetallesCitas[cont2].Sesiones.Contains(s))
                    {
                        sesionDA.registrarSesion(s, dc.IdDetalleCita, citaMod.IdCita, citaAnt.Cliente.IdCliente);
                    }
                    else if (citaAnt.DetallesCitas[cont2].Sesiones.Contains(s))
                    {
                        int indice = citaAnt.DetallesCitas[cont2].Sesiones.IndexOf(s);
                        if (s.NumDeSesion != citaAnt.DetallesCitas[cont2].Sesiones[indice].NumDeSesion)
                        {
                            sesionDA.actualizarNumeroSesion(s.IdSesion, s.NumDeSesion);
                        }
                    }
                }
                cont2++;
            }
        }
    }
}
