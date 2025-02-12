using DAM_Leccion_DAO.Model;
using FoundationStandard.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_DAO.ViewModel
{
    internal class PersonasViewModel
    {
        public ObservableCollection<PersonaModel> Personas { get; set; }

        public PersonasViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            var listado = new Hydrator<PersonaModel>().WithFirstName(n => n.Nombre);
            Personas = new ObservableCollection<PersonaModel>(listado.GetList(20));
        }

    }
}
