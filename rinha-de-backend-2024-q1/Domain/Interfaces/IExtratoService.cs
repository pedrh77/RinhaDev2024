using Domain.DTO.Response;

namespace Domain.Interfaces
{
    public interface IExtratoService
    {
        public ExtratoResponseDto ExtratoClientePorId(int id);
    }
}
