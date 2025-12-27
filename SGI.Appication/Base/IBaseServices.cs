

using SGI.Domain.Base;

namespace SGI.Appication.Base
{
    public interface IBaseServices<TCreateDto, TUpdateDto, TDeleteDto> where TCreateDto : class where TUpdateDto : class where TDeleteDto : class
    {
        Task<OperationResult> CreateAsync(TCreateDto createDto);
        Task<OperationResult> UpdateAsync(TUpdateDto updateDto);
        Task<OperationResult> RemoveAsync(int id);
        Task<OperationResult> DeleteAsync(TDeleteDto deleteDto);
        Task<OperationResult> GetAllAsync(bool? isDeleted);
        Task<OperationResult> GetByIdAsync(int id, bool? isDeleted);
    }
}
