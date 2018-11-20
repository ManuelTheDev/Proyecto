using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class FichaMedida
    {
        private int idFichaMedida;
        private int codCorrelativo;
        private static int i = 1; 
        private Cliente cliente;
        private DateTime fecha;
        private string tipo;
        private double peso;
        private double espalda;
        private double abdomenAlto;
        private double abdomenBajo;
        private double cintura;
        private double brazoDerecho;
        private double brazoIzquierdo;
        private double gluteos;
        private double piernaIzq;
        private double piernaDer;

        public FichaMedida()
        {

        }
        public FichaMedida(Cliente cliente, DateTime fecha, string tipo, double peso, double espalda, double abdomenAlto, double abdomenBajo, double cintura, double brazoDerecho, double brazoIzquierdo, double gluteos, double piernaIzq, double piernaDer)
        {
            this.CodCorrelativo = I++;
            this.Cliente = cliente;
            this.Fecha = fecha;
            this.Tipo = tipo;
            this.Peso = peso;
            this.Espalda = espalda;
            this.AbdomenAlto = abdomenAlto;
            this.AbdomenBajo = abdomenBajo;
            this.Cintura = cintura;
            this.BrazoDerecho = brazoDerecho;
            this.BrazoIzquierdo = brazoIzquierdo;
            this.Gluteos = gluteos;
            this.PiernaIzq = piernaIzq;
            this.PiernaDer = piernaDer;
        }

        public int IdFichaMedida { get => idFichaMedida; set => idFichaMedida = value; }
        public int CodCorrelativo { get => codCorrelativo; set => codCorrelativo = value; }
        public static int I { get => i; set => i = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Espalda { get => espalda; set => espalda = value; }
        public double AbdomenAlto { get => abdomenAlto; set => abdomenAlto = value; }
        public double AbdomenBajo { get => abdomenBajo; set => abdomenBajo = value; }
        public double Cintura { get => cintura; set => cintura = value; }
        public double BrazoDerecho { get => brazoDerecho; set => brazoDerecho = value; }
        public double BrazoIzquierdo { get => brazoIzquierdo; set => brazoIzquierdo = value; }
        public double Gluteos { get => gluteos; set => gluteos = value; }
        public double PiernaIzq { get => piernaIzq; set => piernaIzq = value; }
        public double PiernaDer { get => piernaDer; set => piernaDer = value; }

        public  DateTime FechaFicha { get => fecha.Date; }
    }
}
