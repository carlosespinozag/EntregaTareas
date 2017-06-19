using EntregaTareas.Portable.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.Portable.COMMON.Interfaces
{
    public interface IMateriaManager:IGenericManager<MateriaDTO>
    {
        Task<List<MateriaDTO>> BuscarMateriasDeDocente(string IdDocente);
        Task<List<MateriaDTO>> BuscarMateriasDeAlumno(string IdAlumno);


    }
}
