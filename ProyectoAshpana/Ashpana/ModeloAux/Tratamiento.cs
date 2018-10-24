using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tratamiento
    {
        private int _idTrat;
        private string _nombreTrat;
        private double _duracionTrat;
        private double _precioTrat;
        private int _tipoTrat; //1:Facial 0:Corporal
        private int _estadoTrat; //1:Activa 0:Inactiva
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

        public Tratamiento(int idTrat, string nombreTrat, double duracionTrat, double precioTrat, int tipoTrat, int estadoTrat, BindingList<CondicionMedica> condicionesMedicas, string condicionesMedicasString, BindingList<Zona> zonasTratar, string zonasTratarString, string tipoString)
        {
            _idTrat = idTrat;
            _nombreTrat = nombreTrat;
            _duracionTrat = duracionTrat;
            _precioTrat = precioTrat;
            _tipoTrat = tipoTrat;
            _estadoTrat = estadoTrat;
            _condicionesMedicas = condicionesMedicas;
            _condicionesMedicasString = condicionesMedicasString;
            _zonasTratar = zonasTratar;
            _zonasTratarString = zonasTratarString;
            _tipoString = tipoString;
        }

        public int IdTrat { get => _idTrat; set => _idTrat = value; }
        public string NombreTrat { get => _nombreTrat; set => _nombreTrat = value; }
        public double DuracionTrat { get => _duracionTrat; set => _duracionTrat = value; }
        public double PrecioTrat { get => _precioTrat; set => _precioTrat = value; }
        public int TipoTrat { get => _tipoTrat; set => _tipoTrat = value; }
        public int EstadoTrat { get => _estadoTrat; set => _estadoTrat = value; }
        public BindingList<CondicionMedica> CondicionesMedicas { get => _condicionesMedicas; set => _condicionesMedicas = value; }
        public string CondicionesMedicasString { get => _condicionesMedicasString; set => _condicionesMedicasString = value; }
        public BindingList<Zona> ZonasTratar { get => _zonasTratar; set => _zonasTratar = value; }
        public string ZonasTratarString { get => _zonasTratarString; set => _zonasTratarString = value; }
        public string TipoString { get => _tipoString; set => _tipoString = value; }
    }
}
