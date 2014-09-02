using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data;
using Entidades;



namespace Bussines
{
    class Program
    {
        static void Main(string[] args)
        {
            DaoCurso dc = new DaoCurso();
            Curso c = new Curso
            {
                id = 1,
                comision = new Comision
                {
                    id = 1,
                    descripcion = "Algoritmos y Estructuras de Datos",
                    anio = 2014
                },
                materia = new Materia { },                
            };
            Curso nc = dc.find(1);


           
        }
    }
}
