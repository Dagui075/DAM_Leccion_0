using DAM_Leccion_DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_DAO.ViewModel
{
    public class MainPageViewModel
    {
        public PersonaModel personaModel { get; set; }

        public MainPageViewModel()
        {
            Consultar
                ();
        }
        public void Consultar()
        {
            personaModel = new PersonaModel()
            {
                Nombre = "Dylan",
                Apellido = "Aguilar",
                Edad = "20"
            };
            

        }
    }
}
