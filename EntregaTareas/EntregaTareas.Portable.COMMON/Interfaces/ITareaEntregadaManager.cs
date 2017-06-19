using EntregaTareas.Portable.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTareas.Portable.COMMON.Interfaces
{
    public interface ITareaEntregadaManager:IGenericManager<TareaEntregadaDTO>
    {
        Task<List<TareaEntregadaDTO>> BuscarEntregasDeUnaTarea(string idTarea);
    }
}
