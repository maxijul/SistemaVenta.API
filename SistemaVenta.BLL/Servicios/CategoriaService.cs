using AutoMapper;
using SistemaVenta.BLL.Interfaces;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.DTO;
using SistemaVenta.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Categoria> _categoriaRepository;

        public CategoriaService(IMapper mapper, IGenericRepository<Categoria> categoriaRepository)
        {
            _mapper = mapper;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<List<CategoriaDTO>> GetLista()
        {
            try
            {
                var listaCategorias = await _categoriaRepository.Consultar();
                return _mapper.Map<List<CategoriaDTO>>(listaCategorias.ToList());
            }
            catch
            {
                throw;
            }
        }
    }
}
