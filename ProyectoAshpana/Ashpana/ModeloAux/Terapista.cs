using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Terapista : Trabajador
    {
        private int idTerapista;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private int tipo;
        private BindingList<Tratamiento> tratamientos;

        public TimeSpan horaEntry { get => Convert.ToDateTime(horaEntrada).TimeOfDay; }
        public TimeSpan horaOut { get => Convert.ToDateTime(horaSalida).TimeOfDay;  }
        public String NOMBRES { get => Nombres; }
        public String AP_PATERNO { get => ApPaterno;  }
        public String AP_MATERNO { get => ApMaterno;  }

        public int Tipo { get => tipo; set => tipo = value; }
        public BindingList<Tratamiento> Tratamientos { get => tratamientos; set => tratamientos = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public int IdTerapista { get => idTerapista; set => idTerapista = value; }

        
        public Terapista()
        {
            Tratamientos = new BindingList<Tratamiento>(); 
        }


        
    }
}
