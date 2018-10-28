using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tratamiento: Servicio
    {
        private int _idTrat;
        private double _duracionTrat;
        private int _tipoTrat; //1:Facial 0:Corporal
        private BindingList<CondicionMedica> _condicionesMedicas;
        private String _condicionesMedicasString;
        private BindingList<Zona> _zonasTratar;
        private String _zonasTratarString;
        private String _tipoString;

        public Tratamiento()
        {
            _condicionesMedicas = new BindingList<CondicionMedica>();
            _zonasTratar = new BindingList<Zona>();

        }

        public Tratamiento(int idServicio, string nombreServicio, double precioServicio, int estadoServicio,int idTrat, double duracionTrat, int tipoTrat, BindingList<CondicionMedica> condicionesMedicas, string condicionesMedicasString, BindingList<Zona> zonasTratar, string zonasTratarString, string tipoString): base(idServicio, nombreServicio, precioServicio, estadoServicio)
        {
            _idTrat = idTrat;
            _duracionTrat = duracionTrat;
            _tipoTrat = tipoTrat;
            _condicionesMedicas = condicionesMedicas;
            _condicionesMedicasString = condicionesMedicasString;
            _zonasTratar = zonasTratar;
            _zonasTratarString = zonasTratarString;
            _tipoString = tipoString;
        }

        public int IdTrat { get => _idTrat; set => _idTrat = value; }
        public double DuracionTrat { get => _duracionTrat; set => _duracionTrat = value; }
        public int TipoTrat { get => _tipoTrat; set => _tipoTrat = value; }
        public BindingList<CondicionMedica> CondicionesMedicas { get => _condicionesMedicas; set => _condicionesMedicas = value; }
        public string CondicionesMedicasString { get => _condicionesMedicasString; set => _condicionesMedicasString = value; }
        public BindingList<Zona> ZonasTratar { get => _zonasTratar; set => _zonasTratar = value; }
        public string ZonasTratarString { get => _zonasTratarString; set => _zonasTratarString = value; }
        public string TipoString { get => _tipoString; set => _tipoString = value; }
    }
}
